using System.Diagnostics;

namespace Lab2
{
    public partial class MainForm : Form
    {
        // Ключи городов в словаре часов (не локализуются)
        private const string Moscow = "Moscow";
        private const string London = "London";
        private const string Vladivostok = "Vladivostok";

        private readonly Clock clock = new Clock();

        public MainForm()
        {
            InitializeComponent();

            clock.AddCity(Moscow, TimeSpan.FromHours(3));
            clock.AddCity(London, GetUtcOffset("Europe/London", "GMT Standard Time", TimeSpan.Zero));
            clock.AddCity(Vladivostok, TimeSpan.FromHours(10));
            clock.SecondTick += Clock_SecondTick;

            ShowTime(DateTime.Now);
            UpdateMenu();
        }

        /// <summary>
        /// Текущее смещение пояса относительно UTC (для Лондона учитывает летнее время).
        /// </summary>
        private static TimeSpan GetUtcOffset(string ianaId, string windowsId, TimeSpan fallback)
        {
            foreach (string id in new[] { windowsId, ianaId })
            {
                try
                {
                    return TimeZoneInfo.FindSystemTimeZoneById(id).GetUtcOffset(DateTime.UtcNow);
                }
                catch (TimeZoneNotFoundException) { }
                catch (InvalidTimeZoneException) { }
            }
            return fallback;
        }

        /// <summary>Обработчик события SecondTick часов.</summary>
        private void Clock_SecondTick(Clock sender, DateTime now)
        {
            ShowTime(now);
        }

        private void ShowTime(DateTime now)
        {
            textBoxMoscow.Text = clock.GetTime(Moscow).ToLongTimeString();
            textBoxLondon.Text = clock.GetTime(London).ToLongTimeString();
            textBoxVladivostok.Text = clock.GetTime(Vladivostok).ToLongTimeString();
        }

        private void UpdateMenu()
        {
            menuStart.Enabled = !clock.IsRunning;
            menuStop.Enabled = clock.IsRunning;
        }

        private void menuStart_Click(object sender, EventArgs e)
        {
            clock.Start();
            UpdateMenu();
        }

        private void menuStop_Click(object sender, EventArgs e)
        {
            clock.Stop();
            UpdateMenu();
        }

        private void menuExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void menuRussian_Click(object sender, EventArgs e)
        {
            RestartWithLanguage("ru");
        }

        private void menuEnglish_Click(object sender, EventArgs e)
        {
            RestartWithLanguage("en");
        }

        /// <summary>Перезапускает приложение с другим языком интерфейса.</summary>
        private void RestartWithLanguage(string lang)
        {
            Process.Start(Application.ExecutablePath, lang);
            Close();
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            clock.Dispose();
        }
    }
}

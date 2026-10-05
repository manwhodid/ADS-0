using System.Globalization;

namespace Lab2
{
    internal static class Program
    {
        /// <summary>
        /// Точка входа приложения.
        /// Язык интерфейса задаётся аргументом командной строки: "en" или "ru" (по умолчанию).
        /// Пример: Lab2.exe en
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            string lang = args.Length > 0 ? args[0] : "ru";

            // Культура должна быть назначена ДО создания формы,
            // тогда ресурсы формы загрузятся на нужном языке.
            CultureInfo culture = lang.StartsWith("en", StringComparison.OrdinalIgnoreCase)
                ? new CultureInfo("en-US")
                : new CultureInfo("ru-RU");
            Thread.CurrentThread.CurrentUICulture = culture;
            Thread.CurrentThread.CurrentCulture = culture;

            ApplicationConfiguration.Initialize();
            Application.Run(new MainForm());
        }
    }
}

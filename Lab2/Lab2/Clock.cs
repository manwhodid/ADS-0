namespace Lab2
{
    /// <summary>
    /// Делегат, определяющий вид функции обратного вызова для события SecondTick.
    /// </summary>
    /// <param name="sender">Часы, сгенерировавшие событие.</param>
    /// <param name="now">Текущее (локальное) время на момент срабатывания.</param>
    public delegate void SecondTickHandler(Clock sender, DateTime now);

    /// <summary>
    /// Часы: знают текущее время, смещения времени для разных городов
    /// и каждую секунду генерируют событие SecondTick.
    /// </summary>
    public class Clock : IDisposable
    {
        private readonly System.Windows.Forms.Timer timer;
        private readonly Dictionary<string, TimeSpan> offsets = new();

        /// <summary>Событие, генерируемое при каждом срабатывании таймера.</summary>
        public event SecondTickHandler? SecondTick;

        /// <summary>Текущие дата и время (обновляются по событию таймера Tick).</summary>
        public DateTime Now { get; private set; }

        /// <summary>Идёт ли отсчёт времени.</summary>
        public bool IsRunning => timer.Enabled;

        /// <summary>Часы с интервалом срабатывания 1 с.</summary>
        public Clock() : this(1000) { }

        /// <summary>Часы с заданным интервалом срабатывания.</summary>
        /// <param name="interval">Интервал в миллисекундах.</param>
        public Clock(int interval)
        {
            Now = DateTime.Now;
            timer = new System.Windows.Forms.Timer { Interval = interval };
            timer.Tick += Timer_Tick;
        }

        /// <summary>Добавляет город и его смещение относительно UTC.</summary>
        public void AddCity(string city, TimeSpan offset)
        {
            offsets[city] = offset;
        }

        /// <summary>Возвращает время (дату и время) в указанном городе.</summary>
        public DateTime GetTime(string city)
        {
            if (!offsets.TryGetValue(city, out TimeSpan offset))
                throw new ArgumentException($"Город \"{city}\" не добавлен в часы.", nameof(city));
            return Now.ToUniversalTime() + offset;
        }

        /// <summary>Список городов, известных часам.</summary>
        public IEnumerable<string> Cities => offsets.Keys;

        public void Start()
        {
            timer.Start();
        }

        public void Stop()
        {
            timer.Stop();
        }

        private void Timer_Tick(object? sender, EventArgs e)
        {
            Now = DateTime.Now;
            SecondTick?.Invoke(this, Now);
        }

        public void Dispose()
        {
            timer.Dispose();
        }
    }
}

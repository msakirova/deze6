namespace deze6.Class
{
    public class Cow : Livestock
    {
        private double _dailyMilk;
        private bool _isMilked;

        /// <summary>
        /// Создаёт корову с заданными характеристиками и состоянием здоровья
        /// </summary>
        public Cow(string name, int age, double weight, string healthStatus): base(name, age, weight, healthStatus)
        {
            DailyMilk = 0;
            _isMilked = false;
        }

        /// <summary>
        /// Создаёт корову с заданными характеристиками, удоем и состоянием здоровья
        /// </summary>
        public Cow(string name, int age, double weight, double dailyMilk, string healthStatus)
            : base(name, age, weight, healthStatus)
        {
            DailyMilk = dailyMilk;
            _isMilked = false;
        }

        /// <summary>
        /// Возвращает и изменяет суточный удой
        /// </summary>
        public double DailyMilk
        {
            get { return _dailyMilk; }
            set
            {
                if (value < 0)
                    throw new ArgumentException("Удой не может быть отрицательным");

                _dailyMilk = value;
            }
        }

        /// <summary>
        /// Показывает, подоена ли корова
        /// </summary>
        public bool IsMilked
        {
            get { return _isMilked; }
        }


        /// <summary>
        /// Возвращает название вида животного.
        /// </summary>
        public override string GetAnimalType()
        {
            return "Дойная корова";
        }

        /// <summary>
        /// Возвращает информацию о корове и ее удое
        /// </summary>
        public override void GetInformation()
        {
            base.GetInformation();

            Console.WriteLine($"Среднесуточный удой: {DailyMilk:F1} л \n Подоена сегодня: {(_isMilked ? "Да" : "Нет")}");
            Console.WriteLine();
        }

        /// <summary>
        /// Выполняет доение коровы
        /// </summary>
        public void Milk()
        {
            if (_isMilked)
                Console.WriteLine($"{Name} уже подоена сегодня");

            _isMilked = true;
            Console.WriteLine($"Корова {Name} подоена. Получено {DailyMilk:F1} л молока");
            Console.WriteLine();
        }

        /// <summary>
        /// Сбрасывает отметку о доении на новый день
        /// </summary>
        public void ResetMilking()
        {
            _isMilked = false;
        }

        /// <summary>
        /// Рассчитывает ожидаемый удой за указанное число дней
        /// </summary>
        public double CalculateMilk(int days)
        {
            if (days < 0)
                throw new ArgumentException("Количество дней не может быть отрицательным");

            return DailyMilk * days;
        }

        /// <summary>
        /// Возвращает сообщение о кормлении коровы
        /// </summary>
        public override void Feed()
        {
            Console.WriteLine($"Дойная корова {Name} получает сено и корм");
        }
    }
}
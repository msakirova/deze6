namespace deze6.Class
{
    public class Bull : Livestock
    {
        private string _purpose;
        private bool _isAvailableForBreeding;


        /// <summary>
        /// Создает быка с назначением по умолчанию
        /// </summary>
        public Bull(string name, int age, double weight, string healthstatus): base(name, age, weight, healthstatus)
        {
            _purpose = "Разведение";
            _isAvailableForBreeding = true;
        }

        /// <summary>
        /// Создает быка с заданным назначением и доступностью для разведения
        /// </summary>
        public Bull(string name,int age,double weight,string healthstatus,string purpose, bool availableForBreeding): base(name, age, weight, healthstatus)
        {
            if (string.IsNullOrWhiteSpace(purpose))
                throw new ArgumentException("Укажите назначение быка");

            _purpose = purpose;
            _isAvailableForBreeding = availableForBreeding;
        }

        /// <summary>
        /// Возвращает и изменяет назначение быка
        /// </summary>
        public string Purpose
        {
            get { return _purpose; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("Назначение не может быть пустым");

                _purpose = value;
            }
        }

        /// <summary>
        /// Возвращает и изменяет доступность быка для разведения
        /// </summary>
        public bool IsAvailableForBreeding
        {
            get { return _isAvailableForBreeding; }
            set { _isAvailableForBreeding = value; }
        }

        /// <summary>
        /// Возвращает название вида животного
        /// </summary>
        public override string GetAnimalType()
        {
            return "Бык";
        }

        /// <summary>
        /// Возвращает информацию о быке и его назначении
        /// </summary>
        public override void GetInformation()
        {
            base.GetInformation();

            Console.WriteLine($"Назначение: {Purpose} \n Доступен для разведения: {(IsAvailableForBreeding ? "Да" : "Нет")}");
            Console.WriteLine();
        }

        /// <summary>
        /// Изменяет доступность быка для разведения
        /// </summary>
        public void SetBreedingAvailability(bool available)
        {
            IsAvailableForBreeding = available;
        }

        /// <summary>
        /// Проверяет, доступен ли бык для разведения
        /// </summary>
        public bool CheckBreedingAvailability()
        {
            return IsAvailableForBreeding && HealthStatus == "Здоровый";
        }

        /// <summary>
        /// Возвращает сообщение о кормлении быка
        /// </summary>
        public override void Feed()
        {
            Console.WriteLine($"Бык {Name} получает сено и питательный корм");
        }
    }
}
namespace deze6.Class
{
    public abstract class Livestock
    {
        private string _name;
        private int _age;
        private double _weight;
        private string _healthStatus;

        /// <summary>
        /// Создает животное с заданными характеристиками
        /// </summary>
        public Livestock(string name, int age, double weight, string healthStatus)
        {
            if (string.IsNullOrWhiteSpace(name))
                throw new ArgumentException("Имя животного не может быть пустым.");

            if (age < 0 || weight <= 0)
                throw new ArgumentException("Некорректные характеристики животного.");

            _name = name;
            _age = age;
            _weight = weight;
            _healthStatus = healthStatus;
        }


        /// <summary>
        /// Возвращает имя животного
        /// </summary>
        public string Name
        {
            get { return _name; }
        }

        /// <summary>
        /// Возвращает и изменяет возраст животного
        /// </summary>
        public int Age
        {
            get { return _age; }
            set
            {
                if (value < 0)
                    throw new ArgumentException("Возраст не может быть отрицательным.");

                _age = value;
            }
        }

        /// <summary>
        /// Возвращает и изменяет вес животного
        /// </summary>
        public double Weight
        {
            get { return _weight; }
            set
            {
                if (value <= 0)
                    throw new ArgumentException("Вес должен быть положительным.");

                _weight = value;
            }
        }

        /// <summary>
        /// Возвращает и изменяет состояние здоровья
        /// </summary>
        public string HealthStatus
        {
            get { return _healthStatus; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("Укажите состояние здоровья.");

                _healthStatus = value;
            }
        }


        /// <summary>
        /// Возвращает тип животного
        /// </summary>
        public abstract string GetAnimalType();

        /// <summary>
        /// Возвращает информацию о животном.
        /// </summary>
        public virtual void GetInformation()
        {
            Console.WriteLine($"Вид: {GetAnimalType()} \n Имя: {Name} \n Возраст: {Age} лет \n Вес: {Weight:F1} кг \n Здоровье: {HealthStatus}");
            Console.WriteLine();
        }

        /// <summary>
        /// Изменяет состояние здоровья животного
        /// </summary>
        public void ExamineHealth(string status)
        {
            HealthStatus = status;
        }

        /// <summary>
        /// Увеличивает возраст животного на один год
        /// </summary>
        public void CelebrateBirthday()
        {
            Age++;
        }

        /// <summary>
        /// Возвращает сообщение о кормлении животного
        /// </summary>
        public virtual void Feed()
        {
            Console.WriteLine($"{Name} получает корм");
        }

    }
}
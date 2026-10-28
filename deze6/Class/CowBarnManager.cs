namespace deze6.Class
{
    public class CowBarnManager
    {

        private string _barnName;
        private int _capacity;
        private readonly List<Livestock> _animals;

        /// <summary>
        /// Создает коровник с названием и максимальной вместимостью
        /// </summary>
        public CowBarnManager(string barnName, int capacity)
        {
            if (string.IsNullOrWhiteSpace(barnName))
                throw new ArgumentException("Название коровника не может быть пустым");

            if (capacity <= 0)
                throw new ArgumentException("Вместимость должна быть положительной");

            _barnName = barnName;
            _capacity = capacity;
            _animals = new List<Livestock>();
        }


        /// <summary>
        /// Возвращает название коровника
        /// </summary>
        public string BarnName
        {
            get { return _barnName; }
        }

        /// <summary>
        /// Возвращает и изменяет вместимость коровника
        /// </summary>
        public int Capacity
        {
            get { return _capacity; }

        }

        /// <summary>
        /// Возвращает количество животных
        /// </summary>
        public int AnimalCount
        {
            get { return _animals.Count; }
        }

        /// <summary>
        /// Возвращает количество свободных мест
        /// </summary>
        public int FreePlaces
        {
            get { return Capacity - AnimalCount; }
        }


        /// <summary>
        /// Добавляет животное, если в коровнике есть свободное место
        /// </summary>
        public bool AddAnimal(Livestock animal)
        {
            if (animal == null)
                throw new ArgumentNullException(nameof(animal));

            if (AnimalCount >= Capacity)
            {
                Console.WriteLine("Коровник заполнен");
                return false;
            }

            _animals.Add(animal);
            Console.WriteLine($"Животное {animal.Name} добавлено");
            return true;
        }

        /// <summary>
        /// Удаляет животное по имени
        /// </summary>
        public bool RemoveAnimal(string name)
        {
            Livestock animal = _animals.FirstOrDefault(animal => animal.Name.Equals(name,StringComparison.OrdinalIgnoreCase));

            if (animal == null)
                return false;

            _animals.Remove(animal);
            return true;
        }

        /// <summary>
        /// Выводит информацию обо всех животных
        /// </summary>
        public void ShowAllAnimals()
        {
            Console.WriteLine($"Животные в коровнике «{BarnName}»:");

            if (_animals.Count == 0)
            {
                Console.WriteLine("Животных пока нет.");
                return;
            }

            foreach (Livestock animal in _animals)
                animal.GetInformation();
        }

        /// <summary>
        /// Считает количество дойных коров
        /// </summary>
        public int CountCows()
        {
            return _animals.OfType<Cow>().Count();
        }

        /// <summary>
        /// Считает количество быков
        /// </summary>
        public int CountBulls()
        {
            return _animals.OfType<Bull>().Count();
        }

        /// <summary>
        /// Рассчитывает общий ожидаемый удой за заданное число дней
        /// </summary>
        public double CalculateTotalMilk(int days)
        {
            if (days < 0)
                throw new ArgumentException("Количество дней не может быть отрицательным.");

            return _animals.OfType<Cow>().Where(cow => !cow.IsMilked).Sum(cow => cow.CalculateMilk(days));
        }

        /// <summary>
        /// Выводит сводную информацию о коровнике
        /// </summary>
        public void ShowBarnStatistics()
        {
            Console.WriteLine($"Коровник: {BarnName} \n Вместимость: {Capacity} \n Животных: {AnimalCount} \n Свободных мест: {FreePlaces} \n Дойных коров: {CountCows()} \n Быков: {CountBulls()}");
            Console.WriteLine();
        }
    }
}
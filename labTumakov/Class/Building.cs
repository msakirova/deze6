namespace labTumakov.Class
{
    public class Building
    {
        private int _buildingNumber;
        private double _height;
        private int _floors;
        private int _apartments;
        private int _entrances;

        private static int _lastBuildingNumber = 0;

        public Building()
        {
            _buildingNumber = GenerateBuildingNumber();
            _height = 0;
            _floors = 1;
            _apartments = 0;
            _entrances = 1;
        }

        /// <summary>
        /// Создает здание с заданными характеристиками
        /// </summary>
        public Building(double height,int floors,int apartments,int entrances)
        {
            if (height <= 0 || floors <= 0 || apartments < 0 || entrances <= 0)
                throw new ArgumentException("Указаны некорректные характеристики здания.");

            _buildingNumber = GenerateBuildingNumber();
            _height = height;
            _floors = floors;
            _apartments = apartments;
            _entrances = entrances;
        }


        /// <summary>
        /// Возвращает уникальный номер здания
        /// </summary>
        public int BuildingNumber
        {
            get { return _buildingNumber; }
        }

        /// <summary>
        /// Возвращает и изменяет высоту здания
        /// </summary>
        public double Height
        {
            get { return _height; }
        }

        /// <summary>
        /// Возвращает и изменяет количество этажей
        /// </summary>
        public int Floors
        {
            get { return _floors; }
            
        }

        /// <summary>
        /// Возвращает и изменяет количество квартир
        /// </summary>
        public int Apartments
        {
            get { return _apartments; }
            
        }

        /// <summary>
        /// Возвращает и изменяет количество подъездов
        /// </summary>
        public int Entrances
        {
            get { return _entrances; }
            
        }


        /// <summary>
        /// Увеличивает последний номер и возвращает новый номер здания
        /// </summary>
        public static int GenerateBuildingNumber()
        {
            _lastBuildingNumber++;
            return _lastBuildingNumber;
        }


        /// <summary>
        /// Вычисляет среднюю высоту одного этажа.
        /// </summary>
        public double CalculateFloorHeight()
        {
            return _height / _floors;
        }

        /// <summary>
        /// Вычисляет среднее количество квартир в одном подъезде
        /// </summary>
        public double CalculateApartmentsPerEntrance()
        {
            return (double)_apartments / _entrances;
        }

        /// <summary>
        /// Вычисляет среднее количество квартир на одном этаже
        /// </summary>
        public double CalculateApartmentsPerFloor()
        {
            return (double)_apartments / _floors;
        }

        /// <summary>
        /// Вычисляет среднее количество квартир на этаже одного подъезда
        /// </summary>
        public double CalculateApartmentsPerFloorPerEntrance()
        {
            return (double)_apartments / (_floors * _entrances);
        }

        /// <summary>
        /// Выводит информацию о здании в консоль
        /// </summary>
        public void PrintInformation()
        {
            Console.WriteLine($"Номер здания: {_buildingNumber}\nВысота: {_height:F2} м\nЭтажей: {_floors}\nКвартир: {_apartments}\nПодъездов: {_entrances}\nВысота этажа: {CalculateFloorHeight():F2} м\nКвартир в подъезде (в среднем): {CalculateApartmentsPerEntrance():F2}\nКвартир на этаже (в среднем): {CalculateApartmentsPerFloor():F2}\nКвартир на этаже одного подъезда (в среднем): {CalculateApartmentsPerFloorPerEntrance():F2}");
            Console.WriteLine();
        }
    }
}

using deze6.Class;

namespace CowBarn
{
    internal class Program
    {
        static void Main()
        {
            Task();
        }

        #region Задание 1
        static void Task()
        {
            Console.WriteLine("#1");

            CowBarnManager barn = new CowBarnManager("Заря", 10);

            #region Создание и добавление животных

            /// <summary>
            /// Создает дойных коров и быка с разными характеристиками
            /// </summary>
            Cow cow1 = new Cow("Пипка", 4, 450, 18, "Здорова");

            Cow cow2 = new Cow("Айнура", 3, 420, "Здорова");

            Bull bull1 = new Bull("Семен", 5, 750, "Здоровый");

            Bull bull2 = new Bull("Лобанов", 4, 700, "Не здоров");


            /// <summary>
            /// Добавляет созданных животных в коровник
            /// </summary>
            barn.AddAnimal(cow1);
            barn.AddAnimal(cow2);
            barn.AddAnimal(bull1);
            barn.AddAnimal(bull2);
            Console.WriteLine();

            #endregion

            /// <summary>
            /// Выводит характеристики животных и статистику коровника
            /// </summary>
            barn.ShowAllAnimals();
            barn.ShowBarnStatistics();

            /// <summary> 
            /// Вызывает переделанный под каждого животного метод Feed (полиморфизм)
            /// </summary>

            Livestock[] animals = { cow1, cow2, bull1, bull2 };

            foreach (Livestock animal in animals)
                animal.Feed();
            Console.WriteLine();

            #region Работа с коровами

            /// <summary>
            /// Демонстрирует доение, расчет удоя и смену состояния здоровья
            /// </summary>
            Console.WriteLine("Работа с коровами");

            cow1.Milk();

            Console.WriteLine($"Ожидаемый удой за 7 дней: {cow1.CalculateMilk(7):F1} л");
            Console.WriteLine();

            cow2.ExamineHealth("Требуется осмотр");

            cow2.GetInformation();

            cow1.ResetMilking();
            Console.WriteLine();

            #endregion

            #region Работа с быками

            /// <summary>
            /// Проверяет доступность быка для разведения
            /// </summary>
            Console.WriteLine("Работа с быками");

            Console.WriteLine($"Бык {bull1.Name} доступен для разведения:{(bull1.CheckBreedingAvailability() ? "Да" : "Нет")}");
            Console.WriteLine();
            #endregion

            #region Изменение характеристик и удаление животного

            /// <summary>
            /// Изменение свойства, увеличение возраста и удаление
            /// </summary>

            cow1.Age++;
            cow1.Weight = 455;
            Console.WriteLine("После изменения характеристик:");
            Console.WriteLine($"Возраст {cow1.Name}: {cow1.Age}");

            Console.WriteLine($"Вес {cow1.Name}: {cow1.Weight} кг");

            Console.WriteLine($"Удаление животного: Семен");

            barn.RemoveAnimal("Семен");
            barn.ShowBarnStatistics();

            #endregion

            #region Итоговый расчет

            /// <summary>
            /// Рассчитывает ожидаемый удой коров, которых еще не доили сегодня
            /// </summary>
            Console.WriteLine("Итоги");

            Console.WriteLine($"Ожидаемый удой за 3 дня: {barn.CalculateTotalMilk(3):F1} л");

            #endregion
        }

        #endregion
    }
}
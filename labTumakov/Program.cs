using labTumakov.Class;
using labTumakov.Enums;

namespace labTumakov
{
    internal class Program
    {
        static void Main()
        {
            Task7_1();
            Task7_2();
            Task7_3();
            DZ7_1();
        }

        #region Упражнение 7.1

        static void Task7_1()
        {
            Console.WriteLine("Упражнение 7.1");

            decimal balance = ReadNonNegativeDecimal("Введите начальный баланс счета: ");
            BankAccountType accountType = ReadAccountType();

            BankAccount account = new BankAccount(balance, accountType);

            account.PrintInformation();

            Console.ReadKey();
        }

        #endregion

        #region Упражнение 7.2

        static void Task7_2()
        {
            Console.WriteLine("Упражнение 7.2");

            decimal balance1 = ReadNonNegativeDecimal("Введите баланс первого счета: ");
            BankAccountType type1 = ReadAccountType();

            decimal balance2 = ReadNonNegativeDecimal("Введите баланс второго счета: ");
            BankAccountType type2 = ReadAccountType();

            decimal balance3 = ReadNonNegativeDecimal("Введите баланс третьего счета: ");
            BankAccountType type3 = ReadAccountType();

            BankAccount account1 = new BankAccount(balance1, type1);
            BankAccount account2 = new BankAccount(balance2, type2);
            BankAccount account3 = new BankAccount(balance3, type3);

            account1.PrintInformation();
            account2.PrintInformation();
            account3.PrintInformation();

            Console.ReadKey();
        }

        #endregion

        #region Упражнение 7.3

        static void Task7_3()
        {
            Console.WriteLine("Упражнение 7.3");

            decimal balance = ReadNonNegativeDecimal("Введите начальный баланс счета: ");
            BankAccountType accountType = ReadAccountType();

            BankAccount account = new BankAccount(balance, accountType);

            account.PrintInformation();

            decimal depositAmount = ReadPositiveDecimal("Введите сумму для пополнения: ");

            account.Deposit(depositAmount);
            account.PrintInformation();

            decimal withdrawAmount = ReadPositiveDecimal("Введите сумму для снятия: ");

            account.Withdraw(withdrawAmount);
            account.PrintInformation();

            decimal secondWithdrawAmount = ReadPositiveDecimal("Введите сумму для следующего снятия: ");

            account.Withdraw(secondWithdrawAmount);
            account.PrintInformation();

            Console.ReadKey();
        }

        #endregion

        #region Домашнее задание 7.1

        static void DZ7_1()
        {
            Console.WriteLine("Домашнее задание 7.1");

            int buildingcount = ReadPositiveInt("Введите количество зданий: ");

            for (int i = 0; i < buildingcount; i++)
            {
                double height = ReadPositiveDouble($"Введите высоту {i} здания: ");
                int floors = ReadPositiveInt($"Введите количество этажей {i} здания: ");
                int apartaments = ReadPositiveInt($"Введите количество квартир в {i} здании: ");
                int enentrances = ReadPositiveInt($"Введите количество подъездов в {i} здании: ");

                Building building = new Building(height, floors, apartaments, enentrances);

                building.PrintInformation();
            }
        }

        #endregion

        #region Методы ввода

        static int ReadPositiveInt(string message)
        {
            int value;

            Console.Write(message);

            while (!int.TryParse(Console.ReadLine(), out value) || value <= 0)
                Console.Write("Ошибка. Введите целое число больше нуля: ");

            return value;
        }

        static double ReadPositiveDouble(string message)
        {
            double value;

            Console.Write(message);

            while (!double.TryParse(Console.ReadLine(), out value) || double.IsNaN(value) || double.IsInfinity(value) || value <= 0)
                Console.Write("Ошибка. Введите число больше нуля: ");

            return value;
        }

        static decimal ReadPositiveDecimal(string message)
        {
            decimal value;

            Console.Write(message);

            while (!decimal.TryParse(Console.ReadLine(), out value) || value <= 0)
                Console.Write("Ошибка. Введите число больше нуля: ");

            return value;
        }

        static decimal ReadNonNegativeDecimal(string message)
        {
            decimal value;

            Console.Write(message);

            while (!decimal.TryParse(Console.ReadLine(), out value) || value < 0)
                Console.Write("Ошибка. Введите неотрицательное число: ");

            return value;
        }

        static BankAccountType ReadAccountType()
        {
            Console.WriteLine("Выберите тип счета:");
            Console.WriteLine("1 - Дебетовый");
            Console.WriteLine("2 - Кредитный");
            Console.WriteLine("3 - Накопительный");

            int type;

            while (!int.TryParse(Console.ReadLine(), out type) || type < 1 || type > 3)
                Console.Write("Ошибка. Выберите тип счета от 1 до 3: ");

            return (BankAccountType)(type - 1);
        }

        #endregion
    }
}
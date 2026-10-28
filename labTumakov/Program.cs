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

            BankAccount account = new BankAccount(15000m,BankAccountType.Дебетовый);

            account.PrintInformation();

            Console.ReadKey();
        }

        #endregion

        #region Упражнение 7.2
        static void Task7_2()
        {
            Console.WriteLine("Упражнение 7.2");
            BankAccount account1 = new BankAccount(5000m,BankAccountType.Дебетовый);
            BankAccount account2 = new BankAccount(8000m,BankAccountType.Накопительный);
            BankAccount account3 = new BankAccount(12300m, BankAccountType.Кредитный);

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

            BankAccount account = new BankAccount(10000m,BankAccountType.Дебетовый);

            account.PrintInformation();

            account.Deposit(2500m);
            account.PrintInformation();

            account.Withdraw(3000m);
            account.PrintInformation();

            account.Withdraw(20000m);
            account.PrintInformation();

            Console.ReadKey();
        }

        #endregion

        #region Домашнее задание 7.1
        static void DZ7_1()
        {
            Console.WriteLine("Домашнее задание 7.1");

            Building building1 = new Building(30,10,100,4);
            Building building2 = new Building(18,6,48,2);

            building1.PrintInformation();
            building2.PrintInformation();
        }

        #endregion
    }
}
using labTumakov.Enums;

namespace labTumakov.Class
{
    public class BankAccount
    {
        private int _accountNumber;
        private decimal _balance;
        private BankAccountType _accountType;

        private static int _lastAccountNumber = 0;

        /// <summary>
        /// Создает банковский счет с заданным балансом и типом
        /// </summary>
        public BankAccount(decimal balance, BankAccountType accountType)
        {
            _accountNumber = GenerateAccountNumber();
            _balance = balance;
            _accountType = accountType;
        }

        #region упр 7_1
        /// <summary>
        /// Возвращает номер счета только для чтения
        /// </summary>
        public int AccountNumber
        {
            get { return _accountNumber; }
        }

        /// <summary>
        /// Возвращает текущий баланс только для чтения
        /// </summary>
        public decimal Balance
        {
            get { return _balance; }
        }

        /// <summary>
        /// Возвращает и изменяет тип банковского счета
        /// </summary>
        public BankAccountType AccountType
        {
            get { return _accountType; }
        }

        /// <summary>
        /// Изменяет тип банковского счета
        /// </summary>
        public void SetAccountType(BankAccountType accountType)
        {
            _accountType = accountType;
        }


        /// <summary>
        /// Выводит информацию о банковском счете
        /// </summary>
        public void PrintInformation()
        {
            Console.WriteLine($"Номер счета: {_accountNumber}\n Баланс: {_balance:F2}\n Тип счета: {_accountType}");
            Console.WriteLine();
        }
        #endregion

        #region упр 7_2
        /// <summary>
        /// Увеличивает последний номер и возвращает новый уникальный номер счета
        /// </summary>
        public static int GenerateAccountNumber()
        {
            _lastAccountNumber++;
            return _lastAccountNumber;
        }
        #endregion

        #region упр 7_3
        /// <summary>
        /// Пополняет счет на указанную положительную сумму.
        /// </summary>
        public bool Deposit(decimal amount)
        {
            if (amount <= 0)
            {
                Console.WriteLine("Сумма пополнения должна быть положительной");
                return false;
            }

            _balance += amount;
            Console.WriteLine($"Счет пополнен на {amount:F2} \n Баланс: {_balance}" );
            return true;
        }

        /// <summary>
        /// Снимает со счета сумму, если ее достаточно на балансе
        /// </summary>
        public bool Withdraw(decimal amount)
        {
            if (amount <= 0)
            {
                Console.WriteLine("Сумма снятия должна быть положительной");
                return false;
            }

            if (amount > _balance)
            {
                Console.WriteLine("Недостаточно средств на счете");
                return false;
            }

            _balance -= amount;
            Console.WriteLine($"Со счета снято {amount:F2} \n Остаток: {_balance}");
            return true;
        }
        #endregion
    }
}

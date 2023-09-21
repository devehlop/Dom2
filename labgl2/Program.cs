using System;


namespace labgl2
{
    internal class Program
    {
        enum AccountType
        {
           Текущий,
           Сберегательный
        }
        struct BankAccount
        {
            public int accountNumber;
            public string accountType;
            public double accountBalance;

        }
        enum Vuz
        {
            КГУ,
            КАИ,
            КХТИ
        }
        struct User
        {
            public string Name;
            public Vuz Vuz;

        }
        static void Main(string[] args)
        {
            Console.WriteLine("Упражнение 3.1");
            AccountType tec = AccountType.Текущий;
            AccountType cber = AccountType.Сберегательный;
            Console.WriteLine($"Банк имеет {tec} счет и {cber} счет");

            Console.WriteLine("Упражнение 3.2");
            BankAccount accountname = new BankAccount();
            accountname.accountNumber = 10;
            accountname.accountType = "Текущий";
            accountname.accountBalance = 100000;

            Console.WriteLine($"Номер б/с: {accountname.accountNumber}");
            Console.WriteLine($"Тип б/с: {accountname.accountType}");
            Console.WriteLine($"Баланс б/с: {accountname.accountBalance}");

            Console.WriteLine("Упражнение 3.1");
            User user = new User();
            user.Name = "Рустам";
            user.Vuz = Vuz.КГУ;
            Console.WriteLine($"Работник: {user.Name}");
            Console.WriteLine($"ВУЗ: {user.Vuz} ");
        }   
    }
}

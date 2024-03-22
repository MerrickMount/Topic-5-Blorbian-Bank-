namespace Topic_5__Blorbian_Bank_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double userBill, userDeposit, userWithdrawal;
            double userBalance = 150;
            string userTransaction;
            Console.WriteLine("Welcome to the Bank of Blorb");
            Console.WriteLine("Please Select Your Transaction type:");
            Console.WriteLine("Transaction options: Deposit, withdrawal, bill payment, balance update");
            userTransaction = Console.ReadLine();
            if (userTransaction.ToLower() == "deposit")
            {
                Console.WriteLine("Please Insert check or cash");
                Thread.Sleep(1000);
                Console.WriteLine("What total value of check or money");
                userDeposit = double.Parse(Console.ReadLine());
                Console.Write("Checking To varify total");
                Thread.Sleep(800);
                Console.Write(".");
                Thread.Sleep(800);
                Console.Write(".");
                Thread.Sleep(800);
                Console.WriteLine(".");
                Thread.Sleep(1500);
                Random random = new Random();
                if (random.Next(1,10) == 2)
                {
                    Console.WriteLine("The Value you entered is more than what you deposited.");
                    Console.WriteLine("The BoBTM Is confiscating your deposit as punishment.");
                    Console.Write("Charging");
                    Thread.Sleep(800);
                    Console.Write(".");
                    Thread.Sleep(800);
                    Console.Write(".");
                    Thread.Sleep(800);
                    Console.WriteLine(".");
                    Thread.Sleep(2000);
                    Console.WriteLine($"New Balance: ${userBalance - 0.75}");
                    Console.WriteLine("Press enter to close this menu");
                    Environment.Exit(0);
                }
                else
                {
                    Console.WriteLine("Value entered is correct");
                    Thread.Sleep(1500);
                    Console.WriteLine("Depositing");
                    Thread.Sleep(800);
                    Console.Write(".");
                    Thread.Sleep(800);
                    Console.Write(".");
                    Thread.Sleep(800);
                    Console.WriteLine(".");
                    Thread.Sleep(2000);
                    Console.WriteLine($"New Balance: ${(userBalance + userDeposit) - 0.75}");
                    Console.WriteLine("Press enter to close this menu");
                    Environment.Exit(0);
                }
            }
            if (userTransaction.ToLower() == "withdrawal")
            {
                Console.WriteLine("Please Input Withdrawal amount");
                userWithdrawal = Double.Parse(Console.ReadLine());
                if (userWithdrawal > 149.25)
                {
                    Console.WriteLine("Balance to low to complete the transaction");
                    Console.Write("Charging");
                    Thread.Sleep(800);
                    Console.Write(".");
                    Thread.Sleep(800);
                    Console.Write(".");
                    Thread.Sleep(800);
                    Console.WriteLine(".");
                    Thread.Sleep(2000);
                    Console.WriteLine($"New Balance: ${userBalance - 0.75}");
                    Console.WriteLine("Press enter to close this menu");
                    Environment.Exit(0);
                }
                else
                {
                    Console.Write("Charging");
                    Thread.Sleep(800);
                    Console.Write(".");
                    Thread.Sleep(800);
                    Console.Write(".");
                    Thread.Sleep(800);
                    Console.WriteLine(".");
                    Thread.Sleep(2000);
                    Console.WriteLine($"New Balance: ${(userBalance - userWithdrawal) - 0.75}");
                    Console.WriteLine("Press enter to close this menu");
                    Environment.Exit(0);
                }
            }
            if (userTransaction.ToLower() == "bill payment")
            {
                Console.WriteLine("Please Input Bill price");
                userBill = Double.Parse(Console.ReadLine());
                if (userBill > 149.25)
                {
                    Console.WriteLine("Balance to low to complete the transaction");
                    Console.Write("Charging");
                    Thread.Sleep(800);
                    Console.Write(".");
                    Thread.Sleep(800);
                    Console.Write(".");
                    Thread.Sleep(800);
                    Console.WriteLine(".");
                    Thread.Sleep(2000);
                    Console.WriteLine($"New Balance: ${userBalance - 0.75}");
                    Console.WriteLine("Press enter to close this menu");
                    Environment.Exit(0);
                }
                else
                {
                    Console.Write("Charging");
                    Thread.Sleep(800);
                    Console.Write(".");
                    Thread.Sleep(800);
                    Console.Write(".");
                    Thread.Sleep(800);
                    Console.WriteLine(".");
                    Thread.Sleep(2000);
                    Console.WriteLine($"New Balance: ${(userBalance - userBill) - 0.75}");
                    Console.WriteLine("Press enter to close this menu");
                    Environment.Exit(0);
                }
            }
            if (userTransaction.ToLower() == "balance update")
            {
                Console.WriteLine($"Your current balance: ${userBalance}");
                Console.Write("Charging");
                Thread.Sleep(800);
                Console.Write(".");
                Thread.Sleep(800);
                Console.Write(".");
                Thread.Sleep(800);
                Console.WriteLine(".");
                Thread.Sleep(2000);
                Console.WriteLine($"New Balance: ${userBalance - 0.75}");
                Console.WriteLine("Press enter to close this menu");
                Environment.Exit(0);
            }
            else
            {
                userBalance = (userBalance - 0.75);
                Console.WriteLine("Error... Incorrect Option");
                Console.Write("Charging");
                Thread.Sleep(800);
                Console.Write(".");
                Thread.Sleep(800);
                Console.Write(".");
                Thread.Sleep(800);
                Console.WriteLine(".");
                Thread.Sleep(2000);
                Console.WriteLine($"New Balance: ${userBalance}");
                Console.WriteLine("Press enter to close this menu");
                Environment.Exit(0);
            }
        }
    }
}
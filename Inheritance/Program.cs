namespace Inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Account myAccount = new Account();
            double currentAmount = 0.0;
            currentAmount = myAccount.setAccountBalance(1000.00);
            Console.WriteLine("Current Amount {0}", currentAmount);
            currentAmount = myAccount.withdrawFromAccount(200.00);
            Console.WriteLine("Current Amount {0}", currentAmount);
            currentAmount = myAccount.getAccountBalance();
            Console.WriteLine("Current Amount {0}", currentAmount);
            Console.ReadLine();
        }
    }
}

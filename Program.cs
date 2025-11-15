using System;

namespace ATM
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "ATM Machine";

            cardHolder currentUser = new cardHolder();

            while (true)
            {
                Console.WriteLine("Please choose from one of the following options...");
                Console.WriteLine("1. Deposit");
                Console.WriteLine("2. Withdraw");
                Console.WriteLine("3. Show Balance");
                Console.WriteLine("4. Exit");

                Console.Write("Your choice: ");
                int choose = Int32.Parse(Console.ReadLine());

                switch (choose)
                {
                    case 1:
                        Console.Write("How much money would you like to deposit: ");
                        decimal deposit = Decimal.Parse(Console.ReadLine());
                        currentUser.setBalance(currentUser.getBalance() + deposit);
                        Console.WriteLine("Thank you for your deposit. Your new balance is: " + currentUser.getBalance() + " BGN");
                        break;

                    case 2:
                        Console.Write("How much money would you like to withdraw: ");
                        decimal withdraw = Decimal.Parse(Console.ReadLine());

                        if (currentUser.getBalance() < withdraw)
                        {
                            Console.WriteLine("Insufficient balance :(");
                        }
                        else
                        {
                            currentUser.setBalance(currentUser.getBalance() - withdraw);
                            Console.WriteLine("You have withdrawn: " + withdraw + " BGN. Your new balance is: " + currentUser.getBalance() + " BGN");
                        }
                        break;

                    case 3:
                        Console.WriteLine("Your current balance is: " + currentUser.getBalance() + " BGN");
                        break;

                    case 4:
                        Console.WriteLine("Thank you! Have a nice day!");
                        return; 
                }

                Console.WriteLine(); 
            }
        }
    }
}

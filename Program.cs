using static System.Net.Mime.MediaTypeNames;

namespace BankEncapsulation
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Create a new instance of the BankAccount class
            BankAccount ATM = new BankAccount();

            //Allow the user of the application to Deposit money
            Console.WriteLine("How much money would you like to Deposit?");
            double response = double.Parse(Console.ReadLine());

            ATM.Deposit(response);
            //the amount deposited
            //EXTRA CREDIT-give the total 
            //Allow the user to retrieve their balance through the console
            //EXTRA CREDIT-allow user to make a withdrawl using similar process in line 13 and 14  
            double newBal = ATM.GetBalance();
            Console.WriteLine($"You have a new balance of {newBal}");

            //make a withdraw process
                
        }
}
}

using Solid_Principles.ISP;
using Solid_Principles.LSP;
using Solid_Principles.OCP;
using Solid_Principles.SRP;
using System;
using System.Reflection.Metadata;

public class Program
{
    static void PrintAccountDetails(BankAccount account)
    {
        Console.WriteLine($"Account Number: {account.AccountNumber}, Balance: {account.Balance}");
    }
    static void Main()
    {

        //Solid Principle 1 SRP (Single Responsibility Principle)
        TaskManager taskManager = new TaskManager();
        ConsoleUI consoleUI = new ConsoleUI(taskManager);
        //consoleUI.Run();



        //Solid Principle 2 OCP (Open CLosed Principle)
        IShapeDrawer circle = new Circle();
        IShapeDrawer square = new Square();
        circle.draw();
        square.draw();


        //Solid Principle 3 LSP (Liskov Substitution Principle)
        BankAccount savingsAccount = new SavingAccount("SA123", 1000m, 0.03m);
        BankAccount currentAccount = new CurrentAccount("CA456", 1500m, 500m);
        Console.WriteLine("Before Transactions:");
        PrintAccountDetails(savingsAccount);
        PrintAccountDetails(currentAccount);
        savingsAccount.WithDraw(500m);
        currentAccount.WithDraw(2000m);
        Console.WriteLine("\nAfter Transactions:");
        PrintAccountDetails(savingsAccount);
        PrintAccountDetails(currentAccount);
        Console.ReadKey();



        //Solid Principle 4 ISP (Interface Segregation Principle)

        Documents document = new Documents();
        document.EditDocument();
        document.ViewDocument();

        ImageDocument imageDocument = new ImageDocument();
        imageDocument.ViewDocument();


        //Solid Principle 5 DIP (Dependency Inversion Principle)




    }
}

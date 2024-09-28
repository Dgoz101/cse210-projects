using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to your journal.");
        int opcion = 0;
        MyJournal journal = new MyJournal();
        while (opcion !=5)
        {
                Console.WriteLine("Select an option:\n"+
                "\n1.Write"+
                "\n2.Display"+
                "\n3.Load"+
                "\n4.Save"+
                "\n5.Quit");
                opcion = int.Parse(Console.ReadLine());
                switch(opcion)
                    {
                            case 1:
                            journal.AddEntry2() ;
                                break;
                            case 2:
                            journal.DisplayEntries();
                                break;
                            case 3:
                                journal.LoadFromFile();
                                break;
                            case 4:
                                journal.SavingToFile();
                                break;
                            case 5:
                                Console.WriteLine("Til' next time!");
                                break;
                            default:
                                Console.Write("Invalid choice:\n");
                                break;

                    }
        }
       
    }
}
using System;

class Program
{
    static void Main(string[] args)
    {
        bool cont = true;
        while(cont)
        {
            Console.Clear();
            Console.WriteLine("Menu options:");
            Console.WriteLine("1.Breathing");
            Console.WriteLine("2.Reflecting");
            Console.WriteLine("3.Listing");
            Console.WriteLine("4.Quit");
            Console.WriteLine("Select an activity from the menu. Enter the number here: ");
            string option = Console.ReadLine();

            if (option == "1")
            {
                BreathingActivity breathing1 = new BreathingActivity();
                breathing1.Run();
            } 
            else if (option == "2")
            {
                ReflectingActivity reflect1 = new ReflectingActivity();
                reflect1.Run();
            } 
            else if (option == "3")
            {
                ListingActitivity list1 = new ListingActitivity();
                list1.Run();
            } 
            else if (option == "4")
            {
                cont = false;
            } 
            else 
            {
                Console.WriteLine("An error has occurred. Restart the application.");
            }
        }       
    }
}
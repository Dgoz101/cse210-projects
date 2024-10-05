using System;

class Program
{
    static void Main(string[] args)
    {
        Scripture scripture = GetRandomScripture();
        bool memorizing = true;

        while (memorizing)
        {   
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText() + "\n");
            Console.WriteLine("Press enter to continue memorizing or type quit to exit.");
            string input = Console.ReadLine();


            if (input == "")
            {
                scripture.HideRanbomWords(5);
                if (scripture.IsCompletelyHidden())
                {
                    memorizing = false;
                }
            }
            else if (input == "quit")
            {
                memorizing = false;
            }
            else
            {
                Console.WriteLine("Invalid input, please press enter or type 'quit' to finish");
            }
        }
    }


    static Scripture GetRandomScripture()
    {
        Random rando = new Random();
        int scriptureReference = rando.Next(2);

        if (scriptureReference == 0)
        {
            Reference reference = new Reference ("John", 3, 16);
            string text = "For God so loved the world, that he gave his only begotten Son,that whosoever believeth in him should not perish, but have everlasting life.";
            return new Scripture(reference, text);
        }
        else 
        {
            Reference reference = new Reference("Proverbs", 3, 5, 6);
            string text = "Trust in the Lord with all thine heart; and lean not unto thine own understanding. In all thy ways acknowledge him, and he shall direct thy paths.";
            return new Scripture(reference, text);
        }
    }


}
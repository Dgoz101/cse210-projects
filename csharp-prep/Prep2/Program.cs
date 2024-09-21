using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter Grade Percentage: ");
        string userValue = Console.ReadLine();

        int userGrade = int.Parse(userValue);

        string letter = "";

        if ( userGrade >= 90 )
        {
            letter = "A";
        }
        else if ( userGrade >= 80 )
        {
            letter = "B";
        }
        else if ( userGrade >= 70 )
        {
            letter = "C";
        }
        else if ( userGrade >= 60 )
        {
            letter = "D";
        }
        else if ( userGrade < 60 )
        {
            letter = "F";
        }
        else
        {
            Console.Write("Enter a valid percentage.");
        }

        Console.Write($"Your grade is {letter}.");


        if (userGrade >= 70)
        {
            Console.Write(" Nice work! You have passed the class!");
        }
        else
        {
            Console.Write(" You didn't pass. Better luck next time!");
        }



    }
}
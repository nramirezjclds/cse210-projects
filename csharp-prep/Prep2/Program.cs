using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep2 World!");

        Console.Write("What is your grade percentage? ");
        string grade = Console.ReadLine();
        int number = int.Parse(grade);
        string letter = "";

    //A grade
        if (number >= 90)
        {          
            letter = "A";
        }

    //B grade
        else if(number >= 80 && number < 90)
        {         
            letter = "B";
        }

    //C grade
        else if(number >= 70 && number < 80)
        {
            letter = "C";
        }

    //D grade
        else if(number >= 60 && number < 70)
        {        
            letter = "D";
        }

    //F grade
        else
        {
            letter = "F";
        }

    //Print Grade
        Console.WriteLine($"{letter}");

    //Passing remarks
        if (number == 100)
        {
            Console.Write("Wow! A perfect score! Here's your diploma.");
        }
        else if (number >= 70 && number < 99)
        {
            Console.Write("Congratulations on passing the class!");
        }
        else
        {
            Console.Write("I'm sorry, better luck next time.");
        }
    }
}
using System;
using System.IO;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Random rd = new Random();
        List <string> prompts_List= new List<string>()
        {
            "Who was the most interesting person I interacted with today?",
            "What was the best part of my day?",
            "How did I see the hand of the Lord in my life today?",
            "What was the strongest emotion I felt today?",
            "If I had one thing I could do over today, what would it be?"
        };
       
        int input;
        do
        {
        Console.WriteLine("Welcome to the Journal Program!");
        Console.WriteLine("Please select on of the following choices:");
        Console.WriteLine("1.Write");
        Console.WriteLine("2.Display");
        Console.WriteLine("3.Load");
        Console.WriteLine("4.Save");
        Console.WriteLine("5.Quit");
        Console.Write("What would you like to do? ");
        input = int.Parse( Console.ReadLine());

        if(input == 1)
        {
            int rand_num = rd.Next(4);
            Console.WriteLine(prompts_List[rand_num]);
            string new_input = Console.ReadLine();
            Console.WriteLine(new_input);
            SaveToFile();

            List <Entry> journal = new List<Entry>();
            journal.Add(new_input);

            static void SaveToFile(List<Entry>journal);
            string filename = "journal.txt";
                using (StreamWriter outputFile = new StreamWriter(filename))
                {
                    foreach (Entry line in journal)
                    {
                        outputFile.WriteLine($"{journal}");
                    }
                }
        }
        }
        while(input != 5);
        {
        }
    }
}
    
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

        Journal journal1 = new Journal();
        List<string> theJournal = new List<string>();
        int input;
        string fileResponse;

        do
        {
        Console.WriteLine("Welcome to the Journal Program!");
        Console.WriteLine("Please select on of the following choices:");
        Console.WriteLine("1. Write");
        Console.WriteLine("2. Display");
        Console.WriteLine("3. Load");
        Console.WriteLine("4. Save");
        Console.WriteLine("5. Quit");
        Console.Write("What would you like to do? ");
        input = int.Parse( Console.ReadLine());

        //#1- Write
        if(input == 1)
        {
            Random random = new Random();
            int rand_num = rd.Next(4);
            Entry userEntry = new Entry();
            userEntry._journalQuestion = prompts_List [rand_num];
            Console.WriteLine(userEntry._journalQuestion);
            Console.Write(">>> ");
            string userJournal = Console.ReadLine();
            userEntry._journalEntry = userJournal;
            journal1._entries.Add(userEntry);
            Console.WriteLine("");
        }
        
        //#2- Display
        else if (input == 2)
        {
            Console.WriteLine("");
            foreach(string entry in theJournal)
            {
                Console.WriteLine(entry);
            }
            journal1.Display();
            Console.WriteLine("");
        }

        //#3- Load
        else if (input == 3)
        {
            Console.Write("What is the file's name? ");
            Console.Write("");
            fileResponse = Console.ReadLine();
            string fileName = fileResponse;
            string[] lines = System.IO.File.ReadAllLines(fileName);
            foreach (string line in lines)
                    {
                            Console.WriteLine(line);
                            theJournal.Add(line);                            
                    }
                    Console.WriteLine("File loaded.");
                    Console.WriteLine("");
        }

        //#4- Save
        else if (input == 4)
        {
            Console.Write("What is the file's name? ");
            Console.Write("");
            fileResponse = Console.ReadLine();
            using (StreamWriter outputFile = new StreamWriter(fileResponse))
            {
                foreach (Entry entry in journal1._entries)
                {
                    outputFile.WriteLine($"Date: {DateTime.Now.ToString("dd-MM-yyyy")} - Prompt: {entry._journalQuestion}");
                    outputFile.WriteLine($"{entry._journalEntry}");
                }
            }
            Console.WriteLine("Your progress has been saved.");
            Console.WriteLine("");
        }
        
        }

        //#5- Quit
        while(input != 5);{} 
    }
}
    
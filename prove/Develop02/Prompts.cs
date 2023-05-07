using System;
using System.Collections.Generic;

public class Prompts
{
    Random rd = new Random();
        public List <string> prompts_List= new List<string>()
        {
            "Who was the most interesting person I interacted with today?",
            "What was the best part of my day?",
            "How did I see the hand of the Lord in my life today?",
            "What was the strongest emotion I felt today?",
            "If I had one thing I could do over today, what would it be?"
        };
        
    public string GetRandomPrompt()
    {
        int index = rd.Next(4);
            Console.WriteLine(prompts_List[index]);
            return prompts_List;
    }
}

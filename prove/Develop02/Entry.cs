using System;

public class Entry
{
    public string _journalEntry = "";
    public string _journalQuestion = "";
    public string _date = DateTime.Now.ToString("dd-MM-yyyy");

    public void Display()
    {
        Console.WriteLine($"{_journalQuestion}");
        Console.WriteLine($"{_date}: {_journalEntry}");
    }
}
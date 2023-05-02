public class Job
{
    public string _company = "";
    public string _jobTitle = "";
    public string _startYear = "";
    public string _endYear = "";

    public Job()
    {
    }

    public void ShowCompany()
    {
        Console.WriteLine($"{_company}");
    }

    public void ShowTitle()
    {
        Console.WriteLine($"{_jobTitle}");
    }

    public void ShowStartYear()
    {
        Console.WriteLine($"{_startYear}");
    }

    public void ShowEndYear()
    {
        Console.WriteLine($"{_endYear}");
    }

    public void DisplayJobDetails()
    {
        Console.WriteLine($"{_jobTitle} ({_company}) {_startYear}-{_endYear}");
    }
}
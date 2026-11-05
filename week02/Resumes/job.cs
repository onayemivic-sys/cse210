public class Job
{
    //iformation about job
    public string _company = "";
    public string _jobTitle = "";
    public int _startyear;
    public int _endyear;


    //display job info
    public void Display()
    {
        Console.WriteLine($"{_jobTitle} ({_company}) {_startyear}-{_endyear}");
    }
}
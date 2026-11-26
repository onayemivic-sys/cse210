using System;
using System.Collections.Generic;

public class ListingActivity : Activity
{
    //store listing prompt
    private List <string> _prompt;

    //constructor 
    public ListingActivity(string name, string description)
    : base (name, description)
    {
        _prompt = new List<string>();
    }
    //run the list in activity
     public void Run()
    {
    }
    //get the list of responses from the user
    public List<string> GetListFromUser()
    {
        return new List<string>();
    }
}
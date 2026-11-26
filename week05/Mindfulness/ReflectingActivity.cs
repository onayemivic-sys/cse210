using System;
using System.Collections.Generic;

public class ReflectingActivity : Activity
{
    //store reflection prompt
    private List<string> _prompt;

//constructor
public ReflectingActivity(string name, string description)
   : base (name, description)
    {
        _prompt = new List<string> ();
    }
    // run the reflecting activity
    public void Run()
    {
    }
    //display reflection questions
    public void DisplayQuestion()
    {
    }
}
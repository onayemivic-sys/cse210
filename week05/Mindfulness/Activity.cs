using System;
public class Activity
{
    // member variables
    protected string _name;
    protected string _description;
    protected int _duration;

    // constructor
    public Activity(string name, string description)
    {
        _name = name;
        _description = description;
        _duration = 0;
    }
    //display the start message
    public void DisplayStartingMessage()
    {
    }
    //display the end message
    public void DisplayEndingMessage()
    {   
    }
    //show a spinner animation
    public void ShowSpinner(int seconds)
    {
    }
    //show a countdown
    public void ShowCountDown(int seconds)
    {
    }
}
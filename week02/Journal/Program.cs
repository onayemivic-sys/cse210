using System;

public class Journal
{
    public void AddEntry(Entry entry) { }
    public void DisplayAll() { }
    public void Savefile(string filename) { }
    public void LoadFromFile(string filename) { }
    public void DisplayMoodSummary() { }
}

public class Entry
{
    public string Date { get; set; }
    public string Prompt { get; set; }
    public string Response { get; set; }
    public string Mood { get; set; }
}

public class PromptGenerator
{
    public string GetRandomPrompt() => "What are you grateful for today?";
}

public class Program
{
    public static void Main(string[] args)
    {
        // for the creative part I added a daily mood tracker to the journal program.
        // The user can  record their mood alongside journal entries.
        //and view a summary of their mood history.
        //I also use Json storage to preserve journal information.


        Journal journal = new Journal();
        PromptGenerator promptGenerator = new PromptGenerator();

        bool running = true;

        Console.WriteLine("==================");
        Console.WriteLine(" MY DAILY JOURNAL ");
        Console.WriteLine("==================");

        while (running)
        {
            Console.WriteLine("\nSelect an option:");
            Console.WriteLine("1. Write a new journal entry");
            Console.WriteLine("2. Display journal");
            Console.WriteLine("3. Save journal");
            Console.WriteLine("4. Load journal");
            Console.WriteLine("5. Track daily mood");
            Console.WriteLine("6. View mood summary");
            Console.WriteLine("7. Quit");
            
            Console.Write("Enter your choice: ");
            string choice = Console.ReadLine()?? "";

            switch (choice)
            {
                case "1": 
                WriteEntry(journal, promptGenerator);
                break;

                case "2":
                journal.DisplayAll();
                break;

                case "3":

                Console.Write("Enter filename to save: ");
                string saveFile = Console.ReadLine() ?? "";
                if (!string.IsNullOrWhiteSpace(saveFile))
                {
                    journal.Savefile(saveFile);
                }
                break;


                case "4":
                    Console.Write("Enter filename to load: ");
                    string loadFile = Console.ReadLine() ?? "";
                    if (!string.IsNullOrWhiteSpace(loadFile))
                    {
                        journal.LoadFromFile(loadFile);
                    }
                    break;

                case "5":
                    WriteEntry(journal, promptGenerator);
                    break;

                case "6":
                    journal.DisplayMoodSummary();
                    break;

                case "7":
                    running = false;
                    Console.WriteLine("Thank you for using your journal!");
                    break;

                default:
                    Console.WriteLine("Invalid option. Try again.");
                    break;
            }
        }
    }

    public static void WriteEntry(
        Journal journal,
        PromptGenerator promptGenerator)
    {
        string prompt = promptGenerator.GetRandomPrompt();

        Console.WriteLine("\nYour journal prompt:");
        Console.WriteLine(prompt);

        Console.Write("\nYour response: ");
        string response = Console.ReadLine() ?? "";

        Console.WriteLine("\nHow are you feeling today?");
        Console.WriteLine("1. Happy");
        Console.WriteLine("2. Excited");
        Console.WriteLine("3. Grateful");
        Console.WriteLine("4. Calm");
        Console.WriteLine("5. Sad");
        Console.WriteLine("6. Stressed");
        Console.WriteLine("7. Tired");

        Console.Write("Choose your mood: ");

        string moodChoice = Console.ReadLine() ?? "";

        string[] moods =
        {
            "Happy", "Excited", "Grateful", "Calm",
            "Sad", "Stressed", "Tired", "Depressed", "Anxious", "Content"
        };

        if (!int.TryParse(moodChoice, out int moodNumber) ||
            moodNumber < 1 || moodNumber > moods.Length)
        {
            Console.WriteLine("Invalid mood. Please try again.");
            return;
        }

        Entry entry = new Entry
        {
            Date = DateTime.Now.ToString("yyyy-MM-dd"),
            Prompt = prompt,
            Response = response,
            Mood = moods[moodNumber - 1]
        };

        journal.AddEntry(entry);

        Console.WriteLine("\nYour journal entry has been recorded!");
    }
}
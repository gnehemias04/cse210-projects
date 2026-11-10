using System.IO;
using System.Collections.Generic;
public class Journal
{
    public List<Entry> _entries = new List<Entry>();

    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);
    }
    public void DisplayAll()
    {
        foreach (var entry in _entries)
        {
            entry.Display();
        }
    }
    public void SaveToFile(string file)
    {
        string newFile = file + ".txt";
        using (StreamWriter outputFile = new StreamWriter(newFile))
        {
            foreach (var entry in _entries)
            {
                outputFile.WriteLine($"{entry._date} ~|~{entry._promptText} ~|~{entry._entryText}");
            }
        }

    }

    public void LoadFromFile(string file)

    {
        string loadFile = file + ".txt";
        _entries.Clear();
        string[] lines = System.IO.File.ReadAllLines(loadFile);
        foreach (string line in lines)
        {
            string[] parts = line.Split("~|~");

            string date = parts[0];
            string promptText = parts[1];
            string entryText = parts[2];
            Entry entry = new Entry(date, promptText, entryText);
            AddEntry(entry);
        }

    }
}
/*


string filename = "myFile.txt";
string[] lines = System.IO.File.ReadAllLines(filename);

foreach (string line in lines)
{
    string[] parts = line.Split(",");

    string firstName = parts[0];
    string lastName = parts[1];
}




using System.IO; 

...

string filename = "myFile.txt";

using (StreamWriter outputFile = new StreamWriter(filename))
{
    // You can add text to the file with the WriteLine method
    outputFile.WriteLine("This will be the first line in the file.");
    
    // You can use the $ and include variables just like with Console.WriteLine
    string color = "Blue";
    outputFile.WriteLine($"My favorite color is {color}");

*/
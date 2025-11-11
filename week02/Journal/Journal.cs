using System.IO;

public class Journal
{
    public List<Entry> _entries = new List<Entry>();

    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);
    }

    public void DisplayAll()
    {
        foreach (Entry entry in _entries)
        {
            entry.Display();
        }
    }

    public void SaveToFiles(string file)
    {
        using (StreamWriter outputFile = new StreamWriter(file))
        {
            //outputFile.WriteLine(_entries);

            foreach (Entry e in _entries)
            {
                
                outputFile.WriteLine($"{e._date} | {e._promptText} | {e._entryText}");
            }
        }
    }

    public void LoadFromFile(string file)
    {
        string[] entries = System.IO.File.ReadAllLines(file);

        foreach (string entry in entries)
        {
            string[] parts = entry.Split("|");

            Entry newEntry = new Entry();

            newEntry._date = parts[0];
            newEntry._promptText = parts[1];
            newEntry._entryText = parts[2];
            
            _entries.Add(newEntry);
        }
    }


}
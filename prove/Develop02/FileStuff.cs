using System.IO;

class FileStuff
{
    public string _filename;
    public List<string> _journal = new List<string>();
    public FileStuff()
    {
    }

    // Prompt for the filename and return the user input
    public string GetFileName()
    {
        Console.WriteLine("What is the filename? ");
        _filename = Console.ReadLine();
        return _filename;
    }

    // Write the current contents of the "_journal" list into a file
    public void FileWrite(List<string> _journal)
    {
        // Prompt for "_filename"
        _filename = GetFileName();

        // Write each entry to the file
        using (StreamWriter outputFile = new StreamWriter(_filename))
        {
            for (int i = 0; i < _journal.Count; i++)
            outputFile.WriteLine(_journal[i]);
        }
    }

    // Read the current contents of a file into the "_journal" list
    // replacing the data in the list
    public List<string> FileRead()
    {
        // Initialize bool so while loop can run
        bool _fileCheck = false;

        while(!_fileCheck)
        {
            // Prompt for "_filename"
            _filename = GetFileName();

            // Try and catch in case of "file not found" (this exceeds requirements)
            try
            {
                // If the file doesn't exist
                if (!File.Exists(_filename))
                    throw new FileNotFoundException();
                // If the file exists
                else
                    _fileCheck = true;
            }
            catch(FileNotFoundException)
            {
                Console.WriteLine("The file don't exist!");
            }
        }    
            
        // Empty the current "_journal" list
        _journal.Clear();

        string[] lines = System.IO.File.ReadAllLines(_filename);

        // Add each entry to the "_journal" list
        foreach (string line in lines)
        {
            string[] parts = line.Split("|");
            foreach (string part in parts)
            {
                _journal.Add(part);
            }
        }
        return _journal;
    }

}
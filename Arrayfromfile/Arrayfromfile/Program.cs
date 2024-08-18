using static System.Console;
using System.IO;

class ReadNameFromFile()
{
    
    static void Main(string[] args)
    {
        string? nameChoice = "";
        int nameChoiceNumber;
        
        string path = @"C:\Users\RaffP\Documents\GitHub\CSharpConsoleApps\Arrayfromfile\Arrayfromfile\names\names.txt";
        string[] readNames = File.ReadAllLines(path);
        WriteLine("These are the names from the file: ");
        foreach (string readName in readNames)
            WriteLine("\t" + readName);

        WriteLine("Number of names: " + readNames.Length);

        Array.Sort(readNames);
        WriteLine("Names have been sorted alphabetically");

        foreach (string readName in readNames)
            WriteLine("\n" + readName);

        using (StreamWriter ap = File.AppendText(path))
        {
            foreach(string readName in readNames) 
                ap.WriteLine(readName);
        }

        WriteLine("What name do you want to select? (e.g 5, 15).");
        nameChoice = ReadLine();
        bool stringInt = int.TryParse(nameChoice, out nameChoiceNumber);



        for(int i = 0; i < nameChoiceNumber; i++)
        {
            int index = i;
            index++;
            if (index == nameChoiceNumber)
            {
                WriteLine("\t your selection: " + nameChoiceNumber);
                WriteLine("\t Test" + readNames[i]);
                
            }

        }


        
            
            return;

        
    }

    
}

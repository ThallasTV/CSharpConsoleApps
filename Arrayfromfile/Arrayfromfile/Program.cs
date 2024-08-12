using static System.Console;
using System.IO;

class ReadNameFromFile()
{
    
    static void Main(string[] args)
    {
        string? nameChoice = "";
        int nameChoiceNumber;
        
        string[] readNames = File.ReadAllLines(@"C:\Users\josh-\Desktop\Git\CSharpConsoleApps\Arrayfromfile\Arrayfromfile\names\names.txt");
        WriteLine("These are the names from the file: ");
        foreach (string readName in readNames)
            WriteLine("\t" + readName);

        WriteLine("Number of names: " + readNames.Length);

        Array.Sort(readNames);
        WriteLine("Names have been sorted alphabetically");

        foreach (string readName in readNames)
            WriteLine("\n" + readName);

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

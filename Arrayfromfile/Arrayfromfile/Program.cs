using static System.Console;
using System.IO;

class ReadNameFromFile()
{
    
    static void Main(string[] args)
    {
        
        string[] readNames = File.ReadAllLines(@"C:\Users\josh-\Desktop\Git\CSharpConsoleApps\Arrayfromfile\Arrayfromfile\names\names.txt");
        WriteLine("These are the names from the file: ");
        foreach (string readName in readNames)
            WriteLine("\t" + readName);

        WriteLine("Number of names: " + readNames.Length);

        Array.Sort(readNames);
        WriteLine("Names have been sorted alphabetically");

        foreach (string readName in readNames)
            WriteLine("\n" + readName);    

        return;


    }
}

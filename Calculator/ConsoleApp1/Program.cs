using System.Text.RegularExpressions;
using static System.Console;

class Calculator
{
    public static double CompleteOperation(double a, double b, string operation)
    {
        double result = double.NaN;

        switch (operation)
        {
            case "1":
                result = a + b;
                break;
            case "2":
                result = a - b;
                break;
            case "3":
                result = a * b;
                break;
            case "4":
                if (b != 0)
                    result = a / b;
                break;
            default:
                break;

        }
        return result;
    }
}

class Program
{
    static void Main(string[] args)
    {
        string? firstValue = "";
        string? secondValue = "";
        double result = 0;
        double dFirstValue;
        double dSecondValue;


        WriteLine("Please input your first value:");
        firstValue = ReadLine();

        while (!double.TryParse(firstValue, out dFirstValue))
        {
            WriteLine("Your input was not a numerical value");
            firstValue = ReadLine();
        }

        while (!Regex.IsMatch(firstValue, @"\w{0-100}"))
        {
            WriteLine("Value out of bounds.");
            firstValue = ReadLine();
        }





        WriteLine("Please input your second value:");
        secondValue = ReadLine();

        while (!double.TryParse(secondValue, out dSecondValue))
        {
            WriteLine("Your input was not a numerical value");
            secondValue = ReadLine();
        }

        WriteLine("Please select from the following options: ");
        WriteLine("\t1 - Addition");
        WriteLine("\t2 - Subtraction");
        WriteLine("\t3 - Multiplication");
        WriteLine("\t4 - Division");

        string? operation = ReadLine();

        //result = Calculator.CompleteOperation(firstValue, secondValue, operation);

        WriteLine("Result: " + result);

        return;




    }
}

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
                if(b != 0)
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
        double firstValue = 0;
        double secondValue = 0;
        double result = 0;

        WriteLine("Please input your first value:");
        firstValue = Convert.ToDouble(ReadLine());

        WriteLine("Please input your second value:");
        secondValue = Convert.ToDouble(ReadLine());

        WriteLine("Please select from the following options: ");
        WriteLine("\t1 - Addition");
        WriteLine("\t2 - Subtraction");
        WriteLine("\t3 - Multiplication");
        WriteLine("\t4 - Division");

        string? operation = ReadLine();

        result = Calculator.CompleteOperation(firstValue, secondValue, operation);

        WriteLine("Result: " + result);

        return;

        


    }
}

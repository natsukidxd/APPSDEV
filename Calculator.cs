public class Calculator
{
    public static void Main(string[] args)
    {
        string name = "Krist Dave Ferrer";
        Console.WriteLine (name);
        Console.WriteLine("Enter two number below.");
        double num1;
        while(true) {
            try {
                Console.Write("Num 1: ");
                num1 = Double.Parse(Console.ReadLine());
                break;
            } catch(FormatException) {
                Console.WriteLine("Try again.");
            }
        }
        double num2;
        while(true) {
            try {
                Console.Write("Num 2: ");
                num2 = Double.Parse(Console.ReadLine());
                break;
            } catch(FormatException) {
                Console.WriteLine("Try again.");
            }
        }
        char op;
        double result = 0;
        while(true) {
            try {
                Console.Write("Select an operator [+ - / * % ] : ");
                string stringOp = Console.ReadLine();
                op = Char.Parse(stringOp);
                break;
            } catch(FormatException) {
                Console.WriteLine("Try again.");
            }
        }
        switch(op) {
            case '+' : {
                result = num1 + num2;
                break;
            }
            case '-' : {
                result = num1 - num2;
                break;
            }
            case '/' : {
                result = num1 / num2;
                break;
            }
            case '*' : {
                result = num1 * num2;
                break;
            }
            case '%' : {
                result = num1 % num2;
                break;
            }
            default : {
                Console.WriteLine("Invalid input");
                break;
            }
        }
        
        Console.WriteLine(num1 + " " + op + " " + num2 + " = " + result);
    }
}

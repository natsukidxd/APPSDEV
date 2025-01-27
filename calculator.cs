public class calculator
{
    public static void Main(string[] args)
    {
        string name = "Krist Dave Ferrer";
        Console.WriteLine (name);
        Console.WriteLine("Enter two number below.");
        Console.Write("Num 1: ");
        double num1 = Convert.ToDouble(Console.ReadLine());
        Console.Write("Num 2: ");
        double num2 = Convert.ToDouble(Console.ReadLine());
        Console.Write("Select an operator [+ - / * % ] : ");
        char op = Convert.ToChar(Console.ReadLine());
        double result = 0;
        
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
        }
        
        Console.WriteLine(num1 + " " + op + " " + num2 + " = " + result);
    }
}

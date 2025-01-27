// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

using System;

public class Display-Demographics
{
    public static void Main(string[] args)
    {
        string name = "Krist Dave Ferrer";
        string nickname = "KD";
        int age = 22;
        string address = "Gun-ob, Lapu-Lapu City, Cebu";
        string gender = "male";
        int yearLevel = 2;
        int idNumber = 21516596;
        string course = "BSIT";
        string job = "College Library Internet";
        string phoneNumber = "09336405666";
        
        Console.WriteLine("Name         : " + name);
        Console.WriteLine("Nickname     : " + nickname);
        Console.WriteLine("Age          : " + age);
        Console.WriteLine("Address      : " + address);
        Console.WriteLine("Gender       : " + gender);
        Console.WriteLine("Year Level   : " + yearLevel);
        Console.WriteLine("ID No.       : " + idNumber);
        Console.WriteLine("Course       : " + course);
        Console.WriteLine("Job          : " + job);
        Console.WriteLine("Phone No.    : " + phoneNumber);
    }
}

// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

using System;

public class Calculator
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

public class FactChecker {

    public static void Main(string[] args)
    {
        Console.Write("Enter a string: ");
        string userString = Console.ReadLine();
        Console.Write("Enter a integer: ");
        int userInt = Convert.ToInt32(Console.ReadLine());
        int stringToInt = Convert.ToInt32(userString);
        
        if(stringToInt == userInt){
            Console.WriteLine("Krist Dave B. Ferrer");
        } else {
            Console.WriteLine("22");
        }
    }
}

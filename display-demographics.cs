public class display-demographics
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
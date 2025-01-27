public class FactCheckerApp {

    public static void Main(string[] args)
    {
        Console.Write("Enter a string: ");
        string userString = Console.ReadLine();
        string lowerUser = userString.ToLower();
        Console.Write("Enter a integer: ");
        int userInt = Convert.ToInt32(Console.ReadLine());

        string correctString = "Hello World";
        string lowerCorrect = correctString.ToLower();
        int correctInt = 2025;
        
        Console.WriteLine("Fact Check\n");
        Console.WriteLine("Correct string: " + correctString);
        Console.WriteLine("Correct int   : " + correctInt);
        
        if(correctString.Equals(lowerUser) && correctInt == userInt) {
            Console.Write("Krist Dave Ferrer");
        } else {
            Console.Write("22");
        }
        
    }
}

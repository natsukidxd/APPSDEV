public class fact-checker-app {

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

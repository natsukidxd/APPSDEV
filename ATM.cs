public class ATM {
    
    public static void Main(string[] args) {
        
        string user = "Krist Dave";
        double balance = 10000;
        string moneyformat = "\tPhp #,##0.00";

        Console.WriteLine("*************** ATM SYSTEM ***************");
        Console.WriteLine("\nWelcome, " + user);
        Console.WriteLine("What would you like to do? \n[1] Check Balance \n[2] Deposit \n[3] Withdraw \n[4] Exit");
        int choice;

        while(true) {
            try {
                Console.Write("Enter your choice: ");
                string temp = Console.ReadLine();
                choice = Int32.Parse(temp);
                if(choice > 4 || choice <= 0) {
                    Console.WriteLine("Try again.");
                } else {
                    break;
                }
            } catch(FormatException) {
                Console.WriteLine("Try again.");
            }
        }
        switch(choice) {
            case 1: {
                Console.WriteLine("\n*********** BALANCE ***********\n");
                Console.WriteLine("Your current balance is: ");
                Console.WriteLine(balance.ToString(moneyformat));
                break;
            }
            case 2: {
                Console.WriteLine("\n*********** DEPOSIT ***********\n");
                while(true) {
                    try {
                        Console.Write("Deposit: ");
                        string temp = Console.ReadLine();
                        double deposit = Convert.ToDouble(temp);
                        if(deposit > 0) {
                            balance+=deposit;
                            Console.WriteLine(deposit.ToString(moneyformat) + " is deposited to your account.");
                            break;
                        } else {
                            Console.WriteLine("Can't deposit 0 or negative amounts.");
                        }
                    } catch(FormatException) {
                        Console.WriteLine("Try again.");
                    }
                }
                break;
            }
            case 3: {
                Console.WriteLine("\n*********** WITHDRAW ***********\n");
                while(true) {
                    try {
                        Console.Write("Withdraw: ");
                        string temp = Console.ReadLine();
                        double withdraw = Convert.ToDouble(temp);
                        if(withdraw < balance) {
                            balance-=withdraw;
                            Console.WriteLine(withdraw.ToString(moneyformat) + " is withdrawn to your account.");
                            Console.WriteLine("\nYour new current balance is: ");
                            Console.WriteLine(balance.ToString(moneyformat));
                            break;
                        } else {
                            Console.WriteLine("Insufficient funds.");
                        }
                    } catch(FormatException) {
                        Console.WriteLine("Try again.");
                    }
                }
                break;
            }
            case 4: {
                Console.WriteLine("\n*********** THANK YOU FOR USING OUR ATM SERVICE ***********\n");
                break;
            }
        }
    }
}

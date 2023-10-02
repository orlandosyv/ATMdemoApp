using System;
using System.Diagnostics.Tracing;

public class cardHolder {
    string cardNum;
    int PIN;
    string firstName;
    string lastName;
    double balance;
    public cardHolder(string cardNum, int PIN, string firstName, string lastName, double balance ) {
        this.cardNum = cardNum;
        this.PIN = PIN;
        this.firstName = firstName;
        this.lastName = lastName;
        this.balance = balance;
    }
   
    public string getNum () {return cardNum; } 
    public int getPIN () { return PIN;}
    public string getFirstName () { return firstName;}
    public string getLastName () { return lastName;}
    public double getBalance () { return balance;}
    public void setNum(string newCardNum) { cardNum = newCardNum; }
    public void setPIN(int newPIN) {  PIN = newPIN; }
    public void setFirstName(string newFirstName) {  firstName = newFirstName; }
    public void setLastName(string newLastName) {  lastName = newLastName; }
    public void setBalance(double newBalance) {  balance = newBalance; }
    public static void Main(String[] args)
    {
        void printOptions  ()
        {
            Console.WriteLine("Please choose one of the options...");
            Console.WriteLine("1. Deposit");
            Console.WriteLine("2. Withdraw");
            Console.WriteLine("3. Show Balance");
            Console.WriteLine("4. Exit");            
        }

        void deposit (cardHolder currentUser)
        {
            Console.WriteLine("How much do you want to deposit? ");
            double deposit = Double.Parse(Console.ReadLine());
            currentUser.setBalance(currentUser.balance + deposit);
            Console.WriteLine("Thank you, your new balance is: " + currentUser.balance);
            Console.WriteLine("---------------------------");
        }

        void withdraw(cardHolder currentUser)
        {
            Console.WriteLine("How much $$ would you like to withdraw");
            double withdrawal = Double.Parse(Console.ReadLine());
            if (currentUser.balance >= withdrawal) { 
                currentUser.setBalance(currentUser.balance - withdrawal);
                Console.WriteLine("You are good to go... Thank you! •ᴗ•");
                Console.WriteLine("---------------------------");
            }
            else 
            { 
                Console.WriteLine("Insufficient balance...");
                Console.WriteLine("---------------------------");
            }            
        }

        void balance(cardHolder currentUser)
        {
            Console.WriteLine("---------------------------");
            Console.WriteLine("Your Current Balance: " + currentUser.balance);
            Console.WriteLine("---------------------------");
        }

        List<cardHolder> cardHolders = new List<cardHolder>();
        cardHolders.Add(new cardHolder("4655-4571-8841-1123", 1234, "Richy", "Lagos", 99));
        cardHolders.Add(new cardHolder("4655-4571-8841-1124", 4567, "Oreja", "Flores", 254.3));
        cardHolders.Add(new cardHolder("4655-4571-8841-1125", 5678, "Jamie", "Vardy", 185.1));
        cardHolders.Add(new cardHolder("4655-4571-8841-1126",6789 , "Claudio", "Pizarro", 185.1));

        //Prompt User
        Console.WriteLine("Welcome to ATM Demo APP done by OrlandoSYV Corp ");
        Console.WriteLine("Please enter your Card number: ");
        String debitCardNum = "";
        cardHolder currentUser;
        while(true)
        {
            try
            {
                debitCardNum = Console.ReadLine();
                // check in our data set (db in real life) 
                currentUser = cardHolders.FirstOrDefault(ch => ch.cardNum == debitCardNum);
                if(currentUser != null)
                { Console.WriteLine("Card recognized ");
                  break; }
                else { Console.WriteLine("Card NOT recognized ⛔"); }
                
            }
            catch { Console.WriteLine("Card NOT recognized ⛔"); }
        }
        Console.WriteLine("Enter you PIN number: ");
        int userPIN = 0;
        while (true)
        {
            try
            {
                userPIN = int.Parse(Console.ReadLine());
                if (currentUser.getPIN() == userPIN) {
                    Console.WriteLine("Correct PIN ");
                    break; }
                else { Console.WriteLine("Incorrect PIN "); }
            }
            catch { Console.WriteLine("Incorrect PIN "); }
        }

        Console.WriteLine("Welcome " + currentUser.getFirstName() + " :D");
        int option = 0;
        do 
        {
            printOptions();
            try
            {
                option = int.Parse(Console.ReadLine());
            }
            catch { }
            if (option == 1) { deposit(currentUser); }
            else if (option == 2) { withdraw(currentUser); }
            else if (option == 3) { balance(currentUser); }
            else if (option == 4) { break; }
            else { option = 0; }
        }
        while (option != 4);
        Console.WriteLine("Thank you, have a nice day!");
    }
}

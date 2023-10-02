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
            Console.WriteLine("Thank you ⸜(｡˃ ᵕ ˂ )⸝, your new balance is: " + currentUser.balance);
        }

        void withdraw(cardHolder currentUser)
        {
            Console.WriteLine("How much $$ would you like to withdraw");
            double withdraw = Double.Parse(Console.ReadLine());
            if (currentUser.balance >= withdraw) { currentUser.setBalance(currentUser.balance - withdraw); }
            else { Console.WriteLine("Insufficient balance... ꃋᴖꃋ"); }            
        }

    }
    


    
    
   
}

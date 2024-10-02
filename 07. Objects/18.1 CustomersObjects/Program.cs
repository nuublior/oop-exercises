namespace _18._1_CustomersObjects
{
    // This is the Program class containing the Main method
    class Program
    {
        // Main method is the entry point of a C# application
        static void Main()
        {
            // Creating a variable 'aCustomer' of type Customer using the constructor
            Customer aCustomer = new Customer("Alice Smith", 1001, 500.0);
            
            // Depositing money into the customer account
            aCustomer.Deposit(200.0); // Depositing 200

            // Withdrawing money (an amount less than what was deposited)
            aCustomer.Withdraw(100.0); // Withdrawing 100

            // Printing the balance using GetBalance and Console.WriteLine
            Console.WriteLine($"The current balance is: {aCustomer.GetBalance()}");
        }
    }

    // This is the Customer class with attributes, constructors, and methods
    class Customer
    {
        public string name;
        public int id;
        public double balance;

        // First constructor: takes name and id, sets balance to 0
        public Customer(string name, int id)
        {
            this.name = name;
            this.id = id;
            this.balance = 0;
        }

        // Second constructor: takes name, id, and balance
        public Customer(string name, int id, double balance)
        {
            this.name = name;
            this.id = id;
            this.balance = balance;
        }

        // Method to deposit money
        public void Deposit(double amount)
        {
            balance += amount; // Adds the amount to the current balance
        }

        // Method to withdraw money
        public void Withdraw(double amount)
        {
            if (balance >= amount)
            {
                balance -= amount; // Subtracts the amount from the balance
            }
            else
            {
                Console.WriteLine("Insufficient balance to withdraw.");
            }
        }

        // Method to get the current balance
        public double GetBalance()
        {
            return balance; // Returns the balance
        }
    }
}

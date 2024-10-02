namespace _18._2_CustomerDatabaseObjects
{
    // This is the Program class containing the Main method
    class Program
    {
        static void Main()
        {
            // Creating a variable 'aCustomer' of type Customer using the constructor
            Customer aCustomer = new Customer(name: "Alice Smith", id: 1001, balance: 500.0);

            // Depositing money into the customer account
            aCustomer.Deposit(amount: 200.0); // Depositing 200

            // Withdrawing money (an amount less than what was deposited)
            aCustomer.Withdraw(amount: 100.0); // Withdrawing 100

            // Printing the balance using GetBalance and Console.WriteLine
            Console.WriteLine($"The current balance is: {aCustomer.GetBalance()}");

            // Interacting with CustomerDatabase class
            CustomerDatabase customerDb = new CustomerDatabase();
            customerDb.AddCustomer(aCustomer); // Adding customer to the database

            // Adding more customers
            Customer customer2 = new Customer(name: "Bob Jones", id: 1002, balance: 400.0);
            customerDb.AddCustomer(customer2);
            
            Customer customer3 = new Customer(name: "Charlie Brown", id: 1003, balance: 200.0);
            customerDb.AddCustomer(customer3);

            // Print all customers before removal
            Console.WriteLine("Before removing a customer:");
            customerDb.PrintCustomerNames();

            // Removing the customer by their ID
            customerDb.RemoveCustomerById(1002); // Remove the customer with ID 1002

            // Print all customers after removal
            Console.WriteLine("After removing Bob:");
            customerDb.PrintCustomerNames();
        }
    }

    // New CustomerDatabase class
    class CustomerDatabase
    {
        // Attribute to store an array of customers
        private Customer?[] Customers { get; set; }

        // Constructor that initializes the customers array with 10 empty spots
        public CustomerDatabase()
        {
            Customers = new Customer?[10]; // Creates an array with 10 spots for Customer objects
        }

        // Method to add a customer to the customers array
        public void AddCustomer(Customer newCustomer)
        {
            // We will add logic to place the customer into the array
            for (int i = 0; i < Customers.Length; i++)
            {
                if (Customers[i] == null) // Find an empty spot
                {
                    Customers[i] = newCustomer; // Add the customer in the empty spot
                    break; // Exit once the customer is added
                }
            }
        }

        // Method to remove a customer by their ID
        public void RemoveCustomerById(int customerId)
        {
            // Loop through the customers array
            for (int i = 0; i < Customers.Length; i++)
            {
                if (Customers[i] != null && Customers[i]?.Id == customerId)
                {
                    Customers[i] = null; // Remove the customer by setting that spot to null
                    break; // Exit once the customer is removed
                }

            }
        }

        // Method to return all customers in the array
        public Customer?[] GetAllCustomers()
        {
            return Customers;
        }

        // Method to print the names of all customers in the array
        public void PrintCustomerNames()
        {
            foreach (var customer in Customers)
            {
                if (customer != null)
                {
                    Console.WriteLine($"Customer Name: {customer.Name}, ID: {customer.Id}, Balance: {customer.Balance}");
                }
            }
        }
    }

    // This is the Customer class with attributes, constructors, and methods
    class Customer
    {
        // Properties for encapsulation
        public string Name { get; private set; }
        public int Id { get; private set; }
        public double Balance { get; private set; }

        // First constructor: takes name and id, sets balance to 0
        public Customer(string name, int id)
        {
            Name = name;
            Id = id;
            Balance = 0;
        }

        // Second constructor: takes name, id, and balance
        public Customer(string name, int id, double balance)
        {
            Name = name;
            Id = id;
            Balance = balance;
        }

        // Method to deposit money
        public void Deposit(double amount)
        {
            Balance += amount; // Adds the amount to the current balance
        }

        // Method to withdraw money
        public void Withdraw(double amount)
        {
            if (Balance >= amount) // Check if the balance is enough
            {
                Balance -= amount; // Subtracts the amount from the balance
            }
            else
            {
                Console.WriteLine("Insufficient balance to withdraw.");
            }
        }

        // Method to return the balance
        public double GetBalance()
        {
            return Balance;
        }
    }
}

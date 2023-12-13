using System;
using System.Collections.Generic;

class Bank
{
    private List<Customer> customers = new List<Customer>();

    public void AddCustomer(Customer customer)
    {
        customers.Add(customer);
    }

    public void DisplayCustomerAccountDetails(string customerId)
    {
        Customer customer = customers.Find(c => c.CustomerId == customerId);

        if (customer != null)
        {
            Console.WriteLine($"Customer ID: {customer.CustomerId}");
            Console.WriteLine("Account Details:");

            foreach (Account account in customer.Accounts)
            {
                Console.WriteLine($"Account ID: {account.AccountId}, Balance: {account.Balance}");
            }

            Console.WriteLine($"Total Balance: {customer.GetTotalBalance()}");
        }
        else
        {
            Console.WriteLine("Customer not found.");
        }
    }
}

class Customer
{
    public string CustomerId { get; }
    public List<Account> Accounts { get; } = new List<Account>();

    public Customer(string customerId)
    {
        CustomerId = customerId;
    }

    public void AddAccount(Account account)
    {
        Accounts.Add(account);
    }

    public decimal GetTotalBalance()
    {
        decimal totalBalance = 0;

        foreach (Account account in Accounts)
        {
            totalBalance += account.Balance;
        }

        return totalBalance;
    }
}

class Account
{
    public string AccountId { get; }
    public decimal Balance { get; private set; }

    public Account(string accountId, decimal initialBalance)
    {
        AccountId = accountId;
        Balance = initialBalance;
    }

    public void Deposit(decimal amount)
    {
        Balance += amount;
    }

    public bool Withdraw(decimal amount)
    {
        if (Balance >= amount)
        {
            Balance -= amount;
            return true;
        }
        else
        {
            Console.WriteLine("Insufficient funds.");
            return false;
        }
    }
}

class Program
{
    static void Main()
    {
        Bank bank = new Bank();

        
        Customer customer1 = new Customer("prachi1");
        Account account1 = new Account("p1", 1000);
        Account account2 = new Account("p2", 500);

        customer1.AddAccount(account1);
        customer1.AddAccount(account2);

        Customer customer2 = new Customer("prachi2");
        Account account3 = new Account("p3", 1500);

        customer2.AddAccount(account3);

        
        bank.AddCustomer(customer1);
        bank.AddCustomer(customer2);

        
        bank.DisplayCustomerAccountDetails("prachi1");
        bank.DisplayCustomerAccountDetails("prachi2");

       
        account1.Deposit(200);
        account2.Withdraw(300);
        account3.Withdraw(200);

       
        bank.DisplayCustomerAccountDetails("prachi1");
        bank.DisplayCustomerAccountDetails("prachi2");
    }
}


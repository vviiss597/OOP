namespace BankApp.Classes;

public class BankAccount
{
    private string fullName;

     public string FullName
     {
         get { return fullName; }

        set 
         { 
        if (string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentException("Full name can not be empty", nameof(value)); 
             }

        fullName = value;

         }
    } 
}

private decimal balance;

public decimal Balance
{
     get => balance; 

     set
     {
         if (value < 0)
        {
             throw new ArgumentOutOfRangeException(nameof(value), "Balance can not be negative");
        }
         balance = value;
     }
}

public string AccountNumber { get; set; } //auto property
public bool HasPositiveBalance => balance > 0; //read-only property
//get {return fullName;} same as get => fullName;

public BankAccount(string fn, decimal b)
{
     FullName = fn;
     Balance = b;
}

//constructor overloading + consructor chaining
public BankAccount(): this ("Unknown", 0)
{
    //FullName = " Unknown";
    //Balance = 0;
    AccountNumber = "0000";
}

public void Deposit(decimal amount)
{
    //balance = balance + amount;
    if (amount >= 0)
         balance += amount;
     else
        throw new ArgumentOutOfRangeException("Amount can not be negative", nameof(amount));
     
}

public void withdraw(decimal amount)
{
    if (amount >=0)
     {
         if (amount <= balance)
             balance -= amount;
         else
             throw new ArgumentOutOfRangeException("Amount can not be less than current balance", nameof(amount));
    }
     else
     {
         throw new ArgumentOutOfRangeException("Amount should be positive value.", nameof(amount));
     }

}namespace BankApp.Classes;

public class BankAccount
{
     private string fullName;

     public string FullName
     {
         get { return fullName; }

        set 
        { 
             if (string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentException("Full name can not be empty", nameof(value)); 
            }

             fullName = value;

         }
    }  
}

private decimal balance;

public decimal Balance
{
     get => balance; 

     set
     {
         if (value < 0)
         {
            throw new ArgumentOutOfRangeException(nameof(value), "Balance can not be negative");
        }
         balance = value;
     }
}

public string AccountNumber { get; set; } //auto property
public bool HasPositiveBalance => balance > 0; //read-only property
//get {return fullName;} same as get => fullName;

public BankAccount(string fn, decimal b)
{
    FullName = fn;
     Balance = b;
}

//constructor overloading + consructor chaining
public BankAccount(): this ("Unknown", 0)
{
    //FullName = " Unknown";
    //Balance = 0;
    AccountNumber = "0000";
}

public void Deposit(decimal amount)
{
    //balance = balance + amount;
    if (amount >= 0)
         balance += amount;
    else
         throw new ArgumentOutOfRangeException("Amount can not be negative", nameof(amount));

}

public void withdraw(decimal amount)
{
    if (amount >=0)
     {
        if (amount <= balance)
             balance -= amount;
         else
            throw new ArgumentOutOfRangeException("Amount can not be less than current balance", nameof(amount));
     }
     else
     {
         throw new ArgumentOutOfRangeException("Amount should be positive value.", nameof(amount));
     }

}
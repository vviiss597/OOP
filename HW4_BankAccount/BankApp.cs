using BankApp.Classes;

var account = new BankAccount("My Account", 100);
//var account = new BankAccount();



try
{
    account.Deposit(100);
    //account.Withdraw(-50);
     account.Withdraw(100); //throws exception
    //account.FullName ="My Account";
    //account.Balance = 100;
    //account.AccountNumber = "123456";
    //we can read but cannot assign : account.HasPositiveBalance = true;
}
catch (ArgumentException a)
{
     Console.WriteLine($"Validation error:{a.Message}");
}

account.FullName = ""; //set

Console.WriteLine(account.FullName); //get
Console.WriteLine(account.Balance); //get
Console.WriteLine(account.AccountNumber); 
Console.WriteLine(account.HasPositiveBalance); 

account.FullName = account.FullName + "123"; 
//first we read, then we assign
Console.WriteLine(account.FullName);
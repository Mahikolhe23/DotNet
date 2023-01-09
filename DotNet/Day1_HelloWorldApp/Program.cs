// See https://aka.ms/new-console-template for more information
using Banking;
using Maths;

Console.WriteLine("Hello, World!");
Account a = new Account();

// 1 - get default balance
float m = a.getBalance();
Console.WriteLine("1 Initial Balance " + m);

// 2 - set balance and print to console
a.setBalance(15000);
Console.WriteLine("2 After Setting balance " + a.getBalance());

// 3 - deposit 50000 into account
a.Deposit(50000);
Console.WriteLine("3 After deposit 50K " + a.getBalance());

// 4- withdraw 12000 from account
a.Withdraw(12000);
Console.WriteLine("4 After withdraw 12K " + a.getBalance());

// 5 - adding two complex object
Complex c1 = new Complex(10, 12);
Complex c2 = new Complex(22, 20);
Complex c3 = c1 + c2;
Console.WriteLine(c3.Real + " " + c3.Imag);


using Govern;
using Bank;
using Mgr;

// Goven obj
Government g1 = new Government();

// delegate obj
Tax it1 = new Tax(g1.it);
Tax pt1 = new Tax(g1.pt);
Tax st1 = new Tax(g1.st);

// Customer OBJ
Account a1 = new Account(1000);

//attach delegate to obj of event
a1.overbal += it1;
a1.overbal += pt1;
a1.overbal += st1;

// bank mgr obj for calling delegate
Bankmgr bm1 = new Bankmgr();

// bal delegate
Bal b1 = new Bal(bm1.blockacc);
Bal b2 = new Bal(bm1.email);
Bal b3 = new Bal(bm1.sms);

//attached delegate to event
a1.underBal += b1;
a1.underBal += b2;
a1.underBal += b3;

//deposit method
a1.deposit(450000);
Console.WriteLine("before");
Console.WriteLine(a1);
a1.Process();
Console.WriteLine("After");
Console.WriteLine(a1);

//withdraw method
Console.WriteLine("before");
a1.withdraw(450000);
Console.WriteLine("After");
a1.withdraw(2000);


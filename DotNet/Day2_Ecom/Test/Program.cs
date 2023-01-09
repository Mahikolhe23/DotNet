using HR;

Console.WriteLine("-----Welcome-----");
Employee emp = new SalesEmp();
emp.DoWork();
Console.WriteLine(emp);
Console.WriteLine("Salary = " + emp.ComputeSalary());

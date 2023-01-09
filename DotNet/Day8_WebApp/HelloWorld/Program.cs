using HR;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

//new obj of emp class
var emp = new Employee()
{
    Id = 5,
    FirstName = "Mahendra1",
    LastName = "K",
    Email = "mkom"
};

//list of emp
var employees = new List<Employee>();
employees.Add(
    new Employee()
    {
        Id = 2,
        FirstName = "Mahi",
        LastName = "Kolhe",
        Email = "mkolhe23@gmail.com"
    }
);
employees.Add(
    new Employee()
    {
        Id = 10,
        FirstName = "Mahendra",
        LastName = "Kolhe",
        Email = "mkolhe23@gmail.com"
    }
);
employees.Add(
    new Employee()
    {
        Id = 12,
        FirstName = "Mahendra454e54",
        LastName = "Kogfdglhe",
        Email = "mkssrgrgolhe23@gmail.com"
    }
);

app.MapGet("/", () => "Hello World!");
app.MapGet("/emp", () => emp);
app.MapGet("/emplist", () => employees);
app.Run();

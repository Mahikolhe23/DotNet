using BOL;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Text.Json.Serialization;

List<Project> list = new List<Project>();

//sample data
Project p1 = new Project(1, "PMS - 1", "Complete PMS Solution - 1", "Mahendra - 1");
Project p2 = new Project(2, "PMS - 2", "Complete PMS Solution - 2", "Mahendra - 2");
Project p3 = new Project(3, "PMS - 3", "Complete PMS Solution - 3", "Mahendra - 3");

list.Add(p1);
list.Add(p2);
list.Add(p3);

// Switch case
bool exit = false;
do
{
    Console.WriteLine("Enter the choice");
    Console.WriteLine(
        "1.Add Project 2. Udpate Name 3. Delete by ID 4.Find by Id 5.Display All 6.Exit"
    );
    switch (int.Parse(Console.ReadLine()))
    {
        case 1:
            Console.WriteLine("Enter Details of Project : ");
            Console.WriteLine("ID , Name, Description , Manager");
            int id = int.Parse(Console.ReadLine());
            string name = Console.ReadLine();
            string desc = Console.ReadLine();
            string mgr = Console.ReadLine();
            Project p4 = new Project(id, name, desc, mgr);
            list.Add(p4);
            //serealize data into file
            var options = new JsonSerializerOptions { IncludeFields = true };
            var projectJson = JsonSerializer.Serialize<List<Project>>(list, options);
            string filename = @"H:\Mahendra_Sujay\Phase-2\VS-code\DotNet\Day5_Assignment\Day5.json";
            File.WriteAllText(filename, projectJson);
            break;
        case 2:
            Console.WriteLine("Enter the ID");
            id = int.Parse(Console.ReadLine());
            foreach (Project i in list)
            {
                if (i.Id == id)
                {
                    Console.WriteLine("Enter Name");
                    i.Name = Console.ReadLine();
                }
            }
            //serealize data into file
            options = new JsonSerializerOptions { IncludeFields = true };
            projectJson = JsonSerializer.Serialize<List<Project>>(list, options);
            filename = @"H:\Mahendra_Sujay\Phase-2\VS-code\DotNet\Day5_Assignment\Day5.json";
            File.WriteAllText(filename, projectJson);

            //de-serealize data from file
            string JsonString = File.ReadAllText(filename);
            List<Project> jsonP = JsonSerializer.Deserialize<List<Project>>(JsonString);
            Console.WriteLine("Data from json file");
            break;
        case 3:
            Console.WriteLine("Enter the ID");
            id = int.Parse(Console.ReadLine());
            for (int i = 0; i < list.Count(); i++)
            {
                if (list[i].Id == id)
                {
                    list.RemoveAt(i);
                }
            }
            //serealize data into file
            options = new JsonSerializerOptions { IncludeFields = true };
            projectJson = JsonSerializer.Serialize<List<Project>>(list, options);
            filename = @"H:\Mahendra_Sujay\Phase-2\VS-code\DotNet\Day5_Assignment\Day5.json";
            File.WriteAllText(filename, projectJson);

            //de-serealize data from file
            JsonString = File.ReadAllText(filename);
            jsonP = JsonSerializer.Deserialize<List<Project>>(JsonString);
            Console.WriteLine("Data from json file");
            break;
        case 4:
            Console.WriteLine("Enter the ID");
            id = int.Parse(Console.ReadLine());
            foreach (Project i in list)
            {
                if (i.Id == id)
                {
                    Console.WriteLine(i);
                }
            }
            //serealize data into file
            options = new JsonSerializerOptions { IncludeFields = true };
            projectJson = JsonSerializer.Serialize<List<Project>>(list, options);
            filename = @"H:\Mahendra_Sujay\Phase-2\VS-code\DotNet\Day5_Assignment\Day5.json";
            File.WriteAllText(filename, projectJson);

            //de-serealize data from file
            JsonString = File.ReadAllText(filename);
            jsonP = JsonSerializer.Deserialize<List<Project>>(JsonString);
            Console.WriteLine("Data from json file");
            break;
        case 5:
            Console.WriteLine("All Projects");
            foreach (Project item in list)
            {
                Console.WriteLine(item);
            }
            //serealize data into file
            options = new JsonSerializerOptions { IncludeFields = true };
            projectJson = JsonSerializer.Serialize<List<Project>>(list, options);
            filename = @"H:\Mahendra_Sujay\Phase-2\VS-code\DotNet\Day5_Assignment\Day5.json";
            File.WriteAllText(filename, projectJson);

            //de-serealize data from file
            JsonString = File.ReadAllText(filename);
            jsonP = JsonSerializer.Deserialize<List<Project>>(JsonString);
            Console.WriteLine("Data from json file");
            break;
        case 6:
            exit = true;
            break;
    }
} while (!exit);

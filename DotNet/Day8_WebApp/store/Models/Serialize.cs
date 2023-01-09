using System.IO;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using USERNAME;

namespace SERIAL;

public class Serialize
{
    //File path
    string filepath =
        @"H:\Mahendra_Sujay\Phase-2\VS-code\DotNet\Day8_WebApp\store\wwwroot\database\login.json";

    //De-Serialize data from file
    List<User> dataList = new List<User>();

    public List<User> restore()
    {
        string loginDetailsString = File.ReadAllText(filepath);
        List<User> loginDetails = JsonSerializer.Deserialize<List<User>>(loginDetailsString);
        return loginDetails;
    }

    // sample admin data
    public void adminLog()
    {
        User u1 = new User("Mahendra", "Kolhe", 7350, "mkolhe23@gmail.com", "Mahikolhe");
        dataList.Add(u1);

        var options = new JsonSerializerOptions { IncludeFields = true };
        var userlistJSON = JsonSerializer.Serialize<List<User>>(dataList, options);
        File.WriteAllText(filepath, userlistJSON);
    }

    //method to register user
    public bool register(
        string firstname,
        string lastname,
        int contactnumber,
        string email,
        string password
    )
    {
        List<User> userList = restore();
        foreach (User user in userList)
        {
            if (user.Email == email)
            {
                return false;
            }
        }
        //serialize of data
        User u1 = new User(firstname, lastname, contactnumber, email, password);
        userList.Add(u1);

        var options = new JsonSerializerOptions { IncludeFields = true };
        var userlistJSON = JsonSerializer.Serialize<List<User>>(userList, options);
        File.WriteAllText(filepath, userlistJSON);
        return true;
    }

    //method for login data
    public bool login(string email, string password)
    {
        List<User> userList = restore();
        foreach (User user in userList)
        {
            if (user.Email == email && user.Password == password)
            {
                return true;
            }
        }
        return false;
    }
}

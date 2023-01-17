namespace DAL;
using MySql.Data.MySqlClient;
using BOL;
using System.Text.Json;
public class UserDAL
{
    static string filep=@"F:\Mahi\DotNet\DotNet\EndModule\endmodule\wwwroot\db\user.json";

    public static bool sereialize(List<User> list){
        var options=new JsonSerializerOptions{IncludeFields=true};
        var userlist=JsonSerializer.Serialize(list,options);
        File.WriteAllText(filep, userlist);
        return true;
    }
    public static List<User> deserialize(){
        string users= File.ReadAllText(filep);
        List<User> list= JsonSerializer.Deserialize<List<User>>(users);
        return list;
    }
    public static bool Login(string email,string password){
        List<User> list= deserialize();
        foreach(User user in list){
            if(user.Email.Equals(email)&&user.Password.Equals(password)){
                return true;
            }
        }
        return false;
    }
    public static bool Register(string name,string email,string password){
        List<User> list= new List<User>();
        list.Add(new User(name,email,password));
        sereialize(list);
        return true;
    }
}
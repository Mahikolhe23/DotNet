namespace DAL;
using MySql.Data.MySqlClient;
using BOL;

public class StudentDAL
{
    static string path = @"server=localhost;user=root;password=root123;port=3306;database=dotnet;";
    public static List<Student> Display()
    {
        List<Student> list = new List<Student>();
        MySqlConnection con= new MySqlConnection();
        con.ConnectionString=path;
        try{
            con.Open();
            string querry=@"select* from student";
            MySqlCommand cmd  = new MySqlCommand(querry,con);
            MySqlDataReader reader= cmd.ExecuteReader();
            while(reader.Read()){
            int rollno=int.Parse(reader["rollno"].ToString());
            string name=reader["name"].ToString();
            string email=reader["email"].ToString();
            string city=reader["city"].ToString();
            Student s= new Student(rollno,name,email,city);
            list.Add(s);
        }
        }catch(Exception e){
            Console.WriteLine(e.Message);
        }finally{
            con.Close();
        }     
        return list;
    }

    public static Student GetStudentByRollNo(int rollno){
        List<Student> list= Display();
        foreach(Student s in list){
            if(s.Rollno==rollno)
            return s;
        }
        return null;
    }
    public static void Delete(int rollno){
        MySqlConnection con = new MySqlConnection();
        con.ConnectionString=path;
        try{
            con.Open();
            string querry=@"delete from student where rollno="+rollno;
            MySqlCommand cmd= new MySqlCommand(querry,con);
            cmd.ExecuteNonQuery();
        }catch(Exception e){
            Console.WriteLine(e.Message);
        }finally{
            con.Close();
        }
    }

    public static bool Insert(int roll, string name, string email, string city)
    {
        MySqlConnection con = new MySqlConnection();
        con.ConnectionString = path;
        bool status = false;
        try
        {
            con.Open();
            string querry =
                "insert into student(rollno,name,email,city) values('"
                + roll
                + "','"
                + name
                + "','"
                + email
                + "','"
                + city
                + "')";
            MySqlCommand cmd = new MySqlCommand(querry, con);
            cmd.ExecuteNonQuery();
            status = true;
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
        finally
        {
            con.Close();
        }
        return status;
    }
    public static void Update(int roll, string name, string email, string city)
    {
        MySqlConnection con = new MySqlConnection();
        con.ConnectionString = path;
        try
        {
            con.Open();
            string querry ="update student set name='"+name+"',email='"+email+"',city='"+city+"' where rollno="+roll;
            MySqlCommand cmd = new MySqlCommand(querry, con);
            cmd.ExecuteNonQuery();
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
        finally
        {
            con.Close();
        }
    }
}

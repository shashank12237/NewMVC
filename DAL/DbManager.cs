using BOL;
using MySql.Data.MySqlClient;
using System.Data;
namespace DAL;

public class DbManager
{
    public static string para=@"server=localhost;port=3306;user=root;password=kainchidham;database=newmvc";
    public static List<Student> GetAllStudents(){
        List<Student> list=new List<Student>();
        MySqlConnection con=new MySqlConnection();
        con.ConnectionString=para;
        try{
            string query="select * from students";
            DataSet dataset=new DataSet();
            MySqlCommand cmd=new MySqlCommand();
            cmd.Connection=con;
            cmd.CommandText=query;
            MySqlDataAdapter data=new MySqlDataAdapter();
            data.SelectCommand=cmd;
            data.Fill(dataset);
            DataTable table=dataset.Tables[0];

            DataRowCollection row=table.Rows;
            foreach(DataRow i in row)
            {
                int id=int.Parse(i["id"].ToString());
                string name=(i["name"].ToString());
                int marks=int.Parse(i["marks"].ToString());
            
            Student std=new Student
            {
                Id=id,
                Name=name,
                Marks=marks

            };
            list.Add(std);
            }

        }catch(Exception ex){
            Console.WriteLine(ex);
        }
        finally{
            con.Close();
        }
        return list;
    }
}

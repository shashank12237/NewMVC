using BOL;
using DAL;
namespace BLL;
public class StudentManager
{
    //we have to store data frm db into a list
    public List<Student> GetStudentsData(){
        List<Student> stdlist=new List<Student>();
        stdlist=DbManager.GetAllStudents();
        return stdlist;
    }
}

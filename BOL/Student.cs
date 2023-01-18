namespace BOL;
public class Student
{
    public int Id {get;set;}
    public string? Name {get;set;}
    public int Marks {get;set;}

 public Student(){
        this.Id=1;
        this.Name="sid";
        this.Marks=40;
    }

    public Student(int id, string name, int marks){
        this.Id=id;
        this.Name=name;
        this.Marks=marks;
    }
}

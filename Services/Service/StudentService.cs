namespace Services.Service;
using Domain.Models;
public class StudentService
{
   private List<Student> students = new List<Student>();
    public List<Student> GetStudents()
    {
        return students;
    }
    public void Add(Student student)
    {

        students.Add(student);
    }
    public void Update(Student student, int id)
    { 
        foreach (var item in students)
                {
               if (item.Id == id)
              {
                  item.FirstName = student.FirstName;
                  item.LastName = student.LastName;
                  item.FatherName = student.FatherName;
                  item.Address = student.Address;
                  item.BirthDate = student.BirthDate;
                  item.Phone = student.Phone;
              }     
                }

        {
        /*foreach (Student student2 in students)
        {
            int cnt = 0;
            cnt++;
            if (student2.Id == id)
            {
                students.Remove(student2);
                students.Insert(cnt, student);
            }*/
        }
            //  foreach (Student student2 in students)
            //  {

            //      if (student2.Id == id)
            //      {
            //          students.Remove(student2);
            //          students.Add(student);
            //      }
            //  }


            {
               
              
            }
    }
    public Student GetStudentById(int id)
    {
        Student student = new Student();
       
            foreach(Student item in students)
            {
                if(item.Id == id)
                {
                    student = item;
                }
            }
           return student;
    }


    public void Delete(int id)
    {
        foreach(Student item in students)
        {
           if(item.Id == id)
            {
               students.Remove(item);
            }
        }
    } 

}
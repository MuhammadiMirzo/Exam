namespace Services.Service;
using Domain.Models;
public class TeacherService
{
   private List<Teacher> teachers = new List<Teacher>();
    public List<Teacher> GetTeachers()
    {
        return teachers;
    }
    public void Add(Teacher teacher)
    {

        teachers.Add(teacher);
    }
    public void Update(Teacher teacher, int id)
    { 
        foreach (var item in teachers)
                {
               if (item.Id == id)
              {
                  item.Name = teacher.Name;
                  item.Surname = teacher.Surname;
                  item.Experience = teacher.Experience;
                  item.Position = teacher.Position;
                  item.Id = teacher.Id;
              }     
                }

        {
        /*foreach (Teacher teacher2 in teacher)
        {
            int cnt = 0;
            cnt++;
            if (teacher2.Id == id)
            {
                teachers.Remove(teacher2);
                teachers.Insert(cnt, teacher);
            }*/
        }
        { 
            //  foreach (Teacher teacher2 in teachers)
            //  {

            //      if (teacher2.Id == id)
            //      {
            //          teachers.Remove(teacher2);
            //          teachers.Add(teacher);
            //      }
            //  }
        }

            
               
              
           
    }
    public Teacher GetTeacherById(int id)
    {
        Teacher teacher = new Teacher();
       
            foreach(Teacher item in teachers)
            {
                if(item.Id == id)
                {
                    teacher = item;
                }
            }
           return teacher;
    }


    public void Delete(int id)
    {
        foreach(Teacher item in teachers)
        {
           if(item.Id == id)
            {
               teachers.Remove(item);
            }
        }
    } 

}
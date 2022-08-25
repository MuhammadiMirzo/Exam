namespace Services.Service;
using Domain.Models;
public class CourseService
{
   private List<Course> courses = new List<Course>();
    public List<Course> GetCourses()
    {
        return courses;
    }
    public void Add(Course course)
    {

        courses.Add(course);
    }
    public void Update(Course course, int id)
    { 
        foreach (var item in courses)
                {
               if (item.Id == id)
              {
                  item.Description = course.Description;
                  item.Fee = course.Fee;
                  item.HasDiscount = course.HasDiscount;
                  item.Id = course.Id;
                  item.Title = course.Title;
              }     
                }

        {
        /*foreach (Course course2 in course)
        {
            int cnt = 0;
            cnt++;
            if (course2.Id == id)
            {
                courses.Remove(course2);
                courses.Insert(cnt, course);
            }*/
        }
        { 
            //  foreach (Course course2 in courses)
            //  {

            //      if (course2.Id == id)
            //      {
            //          courses.Remove(course2);
            //          courses.Add(course);
            //      }
            //  }
        }

            
               
              
           
    }
    public Course GetCourseById(int id)
    {
        Course course = new Course();
       
            foreach(Course item in courses)
            {
                if(item.Id == id)
                {
                    course = item;
                }
            }
           return course;
    }


    public void Delete(int id)
    {
        foreach(Course item in courses)
        {
           if(item.Id == id)
            {
               courses.Remove(item);
            }
        }
    } 

}
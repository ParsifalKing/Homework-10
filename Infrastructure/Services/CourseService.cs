
using Domain.Models;
namespace Infrastructure.Services;

public class CourseService
{
        List<Course> courses = new List<Course>();

     public List<Course> GetCourse()
     {
        return courses;
     } 
     public void AddCourse(Course teacher)
     {
       courses.Add(teacher);
     }
     public void UpdateCourse(Course course)
     {
        foreach (var cour in courses)
        {
            if( cour.Id == course.Id )
            {
            cour.Id = course.Id;
            cour.Title = course.Title;
            cour.Description = course.Description;
            cour.Fee = course.Fee;
            cour.HasDiscount = course.HasDiscount;
            }
        }
     }
     public void DeleteCourse(int Id)
     {
        foreach (var cour in courses)
        {
            if (cour.Id == Id)
            {
                courses.Remove(cour);
            }
        }
     }
}

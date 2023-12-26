using Domain.Models;

namespace Infrastructure.Services;

public class TeacherService
{
    List<Teacher> teachers = new List<Teacher>();

     public List<Teacher> GetTeacher()
     {
        return teachers;
     } 
     public void AddTeacher(Teacher teacher)
     {
       teachers.Add(teacher);
     }
     public void UpdateTeacher(Teacher teacher)
     {
        foreach (var tea in teachers)
        {
            if( tea.Id == teacher.Id )
            {
            tea.Id = teacher.Id;
            tea.FirstName = teacher.FirstName;
            tea.LastName = teacher.LastName;
            tea.Position = teacher.Position;
            tea.ExperienceAmount = teacher.ExperienceAmount;
            }
        }
     }
     public void DeleteTeacher(int Id)
     {
        foreach (var tea in teachers)
        {
            if (tea.Id == Id)
            {
                teachers.Remove(tea);
            }
        }
     }
}

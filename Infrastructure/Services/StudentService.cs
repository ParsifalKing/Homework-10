using Domain.Models;

namespace Infrastructure.Services;

public class StudentService
{
    List<Student> students = new List<Student>();

     public List<Student> GetStudents()
     {
        return students;
     } 
     public void AddStudent(Student student)
     {
       students.Add(student);
     }
     public void UpdateStudent(Student student)
     {
        foreach (var std in students)
        {
            if( std.Id == student.Id )
            {
            std.Id = student.Id;
            std.FirstName = student.FirstName;
            std.LastName = student.LastName;
            std.BirthDate = student.BirthDate;
            std.Address = student.Address;
            }
        }
     }
     public void DeleteStudent(int Id)
     {
        foreach (var std in students)
        {
            if (std.Id == Id)
            {
                students.Remove(std);
            }
        }
     }

}



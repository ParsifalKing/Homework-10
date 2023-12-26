using Infrastructure.Services;
using Domain.Models;
using System.Data.Common;

System.Console.Write($"Student, Teachers, Courses or Posts \n");
System.Console.Write("Enter what you want to see : ");
string softclub = Console.ReadLine();

if( softclub == "students" || softclub == "Students")
{
    var student = new Student();
    var StudentSer = new StudentService();
    
    while(true)
    {
    System.Console.WriteLine($"     Commands : list, add, change, delete, exit");
    System.Console.Write("Write some command : ");
    string command = Console.ReadLine();

    if ( command == "list")
    {
        foreach (var item in StudentSer.GetStudents())
        {
         System.Console.WriteLine(item.Id);
         System.Console.WriteLine(item.FirstName);
         System.Console.WriteLine(item.LastName); 
         System.Console.WriteLine(item.BirthDate);
         System.Console.WriteLine(item.Address);          
        }

    }

    if ( command == "add")
    {
        
    System.Console.Write("Enter Id : ");
    student.Id = Convert.ToInt32(Console.ReadLine());
    System.Console.Write("Enter Name : ");
    student.FirstName = Console.ReadLine();
    System.Console.Write("Enter Surname : ");
    student.LastName = Console.ReadLine();
    System.Console.Write("Enter BirthDay : ");
    student.BirthDate = new DateTime(Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine())); 
    System.Console.Write("Enter Address : ");
    student.Address = Console.ReadLine(); 
    StudentSer.AddStudent(student);
    }

    else if ( command == "change")
    {
      System.Console.Write("Enter Id : ");
      int Id = Convert.ToInt32(Console.ReadLine());

      foreach (var std in StudentSer.GetStudents())
      {
          if (std.Id == Id)
        {
    System.Console.Write("Enter Name : ");
    student.FirstName = Console.ReadLine();
    System.Console.Write("Enter Surname : ");
    student.LastName = Console.ReadLine();
    System.Console.Write("Enter BirthDay : ");
    student.BirthDate = new DateTime(Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine())); 
    System.Console.Write("Enter Address : ");
    student.Address = Console.ReadLine(); 
    StudentSer.AddStudent(student);        
        }
      }
    }

    else if ( command == "delete")
    {
      System.Console.Write("Enter Id : ");
      int Id = Convert.ToInt32(Console.ReadLine());

      foreach (var std in StudentSer.GetStudents())
      {
          if (std.Id == Id)
        {
            StudentSer.DeleteStudent(Id);     
        }
      }
    }
    else if (command == "exit" || command == "Exit")
    {
       break; 
    }

    }

}



using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;


namespace BuffTeks_Models
{
    class CR_Students  // This class will create and read for students
    {
        static void Main(string[] args)
        {
            using(var db = new AppDbContext())
            {
                try
                {
                    db.Database.EnsureCreated(); // reads

                    if(!db.Students.Any())
                    {
                        List<Student> students = new List<Student>() // creates new records
                        {
                            new Student()
                            {
                                StudentFName = "",
                                StudentLName = "",
                                StudentPhone = "",
                                StudentEmail = "",
                                StudentRole = ""
                            },                   
                        };
                        db.Students.AddRange(students);
                        db.SaveChanges();                                              
                    }
                    else
                    {
                        var students = db.Students.ToList(); // error/exception handling
                        foreach(Student s in students)
                        {
                            Console.WriteLine(s);
                        }
                    }
                    if(!db.Advisors.Any())
                    {
                        Console.WriteLine("Houston, we have a problem.");
                    }
                }
                catch(Exception exp)
                {
                    Console.WriteLine(exp.Message); // if there is a problem, display it
                }
            }
        }
    }
}

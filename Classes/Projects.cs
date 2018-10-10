using System;
using System.Collections.Generic;
using System.Linq;

namespace BuffTeks_Models
{
    class CR_Projects  // This class will create and read for students
    {
        static void Main(string[] args)
        {
            using(var db = new AppDbContext())
            {
                try
                {
                    db.Database.EnsureCreated(); // reads

                    if(!db.Projects.Any())
                    {
                        List<Project> projects = new List<Project>() // creates new records
                        {
                            new Project()
                            {
                                ProjectName = "",
                                ProjectLeader = "",
                                ProjectDesc = "",
                            },                   
                        };
                        db.Projects.AddRange(projects);
                        db.SaveChanges();                                              
                    }
                    else
                    {
                        var Projects = db.Projects.ToList(); // error/exception handling
                        foreach(Project s in Projects)
                        {
                            Console.WriteLine(s);
                        }
                    }
                    if(!db.Projects.Any())
                    {
                        Console.WriteLine("Houston, we have a problem.");
                    }
                }
                catch(Exception exp)
                {
                    Console.WriteLine(exp.Message); // if there is an exception problem, display it
                }
            }
        }
    }
}
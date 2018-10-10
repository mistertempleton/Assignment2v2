using System;
using System.Collections.Generic;
using System.Linq;

namespace BuffTeks_Models
{
    class CR_Teams
    {
        static void Main(string[] args)
        {
            using(var db = new AppDbContext())
            {
                try
                {
                    db.Database.EnsureCreated(); // reads

                    if(!db.Advisors.Any())
                    {
                        List<Team> Teams = new List<Team>() // creates new records
                        {
                            new Team()
                            {
                                TeamName = "TeamName",
                            },                     
                        };
                        db.Teams.AddRange(Teams);
                        db.SaveChanges();                                              
                    }
                    else
                    {
                        var Teams = db.Teams.ToList(); // error/exception handling
                        foreach(Team s in Teams)
                        {
                            Console.WriteLine(s);
                        }
                    }
                    if(!db.Teams.Any())
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

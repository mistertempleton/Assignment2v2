using System;
using System.Collections.Generic;
using System.Linq;

namespace BuffTeks_Models
{
    class CR_Organizations  // This class will create and read for students
    {
        static void Main(string[] args)
        {
            using(var db = new AppDbContext())
            {
                try
                {
                    db.Database.EnsureCreated(); // reads

                    if(!db.Organizations.Any())
                    {
                        List<Organization> organizations = new List<Organization>() // creates new records
                        {
                            new Organization()
                            {
                                OrgName = "",
                                OrgBizName = "",
                                OrgPhone = "",
                                OrgEmail = "",
                            },                   
                        };
                        db.Organizations.AddRange(organizations);
                        db.SaveChanges();                                              
                    }
                    else
                    {
                        var organizations = db.Organizations.ToList(); // error/exception handling
                        foreach(Organization s in organizations)
                        {
                            Console.WriteLine(s);
                        }
                    }
                    if(!db.Organizations.Any())
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

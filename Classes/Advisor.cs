using System;
using System.Collections.Generic;
using System.Linq;


namespace BuffTeks_Models
{
    class Advisors
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
                        List<Advisor> Advisors = new List<Advisor>() // creates new records
                        {
                            new Advisor()
                            {
                                AdvisorFName = "",
                                AdvisorLName = "",
                                AdvisorPhone = "",
                                AdvisorEmail = "",

                            },                     
                        };
                        db.Advisors.AddRange(Advisors);
                        db.SaveChanges();                                              
                    }
                    else
                    {
                        var advisors = db.Advisors.ToList(); // error/exception handling
                        foreach(Advisor s in advisors)
                        {
                            Console.WriteLine(s);
                        }
                    }
                    if(!db.Advisors.Any())
                    {
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
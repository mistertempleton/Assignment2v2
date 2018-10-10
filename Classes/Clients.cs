using System;
using System.Collections.Generic;
using System.Linq;

namespace BuffTeks_Models
{
    class clients // This class will create and read for students
    {
        static void Main(string[] args)
        {
            using(var db = new AppDbContext())
            {
                try
                {
                    db.Database.EnsureCreated(); // reads

                    if(!db.Client.Any())
                    {
                        List<Client> clients = new List<Client>() // creates new records
                        {
                            new Client()
                            {
                                ClientFName = "",
                                ClientLName = "",
                                ClientPhone = "",
                                ClientEmail = "",
                                ClientBizName = ""
                            },                   
                        };
                        db.Clients.AddRange(clients);
                        db.SaveChanges();                                              
                    }
                    else
                    {
                        var clients = db.Clients.ToList(); // error/exception handling
                        foreach(Client s in Client)
                        {
                            Console.WriteLine(s);
                        }
                    }
                    if(!db.Clients.Any())
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
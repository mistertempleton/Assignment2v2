using System;
namespace BuffTeks_Models
{
    public class Advisor
    {
        public int AdvisorID {get; set;}
        public string AdvisorFName {get; set;}
        public string AdvisorLName {get; set;}
        public string AdvisorPhone {get; set;}
        public string AdvisorEmail {get; set;}

        public override string ToString()
        {
            return this.AdvisorFName + " " + this.AdvisorLName;
        }
    }
}
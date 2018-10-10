using System;
namespace BuffTeks_Models
{
    public class Student
    {
        public int StudentID {get; set;}
        public string StudentPhone {get;set;}
        public string StudentFName {get; set;}
        public string StudentLName {get; set;}
        public string StudentEmail {get; set;}
        public string StudentRole {get; set;}

        public override string ToString()
        {
            return this.StudentFName + " " + this.StudentLName;
        }
    }
}
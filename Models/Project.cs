using System;
namespace BuffTeks_Models
{
    public class Project
    {
        public int ProjectID { get; set; }
        public string ProjectName {get; set; }
        public int ProjectHours { get; set; }
        public string ProjectLeader { get; set; }
        public DateTime DeadLine { get; set; }
        public DateTime StartLine { get; set; }
        public string ProjectDesc { get; set;}
        public int ProjectClient { get; set; }
    }
}
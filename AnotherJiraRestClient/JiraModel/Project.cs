namespace AnotherJiraRestClient.JiraModel
{
    public class Project
    {
        public string self { get; set; }
        public string id { get; set; }
        public string key { get; set; }
        public string description { get; set; }
        public string name { get; set; }
        public ProjectCategory projectCategory { get; set; }
        public ProjectLead lead { get; set; }
    }
}
namespace JMD.Models
{
    public class JobsData
    {
        public JobsData()
        {

        }
        public int JobID { get; set; }
        public string JobType { get; set; }
        public string JobName { get; set; }
        public string JobFrequency { get; set; }
        public DateTime RunDateTime { get; set; }
        public string JobOwnerName {  get; set; }
        public string Status { get; set; }
        public string JobDependencyUpstream {  get; set; }
        public string JobDependencyDownstream { get; set; }

    }
}
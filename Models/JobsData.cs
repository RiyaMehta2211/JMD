using System;

namespace JMD.Models
{
    public class JobsData
    {
        public JobsData()
        {

        }
        public string JobType { get; set; }
        public string JobName { get; set; }
        public string JobFrequency { get; set; }
        public DateTime LastRunSchedule { get; set; }
        public string JobOwnerName {  get; set; }
        public string Job_Status { get; set; }
        public string JobDependencyUpstream {  get; set; }
        public string JobDependencyDownstream { get; set; }

    }
}
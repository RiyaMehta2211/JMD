using System;

namespace JMD
{
    public class JobTransactions
    {
        public JobTransactions()
        {

        }

        public int JobTransactionID { get; set; }
        public string Job_Status { get; set; }
        public DateTime LastRunSchedule { get; set; }
        public string JobFrequency { get; set; }
        public int JobID { get; set; }
        public Job job { get; set; }
    }
}
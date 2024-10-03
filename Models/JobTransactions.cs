using System;

namespace JMD.Models;

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
    public Jobs job { get; set; }
}
namespace JMD.Models;

public class JobLogs
{
    public JobLogs() {

    }
    public int ID { get; set; }
    public int JobID { get; set; }
    public string Job_status { get; set; }
    public DateTime DateTime { get; set; }
}
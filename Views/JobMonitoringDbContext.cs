namespace JMD
{
	public class JobMonitoringDbContext : JobMonitoringDbContext
	{
		public JobMonitoringDbContext(DbContextOptions<JobMonitoringDbContext> options) : base(options) {
		
		}
		//Code - Approach
		public DbSet<JobsData> JobsData { get; set; }
	}
}
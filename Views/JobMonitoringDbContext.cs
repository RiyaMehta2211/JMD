using Microsoft.EntityFrameworkCore;
namespace JMD.Views;

public class JobMonitoringDbContext : DbContext
{
	public JobMonitoringDbContext(DbContextOptions<JobMonitoringDbContext> options) : base(options) {
	
	}
	//Code - Approach
	public DbSet<JobsData> JobsData { get; set; }
}
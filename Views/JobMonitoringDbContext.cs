using JMD.Models;
using Microsoft.EntityFrameworkCore;
using System.Data;
namespace JMD.Views;

public class JobMonitoringDbContext : DbContext
{
	public JobMonitoringDbContext(DbContextOptions<JobMonitoringDbContext> options) : base(options) {
	
	}

    //To override the requirement of a primary key in the JobsData table
    public DbSet<JobsData> JobsData { get; set; }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<JobsData>().HasNoKey();
    }
}
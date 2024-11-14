using JMD.Models;
using Microsoft.AspNetCore.Authorization;

using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using Microsoft.Identity.Web.Resource;
using Dapper;

namespace JMD.Controllers
{
    [Authorize]
    [ApiController]
    [Route("[controller]")]
    [RequiredScope(RequiredScopesConfigurationKey = "AzureAd:Scopes")]
    public class JobController : Controller
    {
        /*private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };*/

        private readonly ILogger<JobController> _logger;

        public JobController(ILogger<JobController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "GetJobsData")]
        //public IEnumerable<JobsData> GetJobsData()
        public ActionResult Index()
        {
            List<JobsData> jobs = new List<JobsData>();
            var connection = new SqlConnection("Server = sgaspspsdevdb001.ab736799b18b.database.windows.net; Database = JMD");
            /*using (connection = new SqlConnection("Server = sgaspspsdevdb001.ab736799b18b.database.windows.net; Database = JMD")
            {*/
            connection.Open();
            jobs = connection.Query<JobsData>("SELECT * From JobsData").ToList();

            return View(jobs);
            //return connection.Query<JobsData>("SELECT * FROM dbo.JobsData").ToList(); }
        }
        /*return Enumerable.Range(1, 5).Select(index => new JobsData
    {
        Date = DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
        TemperatureC = Random.Shared.Next(-20, 55),
        Summary = Summaries[Random.Shared.Next(Summaries.Length)]
    })
    .ToArray();*/
    }
}

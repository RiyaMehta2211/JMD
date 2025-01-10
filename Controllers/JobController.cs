using JMD.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using System.Data;
using Dapper;
using JMD.Views;
using Microsoft.EntityFrameworkCore;
using NuGet.Common;
namespace JMD.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class JobController : Controller//ControllerBase
    {
        private readonly JobMonitoringDbContext _context;
        public JobController(JobMonitoringDbContext context)
        {
            _context = context;
        }
        [HttpGet]

        public async Task<IActionResult> Index()
        {
            return View(await _context.JobsData.ToListAsync());
        }

        // POST: JobController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([FromForm] JobsData model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _context.JobsData.Add(model);
                    await _context.SaveChangesAsync();
                    return RedirectToAction(nameof(Index));
                }
                return View(model);
            }
            catch
            {
                return View(model);
            }
        }
        /*[HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit(int id, [FromForm] JobsData model)
        {
            try
            {
                if (id != model.JobID)
                {
                    return BadRequest();
                }

                if (ModelState.IsValid)
                {
                    _context.Entry(model).State = EntityState.Modified;
                    await _context.SaveChangesAsync();
                    return RedirectToAction(nameof(Index));
                }
                return View(model);
            }
            catch
            {
                return View(model);
            }
        }*/
        /*public async Task<ActionResult<IEnumerable<JobsData>>> GetJobs() {
        var jobs = await _context.JobsData.ToListAsync();
        foreach (var job in jobs)
        {
            Console.WriteLine($"JobID: {job.JobID}, JobName: {job.JobName}");
        }
        return jobs;
        //return await _context.JobsData.ToListAsync();
        }*/

        /*// GET: HomeController
        public ActionResult Index()
        {
            List<JobsData> jobs = new List<JobsData>();
            using (IDbConnection db = new SqlConnection("Server = sgaspspsdevdb001.ab736799b18b.database.windows.net; Database = JMD"))
            {

                jobs = db.Query<JobsData>("Select * From JobsData").ToList();
            }
            return View(jobs);
        }*/
    }
}

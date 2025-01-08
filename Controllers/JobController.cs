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
        /*public async Task<ActionResult<IEnumerable<JobsData>>> GetJobs()
        {
            var jobs = await _context.JobsData.ToListAsync();
            foreach (var job in jobs)
            {
                Console.WriteLine($"JobID: {job.JobID}, JobName: {job.JobName}");
            }
            return jobs;
            //return await _context.JobsData.ToListAsync();
        }*/
        public async Task<IActionResult> Index()
        {
            return View(await _context.JobsData.ToListAsync());
        }

        /*// GET: HomeController
        public ActionResult Index()
        {
            List<JobsData> jobs = new List<JobsData>();
            using (IDbConnection db = new SqlConnection("Server = sgaspspsdevdb001.ab736799b18b.database.windows.net; Database = JMD"))
            {

                jobs = db.Query<JobsData>("Select * From JobsData").ToList();
            }
            return View(jobs);
        }

        // GET: HomeController/Details/5
       public ActionResult Details(int id)
        {
            return View();
        }

        // GET: HomeController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: HomeController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: HomeController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: HomeController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: HomeController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: HomeController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }*/
    }
}

using JMD.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using System.Data;
using Dapper;
using JMD.Views;
using Microsoft.EntityFrameworkCore;
namespace JMD.Controllers
{
    public class JobController : Controller
    {
        private readonly JobMonitoringDbContext _context;
        public JobController(JobMonitoringDbContext context)
        {
            _context = context;
        }
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

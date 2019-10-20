using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CollabFast.Models;

namespace CollabFast.Controllers
{
    public class ProjectController : Controller
    {
        private readonly ApplicationDbContext db;

        public ProjectController()
        {
            db = new ApplicationDbContext();
        }
        // GET: Project
        [Authorize]
        public ActionResult Index()
        {
            var projects = db.Projects.ToList();
            return View(projects);
        }

        // GET: Project/Details/5
        public ActionResult Details(Guid id)
        {
            var project = db.Projects.FirstOrDefault(p => p.Id == id);
            return View(project);
        }

        // GET: Project/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Project/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                var p = new Project();
                p.ProjectName = collection["ProjectName"];
                p.ProjectOwner = User.Identity.Name;

                db.Projects.Add(p);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Project/Edit/5
        public ActionResult Edit(Guid id)
        {
            var project = db.Projects.FirstOrDefault(p => p.Id == id);
            return View(project);
        }

        // POST: Project/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Project/Delete/5
        public ActionResult Delete(Guid id)
        {
            var project = db.Projects.FirstOrDefault(p => p.Id == id);
            return View(project);
        }

        // POST: Project/Delete/5
        [HttpPost]
        public ActionResult Delete(Guid id, FormCollection collection)
        {
            try
            {
                var project = db.Projects.FirstOrDefault(p => p.Id == id);
                db.Projects.Remove(project);
                db.SaveChanges();

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}

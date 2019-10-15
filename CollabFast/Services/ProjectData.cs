using System;
using System.Collections.Generic;
using System.Linq;
using CollabFast.Models;
using System.Data.Entity;

namespace CollabFast.Services
{
    public class ProjectData
    {
        //Get instance of DB
        private readonly CollabFastDbContext db;

        // Constructor to get an instance on the db
        public ProjectData(CollabFastDbContext db)
        {
            this.db = db;
        }

        // Get all projects in alphabetical order
        public IEnumerable<Project> GetAll()
        {
            return from p in db.Projects
                   orderby p.ProjectName
                   select p;
        }

        // Get a project by its ID
        public Project GetById(Guid id)
        {
            return db.Projects.FirstOrDefault(p=> p.Id == id);
        }

        // Get project by matching user ID
        public IEnumerable<Project> ProjectsByUser(Guid user)
        {
            return null;
        }

        // Add a project to the database.
        public void AddProject(Project project)
        {
            db.Projects.Add(project);
            db.SaveChanges();
        }

        // allows the update of a project.
        public void UpdateProject(Project project)
        {
            var entry = db.Entry(project);
            entry.State = EntityState.Modified;
            db.SaveChanges();
        }

        // TODO implement. This is a feature beyond the MVP.
        public void DeleteProject(Project project)
        {
            // delete the project.
        }
    }
}
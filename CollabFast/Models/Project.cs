using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;


namespace CollabFast.Models
{
    public class Project
    {
        [Display(Name = "Project Name")]
        public string projectName { get; set; }
        public TaskList taskList { get; set; }
        public Calendar projectCalendar { get; set; }
        public Chat projectChat { get; set; }

        //The owner/admin of the project
        [Display(Name = "Owner")]
        public ApplicationUser projectOwner { get; set; }

        // Other project members that are not the owner.
        [Display(Name = "Team Members")]
        public ICollection<ApplicationUser> projectMembers { get; set; }
    }
}

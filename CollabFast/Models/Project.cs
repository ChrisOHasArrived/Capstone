using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CollabFast.Models
{
    public class Project
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid id { get; set; }

        [Display(Name = "Project Name")]
        public string projectName { get; set; }


        //The owner/admin of the project
        [Display(Name = "Owner")]
        public ApplicationUser projectOwner { get; set; }

        // Other project members that are not the owner.
        [Display(Name = "Team Members")]
        public ICollection<ApplicationUser> projectMembers { get; set; }


        // Features
        [ForeignKey("TaskList")]
        public virtual Guid taskListID { get; set; }
        [ForeignKey("Calendar")]
        public virtual Guid calendarID { get; set; }
        [ForeignKey("Chat")]
        public virtual Guid chatID { get; set; }
    }
}

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
        public Guid Id { get; set; }

        [Display(Name = "Project Name")]
        public string ProjectName { get; set; }


        //The owner/admin of the project
        [Display(Name = "Owner")]
        public ApplicationUser ProjectOwner { get; set; }

        // Other project members that are not the owner.
        [Display(Name = "Team Members")]
        public ICollection<ApplicationUser> ProjectMembers { get; set; }


        // Features
        [ForeignKey("TaskList")]
        public virtual Guid TaskListID { get; set; }
        [ForeignKey("Calendar")]
        public virtual Guid CalendarID { get; set; }
        [ForeignKey("Chat")]
        public virtual Guid ChatID { get; set; }
    }
}

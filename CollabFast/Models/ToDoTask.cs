using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace CollabFast.Models
{
    public class ToDoTask
    {
            [Key]
            [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
            public Guid ID { get; set; }
            public string Name { get; set; }
            public string Assignee { get; set; }
            public DateTime DueDate { get; set; }
            public Priority Priority { get; set; }
        
    }
}
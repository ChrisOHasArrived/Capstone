using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CollabFast.Models
{
    public class TaskList
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid id { get; set; }

        public int ID { get; set; }
        public string taskListName { get; set; }

        [ForeignKey("ListTask")]
        public virtual List<Guid> taskIDs { get; set; }
    }
}

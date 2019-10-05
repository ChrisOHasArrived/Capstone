using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;


namespace CollabFast.Models
{
    public class TaskList
    {
        public int ID { get; set; }
        public string taskListName { get; set; }
        public ICollection<ListTask> tasks { get; set; }
    }
}

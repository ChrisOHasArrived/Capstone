using System;
using System.Collections.Generic;
using System.Text;

namespace CollabFast.Models
{
    public class TaskList
    {
        public string taskListName { get; set; }
        public ICollection<TaskList> tasks { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace CollabFast.Models
{
    public class Project
    {
        public string projectName { get; set; }
        public TaskList taskList { get; set; }
    }
}

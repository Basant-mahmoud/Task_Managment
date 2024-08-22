using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_Managment
{
    public  class Task
    {
        public string TaskName { get; set; }
        public string Status { get; set; }
        public DateTime DueDate { get; set; }
        public int AssignedTo { get; set; } 
    }
}

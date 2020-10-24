using System;
using System.Collections.Generic;

namespace EntityFramwork.Models
{
    public partial class Tasks
    {
        public int TaskId { get; set; }
        public string Subject { get; set; }
        public DateTime? CreateTime { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? DueDate { get; set; }
        public DateTime? CompletedDate { get; set; }
        public bool Complete { get; set; }
        public string Importance { get; set; }
    }
}

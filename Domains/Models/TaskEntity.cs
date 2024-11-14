using Domains.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domains.Models
{
	public class TaskEntity
	{
        public string? Description { get; set; }
        public string? Name { get; set; }
        public bool IsDone { get; set; }
        public long Id { get; set; }    
        public Priority Priority { get; set; }

        public DateTime GetCreated { get; set; }
        
    }
}

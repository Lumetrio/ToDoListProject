using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domains.Models
{
    public class User
    {
        public int Id { get; set; }
        [MinLength(6)]
		public string Name { get; set; }
        [MinLength(6)]
        public string Password { get; set; }

        //public ICollection<TaskEntity>tasks { get; set; }
    }
}

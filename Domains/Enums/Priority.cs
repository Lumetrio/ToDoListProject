using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domains.Enums
{
	public enum Priority
	{
		[Display(Name ="Легкий")]
		Easy=1,
		[Display(Name = "Средний")]
		Medium =2,
		[Display(Name = "Тяжелый")]
		Hard =3
	}
}

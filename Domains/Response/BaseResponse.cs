using Domains.Enums;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domains.Response
{
	public class BaseResponse<T>:IBaseResponse<T> where T : class
	{
        public string Description { get; set; }
		public StatusCode Status { get; set; }

		public T Data { get; set; }
    }
	public interface IBaseResponse<T>
	{
		string Description { get; set; }
		StatusCode Status { get; set; }

		public T Data { get; }
	}
}

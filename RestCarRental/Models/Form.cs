using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RestCarRental.Models
{
	public class Form<T>
	{
		public string Uri;
		public string Rel;
		public string Mode;
		public T Payload;
	}
}

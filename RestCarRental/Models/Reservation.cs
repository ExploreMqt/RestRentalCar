using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RestCarRental.Models
{
	public class Reservation
	{
		public string Vin;
		public DateTime Start;
		public DateTime End;
		public string DriverLicense;
	}
}

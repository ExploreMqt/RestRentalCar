using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RestCarRental.Models
{
	public class CancelableReservation : Reservation
	{
		public Form<Cancelation> Cancel;
	}
}

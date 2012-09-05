using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using RestCarRental.Models;

namespace RestCarRental.Controllers
{

	public class CarsController : ApiController
	{
		// GET api/values
		public IEnumerable<Car> Get()
		{
			return new[] { 
				new Car{
					Make="Ford", 
					Model="Taurus", 
					Vin="1234", 
					Reservation=new Form<Reservation>{ 
						Uri="...", 
						Rel="reserveCar", 
						Mode="POST", 
						Payload = new Reservation{ Vin="1234", DriverLicense=String.Empty}
					}
				},
				new Car{
					Make="Dodge", 
					Model="Cyrus", 
					Vin="4321", 
					Reservation=new Form<Reservation>{ 
						Uri="...", 
						Rel="reserveCar", 
						Mode="POST", 
						Payload = new Reservation{ Vin="4321", DriverLicense=String.Empty}
					}
				}
			};
		}
	}
}
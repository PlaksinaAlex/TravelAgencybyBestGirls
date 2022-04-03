using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelAgencyContracts.BindingModels
{
	public class CreatePaymentBindingModel
	{
		public int TripId { get; set; }
		public int TourId { get; set; }
		public int? ClientId { get; set; }
		public int Sum { get; set; }
	}
}

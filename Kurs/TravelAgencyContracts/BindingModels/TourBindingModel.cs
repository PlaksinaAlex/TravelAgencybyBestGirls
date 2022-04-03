using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelAgencyContracts.BindingModels
{
	public class TourBindingModel
	{
		public int? Id { get; set; }

		public string TourName { get; set; }

		public DateTime DateStartTour { get; set; }

		public int TourPrice { get; set; }

	}
}

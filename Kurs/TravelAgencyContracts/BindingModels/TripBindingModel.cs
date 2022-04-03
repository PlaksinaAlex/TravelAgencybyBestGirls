using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelAgencyContracts.BindingModels
{
	public class TripBindingModel
	{
	    public int? Id { get; set; }
        public string TripName { get; set; }
        public int ClientId { get; set; }
        public decimal Price { get; set; }
        public Dictionary<int, (string, int)> TripTours { get; set; }
        public Dictionary<int, (string, int)> TripExpenses { get; set; }

	}
}

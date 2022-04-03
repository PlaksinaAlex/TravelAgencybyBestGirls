using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace TravelAgencyDatabaseImplement.Models
{
	public class Tour
	{
		public int Id { get; set; }
		[Required]
		public string TourName { get; set; }
		[Required]
		public int TourPrice { get; set; }
		[Required]

		[ForeignKey("TourId")]

		public virtual List<TripTour> TripTours { get; set; }
	}
}

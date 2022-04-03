using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TravelAgencyDatabaseImplement.Models
{
	public class Trip
	{
        public int Id { get; set; }
        [Required]
        public string TripName { get; set; }
        public int ClientId { get; set; }
        [Required]
        public decimal Price { get; set; }
        [ForeignKey("TripId")]
        public virtual List<TripTour> TripTours { get; set; }
        [ForeignKey("TripId")]
        public virtual List<TripExpense> TripExpenses { get; set; }

        [ForeignKey("TripId")]
        public virtual List<Payment> Payments { get; set; }
    }
}

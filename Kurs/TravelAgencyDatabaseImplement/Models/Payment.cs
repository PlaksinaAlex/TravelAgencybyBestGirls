using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using TravelAgencyContracts.Enums;

namespace TravelAgencyDatabaseImplement.Models
{
	public class Payment
	{
        public int Id { get; set; }
        [Required]
        public int Tour { get; set; }
        public int ClientId { get; set; }
        public int TripId { get; set; }
        [Required]
        public int Sum { get; set; }
        [Required]
        public int Remain { get; set; }
        [Required]
        public DateTime DateStart { get; set; }
        public DateTime? DateFinish { get; set; }
        [Required]
        public PaymentStatus Status { get; set; }

        public virtual Trip Trip { get; set; }

        public virtual Client Client { get; set; }
    }
}

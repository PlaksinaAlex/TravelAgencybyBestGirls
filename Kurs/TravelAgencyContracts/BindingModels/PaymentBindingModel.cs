using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravelAgencyContracts.Enums;

namespace TravelAgencyContracts.BindingModels
{
    public class PaymentBindingModel
    {
        public int? Id { get; set; }
        public int Tour { get; set; }
        public int TripId { get; set; }
        public int Sum { get; set; }
        public int Remain { get; set; }
        public DateTime DateStart { get; set; }
        public DateTime? DateFinish { get; set; }
        public PaymentStatus Status { get; set; }
    }
}

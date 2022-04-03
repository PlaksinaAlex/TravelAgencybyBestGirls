using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using TravelAgencyContracts.Enums;

namespace TravelAgencyContracts.ViewModels
{
	public class PaymentViewModel
	{
        public int Id { get; set; }
        public int TourId { get; set; }
        [DisplayName("Название тура из путешествия")]
        public int Tour { get; set; }
        public int TripId { get; set; }
        [DisplayName("Название путешествия")]
        public int TripName { get; set; }

        [DisplayName("Стоимость путешествия")]
        public int Sum { get; set; }

        [DisplayName("Осталось оплатить")]
        public int Remain { get; set; }

        [DisplayName("Дата создания")]
        public DateTime DateStart { get; set; }

        [DisplayName("Дата выполнения")]
        public DateTime? DateFinish { get; set; }

        [DisplayName("Статус")]
        public PaymentStatus Status { get; set; }
    }
}

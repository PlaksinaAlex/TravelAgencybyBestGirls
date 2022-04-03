using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace TravelAgencyContracts.ViewModels
{
    public class TripViewModel
    {
        public int Id { get; set; }
        [DisplayName("Название путешествия")]
        public string TripName { get; set; }
        public int ClientId { get; set; }
        [DisplayName("Дата начала")]
        public DateTime DateStartTour { get; set; }
        [DisplayName("Дата окончания")]
        public DateTime? DateFinishTour { get; set; }
        [DisplayName("Статус")]
        public  PaymantStatus Status { get; set; }
        [DisplayName("Стоимость")]
        public decimal Price { get; set; }
        [DisplayName("Туры")]
        public Dictionary<int, (string, int)> TripTours { get; set; }
        [DisplayName("Затраты")]
        public Dictionary<int, (string, int)> TripExpenses { get; set; }
    }
}


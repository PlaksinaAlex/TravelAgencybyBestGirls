using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravelAgencyContracts.ViewModels;
using TravelAgencyContracts.BindingModels;

namespace TravelAgencyContracts.StorageContracts
{
	public interface ITourStorage
	{
        List<TourViewModel> GetFullList();

        List<TourViewModel> GetFilteredList(TourBindingModel model);

        TourViewModel GetElement(TourBindingModel model);

        void Insert(TourBindingModel model);

        void Update(TourBindingModel model);

        void Delete(TourBindingModel model);

    }
}

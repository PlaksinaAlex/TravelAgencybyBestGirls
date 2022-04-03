using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravelAgencyContracts.BindingModels;
using TravelAgencyContracts.ViewModels;

namespace TravelAgencyContracts.BusinessLogicContracts
{
	public interface ITourLogic
	{
		List<TourViewModel> Read(TourBindingModel model);
		void CreateOrUpdate(TourBindingModel model);
		void Delete(TourBindingModel model);
	}
}

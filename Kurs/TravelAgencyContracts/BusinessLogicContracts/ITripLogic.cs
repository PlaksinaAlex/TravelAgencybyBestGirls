using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravelAgencyContracts.BindingModels;
using TravelAgencyContracts.ViewModels;

namespace TravelAgencyContracts.BusinessLogicContracts
{
	public interface ITripLogic
	{
		List<TripViewModel> Read(TripBindingModel model);
		void CreateOrUpdate(TripBindingModel model);
		void Delete(TripBindingModel model);
	}
}

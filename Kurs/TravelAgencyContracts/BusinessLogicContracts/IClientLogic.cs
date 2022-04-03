using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravelAgencyContracts.BindingModels;
using TravelAgencyContracts.ViewModels;

namespace TravelAgencyContracts.BusinessLogicContracts
{
	public interface IClientLogic
	{
		List<ClientViewModel> Read(ClientBindingModel model);
		void CreateOrUpdate(ClientBindingModel model);
		void Delete(ClientBindingModel model);
	}
}

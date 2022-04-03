using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravelAgencyContracts.BindingModels;
using TravelAgencyContracts.ViewModels;

namespace TravelAgencyContracts.BusinessLogicContracts
{
	public interface IWorkerLogic
	{
		List<WorkerViewModel> Read(WorkerBindingModel model);
		void CreateOrUpdate(WorkerBindingModel model);
		void Delete(WorkerBindingModel model);
	}
}

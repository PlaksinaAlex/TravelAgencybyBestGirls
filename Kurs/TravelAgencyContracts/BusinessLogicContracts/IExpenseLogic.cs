using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravelAgencyContracts.BindingModels;
using TravelAgencyContracts.ViewModels;


namespace TravelAgencyContracts.BusinessLogicContracts
{
	public interface IExpenseLogic
	{
		List<ExpenseViewModel> Read(ExpenseBindingModel model);
		void CreateOrUpdate(ExpenseBindingModel model);
		void Delete(ExpenseBindingModel model);
	}
}

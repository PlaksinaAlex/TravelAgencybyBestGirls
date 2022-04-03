using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravelAgencyContracts.ViewModels;
using TravelAgencyContracts.BindingModels;

namespace TravelAgencyContracts.StorageContracts
{
	public interface IExpenseStorage
	{
        List<ExpenseViewModel> GetFullList();

        List<ExpenseViewModel> GetFilteredList(ExpenseBindingModel model);

        ExpenseViewModel GetElement(ExpenseBindingModel model);

        void Insert(ExpenseBindingModel model);

        void Update(ExpenseBindingModel model);

        void Delete(ExpenseBindingModel model);

    }
}

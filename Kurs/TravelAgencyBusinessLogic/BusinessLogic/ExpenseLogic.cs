using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravelAgencyContracts.ViewModels;
using TravelAgencyContracts.BindingModels;
using TravelAgencyContracts.BusinessLogicContracts;
using TravelAgencyContracts.StorageContracts;

namespace TravelAgencyBusinessLogic.BusinessLogic
{
	public class ExpenseLogic : IExpenseLogic
	{

		private readonly IExpenseStorage _expenseStorage;
		public ExpenseLogic(IExpenseStorage expenseStorage)
		{
			_expenseStorage = expenseStorage;
		}
		public List<ExpenseViewModel> Read(ExpenseBindingModel model)
		{
			if (model == null)
			{
				return _expenseStorage.GetFullList();
			}
			if (model.Id.HasValue)
			{
				return new List<ExpenseViewModel>
				{
					_expenseStorage.GetElement(model)
				};
			}
			return _expenseStorage.GetFilteredList(model);
		}
		public void CreateOrUpdate(ExpenseBindingModel model)
		{
			var element = _expenseStorage.GetElement(new ExpenseBindingModel
			{
				ExpenseName = model.ExpenseName
			});
			if (element != null && element.Id != model.Id)
			{
				throw new Exception("Уже есть статья с таким названием");
			}
			if (model.Id.HasValue)
			{
				_expenseStorage.Update(model);
			}
			else
			{
				_expenseStorage.Insert(model);
			}
		}
		public void Delete(ExpenseBindingModel model)
		{
			var element = _expenseStorage.GetElement(new ExpenseBindingModel
			{
				Id = model.Id
			});
			if (element == null)
			{
				throw new Exception("Элемент не найден");
			}
			_expenseStorage.Delete(model);
		}
	}
}

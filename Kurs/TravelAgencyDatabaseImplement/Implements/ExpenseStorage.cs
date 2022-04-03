using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravelAgencyContracts.BindingModels;
using TravelAgencyContracts.StorageContracts;
using TravelAgencyContracts.ViewModels;
using TravelAgencyDatabaseImplement.Models;


namespace TravelAgencyDatabaseImplement.Implements
{
	public class ExpenseStorage : IExpenseStorage
	{
		public List<ExpenseViewModel> GetFullList()
		{
			using var context = new TravelAgencyDatabase();
			return context.Expenses.Select(CreateModel).ToList();
		}
		public List<ExpenseViewModel> GetFilteredList(ExpenseBindingModel model)
		{
			if (model == null)
			{
				return null;
			}
			using var context = new TravelAgencyDatabase();
			return context.Expenses
			.Where(rec => rec.ExpenseName.Contains(model.ExpenseName)).Select(CreateModel).ToList();
		}
		public ExpenseViewModel GetElement(ExpenseBindingModel model)
		{
			if (model == null)
			{
				return null;
			}
			using var context = new TravelAgencyDatabase();
			var expense = context.Expenses
			.FirstOrDefault(rec => rec.ExpenseName == model.ExpenseName || rec.Id
		   == model.Id);
			return expense != null ? CreateModel(expense) : null;
		}
		public void Insert(ExpenseBindingModel model)
		{
			using var context = new TravelAgencyDatabase();
			context.Expenses.Add(CreateModel(model, new Expense()));
			context.SaveChanges();
		}
		public void Update(ExpenseBindingModel model)
		{
			using var context = new TravelAgencyDatabase();
			var element = context.Expenses.FirstOrDefault(rec => rec.Id == model.Id);
			if (element == null)
			{
				throw new Exception("Элемент не найден");
			}
			CreateModel(model, element);
			context.SaveChanges();
		}
		public void Delete(ExpenseBindingModel model)
		{
			using var context = new TravelAgencyDatabase();
			Expense element = context.Expenses.FirstOrDefault(rec => rec.Id ==
		   model.Id);
			if (element != null)
			{
				context.Expenses.Remove(element);
				context.SaveChanges();
			}
			else
			{
				throw new Exception("Элемент не найден");
			}
		}
		private static Expense CreateModel(ExpenseBindingModel model, Expense expense)
		{
			expense.ExpenseName = model.ExpenseName;
			expense.ExpensePrice = model.ExpensePrice;
			return expense;
		}
		private static ExpenseViewModel CreateModel(Expense expense)
		{
			return new ExpenseViewModel
			{
				Id = expense.Id,
				ExpenseName = expense.ExpenseName,
				ExpensePrice= expense.ExpensePrice
			};
		}
	}
}

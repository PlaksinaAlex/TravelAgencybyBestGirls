using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace TravelAgencyContracts.ViewModels
{
	public class ExpenseViewModel
	{
		public int Id { get; set; }

		[DisplayName("Имя сотрудника")]
		public int WorkerFIO { get; set; }
		public int WorkerId { get; set; }

		[DisplayName("Название статьи затрат")]
		public string ExpenseName { get; set; }

		[DisplayName("Стоимость затраты")]
		public int ExpensePrice { get; set; }
	}
}

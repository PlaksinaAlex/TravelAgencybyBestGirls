using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TravelAgencyDatabaseImplement.Models
{
	public class Expense
	{
		public int Id { get; set; }
		[Required]

		public int WorkerId { get; set; }
		public string ExpenseName { get; set; }
		[Required]
		public int ExpensePrice { get; set; }
		[Required]

		[ForeignKey("ExpenseId")]
		public virtual List<TripExpense> TripExpenses { get; set; }

		public virtual Worker Worker { get; set; }
	}
}

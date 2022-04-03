using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace TravelAgencyDatabaseImplement.Models
{
	public class TripExpense
	{
		public int Id { get; set; }
		public int TripId { get; set; }
		public int ExpenseId { get; set; }
		[Required]
		public int Count { get; set; }
		public virtual Trip Trip { get; set; }
		public virtual Expense Expense { get; set; }
	}
}

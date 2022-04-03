using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelAgencyContracts.BindingModels
{
	public class ExpenseBindingModel
	{
        public int? Id { get; set; }
        public int WorkerId { get; set; }
        public string  ExpenseName { get; set; }
        public int ExpensePrice{ get; set; }

    }
}

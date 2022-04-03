using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace TravelAgencyContracts.ViewModels
{
	public class WorkerViewModel
	{
		public int? Id { get; set; }

		[DisplayName("Имя сотрудника")]
		public string Name { get; set; }

		[DisplayName("Почта сотрудника")]
		public string Email { get; set; }

		[DisplayName("Пароль сотрудника")]
		public string Password { get; set; }
	}
}

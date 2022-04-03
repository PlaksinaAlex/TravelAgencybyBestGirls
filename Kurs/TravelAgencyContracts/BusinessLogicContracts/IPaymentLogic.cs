using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravelAgencyContracts.BindingModels;
using TravelAgencyContracts.ViewModels;


namespace TravelAgencyContracts.BusinessLogicContracts
{
	public interface IPaymentLogic
	{
		List<PaymentViewModel> Read(PaymentBindingModel model);
		void CreatePayment(CreatePaymentBindingModel model);
		void MakePeaceOfPayment(ChangePaymentStatusBindingModel model);
		void FinishPayment(ChangePaymentStatusBindingModel model);
	}
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravelAgencyContracts.ViewModels;
using TravelAgencyContracts.BindingModels;
using TravelAgencyContracts.BusinessLogicContracts;
using TravelAgencyContracts.StorageContracts;
using TravelAgencyContracts.Enums;

namespace TravelAgencyBusinessLogic.BusinessLogic
{
    public class PaymentLogic : IPaymentLogic
    {
        private readonly IPaymentStorage _paymentStorage;

        public PaymentLogic(IPaymentStorage paymentStorage)
        {
            _paymentStorage = paymentStorage;
        }

        public List<PaymentViewModel> Read(PaymentBindingModel model)
        {
            if (model == null)
            {
                return _paymentStorage.GetFullList();
            }
            if (model.Id.HasValue)
            {
                return new List<PaymentViewModel> { _paymentStorage.GetElement(model) };
            }
            return _paymentStorage.GetFilteredList(model);
        }
        public void CreatePayment(CreatePaymentBindingModel model)
        {
            _paymentStorage.Insert(new PaymentBindingModel
            {
                Id = model.TripId,
                Sum = model.Sum,
                DateStart = DateTime.Now,
                Status = PaymentStatus.Ожидается
            });
        }
        public void MakePeaceOfPayment(ChangePaymentStatusBindingModel model)
        {
            var payment = _paymentStorage.GetElement(new PaymentBindingModel
            {
                Id = model.PaymentID
            });
            if (payment == null)
            {
                throw new Exception("Информация об оплате не найдена");
            }
            if (!payment.Status.Equals("Ожидается"))
            {
                throw new Exception("Оплата не в статусе \"Ожидается\"");
            }
            _paymentStorage.Update(new PaymentBindingModel
            {
                Id = payment.Id,
                TripId = payment.TripId,
                Remain = payment.Remain,
                DateStart = payment.DateStart,
                DateFinish = DateTime.Now,
                Status = PaymentStatus.ЧастичнаяОплата
            });
        }
        public void FinishPayment(ChangePaymentStatusBindingModel model)
        {
            var payment = _paymentStorage.GetElement(new PaymentBindingModel
            {
                Id = model.PaymentID
            });
            if (payment == null)
            {
                throw new Exception("Информация об оплате не найдена");
            }
            if (!payment.Status.Equals("ЧастичнаяОплата"))
            {
                throw new Exception("Оплата не в статусе \"ЧастичнаяОплата\"");
            }
            _paymentStorage.Update(new PaymentBindingModel
            {
                Id = payment.Id,
                TripId = payment.TripId,
                Sum = payment.Sum,
                DateStart = payment.DateStart,
                DateFinish = payment.DateFinish,
                Status = PaymentStatus.Оплачено
            });
        }
    }
}

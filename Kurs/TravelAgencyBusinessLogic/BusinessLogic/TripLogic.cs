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
	public class TripLogic :ITripLogic
	{
        private readonly ITripStorage _tripStorage;
        public TripLogic(ITripStorage tripStorage)
        {
            _tripStorage = tripStorage;
        }
        public List<TripViewModel> Read(TripBindingModel model)
        {
            if (model == null)
            {
                return _tripStorage.GetFullList();
            }
            if (model.Id.HasValue)
            {
                return new List<TripViewModel> { _tripStorage.GetElement(model)
                };
            }
            return _tripStorage.GetFilteredList(model);
        }
        public void CreateOrUpdate(TripBindingModel model)
        {
            var element = _tripStorage.GetElement(new TripBindingModel
            {
                TripName = model.TripName
            });
            if (element != null && element.Id != model.Id)
            {
                throw new Exception("Такое путешествие уже имеется");
            }
            if (model.Id.HasValue)
            {
                _tripStorage.Update(model);
            }
            else
            {
                _tripStorage.Insert(model);
            }
        }

        public void Delete(TripBindingModel model)
        {
            var element = _tripStorage.GetElement(new TripBindingModel
            {
                Id = model.Id
            });
            if (element == null)
            {
                throw new Exception("Путешествие не найдено");
            }
            _tripStorage.Delete(model);
        }
    }
}

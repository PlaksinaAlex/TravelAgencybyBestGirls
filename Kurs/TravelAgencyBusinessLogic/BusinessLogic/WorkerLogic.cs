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
	public class WorkerLogic : IWorkerLogic
	{
        private readonly IWorkerStorage _workerStorage;

        public WorkerLogic(IWorkerStorage workerStorage)
        {
            _workerStorage = workerStorage;
        }

        public List<WorkerViewModel> Read(WorkerBindingModel model)
        {
            if (model == null)
            {
                return _workerStorage.GetFullList();
            }
            if (model.Id.HasValue)
            {
                return new List<WorkerViewModel> { _workerStorage.GetElement(model) };
            }
            return _workerStorage.GetFilteredList(model);
        }

        public void CreateOrUpdate(WorkerBindingModel model)
        {
            var element = _workerStorage.GetElement(new WorkerBindingModel
            {
                Email = model.Email
            });
            if (element != null && element.Id != model.Id)
            {
                throw new Exception("Уже есть сотрудник с таким логином");
            }
            if (model.Id.HasValue)
            {
                _workerStorage.Update(model);
            }
            else
            {
                _workerStorage.Insert(model);
            }
        }
        public void Delete(WorkerBindingModel model)
        {
            var element = _workerStorage.GetElement(new WorkerBindingModel { Id = model.Id });
            if (element == null)
            {
                throw new Exception("Сотрудник не найден");
            }
            _workerStorage.Delete(model);
        }
    }
}

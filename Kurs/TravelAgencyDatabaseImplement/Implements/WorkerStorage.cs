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
	public class WorkerStorage : IWorkerStorage
	{
        public List<WorkerViewModel> GetFullList()
        {
            using var context = new TravelAgencyDatabase();
            return context.Workers.Select(CreateModel).ToList();

        }
        public List<WorkerViewModel> GetFilteredList(WorkerBindingModel model)
        {
            if (model == null)
            {
                return null;
            }
            using var context = new TravelAgencyDatabase();
            return context.Workers.Where(rec => rec.Email == model.Email && rec.Password == model.Password).Select(CreateModel).ToList();
        }
        public WorkerViewModel GetElement(WorkerBindingModel model)
        {
            if (model == null)
            {
                return null;
            }
            using var context = new TravelAgencyDatabase();
            var worker = context.Workers.FirstOrDefault(rec => rec.Email == model.Email || rec.Id == model.Id);
            return worker != null ? CreateModel(worker) : null;
        }
        public void Insert(WorkerBindingModel model)
        {
            using var context = new TravelAgencyDatabase();
            context.Workers.Add(CreateModel(model, new Worker()));
            context.SaveChanges();
        }
        public void Update(WorkerBindingModel model)
        {
            using var context = new TravelAgencyDatabase();
            var worker = context.Workers.FirstOrDefault(rec => rec.Id == model.Id);
            if (worker == null)
            {
                throw new Exception("Элемент не найден");
            }
            CreateModel(model, worker);
            context.SaveChanges();
        }
        public void Delete(WorkerBindingModel model)
        {
            using var context = new TravelAgencyDatabase();
            Worker worker = context.Workers.FirstOrDefault(rec => rec.Id == model.Id);
            if (worker != null)
            {
                context.Workers.Remove(worker);
                context.SaveChanges();
            }
            else
            {
                throw new Exception("Элемент не найден");
            }
        }
        private static Worker CreateModel(WorkerBindingModel model, Worker worker)
        {
            worker.Name = model.Name;
            worker.Email = model.Email;
            worker.Password = model.Password;
            return worker;
        }
        private static WorkerViewModel CreateModel(Worker worker)
        {
            return new WorkerViewModel
            {
                Id = worker.Id,
                Name = worker.Name,
                Email = worker.Email,
                Password = worker.Password
            };
        }
    }
}

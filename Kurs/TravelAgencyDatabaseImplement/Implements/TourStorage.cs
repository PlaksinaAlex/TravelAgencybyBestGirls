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
	public class TourStorage : ITourStorage
	{
		public List<TourViewModel> GetFullList()
		{
			using var context = new TravelAgencyDatabase();
			return context.Tours.Select(CreateModel).ToList();
		}
		public List<TourViewModel> GetFilteredList(TourBindingModel model)
		{
			if (model == null)
			{
				return null;
			}
			using var context = new TravelAgencyDatabase();
			return context.Tours
			.Where(rec => rec.TourName.Contains(model.TourName)).Select(CreateModel).ToList();
		}
		public TourViewModel GetElement(TourBindingModel model)
		{
			if (model == null)
			{
				return null;
			}
			using var context = new TravelAgencyDatabase();
			var tour = context.Tours
			.FirstOrDefault(rec => rec.TourName == model.TourName || rec.Id
		   == model.Id);
			return tour != null ? CreateModel(tour) : null;
		}
		public void Insert(TourBindingModel model)
		{
			using var context = new TravelAgencyDatabase();
			context.Tours.Add(CreateModel(model, new Tour()));
			context.SaveChanges();
		}
		public void Update(TourBindingModel model)
		{
			using var context = new TravelAgencyDatabase();
			var element = context.Tours.FirstOrDefault(rec => rec.Id == model.Id);
			if (element == null)
			{
				throw new Exception("Элемент не найден");
			}
			CreateModel(model, element);
			context.SaveChanges();
		}
		public void Delete(TourBindingModel model)
		{
			using var context = new TravelAgencyDatabase();
			Tour element = context.Tours.FirstOrDefault(rec => rec.Id ==
		   model.Id);
			if (element != null)
			{
				context.Tours.Remove(element);
				context.SaveChanges();
			}
			else
			{
				throw new Exception("Элемент не найден");
			}
		}
		private static Tour CreateModel(TourBindingModel model, Tour tour)
		{
			tour.TourName = model.TourName;
			tour.TourPrice = model.TourPrice;
			return tour;
		}
		private static TourViewModel CreateModel(Tour tour)
		{
			return new TourViewModel
			{
				Id = tour.Id,
				TourName = tour.TourName,
				TourPrice = tour.TourPrice
			};
		}
	}
}

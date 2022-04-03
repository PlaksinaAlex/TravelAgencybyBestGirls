using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravelAgencyContracts.BindingModels;
using TravelAgencyContracts.StorageContracts;
using TravelAgencyContracts.ViewModels;
using TravelAgencyDatabaseImplement.Models;
using Microsoft.EntityFrameworkCore;

namespace TravelAgencyDatabaseImplement.Implements
{
	public class TripStorage :ITripStorage
	{
        public List<TripViewModel> GetFullList()
        {
            using var context = new TravelAgencyDatabase();
            return context.Trips
            .Include(rec => rec.TripTours)
            .ThenInclude(rec => rec.Tour)
            .Include(rec => rec.TripExpenses)
            .ThenInclude(rec => rec.Expense)
            .ToList()
            .Select(CreateModel)
            .ToList();
        }
        public List<TripViewModel> GetFilteredList(TripBindingModel model)
        {
            if (model == null)
            {
                return null;
            }
            using var context = new TravelAgencyDatabase();
            return context.Trips
           .Include(rec => rec.TripTours)
            .ThenInclude(rec => rec.Tour)
            .Include(rec => rec.TripExpenses)
            .ThenInclude(rec => rec.Expense)
            .Where(rec => rec.TripName.Contains(model.TripName))
            .Select(CreateModel)
            .ToList();
        }
        public TripViewModel GetElement(TripBindingModel model)
        {
            if (model == null)
            {
                return null;
            }
            using var context = new TravelAgencyDatabase();
            var trip = context.Trips
            .FirstOrDefault(rec => rec.TripName == model.TripName || rec.Id == model.Id);
            return trip != null ? CreateModel(trip) : null;
        }
        public void Insert(TripBindingModel model)
        {
            using var context = new TravelAgencyDatabase();
            using var transaction = context.Database.BeginTransaction();
            try
            {
                CreateModel(model, new Trip(), context);
                context.SaveChanges();
                transaction.Commit();
            }
            catch
            {
                transaction.Rollback();
                throw;
            }
        }
        public void Update(TripBindingModel model)
        {
            using var context = new TravelAgencyDatabase();
            using var transaction = context.Database.BeginTransaction();
            try
            {
                var element = context.Trips.FirstOrDefault(rec => rec.Id == model.Id);
                if (element == null)
                {
                    throw new Exception("Элемент не найден");
                }
                CreateModel(model, element, context);
                context.SaveChanges();
                transaction.Commit();
            }
            catch
            {
                transaction.Rollback();
                throw;
            }
        }
        public void Delete(TripBindingModel model)
        {
            using var context = new TravelAgencyDatabase();
            Trip element = context.Trips.FirstOrDefault(rec => rec.Id == model.Id);
            if (element != null)
            {
                context.Trips.Remove(element);
                context.SaveChanges();
            }
            else
            {
                throw new Exception("Элемент не найден");
            }
        }
        private static Trip CreateModel(TripBindingModel model, Trip trip, TravelAgencyDatabase context)
        {
            trip.TripName = model.TripName;
            trip.Price = model.Price;
            if (trip.Id == 0)
            {
                context.Trips.Add(trip);
                context.SaveChanges();
            }
            if (model.Id.HasValue)
            {
                var tripTours = context.TripTours.Where(rec =>
               rec.TripId == model.Id.Value).ToList();

                context.TripTours.RemoveRange(tripTours.Where(rec =>
               !model.TripTours.ContainsKey(rec.TourId)).ToList());
                context.SaveChanges();
                foreach (var updateTour in tripTours)
                {
                    updateTour.Count =
                   model.TripTours[updateTour.TourId].Item2;
                    model.TripTours.Remove(updateTour.TourId);
                }
                context.SaveChanges();
            }
            if (model.Id.HasValue)
            {
                var tripExpenses = context.TripExpenses.Where(rec =>
               rec.TripId == model.Id.Value).ToList();

                context.TripExpenses.RemoveRange(tripExpenses.Where(rec =>
               !model.TripExpenses.ContainsKey(rec.ExpenseId)).ToList());
                context.SaveChanges();
                foreach (var updateExpenses in tripExpenses)
                {
                    updateExpenses.Count =
                   model.TripExpenses[updateExpenses.ExpenseId].Item2;
                    model.TripExpenses.Remove(updateExpenses.ExpenseId);
                }
                context.SaveChanges();
            }
            foreach (var pc in model.TripTours)
            {
                context.TripTours.Add(new TripTour
                {
                    TripId = trip.Id,
                    TourId = pc.Key,
                    Count = pc.Value.Item2
                });
                context.SaveChanges();
            }
            foreach (var pc in model.TripExpenses)
            {
                context.TripExpenses.Add(new TripExpense
                {
                    TripId = trip.Id,
                    ExpenseId = pc.Key,
                    Count = pc.Value.Item2
                });
                context.SaveChanges();
            }
            return trip;
        }
        private static TripViewModel CreateModel(Trip trip)
        {
            using var context = new TravelAgencyDatabase();
            return new TripViewModel
            {
                Id = trip.Id,
                TripName = trip.TripName,
                Price = trip.Price,       
                TripTours = trip.TripTours.ToDictionary(recPC => recPC.TourId,
                recPC => (recPC.Tour?.TourName, recPC.Count)),
                TripExpenses = trip.TripExpenses.ToDictionary(recPC => recPC.ExpenseId,
                recPC => (recPC.Expense?.ExpenseName, recPC.Count))
            };
        }
    }
}

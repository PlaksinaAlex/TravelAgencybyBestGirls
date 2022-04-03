using System;
using TravelAgencyDatabaseImplement.Models;
using Microsoft.EntityFrameworkCore;

namespace TravelAgencyDatabaseImplement
{
	public class TravelAgencyDatabase : DbContext
	{
		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			if (optionsBuilder.IsConfigured == false)
			{
				optionsBuilder.UseSqlServer(@"Data Source= WIN-11H7FS8O71V\SQLEXPRESS;Initial Catalog=TravelAgencyDatabase;Integrated Security=True;MultipleActiveResultSets=True;");
			}
			base.OnConfiguring(optionsBuilder);
		}
		public virtual DbSet<Tour> Tours { set; get; }
		public virtual DbSet<Trip> Trips { set; get; }
		public virtual DbSet<TripTour> TripTours { set; get; }
		public virtual DbSet<TripExpense> TripExpenses { set; get; }
		public virtual DbSet<Expense> Expenses { set; get; }
		public virtual DbSet<Payment> Payments { set; get; }
		public virtual DbSet<Client> Clients { set; get; }
		public virtual DbSet<Worker> Workers { set; get; }

	}
}

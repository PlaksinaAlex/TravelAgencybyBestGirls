﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravelAgencyContracts.ViewModels;
using TravelAgencyContracts.BindingModels;

namespace TravelAgencyContracts.StorageContracts
{
	public interface ITripStorage
	{
        List<TripViewModel> GetFullList();

        List<TripViewModel> GetFilteredList(TripBindingModel model);

        TripViewModel GetElement(TripBindingModel model);

        void Insert(TripBindingModel model);

        void Update(TripBindingModel model);

        void Delete(TripBindingModel model);
    }
}

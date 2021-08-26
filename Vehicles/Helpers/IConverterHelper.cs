using System;
using System.Threading.Tasks;
using Vehicles.Data.Entities;
using Vehicles.Models;

namespace Vehicles.Helpers
{
    public interface IConverterHelper
    {
        Task<User> ToUserAsync(UserViewModel model, string path, bool isNew);

        UserViewModel ToUserViewModel(User user);

        Task<Vehicle> ToVehicleAsync(VehicleViewModel model, bool isNew);

        VehicleViewModel ToVehicleViewModel(Vehicle vehicle);

        Task<Detail> ToDetailAsync(DetailViewModel model, bool isNew);

        DetailViewModel ToDetailViewModel(Detail detail);
    }
}

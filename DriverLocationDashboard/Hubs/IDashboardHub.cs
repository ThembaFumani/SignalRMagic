using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DriverLocationDashboard
{
    public interface IDashboardHub
    {
        Task UpdateVehicleLocation(string vehicleId, double latitude, double longitude);
        Task<string> GetVehicleLocation(string vehicleId);
        Task SubscribeToVehicleUpdates(string vehicleId);
        Task UnsubscribeFromVehicleUpdates(string vehicleId);
    }
}
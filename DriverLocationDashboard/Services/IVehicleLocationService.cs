using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DriverLocationDashboard
{
    public interface IVehicleLocationService
    {
         void UpdateLocation(string vehicleId, double latitude, double longitude);
        VehicleLocation GetLocation(string vehicleId);
        void SubscribeToUpdates(string vehicleId, string connectionId);
        void UnsubscribeFromUpdates(string vehicleId, string connectionId);
        void SetOwner(string vehicleId, string ownerConnectionId);
        string GetOwnerConnectionId(string vehicleId);
        void NotifySubscribers(string vehicleId, double latitude, double longitude);
    }
}
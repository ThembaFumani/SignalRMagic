namespace DriverLocationDashboard
{
    using Microsoft.AspNet.SignalR;

    public class DashboardHub : Hub<IDashboardHub>
    {
        public Task<string> GetVehicleLocation(string vehicleId)
        {
            throw new NotImplementedException();
        }

        public Task SubscribeToVehicleUpdates(string vehicleId)
        {
            throw new NotImplementedException();
        }

        public Task UnsubscribeFromVehicleUpdates(string vehicleId)
        {
            throw new NotImplementedException();
        }

        public Task UpdateVehicleLocation(string vehicleId, double latitude, double longitude)
        {
            throw new NotImplementedException();
        }
    }
}
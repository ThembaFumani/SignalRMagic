namespace DriverLocationDashboard
{
    using System.Collections.Generic;

    public class VehicleLocationService : IVehicleLocationService
    {
        private readonly Dictionary<string, VehicleLocation>? _vehicleLocations;
        private readonly Dictionary<string, List<string>>? _vehicleSubscribers;
        private readonly Dictionary<string, string>? _vehicleOwners;
        private readonly InMemoryDataProvider? _dataProvider;

        public VehicleLocationService(InMemoryDataProvider dataProvider)
        {
            _vehicleLocations = new Dictionary<string, VehicleLocation>();
            _vehicleSubscribers = new Dictionary<string, List<string>>();
            _vehicleOwners = new Dictionary<string, string>();
            _dataProvider = dataProvider;
        }

         public void UpdateLocation(string vehicleId, double latitude, double longitude)
        {
            _vehicleLocations[vehicleId] = new VehicleLocation { Latitude = latitude, Longitude = longitude };
        }

        public VehicleLocation GetLocation(string vehicleId)
        {
            return _vehicleLocations.TryGetValue(vehicleId, out var location) ? location : null;
        }

        public void SubscribeToUpdates(string vehicleId, string connectionId)
        {
            if (!_vehicleSubscribers.ContainsKey(vehicleId))
            {
                _vehicleSubscribers[vehicleId] = new List<string>();
            }

            _vehicleSubscribers[vehicleId].Add(connectionId);
        }

        public void UnsubscribeFromUpdates(string vehicleId, string connectionId)
        {
            if (_vehicleSubscribers.ContainsKey(vehicleId))
            {
                _vehicleSubscribers[vehicleId].Remove(connectionId);
            }
        }

        public void SetOwner(string vehicleId, string ownerConnectionId)
        {
            _vehicleOwners[vehicleId] = ownerConnectionId;
        }

        public string GetOwnerConnectionId(string vehicleId)
        {
            return _vehicleOwners.TryGetValue(vehicleId, out var ownerConnectionId) ? ownerConnectionId : null;
        }

        public void NotifySubscribers(string vehicleId, double latitude, double longitude)
        {
            if (_vehicleSubscribers.TryGetValue(vehicleId, out var subscribers))
            {
                foreach (var subscriber in subscribers)
                {
                    // Send the location update to each subscriber
                }
            }
        }
    }
}
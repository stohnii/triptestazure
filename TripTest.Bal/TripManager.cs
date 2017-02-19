using System.Collections.Generic;
using TestTrip.Models;
using TripTest.Bal.Arstract;
using TripTest.Dal.Abstract;

namespace TripTest.Bal
{
    public class TripManager : ITripManager
    {
        private readonly ITripRepository _tripRepository;

        public TripManager(ITripRepository tripRepository)
        {
            _tripRepository = tripRepository;
        }

        public int AddTrip(Trip newTrip)
        {
            return _tripRepository.AddTrip(newTrip);
        }

        public bool DeleteTrip(int tripId)
        {
            return _tripRepository.DeleteTrip(tripId);
        }

        public bool EditTrip(Trip updatedTrip)
        {
            return _tripRepository.EditTrip(updatedTrip);
        }

        public Trip GetTrip(int tripId)
        {
            return _tripRepository.GetTrip(tripId);
        }

        public List<Trip> GetTrips(string owner = null)
        {
            return _tripRepository.GetTrips(owner);
        }
    }
}

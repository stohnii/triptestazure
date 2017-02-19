using System.Collections.Generic;
using TestTrip.Models;

namespace TripTest.Dal.Abstract
{
    public interface ITripRepository
    {
        Trip GetTrip(int tripId);

        List<Trip> GetTrips(string owner);

        int AddTrip(Trip newTrip);

        bool EditTrip(Trip updatedTrip);

        bool DeleteTrip(int tripId);
    }
}

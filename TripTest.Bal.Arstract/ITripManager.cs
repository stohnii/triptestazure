using System.Collections.Generic;
using TestTrip.Models;

namespace TripTest.Bal.Arstract
{
    public interface ITripManager
    {
        Trip GetTrip(int tripId);

        List<Trip> GetTrips(string owner = null);

        int AddTrip(Trip newTrip);

        bool EditTrip(Trip updatedTrip);

        bool DeleteTrip(int tripId);
    }
}

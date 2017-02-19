using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using TestTrip.Models;
using TripTest.Dal.Abstract;

namespace TripTest.Dal
{
    public class TripRepository : ITripRepository
    {
        private TripContext _context;

        public int AddTrip(Trip newTrip)
        {
            int newId;

            using (_context = new TripContext())
            {
                var result = _context.Trips.Add(newTrip);
                _context.SaveChanges();
                newId = result.Id;
            }

            return newId;
        }

        public bool DeleteTrip(int tripId)
        {
            bool result = false;

            using (_context = new TripContext())
            {
                try
                {
                    var tripToDelete = _context.Trips.FirstOrDefault(t => t.Id == tripId);

                    if (tripToDelete != null)
                    {
                        _context.Trips.Remove(tripToDelete);
                        _context.SaveChanges();
                    }

                    result = true;
                }
                catch (Exception)
                {
                    throw;
                }
            }

            return result;
        }

        public bool EditTrip(Trip updatedTrip)
        {
            var result = false;

            using (_context = new TripContext())
            {
                try
                {
                    _context.Trips.Attach(updatedTrip);
                    _context.Entry(updatedTrip).State = EntityState.Modified;
                    _context.SaveChanges();
                    result = true;
                }
                catch (Exception)
                {
                    throw;
                };
            }

            return result;
        }

        public Trip GetTrip(int tripId)
        {
            using (_context = new TripContext())
            {
                var trip = _context.Trips.First(t => t.Id == tripId);
                return trip;
            }
        }

        public List<Trip> GetTrips(string owner)
        {
            using (_context = new TripContext())
            {
                var trips = _context.Trips.Where(t => String.IsNullOrEmpty(owner) || t.Owner.Equals(owner)).ToList();
                return trips;
            }
        }
    }
}

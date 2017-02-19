using System;

namespace TestTrip.Models
{
    public class Trip
    {
        public int Id { get; set; }
        public string Owner { get; set; }
        public string TripName { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public string Comment { get; set; }
    }
}

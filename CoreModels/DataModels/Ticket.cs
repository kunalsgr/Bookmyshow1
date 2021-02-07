using System;
using System.Collections.Generic;
using System.Text;

namespace CoreModels.DataModels
{
   public class Ticket
    {
        public int Id { get; set; }
        public string SeatNumber { get; set; }
        public string ShowId { get; set; }
        public string UserId { get; set; }
        public string AmountPaid { get; set; }
        // public int Quantity { get; set; }

        public string ShowLocation { get; set; }
        public string Booked { get; set; }
        public DateTime CreatedOn { get; set; }
    }
}

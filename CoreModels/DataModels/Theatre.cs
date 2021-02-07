using System;
using System.Collections.Generic;
using System.Text;

namespace CoreModels.DataModels
{
   public class Theatre
    {
        public int Id { get; set; }
        public string TheatreName { get; set; }
        public string TheatreAddress { get; set; }
        public string Category { get; set; }
        public int FrontRowSeatsPrice { get; set; }
        public int MiddleRowSeatsPrice { get; set; }
        public int LastRowSeatsPrice { get; set; }
        public int TotalNumberOfSeats { get; set; }
        public int FrontRowLastSeat { get; set; }
        public int MiddleRowLastSeat { get; set; }
        public int LastRowLastSeat { get; set; }


    }
}

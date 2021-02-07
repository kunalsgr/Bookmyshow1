using System;
using System.Collections.Generic;
using System.Text;

namespace CoreModels.CoreModels
{
   public class Show
    {
        public int Id { get; set; }
        public int ShowId { get; set; }
        public int ShowCost { get; set; }
        public DateTime ShowDate { get; set; }
        public int ShowHallId { get; set; }
        public TimeSpan ShowTime { get; set; }
    }
}

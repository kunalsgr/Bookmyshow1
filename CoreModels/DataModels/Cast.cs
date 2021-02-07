using System;
using System.Collections.Generic;
using System.Text;

namespace CoreModels.CoreModels
{
   public class Cast
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string ProfilePicUrl { get; set; }
        public int Gender { get; set; }
        public int Role { get; set; }
        public int MovieId { get; set; }
    }
}

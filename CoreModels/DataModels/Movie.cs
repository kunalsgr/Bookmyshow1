using System;
using System.Collections.Generic;
using System.Text;

namespace CoreModels.CoreModels
{
   public class Movie
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public string MoviePosterUrl { get; set; }

        public int Language { get; set; }
        public int Genere { get; set; }
        public int MovieType { get; set; }
        public int CertificateType { get; set; }
        public string Description { get; set; }
        public double MovieLength { get; set; }
        public DateTime? ReleaseDate { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ASM.Models
{
    public class ListMovieOutputModel
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Des { get; set; }
        public string ReleaseDate { get; set; }
        public int Rating { get; set; }
        public string Image { get; set; }
        public string Lenght { get; set; }
    }
}
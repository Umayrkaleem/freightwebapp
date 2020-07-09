using System;
using System.ComponentModel.DataAnnotations;

namespace freightWebApp.Models
{
    public class Movie
    {
        public int ID { get; set; }
        public string Title { get; set; }

        [DataType(DataType.Date)]
        public DateTime Date { get; set; }
        public string Commodity { get; set; }
        public decimal Linehaul { get; set; }
    }
}
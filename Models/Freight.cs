using System;
using System.ComponentModel.DataAnnotations;

namespace freightWebApp.Models
{
    public class Freight
    {
        public int ID { get; set; }
        
        [Display(Name = "Broker Name")]
        public string BrokerName { get; set; }

        [DataType(DataType.Date)]
        public DateTime Date { get; set; }
        public string Commodity { get; set; }
        public decimal Linehaul { get; set; }
    }
}
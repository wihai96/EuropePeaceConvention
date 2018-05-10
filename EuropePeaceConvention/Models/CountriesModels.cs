using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EuropePeaceConvention.Models
{
    public class CountriesModels
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ISO3 { get; set; }
        public int Population { get; set; }
        public float Area { get; set; }
        public string HourHashCode { get; set; }
    }
}
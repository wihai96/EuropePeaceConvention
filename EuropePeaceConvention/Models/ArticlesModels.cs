using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EuropePeaceConvention.Models
{
    public class ArticlesModels
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string User { get; set; }
        public DateTime PostDate { get; set; }
        public string Content { get; set; }
    }
}
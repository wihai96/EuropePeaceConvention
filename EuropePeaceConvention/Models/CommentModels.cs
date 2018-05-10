using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EuropePeaceConvention.Models
{
    public class CommentModels
    {
        public int Id { get; set; }
        public int ArticleId { get; set; }
        public string User { get; set; }
        public DateTime PostDate { get; set; }
        public string Content { get; set; }
    }
}
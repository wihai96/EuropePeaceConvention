using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EuropePeaceConvention.Models
{
    public class ArticleDetailsViewModels
    {
        public IEnumerable<CommentModels> Comment { get; set; }
        public ArticlesModels Article { get; set; }
    }
}
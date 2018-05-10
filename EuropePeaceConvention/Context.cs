using EuropePeaceConvention.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace EuropePeaceConvention
{
    public class Context : DbContext
    {
        public DbSet<CountriesModels> CountriesModels { get; set; }
        public DbSet<ArticlesModels> ArticlesModels { get; set; }
        public DbSet<CommentModels> CommentModels { get; set; }
    }
}
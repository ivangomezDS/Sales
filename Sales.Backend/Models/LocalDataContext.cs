using Sale.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Sales.Backend.Models
{
    public class LocalDataContext:DataContext
    {
        public System.Data.Entity.DbSet<Sales.Common.Models.Products> Products { get; set; }
    }
}
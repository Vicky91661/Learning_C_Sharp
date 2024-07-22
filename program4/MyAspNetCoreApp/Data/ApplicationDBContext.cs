using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MyAspNetCoreApp.Models;

namespace MyAspNetCoreApp.Data
{
    public class ApplicationDBContext:DbContext
    {
        public ApplicationDBContext(DbContextOptions dbContextOptions) :base(dbContextOptions)// ShortCut = ctor
        {
            
        }

        public DbSet<Stock> Stocks{get;set;}
        public DbSet<Comment> Comments {get;set;}
  }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MvcMovie.Models;

namespace MyWebApplication1_.Data
{
    public class MyWebApplication1_Context : DbContext
    {
        public MyWebApplication1_Context (DbContextOptions<MyWebApplication1_Context> options)
            : base(options)
        {
        }

        public DbSet<MvcMovie.Models.Movie>? Movie { get; set; }
    }
}

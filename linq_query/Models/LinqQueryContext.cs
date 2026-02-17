using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace linq_query.Models
{
    public class LinqQueryContext:DbContext
    {
        public LinqQueryContext(DbContextOptions<LinqQueryContext> options) : base(options)
        {
            
        }
        public DbSet<Employees> Employee { get; set; }=null!;
    }
}
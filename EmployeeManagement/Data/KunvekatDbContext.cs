using EmployeeManagement.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagement.Data
{
    public class KunvekatDbContext : DbContext
    {
        public KunvekatDbContext(DbContextOptions<KunvekatDbContext> options)
        : base(options)
        {
        }

        public DbSet <Employee> employees { get; set; }
    }
}

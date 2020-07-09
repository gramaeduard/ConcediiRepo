using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Concedii.Models
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> options)
        : base(options)
        { }

        public DbSet<Cerere> Cereri { get; set; }
        public DbSet<Concediu> Concedii { get; set; }
        public DbSet<Departament> Departamente { get; set; }
        public DbSet<Personal> Personal { get; set; }
        public DbSet<Status> Status { get; set; }

    }
}

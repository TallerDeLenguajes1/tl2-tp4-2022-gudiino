using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MvcCadeteria.Models;

    public class MvcCadeteriaContext : DbContext
    {
        public MvcCadeteriaContext (DbContextOptions<MvcCadeteriaContext> options)
            : base(options)
        {
        }

        public DbSet<MvcCadeteria.Models.Cadete> Cadete { get; set; } = default!;
    }

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Tankdaten.Models;

namespace Tankdaten.Data
{
    public class TankdatenContext : DbContext
    {
        public TankdatenContext (DbContextOptions<TankdatenContext> options)
            : base(options)
        {
        }

        public DbSet<Tankdaten.Models.TankdatenViewModel> TankdatenViewModel { get; set; } = default!;
    }
}

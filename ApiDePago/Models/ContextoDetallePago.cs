using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiDePago.Models
{
    public class ContextoDetallePago : DbContext
    {
        public ContextoDetallePago(DbContextOptions<ContextoDetallePago> options):base(options)
        {

        }

        public DbSet<DetalleDePago> detalleDePagos { get; set; }
    }
}

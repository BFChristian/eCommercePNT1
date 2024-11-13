using eCommerce.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace eCommerce.Context
{
    public class eCommerceDatabaseContext : DbContext
    {
        public eCommerceDatabaseContext(DbContextOptions<eCommerceDatabaseContext> options) : base(options)
        {
        }

        public DbSet<Producto> Productos { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Compra> Compras { get; set; }
    }
}

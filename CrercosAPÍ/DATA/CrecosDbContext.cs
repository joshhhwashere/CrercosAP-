using CrercosAPÍ.MODELS;
using Microsoft.EntityFrameworkCore;

namespace CrercosAPÍ.DATA
{
    public class CrecosDbContext : DbContext //Heredamos la propiedad DbContext
    {
        public CrecosDbContext(DbContextOptions<CrecosDbContext> options)
            :base (options)
        {
            
        }
        public DbSet<Cliente> Clientes { get; set; } //DbSet son las tablas
        public DbSet<Pedido> Pedidos { get; set; }
        public DbSet<PedidoDetalle> PedidoDetalles { get; set; }
       public DbSet<Producto> Productos { get; set; }
    }
}

using ControleDeCaixa.Model;
using Microsoft.EntityFrameworkCore;

namespace ControleDeCaixa.Infra
{
    public class ConnectionContext : DbContext
    {
        public ConnectionContext(DbContextOptions<ConnectionContext> options) : base(options)
        {
        }

        public DbSet<Caixa> Caixa { get; set; }
        public DbSet<Transacoes> Transacao { get; set; }
    }
}

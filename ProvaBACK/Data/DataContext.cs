using ProvaBACK.Models;
using Microsoft.EntityFrameworkCore;

namespace ProvaBACK.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<FormasPagamento> FormasPagamentos { get; set; }
        public DbSet<InicializarDados> InicializarDados { get; set; }
        public DbSet<ItemVenda> ItensVenda { get; set; }
        public DbSet<Produto> Produtos { get; set; }
    }
}

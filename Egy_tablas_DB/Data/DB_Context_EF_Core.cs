using Egy_tablas_DB.Model;
using Microsoft.EntityFrameworkCore;

namespace Egy_tablas_DB.Data
{
    public class DB_Context_EF_Core : DbContext
    {
        public DB_Context_EF_Core(DbContextOptions<DB_Context_EF_Core> options) : base(options) { }
        public DbSet<Product> Products { get; set; } = default;
    }
}

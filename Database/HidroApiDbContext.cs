using Database;
using Microsoft.EntityFrameworkCore;

namespace Database
{
    /// <summary>
    /// This class handles the sqlite database
    /// </summary>
    public class HidroApiDbContext : DbContext
    {
        /// <summary>
        /// This property allows to manipoulate the video games table
        /// </summary>
        public DbSet<Usuario> Usuario { get; set; }
        public DbSet<Producto> Producto { get; set; }
        public DbSet<Verdura> Verdura { get; set; }
        public DbSet<TipoDocumento> TipoDocumento { get; set; }
    }
}
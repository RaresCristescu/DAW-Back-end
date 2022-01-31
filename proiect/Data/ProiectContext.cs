using Microsoft.EntityFrameworkCore;
using proiect.Models;

namespace proiect.Data
{
    public class ProiectContext:DbContext
    {
        
        public DbSet<User> Users { get; set; }
        public DbSet<Address> Addresses { get; set; }
        public DbSet<Categorie> Categories { get; set; }
        public DbSet<Comanda> Comandas { get; set; }
        public DbSet<DetaliiComanda> DetaliiComandas { get; set; }
        public DbSet<Produs> Produss { get; set; }


        public ProiectContext(DbContextOptions<ProiectContext>options):base(options)
        {

        }


        protected override void OnModelCreating(ModelBuilder builder)
        {
           
            //Baza de date
            //////////////////////////////////////////////////////////////////////////////////
            builder.Entity<Address>()
                .HasMany(c => c.Users)
                .WithOne(e => e.Address);
            builder.Entity<User>()
                .HasMany(c => c.Comandas)
                .WithOne(e => e.User);

            builder.Entity<DetaliiComanda>().HasKey(mr => new { mr.ComandaId, mr.ProdusId });
            builder.Entity<DetaliiComanda>()
                .HasOne<Comanda>(x => x.Comanda)
                .WithMany(y => y.DetaliiComandas)
                .HasForeignKey(z => z.ComandaId);
            builder.Entity<DetaliiComanda>()
                .HasOne<Produs>(x => x.Produs)
                .WithMany(y => y.DetaliiComandas)
                .HasForeignKey(z => z.ProdusId);

            builder.Entity<Categorie>()
                .HasMany(c => c.Produss)
                .WithOne(e => e.Categorie);
            //
            base.OnModelCreating(builder);
        }
    }
}

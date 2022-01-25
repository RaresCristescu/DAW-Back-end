using Microsoft.EntityFrameworkCore;
using proiect.Models;

namespace proiect.Data
{
    public class ProiectContext:DbContext
    {
        //public DbSet<Model1> Models1 { get; set; }
        //public DbSet<Model2> Models2 { get; set; }
        //public DbSet<Model3> Models3 { get; set; }
        //public DbSet<Model4> Models4 { get; set; }
        //public DbSet<ModelsRelation> ModelsRelations { get; set; }
        //public DbSet<Model5> Models5 { get; set; }
        //public DbSet<Model6> Models6 { get; set; }
        public DbSet<Student> Students { get; set; }
        /// <summary>
        /// ///////////////////////////////////////////////////
        /// </summary>
        public DbSet<User> Users { get; set; }
        public DbSet<Address> Addresses { get; set; }
        public DbSet<Categorie> Categories { get; set; }
        public DbSet<Comanda> Comandas { get; set; }
        public DbSet<DetaliiComanda> DetaliiComandas { get; set; }
        public DbSet<Produs> Produss { get; set; }


        public ProiectContext(DbContextOptions<ProiectContext>options):base(options)
        {

        }
        //public DbSet<DataBaseModel> DataBaseModels { get; set; }




        protected override void OnModelCreating(ModelBuilder builder)
        {
            //One To Many
            //builder.Entity<Model1>()
            //    .HasMany(c => c.Models2)
            //    .WithOne(e => e.Model1);
            ///* builder.Entity<Model2>()
            //     .HasOne(c => c.Model1)
            //     .WithMany(e => e.Models2);*/
            ////Many to Many

            //builder.Entity<ModelsRelation>().HasKey(mr => new { mr.Model3Id, mr.Model4Id });

            //builder.Entity<ModelsRelation>()
            //    .HasOne<Model3>(x => x.Model3)
            //    .WithMany(y => y.ModelRelations)
            //    .HasForeignKey(z => z.Model3Id);
            //builder.Entity<ModelsRelation>()
            //    .HasOne<Model4>(x => x.Model4)
            //    .WithMany(y => y.ModelRelations)
            //    .HasForeignKey(z => z.Model4Id);

            ////One to One
            //builder.Entity<Model5>()
            //    .HasOne(a => a.Model6)
            //    .WithOne(b => b.Model5)
            //    .HasForeignKey<Model6>(h => h.Model5Id);
            

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

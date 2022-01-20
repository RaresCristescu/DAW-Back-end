using Microsoft.EntityFrameworkCore;
using proiect.Models.Relations.ManyToMany;
using proiect.Models.Relations.OneToMany;
using proiect.Models.Relations.OneToOne;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace proiect.Models
{
    public class ProiectContext:DbContext
    {
        public ProiectContext(DbContextOptions<ProiectContext>options):base(options)
        {

        }
        public DbSet<DataBaseModel> DataBaseModels { get; set; }

        //One To Many
        public DbSet<Model1> Models1 { get; set; }
        public DbSet<Model2> Models2 { get; set; }
        public DbSet<Model3> Models3 { get; set; }
        public DbSet<Model4> Models4 { get; set; }
        public DbSet<ModelsRelation> ModelsRelations { get; set; }
        public DbSet<Model5> Models5 { get; set; }
        public DbSet<Model6> Models6 { get; set; }


        protected override void OnModelCreating(ModelBuilder builder)
        {
            //One To Many
            builder.Entity<Model1>()
                .HasMany(c => c.Models2)
                .WithOne(e => e.Model1);
            /* builder.Entity<Model2>()
                 .HasOne(c => c.Model1)
                 .WithMany(e => e.Models2);*/
            //Many to Many
            builder.Entity<ModelsRelation>().HasKey(mr => new { mr.Model3Id, mr.Model4Id });

            builder.Entity<ModelsRelation>()
                .HasOne<Model3>(x => x.Model3)
                .WithMany(y => y.ModelRelations)
                .HasForeignKey(z => z.Model3Id);
            builder.Entity<ModelsRelation>()
                .HasOne<Model4>(x => x.Model4)
                .WithMany(y => y.ModelRelations)
                .HasForeignKey(z => z.Model4Id);

            //One to One
            builder.Entity<Model5>()
                .HasOne(a => a.Model6)
                .WithOne(b => b.Model5)
                .HasForeignKey<Model6>(h => h.Model5Id);
        }
    }
}

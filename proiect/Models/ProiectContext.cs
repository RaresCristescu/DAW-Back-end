using Microsoft.EntityFrameworkCore;
using proiect.Models.Relations.OneToMany;
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

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Model1>()
                .HasMany(c => c.Models2)
                .WithOne(e => e.Model1);
           /* builder.Entity<Model2>()
                .HasOne(c => c.Model1)
                .WithMany(e => e.Models2);*/

        }
    }
}

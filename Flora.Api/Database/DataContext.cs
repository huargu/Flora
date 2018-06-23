using Flora.Api.Models;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Flora.Api.Data
{
    public class DataContext : DbContext
    {
        Specification[] specifications = new []
        {
            new Specification { SpecificationId = 2, Name = "Dikenli" },
            new Specification { SpecificationId = 1, Name = "Çiçekli" },
            new Specification { SpecificationId = 3, Name = "Yapraklı" }
        };

        Material[] materials = new []
        {
            new Material { MaterialId = 1, Name = "Gül" },
            new Material { MaterialId = 2, Name = "Papatya" },
            new Material { MaterialId = 3, Name = "Orkide" },
            new Material { MaterialId = 4, Name = "Süslemeler" }
        };

        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<MaterialSpecification>()
                .HasKey(t => new { t.MaterialId, t.SpecificationId });
            
            modelBuilder.Entity<Material>()
                .HasKey(m => m.MaterialId);
            
            modelBuilder.Entity<Specification>()
                .HasKey(s => s.SpecificationId);
            
            modelBuilder.Entity<MaterialSpecification>()
                .HasOne(ms => ms.Material)
                .WithMany(m => m.MaterialSpecifications)
                .HasForeignKey(ms => ms.MaterialId);

            modelBuilder.Entity<MaterialSpecification>()
                .HasOne(ms => ms.Specification)
                .WithMany(m => m.MaterialSpecifications)
                .HasForeignKey(ms => ms.SpecificationId);
            
            modelBuilder.Entity<Material>()
                .HasData(materials);
            
            modelBuilder.Entity<Specification>()
                .HasData(specifications);
            
            modelBuilder.Entity<MaterialSpecification>()
                .HasData(
                    new MaterialSpecification[] {
                        new MaterialSpecification { MaterialId = materials[0].MaterialId, SpecificationId = specifications[0].SpecificationId},
                        new MaterialSpecification { MaterialId = materials[0].MaterialId, SpecificationId = specifications[1].SpecificationId},
                        new MaterialSpecification { MaterialId = materials[0].MaterialId, SpecificationId = specifications[2].SpecificationId},
                        new MaterialSpecification { MaterialId = materials[1].MaterialId, SpecificationId = specifications[0].SpecificationId},
                        new MaterialSpecification { MaterialId = materials[1].MaterialId, SpecificationId = specifications[2].SpecificationId},
                        new MaterialSpecification { MaterialId = materials[2].MaterialId, SpecificationId = specifications[0].SpecificationId},
                        new MaterialSpecification { MaterialId = materials[3].MaterialId, SpecificationId = specifications[2].SpecificationId}
                    }
                );
        }
        public DbSet<Material> Materials { get; set; }
        public DbSet<Specification> Specifications { get; set; }
    }
}
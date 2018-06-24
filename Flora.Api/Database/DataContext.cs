using Flora.Api.Models;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Flora.Api.Data
{
    public class DataContext : DbContext
    {
        Specification[] specifications = new []
        {
            new Specification { SpecificationId = 1, Name = "Çiçekli" },
            new Specification { SpecificationId = 2, Name = "Dikenli" },
            new Specification { SpecificationId = 3, Name = "Yapraklı" }
        };

        Material[] materials = new []
        {
            new Material { MaterialId = 1, Name = "Gül" },
            new Material { MaterialId = 2, Name = "Papatya" },
            new Material { MaterialId = 3, Name = "Orkide" },
            new Material { MaterialId = 4, Name = "Süslemeler" }
        };

        Bouquet[] bouquets = new []
        {
            new Bouquet { BouquetId = 1, Name = "Gül Bahçesi" },
            new Bouquet { BouquetId = 2, Name = "Gelinlikli Güller" },
            new Bouquet { BouquetId = 3, Name = "Orkide" }
        };
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            /* Primary Keys */
            modelBuilder.Entity<MaterialSpecification>()
                .HasKey(t => new { t.MaterialId, t.SpecificationId });
            
            modelBuilder.Entity<Material>()
                .HasKey(m => m.MaterialId);
            
            modelBuilder.Entity<Specification>()
                .HasKey(s => s.SpecificationId);

            modelBuilder.Entity<Bouquet>()
                .HasKey(b => b.BouquetId);
            
            modelBuilder.Entity<BouquetDetail>()
                .HasKey(b => b.DetailId);
            
            modelBuilder.Entity<Arrangement>()
                .HasKey(a => a.ArrangmentId);
            
            /* Foreign Keys */
            modelBuilder.Entity<MaterialSpecification>()
                .HasOne(ms => ms.Material)
                .WithMany(m => m.MaterialSpecifications)
                .HasForeignKey(ms => ms.MaterialId);
            
            modelBuilder.Entity<BouquetDetail>()
                .HasOne(b => b.Bouquet)
                .WithMany(d => d.BouquetTypes)
                .HasForeignKey(b => b.BouquetId);
            
            modelBuilder.Entity<Arrangement>()
                .HasOne(d => d.BouquetDetail)
                .WithMany(b => b.Materials)
                .HasForeignKey(d => d.BouquetDetailId);
            /*
            modelBuilder.Entity<Arrangement>()
                .HasOne(d => d.Material)
                .WithMany(m => m.Arrangments)
                .HasForeignKey(d => d.MaterialId);
            */
            /* Seeding Data */
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
            
            modelBuilder.Entity<Bouquet>()
                .HasData(bouquets);
            
            modelBuilder.Entity<BouquetDetail>()
                .HasData(
                    new BouquetDetail[] {
                        new BouquetDetail { DetailId = 1, Size = "S", Price = 10, BouquetId = bouquets[0].BouquetId },
                        new BouquetDetail { DetailId = 2, Size = "M", Price = 15, BouquetId = bouquets[0].BouquetId },
                        new BouquetDetail { DetailId = 3, Size = "L", Price = 20, BouquetId = bouquets[0].BouquetId },
                        new BouquetDetail { DetailId = 4, Size = "S", Price = 12, BouquetId = bouquets[1].BouquetId },
                        new BouquetDetail { DetailId = 5, Size = "M", Price = 16, BouquetId = bouquets[1].BouquetId },
                        new BouquetDetail { DetailId = 6, Size = "L", Price = 20, BouquetId = bouquets[1].BouquetId },
                        new BouquetDetail { DetailId = 7, Size = "S", Price = 20, BouquetId = bouquets[2].BouquetId },
                        new BouquetDetail { DetailId = 8, Size = "M", Price = 25, BouquetId = bouquets[2].BouquetId },
                        new BouquetDetail { DetailId = 9, Size = "L", Price = 30, BouquetId = bouquets[2].BouquetId }
                    }
                );
            
            modelBuilder.Entity<Arrangement>()
                .HasData(
                    new Arrangement[] {
                        new Arrangement { ArrangmentId = 1, MaterialId = materials[0].MaterialId, MaterialCount = 10, BouquetDetailId = 1 },
                        new Arrangement { ArrangmentId = 2, MaterialId = materials[3].MaterialId, MaterialCount = 1, BouquetDetailId = 1 },
                        new Arrangement { ArrangmentId = 3, MaterialId = materials[0].MaterialId, MaterialCount = 25, BouquetDetailId = 2 },
                        new Arrangement { ArrangmentId = 4, MaterialId = materials[3].MaterialId, MaterialCount = 1, BouquetDetailId = 2 },
                        new Arrangement { ArrangmentId = 5, MaterialId = materials[0].MaterialId, MaterialCount = 50, BouquetDetailId = 3 },
                        new Arrangement { ArrangmentId = 6, MaterialId = materials[3].MaterialId, MaterialCount = 1, BouquetDetailId = 3 },
                        new Arrangement { ArrangmentId = 7, MaterialId = materials[0].MaterialId, MaterialCount = 5, BouquetDetailId = 4 },
                        new Arrangement { ArrangmentId = 8, MaterialId = materials[1].MaterialId, MaterialCount = 20, BouquetDetailId = 4 },
                        new Arrangement { ArrangmentId = 9, MaterialId = materials[3].MaterialId, MaterialCount = 1, BouquetDetailId = 4 },
                        new Arrangement { ArrangmentId = 10, MaterialId = materials[0].MaterialId, MaterialCount = 7, BouquetDetailId = 5 },
                        new Arrangement { ArrangmentId = 11, MaterialId = materials[1].MaterialId, MaterialCount = 20, BouquetDetailId = 5 },
                        new Arrangement { ArrangmentId = 12, MaterialId = materials[3].MaterialId, MaterialCount = 1, BouquetDetailId = 5 },
                        new Arrangement { ArrangmentId = 13, MaterialId = materials[0].MaterialId, MaterialCount = 10, BouquetDetailId = 6 },
                        new Arrangement { ArrangmentId = 14, MaterialId = materials[1].MaterialId, MaterialCount = 20, BouquetDetailId = 6 },
                        new Arrangement { ArrangmentId = 15, MaterialId = materials[3].MaterialId, MaterialCount = 1, BouquetDetailId = 6 },
                        new Arrangement { ArrangmentId = 16, MaterialId = materials[2].MaterialId, MaterialCount = 1, BouquetDetailId = 7 },
                        new Arrangement { ArrangmentId = 17, MaterialId = materials[2].MaterialId, MaterialCount = 2, BouquetDetailId = 8 },
                        new Arrangement { ArrangmentId = 18, MaterialId = materials[2].MaterialId, MaterialCount = 5, BouquetDetailId = 9 }
                    }
                );
        }
        public DbSet<Material> Materials { get; set; }
        public DbSet<Specification> Specifications { get; set; }
        public DbSet<Bouquet> Bouquet { get; set; }
    }
}
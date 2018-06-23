﻿// <auto-generated />
using Flora.Api.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Flora.Api.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20180623192320_MaterialSpecification")]
    partial class MaterialSpecification
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.0-rtm-30799");

            modelBuilder.Entity("Flora.Api.Models.Material", b =>
                {
                    b.Property<int>("MaterialId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.HasKey("MaterialId");

                    b.ToTable("Materials");

                    b.HasData(
                        new { MaterialId = 1, Name = "Gül" },
                        new { MaterialId = 2, Name = "Papatya" },
                        new { MaterialId = 3, Name = "Orkide" },
                        new { MaterialId = 4, Name = "Süslemeler" }
                    );
                });

            modelBuilder.Entity("Flora.Api.Models.MaterialSpecification", b =>
                {
                    b.Property<int>("MaterialId");

                    b.Property<int>("SpecificationId");

                    b.HasKey("MaterialId", "SpecificationId");

                    b.HasIndex("SpecificationId");

                    b.ToTable("MaterialSpecification");

                    b.HasData(
                        new { MaterialId = 1, SpecificationId = 2 },
                        new { MaterialId = 1, SpecificationId = 1 },
                        new { MaterialId = 1, SpecificationId = 3 },
                        new { MaterialId = 2, SpecificationId = 2 },
                        new { MaterialId = 2, SpecificationId = 3 },
                        new { MaterialId = 3, SpecificationId = 2 },
                        new { MaterialId = 4, SpecificationId = 3 }
                    );
                });

            modelBuilder.Entity("Flora.Api.Models.Specification", b =>
                {
                    b.Property<int>("SpecificationId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.HasKey("SpecificationId");

                    b.ToTable("Specifications");

                    b.HasData(
                        new { SpecificationId = 2, Name = "Dikenli" },
                        new { SpecificationId = 1, Name = "Çiçekli" },
                        new { SpecificationId = 3, Name = "Yapraklı" }
                    );
                });

            modelBuilder.Entity("Flora.Api.Models.MaterialSpecification", b =>
                {
                    b.HasOne("Flora.Api.Models.Material", "Material")
                        .WithMany("MaterialSpecifications")
                        .HasForeignKey("MaterialId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Flora.Api.Models.Specification", "Specification")
                        .WithMany("MaterialSpecifications")
                        .HasForeignKey("SpecificationId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
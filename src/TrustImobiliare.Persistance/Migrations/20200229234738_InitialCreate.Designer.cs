﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TrustImobiliare.Persistance;

namespace TrustImobiliare.Persistance.Migrations
{
    [DbContext(typeof(TrustImobiliareDbContext))]
    [Migration("20200229234738_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("TrustImobiliare.Domain.Entities.Address", b =>
                {
                    b.Property<int>("AddressId")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("AddressID")
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AddressDetail")
                        .IsRequired()
                        .HasColumnType("nvarchar(60)")
                        .HasMaxLength(60);

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("nvarchar(20)")
                        .HasMaxLength(20);

                    b.Property<string>("Country")
                        .HasColumnType("nvarchar(15)")
                        .HasMaxLength(15);

                    b.Property<string>("Neighborhood")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PropertyId")
                        .HasColumnName("PropertyID")
                        .HasColumnType("int");

                    b.Property<string>("Region")
                        .IsRequired()
                        .HasColumnType("nvarchar(20)")
                        .HasMaxLength(20);

                    b.HasKey("AddressId");

                    b.HasIndex("PropertyId")
                        .IsUnique();

                    b.ToTable("Addresses");
                });

            modelBuilder.Entity("TrustImobiliare.Domain.Entities.Agent", b =>
                {
                    b.Property<int>("AgentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("AgentId")
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(20)")
                        .HasMaxLength(20);

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(15)")
                        .HasMaxLength(15);

                    b.Property<string>("PhotoLink")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("AgentId");

                    b.ToTable("Agents");
                });

            modelBuilder.Entity("TrustImobiliare.Domain.Entities.Feature", b =>
                {
                    b.Property<int>("FeatureId")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("FeatureID")
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PropertyId")
                        .HasColumnName("PropertyID")
                        .HasColumnType("int");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("FeatureId");

                    b.HasIndex("PropertyId");

                    b.ToTable("Features");
                });

            modelBuilder.Entity("TrustImobiliare.Domain.Entities.Property", b =>
                {
                    b.Property<int>("PropertyId")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("PropertyID")
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AgentId")
                        .HasColumnName("AgentID")
                        .HasColumnType("int");

                    b.Property<int?>("Bathrooms")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasColumnType("ntext");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(40)")
                        .HasMaxLength(40);

                    b.Property<string>("PhotoLinks")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("money");

                    b.Property<string>("PrimaryPhotoLink")
                        .IsRequired()
                        .HasColumnType("nvarchar(200)")
                        .HasMaxLength(200);

                    b.Property<int?>("Rooms")
                        .HasColumnType("int");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("nvarchar(13)")
                        .HasMaxLength(13);

                    b.Property<int>("Surface")
                        .HasColumnType("int");

                    b.Property<int?>("Year")
                        .HasColumnType("int");

                    b.HasKey("PropertyId");

                    b.HasIndex("AgentId");

                    b.ToTable("Properties");
                });

            modelBuilder.Entity("TrustImobiliare.Domain.Entities.Type", b =>
                {
                    b.Property<int>("TypeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("TypeID")
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PropertyId")
                        .HasColumnName("PropertyID")
                        .HasColumnType("int");

                    b.HasKey("TypeId");

                    b.HasIndex("PropertyId")
                        .IsUnique();

                    b.ToTable("Types");
                });

            modelBuilder.Entity("TrustImobiliare.Domain.Entities.Address", b =>
                {
                    b.HasOne("TrustImobiliare.Domain.Entities.Property", "Property")
                        .WithOne("Address")
                        .HasForeignKey("TrustImobiliare.Domain.Entities.Address", "PropertyId")
                        .HasConstraintName("FK_Properties_Addresses")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("TrustImobiliare.Domain.Entities.Feature", b =>
                {
                    b.HasOne("TrustImobiliare.Domain.Entities.Property", "Property")
                        .WithMany("Features")
                        .HasForeignKey("PropertyId")
                        .HasConstraintName("FK_Features_Properties")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();
                });

            modelBuilder.Entity("TrustImobiliare.Domain.Entities.Property", b =>
                {
                    b.HasOne("TrustImobiliare.Domain.Entities.Agent", "Agent")
                        .WithMany("Properties")
                        .HasForeignKey("AgentId")
                        .HasConstraintName("FK_Properties_Agents")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("TrustImobiliare.Domain.Entities.Type", b =>
                {
                    b.HasOne("TrustImobiliare.Domain.Entities.Property", "Property")
                        .WithOne("Type")
                        .HasForeignKey("TrustImobiliare.Domain.Entities.Type", "PropertyId")
                        .HasConstraintName("FK_Properties_Types")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
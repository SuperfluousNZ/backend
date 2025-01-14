﻿// <auto-generated />
using System;
using DigraphyApi.Data;
using DigraphyApi.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace DigraphyApi.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20250114093103_SetupModels")]
    partial class SetupModels
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.HasPostgresEnum(modelBuilder, "FactoidImportance", new[] { "could", "must", "should" });
            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("CollectionTitle", b =>
                {
                    b.Property<int>("CollectionsId")
                        .HasColumnType("integer");

                    b.Property<int>("TitlesId")
                        .HasColumnType("integer");

                    b.HasKey("CollectionsId", "TitlesId");

                    b.HasIndex("TitlesId");

                    b.ToTable("CollectionTitle");
                });

            modelBuilder.Entity("DigraphyApi.Models.Collection", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<bool>("IsVerified")
                        .HasColumnType("boolean");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Collections");
                });

            modelBuilder.Entity("DigraphyApi.Models.Factoid", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Factoids");
                });

            modelBuilder.Entity("DigraphyApi.Models.FactoidsImportance", b =>
                {
                    b.Property<int>("FactoidId")
                        .HasColumnType("integer");

                    b.Property<int>("TitleId")
                        .HasColumnType("integer");

                    b.Property<FactoidImportance>("Importance")
                        .HasColumnType("\"FactoidImportance\"");

                    b.HasKey("FactoidId", "TitleId");

                    b.HasIndex("TitleId");

                    b.ToTable("FactoidsImportance");
                });

            modelBuilder.Entity("DigraphyApi.Models.Order", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("CollectionId")
                        .HasColumnType("integer");

                    b.Property<DateTime>("CreatedAtUtc")
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateTime>("EditedAtUtc")
                        .HasColumnType("timestamp with time zone");

                    b.Property<bool>("IsVerified")
                        .HasColumnType("boolean");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("CollectionId");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("DigraphyApi.Models.OrderTitle", b =>
                {
                    b.Property<int>("OrderId")
                        .HasColumnType("integer");

                    b.Property<int>("TitleId")
                        .HasColumnType("integer");

                    b.Property<int>("Index")
                        .HasColumnType("integer");

                    b.HasKey("OrderId", "TitleId");

                    b.HasIndex("TitleId");

                    b.ToTable("OrderTitle");
                });

            modelBuilder.Entity("DigraphyApi.Models.Title", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("LargePosterUrl")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime>("ReleasedAtUrc")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("SmallPosterUrl")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int?>("TmdbId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.ToTable("Titles");
                });

            modelBuilder.Entity("DigraphyApi.Models.Todo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Todos");
                });

            modelBuilder.Entity("DigraphyApi.Models.Topic", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int?>("TmdbId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.ToTable("Topics");
                });

            modelBuilder.Entity("FactoidTitle", b =>
                {
                    b.Property<int>("AffilitatedTitlesId")
                        .HasColumnType("integer");

                    b.Property<int>("ContainedFactoidsId")
                        .HasColumnType("integer");

                    b.HasKey("AffilitatedTitlesId", "ContainedFactoidsId");

                    b.HasIndex("ContainedFactoidsId");

                    b.ToTable("FactoidTitle");
                });

            modelBuilder.Entity("FactoidTopic", b =>
                {
                    b.Property<int>("AffiliatedFactoidsId")
                        .HasColumnType("integer");

                    b.Property<int>("TopicsId")
                        .HasColumnType("integer");

                    b.HasKey("AffiliatedFactoidsId", "TopicsId");

                    b.HasIndex("TopicsId");

                    b.ToTable("FactoidTopic");
                });

            modelBuilder.Entity("CollectionTitle", b =>
                {
                    b.HasOne("DigraphyApi.Models.Collection", null)
                        .WithMany()
                        .HasForeignKey("CollectionsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DigraphyApi.Models.Title", null)
                        .WithMany()
                        .HasForeignKey("TitlesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("DigraphyApi.Models.FactoidsImportance", b =>
                {
                    b.HasOne("DigraphyApi.Models.Factoid", null)
                        .WithMany("DependentTitlesImportance")
                        .HasForeignKey("FactoidId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DigraphyApi.Models.Title", null)
                        .WithMany("RequiredFactoidsImportance")
                        .HasForeignKey("TitleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("DigraphyApi.Models.Order", b =>
                {
                    b.HasOne("DigraphyApi.Models.Collection", "Collection")
                        .WithMany("Orders")
                        .HasForeignKey("CollectionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Collection");
                });

            modelBuilder.Entity("DigraphyApi.Models.OrderTitle", b =>
                {
                    b.HasOne("DigraphyApi.Models.Order", null)
                        .WithMany("OrderTitles")
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DigraphyApi.Models.Title", null)
                        .WithMany("AffiliatedOrderIndicies")
                        .HasForeignKey("TitleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("FactoidTitle", b =>
                {
                    b.HasOne("DigraphyApi.Models.Title", null)
                        .WithMany()
                        .HasForeignKey("AffilitatedTitlesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DigraphyApi.Models.Factoid", null)
                        .WithMany()
                        .HasForeignKey("ContainedFactoidsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("FactoidTopic", b =>
                {
                    b.HasOne("DigraphyApi.Models.Factoid", null)
                        .WithMany()
                        .HasForeignKey("AffiliatedFactoidsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DigraphyApi.Models.Topic", null)
                        .WithMany()
                        .HasForeignKey("TopicsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("DigraphyApi.Models.Collection", b =>
                {
                    b.Navigation("Orders");
                });

            modelBuilder.Entity("DigraphyApi.Models.Factoid", b =>
                {
                    b.Navigation("DependentTitlesImportance");
                });

            modelBuilder.Entity("DigraphyApi.Models.Order", b =>
                {
                    b.Navigation("OrderTitles");
                });

            modelBuilder.Entity("DigraphyApi.Models.Title", b =>
                {
                    b.Navigation("AffiliatedOrderIndicies");

                    b.Navigation("RequiredFactoidsImportance");
                });
#pragma warning restore 612, 618
        }
    }
}

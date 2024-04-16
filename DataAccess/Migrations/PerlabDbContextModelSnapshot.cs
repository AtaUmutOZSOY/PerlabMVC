﻿// <auto-generated />
using System;
using DataAccess;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DataAccess.Migrations
{
    [DbContext(typeof(PerlabDbContext))]
    partial class PerlabDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            MySqlModelBuilderExtensions.AutoIncrementColumns(modelBuilder);

            modelBuilder.Entity("Models.Concrete.Author", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Affiliation")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<DateTime>("CreatedTime")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int?>("PublicationId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("PublicationId");

                    b.ToTable("Authors");
                });

            modelBuilder.Entity("Models.Concrete.Collaboration", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("CollaborationName")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("CollaborationWebSiteLink")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<DateTime>("CreatedTime")
                        .HasColumnType("datetime(6)");

                    b.HasKey("Id");

                    b.ToTable("Collaborations");
                });

            modelBuilder.Entity("Models.Concrete.NewsFeed", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreatedTime")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasMaxLength(13)
                        .HasColumnType("varchar(13)");

                    b.Property<string>("Link")
                        .HasColumnType("longtext");

                    b.Property<int>("NewsFeedType")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("NewsFeeds");

                    b.HasDiscriminator<string>("Discriminator").HasValue("NewsFeed");

                    b.UseTphMappingStrategy();
                });

            modelBuilder.Entity("Models.Concrete.Research", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreatedTime")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasMaxLength(13)
                        .HasColumnType("varchar(13)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Researches");

                    b.HasDiscriminator<string>("Discriminator").HasValue("Research");

                    b.UseTphMappingStrategy();
                });

            modelBuilder.Entity("Models.Concrete.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreatedTime")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasMaxLength(8)
                        .HasColumnType("varchar(8)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("MiddleName")
                        .HasColumnType("longtext");

                    b.Property<byte[]>("PasswordHash")
                        .IsRequired()
                        .HasColumnType("longblob");

                    b.Property<byte[]>("PasswordSalt")
                        .IsRequired()
                        .HasColumnType("longblob");

                    b.HasKey("Id");

                    b.ToTable("Users");

                    b.HasDiscriminator<string>("Discriminator").HasValue("User");

                    b.UseTphMappingStrategy();
                });

            modelBuilder.Entity("Models.Concrete.Announcement", b =>
                {
                    b.HasBaseType("Models.Concrete.NewsFeed");

                    b.HasDiscriminator().HasValue("Announcement");
                });

            modelBuilder.Entity("Models.Concrete.Event", b =>
                {
                    b.HasBaseType("Models.Concrete.NewsFeed");

                    b.Property<DateTime>("EventTime")
                        .HasColumnType("datetime(6)");

                    b.HasDiscriminator().HasValue("Event");
                });

            modelBuilder.Entity("Models.Concrete.Project", b =>
                {
                    b.HasBaseType("Models.Concrete.Research");

                    b.Property<DateTime>("DeadLine")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("ProjectDescription")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("ProjectManagerFullName")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("ProjectTitle")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasDiscriminator().HasValue("Project");
                });

            modelBuilder.Entity("Models.Concrete.Publication", b =>
                {
                    b.HasBaseType("Models.Concrete.Research");

                    b.Property<string>("Abstract")
                        .HasColumnType("longtext");

                    b.Property<string>("Doi")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Issn")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("JournalName")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasDiscriminator().HasValue("Publication");
                });

            modelBuilder.Entity("Models.Concrete.Person", b =>
                {
                    b.HasBaseType("Models.Concrete.User");

                    b.Property<string>("GraduateSchoolName")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("GraduateTypeEnum")
                        .HasColumnType("int");

                    b.Property<string>("LinkedInUrl")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("OrcidUrl")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("ResearchGateUrl")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasDiscriminator().HasValue("Person");
                });

            modelBuilder.Entity("Models.Concrete.Author", b =>
                {
                    b.HasOne("Models.Concrete.Publication", null)
                        .WithMany("Authors")
                        .HasForeignKey("PublicationId");
                });

            modelBuilder.Entity("Models.Concrete.Publication", b =>
                {
                    b.Navigation("Authors");
                });
#pragma warning restore 612, 618
        }
    }
}

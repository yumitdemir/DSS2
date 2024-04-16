﻿// <auto-generated />
using System;
using Forum.Infrastructure;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Forum.Infrastructure.Migrations
{
    [DbContext(typeof(DatabaseContext))]
    [Migration("20240416224323_testasdas")]
    partial class testasdas
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("Forum.Domain.Models.Comment", b =>
                {
                    b.Property<long?>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long?>("Id"));

                    b.Property<DateTime?>("CreateDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<long?>("CreatorId")
                        .HasColumnType("bigint");

                    b.Property<int>("Likes")
                        .HasColumnType("integer");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Text")
                        .HasMaxLength(500)
                        .HasColumnType("character varying(500)");

                    b.Property<long?>("TopicId")
                        .HasColumnType("bigint");

                    b.Property<DateTime?>("UpdateDate")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("Id");

                    b.HasIndex("CreatorId");

                    b.HasIndex("TopicId");

                    b.ToTable("Comments", (string)null);
                });

            modelBuilder.Entity("Forum.Domain.Models.Topic", b =>
                {
                    b.Property<long?>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long?>("Id"));

                    b.Property<DateTime?>("CreateDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<long?>("CreatorId")
                        .HasColumnType("bigint");

                    b.Property<int>("Likes")
                        .HasColumnType("integer");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Subject")
                        .HasMaxLength(500)
                        .HasColumnType("character varying(500)");

                    b.Property<DateTime?>("UpdateDate")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("Id");

                    b.HasIndex("CreatorId");

                    b.ToTable("Topics", (string)null);
                });

            modelBuilder.Entity("Forum.Domain.Models.User", b =>
                {
                    b.Property<long?>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long?>("Id"));

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("timestamp")
                        .HasColumnName("CreateDate");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(128)
                        .HasColumnType("character varying(128)")
                        .HasColumnName("email");

                    b.Property<string>("FirstName")
                        .HasMaxLength(64)
                        .HasColumnType("character varying(64)")
                        .HasColumnName("first_name");

                    b.Property<bool>("IsDeleted")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("boolean")
                        .HasDefaultValue(false)
                        .HasColumnName("is_deleted");

                    b.Property<string>("LastName")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)")
                        .HasColumnName("last_name");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(32)
                        .HasColumnType("character varying(32)")
                        .HasColumnName("password");

                    b.Property<string>("Role")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasColumnType("text")
                        .HasDefaultValue("User")
                        .HasColumnName("role");

                    b.Property<DateTime>("UpdateDate")
                        .HasColumnType("timestamp")
                        .HasColumnName("UpdateDate");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasMaxLength(64)
                        .HasColumnType("character varying(64)")
                        .HasColumnName("username");

                    b.HasKey("Id");

                    b.HasIndex("Email")
                        .IsUnique()
                        .HasDatabaseName("UX_public_users_email");

                    b.HasIndex("Username")
                        .IsUnique()
                        .HasDatabaseName("UX_public_users_username");

                    b.HasIndex("Username", "Role")
                        .HasDatabaseName("IX_public_users_usename_role");

                    b.ToTable("users", "public");
                });

            modelBuilder.Entity("Forum.Domain.Models.Comment", b =>
                {
                    b.HasOne("Forum.Domain.Models.User", "Creator")
                        .WithMany("Comments")
                        .HasForeignKey("CreatorId")
                        .OnDelete(DeleteBehavior.SetNull);

                    b.HasOne("Forum.Domain.Models.Topic", "Topic")
                        .WithMany("Comments")
                        .HasForeignKey("TopicId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.Navigation("Creator");

                    b.Navigation("Topic");
                });

            modelBuilder.Entity("Forum.Domain.Models.Topic", b =>
                {
                    b.HasOne("Forum.Domain.Models.User", "Creator")
                        .WithMany("Topics")
                        .HasForeignKey("CreatorId")
                        .OnDelete(DeleteBehavior.SetNull);

                    b.Navigation("Creator");
                });

            modelBuilder.Entity("Forum.Domain.Models.Topic", b =>
                {
                    b.Navigation("Comments");
                });

            modelBuilder.Entity("Forum.Domain.Models.User", b =>
                {
                    b.Navigation("Comments");

                    b.Navigation("Topics");
                });
#pragma warning restore 612, 618
        }
    }
}
﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Netflix_Api.Models;

#nullable disable

namespace Netflix_Api.Migrations
{
    [DbContext(typeof(NetflixDBContext))]
    [Migration("20211206113223_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Netflix_Api.Models.AccountModel", b =>
                {
                    b.Property<int>("AccountId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id_account");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(60)
                        .HasColumnType("varchar(60)");

                    b.Property<int?>("PlanId")
                        .HasColumnType("int")
                        .HasColumnName("id_plan");

                    b.HasKey("AccountId");

                    b.HasIndex("PlanId");

                    b.ToTable("Account");
                });

            modelBuilder.Entity("Netflix_Api.Models.PlanModel", b =>
                {
                    b.Property<int>("PlanId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id_plan");

                    b.Property<double>("Price")
                        .HasColumnType("double");

                    b.Property<string>("Quality")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("varchar(10)");

                    b.Property<string>("Resolution")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("varchar(10)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("varchar(15)");

                    b.HasKey("PlanId");

                    b.ToTable("plan");
                });

            modelBuilder.Entity("Netflix_Api.Models.AccountModel", b =>
                {
                    b.HasOne("Netflix_Api.Models.PlanModel", "Plan")
                        .WithMany()
                        .HasForeignKey("PlanId");

                    b.Navigation("Plan");
                });
#pragma warning restore 612, 618
        }
    }
}
﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Netflix_Api.Models;

#nullable disable

namespace Netflix_Api.Migrations
{
    [DbContext(typeof(NetflixDBContext))]
    partial class NetflixDBContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
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

                    b.Property<int?>("PaymentId")
                        .HasColumnType("int")
                        .HasColumnName("id_payment");

                    b.Property<int?>("PlanId")
                        .HasColumnType("int")
                        .HasColumnName("id_plan");

                    b.HasKey("AccountId");

                    b.HasIndex("PaymentId");

                    b.HasIndex("PlanId");

                    b.ToTable("Account");
                });

            modelBuilder.Entity("Netflix_Api.Models.PaymentModel", b =>
                {
                    b.Property<int>("PaymentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id_payment");

                    b.Property<short>("CVV")
                        .HasColumnType("smallint")
                        .HasColumnName("cvv");

                    b.Property<string>("LastName")
                        .HasColumnType("longtext")
                        .HasColumnName("last_name");

                    b.Property<short>("MonthDate")
                        .HasColumnType("smallint")
                        .HasColumnName("month_date");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("name");

                    b.Property<long>("NumberCard")
                        .HasColumnType("bigint")
                        .HasColumnName("number_card");

                    b.Property<int>("TypePayment")
                        .HasColumnType("int");

                    b.Property<int>("TypePaymentId")
                        .HasColumnType("int")
                        .HasColumnName("type_payment");

                    b.Property<short>("YearDate")
                        .HasColumnType("smallint")
                        .HasColumnName("year_date");

                    b.HasKey("PaymentId");

                    b.ToTable("payment");
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

                    b.HasData(
                        new
                        {
                            PlanId = 1,
                            Price = 25.899999999999999,
                            Quality = "Boa",
                            Resolution = "480p",
                            Title = "Básico"
                        },
                        new
                        {
                            PlanId = 2,
                            Price = 39.899999999999999,
                            Quality = "Melhor",
                            Resolution = "1080p",
                            Title = "Padrão"
                        },
                        new
                        {
                            PlanId = 3,
                            Price = 55.899999999999999,
                            Quality = "Superior",
                            Resolution = "4K+HDR",
                            Title = "Premium"
                        });
                });

            modelBuilder.Entity("Netflix_Api.Models.AccountModel", b =>
                {
                    b.HasOne("Netflix_Api.Models.PaymentModel", "Payment")
                        .WithMany()
                        .HasForeignKey("PaymentId");

                    b.HasOne("Netflix_Api.Models.PlanModel", "Plan")
                        .WithMany()
                        .HasForeignKey("PlanId");

                    b.Navigation("Payment");

                    b.Navigation("Plan");
                });
#pragma warning restore 612, 618
        }
    }
}

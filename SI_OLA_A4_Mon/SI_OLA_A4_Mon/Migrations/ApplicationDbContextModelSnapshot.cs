﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SI_OLA_A4_Mon;

#nullable disable

namespace SI_OLA_A4_Mon.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("SI_OLA_A4_Mon.Domains.Address", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<string>("city")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("street")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("zipCode")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("Addresses");
                });

            modelBuilder.Entity("SI_OLA_A4_Mon.Domains.CustomerDomain.Models.Customer", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<int>("addressid")
                        .HasColumnType("int");

                    b.Property<string>("email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("paymentInfoid")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.HasIndex("addressid");

                    b.HasIndex("paymentInfoid");

                    b.ToTable("Customers");
                });

            modelBuilder.Entity("SI_OLA_A4_Mon.Domains.CustomerDomain.Models.PaymentInfo", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<string>("cardNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("expirationDate")
                        .HasColumnType("datetime2");

                    b.HasKey("id");

                    b.ToTable("PaymentInfos");
                });

            modelBuilder.Entity("SI_OLA_A4_Mon.Domains.PaymentDomain.Models.Payment", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<bool>("hasInsurance")
                        .HasColumnType("bit");

                    b.Property<bool>("hasLateFee")
                        .HasColumnType("bit");

                    b.Property<bool>("hasPaid")
                        .HasColumnType("bit");

                    b.HasKey("id");

                    b.ToTable("Payments");
                });

            modelBuilder.Entity("SI_OLA_A4_Mon.Domains.RentalAgreementDomain.Models.RentalAgreement", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<int>("customerid")
                        .HasColumnType("int");

                    b.Property<int>("durationid")
                        .HasColumnType("int");

                    b.Property<int>("paymentid")
                        .HasColumnType("int");

                    b.Property<int>("trailerid")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.HasIndex("customerid");

                    b.HasIndex("durationid");

                    b.HasIndex("paymentid");

                    b.HasIndex("trailerid");

                    b.ToTable("RentalAgreements");
                });

            modelBuilder.Entity("SI_OLA_A4_Mon.Domains.RentalAgreementDomain.Models.RentalDuration", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<DateTime>("endDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("startDate")
                        .HasColumnType("datetime2");

                    b.HasKey("id");

                    b.ToTable("RentalDurations");
                });

            modelBuilder.Entity("SI_OLA_A4_Mon.Domains.TrailerDomain.Models.Location", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<string>("address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("companyName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("Locations");
                });

            modelBuilder.Entity("SI_OLA_A4_Mon.Domains.TrailerDomain.Models.Trailer", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<int>("locationid")
                        .HasColumnType("int");

                    b.Property<string>("status")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("trailerNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.HasIndex("locationid");

                    b.ToTable("Trailers");
                });

            modelBuilder.Entity("SI_OLA_A4_Mon.Domains.CustomerDomain.Models.Customer", b =>
                {
                    b.HasOne("SI_OLA_A4_Mon.Domains.Address", "address")
                        .WithMany()
                        .HasForeignKey("addressid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SI_OLA_A4_Mon.Domains.CustomerDomain.Models.PaymentInfo", "paymentInfo")
                        .WithMany()
                        .HasForeignKey("paymentInfoid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("address");

                    b.Navigation("paymentInfo");
                });

            modelBuilder.Entity("SI_OLA_A4_Mon.Domains.RentalAgreementDomain.Models.RentalAgreement", b =>
                {
                    b.HasOne("SI_OLA_A4_Mon.Domains.CustomerDomain.Models.Customer", "customer")
                        .WithMany()
                        .HasForeignKey("customerid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SI_OLA_A4_Mon.Domains.RentalAgreementDomain.Models.RentalDuration", "duration")
                        .WithMany()
                        .HasForeignKey("durationid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SI_OLA_A4_Mon.Domains.PaymentDomain.Models.Payment", "payment")
                        .WithMany()
                        .HasForeignKey("paymentid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SI_OLA_A4_Mon.Domains.TrailerDomain.Models.Trailer", "trailer")
                        .WithMany()
                        .HasForeignKey("trailerid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("customer");

                    b.Navigation("duration");

                    b.Navigation("payment");

                    b.Navigation("trailer");
                });

            modelBuilder.Entity("SI_OLA_A4_Mon.Domains.TrailerDomain.Models.Trailer", b =>
                {
                    b.HasOne("SI_OLA_A4_Mon.Domains.TrailerDomain.Models.Location", "location")
                        .WithMany()
                        .HasForeignKey("locationid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("location");
                });
#pragma warning restore 612, 618
        }
    }
}

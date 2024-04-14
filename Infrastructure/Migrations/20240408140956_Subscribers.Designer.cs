﻿// <auto-generated />
using System;
using Infrastructure.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Infrastructure.Migrations
{
    [DbContext(typeof(ApiContext))]
    [Migration("20240408140956_Subscribers")]
    partial class Subscribers
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.3");

            modelBuilder.Entity("Infrastructure.Entities.SubscriberEntity", b =>
                {
                    b.Property<string>("Email")
                        .HasColumnType("TEXT");

                    b.Property<bool>("AdvertisingUpdates")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("Created")
                        .HasColumnType("TEXT");

                    b.Property<bool>("DailyNewsletter")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("EventUpdates")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("Podcasts")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("StartupsWeekly")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("WeekinReview")
                        .HasColumnType("INTEGER");

                    b.HasKey("Email");

                    b.ToTable("Subscribers");
                });
#pragma warning restore 612, 618
        }
    }
}

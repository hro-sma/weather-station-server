﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using weather.station.server.Data;

namespace weather.station.server.Migrations
{
    [DbContext(typeof(WeatherStationServerContext))]
    partial class WeatherStationServerContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.4-rtm-31024");

            modelBuilder.Entity("weather.station.server.Models.WeatherUpdate", b =>
                {
                    b.Property<Guid>("WeatherUpdateId")
                        .ValueGeneratedOnAdd();

                    b.Property<Guid>("DeviceId");

                    b.Property<double>("Humidity");

                    b.Property<double>("TemperatureC");

                    b.Property<DateTime>("TimeStamp");

                    b.Property<double>("windspeed");

                    b.HasKey("WeatherUpdateId");

                    b.ToTable("WeatherUpdate");
                });
#pragma warning restore 612, 618
        }
    }
}

﻿

using Microsoft.EntityFrameworkCore;
using System.ComponentModel;

namespace DotnetEfCoreExample.Data
{
   public class DataContext :DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }
        protected override void OnConfiguring (DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring (optionsBuilder);
            optionsBuilder.UseSqlServer("Server=.\\SQLExpress;Database=dotnet7testdb;Trusted_Connection=true;TrustServerCertificate=true;");
        }
      
        
        public DbSet <WeatherForecast> Forecasts { get; set; }
        
    }
}

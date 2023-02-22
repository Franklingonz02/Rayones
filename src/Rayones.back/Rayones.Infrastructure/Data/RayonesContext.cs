﻿using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Rayones.Core.Entidades;
using Rayones.Infrastrucure.Data.Configurations;

#nullable disable

namespace Rayones.Infrastrucure.Data
{
    public partial class RayonesContext : DbContext
    {
        public RayonesContext()
        {
        }

        public RayonesContext(DbContextOptions<RayonesContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Unidades> Unidades { get; set; }



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Modern_Spanish_CI_AS");
            modelBuilder.ApplyConfiguration(new UnidadesConfigurations());

        }


    }
}
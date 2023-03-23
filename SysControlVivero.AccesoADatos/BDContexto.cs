﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Microsoft.EntityFrameworkCore;
using SysControlVivero.EntidadesDeNegocio;

namespace SysControlVivero.AccesoADatos
{
    public class BDContexto : DbContext
    {
        public DbSet<Rol> Rol { get; set; }
        public DbSet<Usuario> Usuario { get; set; }
        public DbSet<Cliente> Cliente { get; set; }
        public DbSet<DetalleCompra> DetalleCompra { get; set; }


        public DbSet<Categoria> Categoria { get; set; }
        public DbSet<Empleado> Empleado { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=DESKTOP-DEV01\SQLEXPRESS02;Initial Catalog=SeguridadWebdb;Integrated Security=True");
        }
    }

}


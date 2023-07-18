using System;
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
        public DbSet<Producto> Producto { get; set; }
        public DbSet<Inventario> Inventario { get; set; }
        public DbSet<Categoria> Categoria { get; set; }
        public DbSet<Empleado> Empleado { get; set; }
        public DbSet<DetalleVenta> DetalleVenta { get; set; }
        public DbSet<Factura> Factura { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //optionsBuilder.UseSqlServer(@"Data Source=DESKTOP-NFDMETJ\SQLEXPRESS;Initial Catalog=ControlVivero;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");

            optionsBuilder.UseSqlServer(@"workstation id=ControlVivero123.mssql.somee.com;packet size=4096;user id=CaroHernandez_SQLLogin_1;pwd=yptvws3ruq;data source=ControlVivero123.mssql.somee.com;persist security info=False;initial catalog=ControlVivero123;Encrypt=False;TrustServerCertificate=False");
        }
    }

}



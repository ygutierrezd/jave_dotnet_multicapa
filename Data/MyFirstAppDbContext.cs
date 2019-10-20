using System;
using Data.Modelos;
using Microsoft.EntityFrameworkCore;

namespace Data {
    public class MyFirstAppDbContext : DbContext {

        public MyFirstAppDbContext (DbContextOptions options) : base (options) { }

        public DbSet<DetalleContacto> DetalleContactos { get; set; }
    }
}
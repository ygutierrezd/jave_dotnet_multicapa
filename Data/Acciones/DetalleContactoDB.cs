using Data.Modelos;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Acciones
{
    public class DetalleContactoDB
    {
        private MyFirstAppDbContext _contexto;

        public DetalleContactoDB() {
            var options = new DbContextOptionsBuilder<MyFirstAppDbContext>()
                .UseInMemoryDatabase(databaseName: "Contactos")
                .Options;
            _contexto = new MyFirstAppDbContext(options);
        }

        public void Agregar(DetalleContacto detalle)
        {
            _contexto.DetalleContactos.Add(detalle);
            _contexto.SaveChanges();
        }

        public List<DetalleContacto> TraerTodos()
        {
            return null ;
        }
    }
}

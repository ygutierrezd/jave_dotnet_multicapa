using Data.Modelos;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Data.Acciones
{
    public class DetalleContactoDB
    {
        private MyFirstAppDbContext _contexto;

        public DetalleContactoDB()
        {
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
            return _contexto.DetalleContactos.ToList();
        }

        public DetalleContacto consultarContacto(string indentificacion)
        {
            return _contexto.DetalleContactos
                .Where(x => x.Identificacion.Equals(indentificacion)).FirstOrDefault();
        }
    }
}

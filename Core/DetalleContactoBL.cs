using Data.Acciones;
using Data.Modelos;
using System;
using System.Collections.Generic;

namespace Core
{
    public class DetalleContactoBL
    {
        private DetalleContactoDB db;
        public DetalleContactoBL()
        {
            db = new DetalleContactoDB();
        }

        public void AgregarDetalleContacto(DetalleContacto detalle)
        {
            db.Agregar(detalle);
        }

        public List<DetalleContacto> ConsultarTodos()
        {

            return db.TraerTodos();

        }

        public DetalleContacto ConsultarContacto(string identificacion)
        {
            if (string.IsNullOrEmpty(identificacion))
                return db.consultarContacto(identificacion);

            return null;
        }
    }
}

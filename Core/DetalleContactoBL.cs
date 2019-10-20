using Data.Acciones;
using Data.Modelos;
using System;
using System.Collections.Generic;

namespace Core
{
    public class DetalleContactoBL
    {
        private DetalleContactoDB db;
        public DetalleContactoBL() {
            db = new DetalleContactoDB();
        }

        public void agregarDetalleContacto(DetalleContacto detalle) {
            db.Agregar(detalle);
        }

        public List<DetalleContacto> traerTodos() {

            return db.TraerTodos();

        }
    }
}

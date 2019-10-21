using System;
using Xunit;
using Core;
using Data.Modelos;
using System.Collections.Generic;

namespace Core.Test
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            DetalleContactoBL detalleNegocio = new DetalleContactoBL();
            Assert.NotNull(detalleNegocio.ConsultarContacto(""));
        }

        [Fact]
        public void Test2()
        {
            DetalleContactoBL detalleNegocio = new DetalleContactoBL();
            var contacto = detalleNegocio.ConsultarTodos();
            Assert.NotNull(contacto);
        }
    }
}

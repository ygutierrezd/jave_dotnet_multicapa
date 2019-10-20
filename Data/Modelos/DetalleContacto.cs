using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Data.Modelos
{
    public class DetalleContacto
    {
        [Key]
        public string Identificacion { get; set; }

        public string Correo { get; set; }

        public string Direccion { get; set; }

        public string Nombres { get; set; }

        public string Apellidos { get; set; }
    }
}

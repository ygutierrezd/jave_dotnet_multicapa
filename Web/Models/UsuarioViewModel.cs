using System;
using System.ComponentModel.DataAnnotations;
using Data.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Web.Models {
    public class UsuarioViewModel {

        [BindProperty]
        public InputModel Input { get; set; }

        [TempData]
        public string ErrorMessage { get; set; }

        public class InputModel : IDetalleContacto {

            [Required (ErrorMessage = "Campo obligatorio")]
            [EmailAddress (ErrorMessage = "Correo invalido")]
            public string Correo { get; set; }

            [StringLength (50, ErrorMessage = "maximo 50 caracteres")]
            public string Direccion { get; set; }

            [Required (ErrorMessage = "Ingrese su nombre")]
            [StringLength (50, ErrorMessage = "maximo 50 caracteres")]
            public string Nombres { get; set; }

            [Required (ErrorMessage = "Ingrese sus apellidos")]
            [StringLength (50, ErrorMessage = "maximo 50 caracteres")]
            public string Apellidos { get; set; }

            [Required (ErrorMessage = "Ingrese sus Identificación")]
            [StringLength (10, ErrorMessage = "maximo 10 caracteres")]
            public string Identificacion { get; set; }
        }
    }
}
using System.Linq;
using System.Threading.Tasks;
using Core;
using Data.Interfaces;
using Data.Modelos;
using Microsoft.AspNetCore.Mvc;
using Web.Data;
using Web.Models;

namespace Web.Controllers {

    [Route ("api/registro")]
    [ApiController]
    public class ApiRegistroController : ControllerBase {
        private readonly ApplicationDbContext _context;

        public ApiRegistroController (ApplicationDbContext context) {
            _context = context;
        }

        [HttpPost]
        [Route("crearUsuario")]
        public async Task<ActionResult<UsuarioViewModel>> PostUsuario (UsuarioViewModel.InputModel user) {
            if (ModelState.IsValid) {

                DetalleContactoBL detalleNegocio = new DetalleContactoBL();
                DetalleContacto detalleContacto = new DetalleContacto
                {
                    Identificacion = user.Identificacion,
                    Apellidos = user.Apellidos,
                    Nombres = user.Nombres,
                    Correo = user.Correo,
                    Direccion = user.Direccion
                };

                detalleNegocio.agregarDetalleContacto(detalleContacto);

                return Ok ();

            }

            return BadRequest ();
        }

        [HttpGet]
        [Route ("usuarios")]
        public async Task<ActionResult> GetUsuarios () {

            DetalleContactoBL detalleNegocio = new DetalleContactoBL ();
            var usuario = detalleNegocio.traerTodos ();

            if (usuario != null) {
                return Ok (usuario);
            } else {
                return BadRequest ();
            }

            // var usuario = new UsuarioViewModel.InputModel {

            //         Nombres = "yesid",
            //         Apellidos = "Gutierrez",
            //         Correo = "yesid.gutierrez@prueba.com",
            //         Direccion = "Kra 51"

            // };

        }
    }
}
namespace Data.Interfaces
{
    public interface IDetalleContacto {
        string Identificacion { get; set; }

        string Correo { get; set; }

        string Direccion { get; set; }

        string Nombres { get; set; }

        string Apellidos { get; set; }
    }
}
namespace CRUD.Models
{
    public class Oficina
    {
        public byte Id { get; set; }
        public string Nombre { get; set; }
        public string Direccion { get; set; }
        public byte Estado { get; set; }
        public DateTime FechaRegistro { get; set; }
        public DateTime UltimaActualizacion { get; set; }

        public Oficina()
        { }
        public Oficina(string nombre, string direccion)
        {
            Nombre = nombre;
            Direccion = direccion;
        }
    }
}

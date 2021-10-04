namespace MascotaFeliz.App.Dominio
{
    public class Dueño
    {
        public int IdDueño {get; set;}
        public int IdentificacionDueño {get; set;}
        public string Nombre {get; set;}
        public string Apellido {get; set;}
        public string Direccion {get; set;}
        public int Telefono {get; set;}
        public Mascota Mascota {set; get;}
    }
}
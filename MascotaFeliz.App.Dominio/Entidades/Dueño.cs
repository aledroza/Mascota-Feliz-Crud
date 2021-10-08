using System;
using System.ComponentModel.DataAnnotations;


namespace MascotaFeliz.App.Dominio
{
    public class Dueño
    {
        public int IdDueño {get; set;}
        [Required,StringLength(50)]
        public string IdentificacionDueño {get; set;}
        [Required,StringLength(50)]
        public string Nombre {get; set;}
        [Required,StringLength(50)]
        public string Apellido {get; set;}
        [Required,StringLength(50)]
        public string Direccion {get; set;}
        [Required,StringLength(50)]
        public string Telefono {get; set;}
        
        public Mascota Mascota {set; get;}
        [Required,StringLength(50)]
        public string NombreMascota {get; set;}
    }
}
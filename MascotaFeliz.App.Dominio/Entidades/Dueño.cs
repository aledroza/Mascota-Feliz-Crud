using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;


namespace MascotaFeliz.App.Dominio
{
    public class Dueño
    {
        public int Id {get; set;}
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
        
        //public Mascota Mascota {set; get;}
        
        //Relacion 1 a Muchos.
        public List<Mascota> Mascota {get; set;}
        [Required,StringLength(50)]
        public string NombreMascota {get; set;}
    }
}
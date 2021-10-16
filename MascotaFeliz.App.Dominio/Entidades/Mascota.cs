using System.Collections.Generic;

namespace MascotaFeliz.App.Dominio
{
    public class Mascota
    {
        public int Id {get; set;}
        public int IdMascota {get; set;}
        public int CodigoMascota {get; set;}
        public string NombreMascota {get; set;}
        public string Edad {get; set;}
        public string Raza {get; set;}
        public string Tipo {get; set;}
        public string Planes {get; set;}
        public Planes Plan {get; set;}

        // Relacion 1 a muchos.
        public List<VisitaDomiciliaria> VisitaDomiciliaria {get; set;}
    
        //public VisitaDomiciliaria VisitaDomiciliaria {get; set;}
        public string IdentificacionDueño {get; set;}
        
    }
}
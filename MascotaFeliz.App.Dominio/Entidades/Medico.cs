namespace MascotaFeliz.App.Dominio
{
    public class Medico
    {
        public int IdMedico {get; set;}
        public string Nombre {get; set;}
        public string Apellido {get; set;}
        public int Telefono {get; set;}
        public string TarjetaProfesional {get; set;}
        public int IdentificacionMedico {get; set;}
        public VisitaDomiciliaria VisitaDomiciliaria {get; set;}
    }
}
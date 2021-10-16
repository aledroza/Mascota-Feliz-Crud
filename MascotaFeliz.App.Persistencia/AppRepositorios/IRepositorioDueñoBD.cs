using MascotaFeliz.App.Dominio;
using System.Collections.Generic;

namespace MascotaFeliz.App.Persistencia.AppRepositorios
{
    public interface IRepositorioDueñoBD
    {
        IEnumerable<Dueño> GetAllDueños();
        Dueño AddDueño(Dueño dueño);
        Dueño UpdateDueño(Dueño dueño);
        void DeleteDueño(int idDueño);
        Dueño GetDueño(int idDueño);
        //filtrando paciente por identificacion
        IEnumerable<Dueño> GetDueñoIdentificacion();

        //filtrando por relaciones
        IEnumerable<Dueño> GetDueñosPerros();

        //base de datos pagina web
        //IEnumerable<Mascota> GetMascotaDueño(int idDueño);
       
         
    }
}
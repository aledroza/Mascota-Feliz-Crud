using System.Collections.Generic;
using MascotaFeliz.App.Dominio;
using System.Linq;
using System;
using System.Collections;

namespace MascotaFeliz.App.Persistencia.AppRepositorios
{
    public interface IRepositorioPlanes
    {
        IEnumerable<Planes> GetPlanes();
        IEnumerable<Dueño> GetDueños();
        IEnumerable<Mascota> GetMascotas();
        Dueño GetDueñoPorId(int dueñoID);
        Mascota GetMascotaPorId(int mascotaID);
        Dueño UpdateDueño(Dueño dueñoActualizado);
        Dueño AddDueño(Dueño nuevoDueño);

        //base de datos pagina web
        IEnumerable<Mascota> GetMascotaDueño(int idDueño);
        Dueño GetDueño(int idDueño);
    }
}
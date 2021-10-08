using System.Collections.Generic;
using MascotaFeliz.App.Dominio;

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
    }
}
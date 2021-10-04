using System.Collections.Generic;
using MascotaFeliz.App.Dominio;

namespace MascotaFeliz.App.Persistencia.AppRepositorios
{
    public class RepositorioPlanesMemoria : IRepositorioPlanes
    {
        List<Planes> plan;
        public RepositorioPlanesMemoria()
        {
            plan = new List<Planes>()
            {
                new Planes{Id=1, Bienestar="Bienestar / Plan Basico", Elite="Elite / Plan Medio", Diamante="Diamante / Plan Full"},
                new Planes{Id=2, Bienestar="Medicina", Elite="Medicina", Diamante="Medicina"},
                new Planes{Id=3, Bienestar="Eutanacia", Elite="Eutanacia", Diamante="Eutanacia"},
                new Planes{Id=4, Bienestar="Peluqueria", Elite="Peluqueria", Diamante="Peluqueria"},
                new Planes{Id=5, Bienestar="Desparasitado / limpieza", Elite="Desparasitado / limpieza", Diamante="Desparasitado / limpieza"},
                new Planes{Id=6, Bienestar="", Elite="Urgencia", Diamante="Urgencia"},
                new Planes{Id=7, Bienestar="", Elite="Guarderia", Diamante="Guarderia"},
                new Planes{Id=8, Bienestar="Visita Domiciliaria", Elite="Visita Domiciliaria", Diamante="Visita Domiciliaria"},
                new Planes{Id=9, Bienestar="Daños a terceros", Elite="Daños a terceros", Diamante="Daños a terceros"},
                new Planes{Id=10, Bienestar="Muerte", Elite="Muerte", Diamante="Muerte"},
                new Planes{Id=11, Bienestar="Gastos de Defensa", Elite="Gastos de Defensa", Diamante="Gastos de Defensa"}

            };
        }

        public IEnumerable<Planes> GetAll()
        {
            return plan;
        }
    }
}
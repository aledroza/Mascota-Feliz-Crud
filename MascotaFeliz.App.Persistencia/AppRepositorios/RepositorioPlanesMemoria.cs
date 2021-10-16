using System;
//using System.Collections.Generic;
using System.Linq;
using System.Collections.Generic;
using MascotaFeliz.App.Dominio;
//using MascotaFeliz.App.Persistencia;
using Microsoft.EntityFrameworkCore;


namespace MascotaFeliz.App.Persistencia.AppRepositorios
{
    public class RepositorioPlanesMemoria : IRepositorioPlanes
    {
        private readonly AppContext _appContext;
        /*//referenciando base de datos
        /// <summary>
        /// Referencia al contexto de Dueño
        /// </summary>
        private readonly AppContext _appContext;
        /// <summary>
        /// Metodo Constructor utiliza
        /// Inyeccion de dependencias para indicar el contexto a utilizar
        /// </summary>
        /// <param name ="appContext"></param>//*/

        //----------------------------------------
        List<Planes> plan;
        List<Dueño> dueño;
        List<Mascota> mascota;



        public RepositorioPlanesMemoria(AppContext appContext)
        {
            // referenciando base de datos
            _appContext = appContext;
        }
        public RepositorioPlanesMemoria()
        {
            // referenciando base de datos
            // _appContext = appContext;
            //-------------------------------------------
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

            dueño = new List<Dueño>()
            {

                new Dueño{IdDueño=1, IdentificacionDueño="Cedula", Nombre="Nombre", Apellido="Apellido", Direccion="Direccion", Telefono="Telefono",NombreMascota="Nombre Mascota"},
                new Dueño{IdDueño=2, IdentificacionDueño="67032716", Nombre="Alexis", Apellido="Pedroza", Direccion="Calle 44a # 45-06", Telefono="3207813976",NombreMascota="picolo"}
            };

            mascota = new List<Mascota>()
            {

                new Mascota{IdMascota=2, CodigoMascota=002, NombreMascota="Nombre Mascota", Edad="Edad", Raza="Raza", Tipo="Tipo", Planes="Plan",IdentificacionDueño="Cedula Dueño"},
                new Mascota{IdMascota=3, CodigoMascota=003, NombreMascota="rastier", Edad="1", Raza="buldosrer", Tipo="gato", Planes="Bienestar",IdentificacionDueño="67032716"}
            };
        }

        public IEnumerable<Planes> GetPlanes()
        {
            return plan;
            //return dueño;
        }

        public IEnumerable<Dueño> GetDueños()
        {
            return dueño;
        }

        public IEnumerable<Mascota> GetMascotas()
        {
            return mascota;
        }

        public Dueño GetDueñoPorId(int dueñoID)
        {
            return dueño.SingleOrDefault(s => s.IdDueño == dueñoID);
        }

        public Mascota GetMascotaPorId(int mascotaID)
        {
            return mascota.SingleOrDefault(s => s.IdMascota == mascotaID);
        }

        public Dueño UpdateDueño(Dueño dueñoActualizado)
        {
            var dueños = dueño.SingleOrDefault(r => r.IdDueño == dueñoActualizado.IdDueño);
            if (dueños != null)
            {
                dueños.IdentificacionDueño = dueñoActualizado.IdentificacionDueño;
                dueños.Nombre = dueñoActualizado.Nombre;
                dueños.Apellido = dueñoActualizado.Apellido;
                dueños.Direccion = dueñoActualizado.Direccion;
                dueños.Telefono = dueñoActualizado.Telefono;
                dueños.NombreMascota = dueñoActualizado.NombreMascota;
            }
            return dueños;

        }

        public Dueño AddDueño(Dueño nuevoDueño)
        {
            nuevoDueño.IdDueño = dueño.Max(r => r.IdDueño) + 1;
            dueño.Add(nuevoDueño);
            return nuevoDueño;
        }

        //----------------------> base de datos pagina web <--------------------------------------
        IEnumerable<Mascota> IRepositorioPlanes.GetMascotaDueño(int idDueño)
        {
            var dueño = _appContext.Dueño.Where(s => s.Id == idDueño).Include(s => s.Mascota).FirstOrDefault();

            return dueño.Mascota;
        }
        //---------------------------obteniendo dueño de la base de datos -------------------------------
        Dueño IRepositorioPlanes.GetDueño(int idDueño)
        {
            //throw new System.NotImplementedException();
            return _appContext.Dueño.FirstOrDefault(p => p.Id == idDueño);
            //FirstOrDefault
        }

    }
}
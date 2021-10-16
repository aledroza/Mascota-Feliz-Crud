using MascotaFeliz.App.Persistencia;
using MascotaFeliz.App.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace MascotaFeliz.App.Persistencia.AppRepositorios
{
    public class RepositorioDueñoBD : IRepositorioDueñoBD
    {
        /// <summary>
        /// Referencia al contexto de Dueño
        /// </summary>
        private readonly AppContext _appContext;
        /// <summary>
        /// Metodo Constructor utiliza
        /// Inyeccion de dependencias para indicar el contexto a utilizar
        /// </summary>
        /// <param name ="appContext"></param>//
        public RepositorioDueñoBD(AppContext appContext)
        {
            _appContext = appContext;
        }

        Dueño IRepositorioDueñoBD.AddDueño(Dueño dueño)
        {
            //throw new System.NotImplementedException();
            var dueñoAdicionado = _appContext.Dueño.Add(dueño);
            _appContext.SaveChanges();
            return dueñoAdicionado.Entity;
        }

        void IRepositorioDueñoBD.DeleteDueño(int idDueño)
        {
            //throw new System.NotImplementedException();
            var dueñoEncontrada = _appContext.Dueño.FirstOrDefault(p => p.Id == idDueño);
            if (dueñoEncontrada == null)
                return;
            _appContext.Dueño.Remove(dueñoEncontrada);
            _appContext.SaveChanges();
        }
        IEnumerable<Dueño> IRepositorioDueñoBD.GetAllDueños()
        {
            //throw new System.NotImplementedException();
            return _appContext.Dueño;

        }
        Dueño IRepositorioDueñoBD.GetDueño(int idDueño)
        {
            //throw new System.NotImplementedException();
            return _appContext.Dueño.FirstOrDefault(p => p.Id == idDueño);
            //FirstOrDefault
        }

        Dueño IRepositorioDueñoBD.UpdateDueño(Dueño dueño)
        {
            //throw new System.NotImplementedException();

            var dueñoEncontrada = _appContext.Dueño.FirstOrDefault(p => p.Id == dueño.Id);
            if (dueñoEncontrada != null)
            {
                dueñoEncontrada.IdDueño = dueño.Id;
                dueñoEncontrada.IdentificacionDueño = dueño.IdentificacionDueño;
                dueñoEncontrada.Nombre = dueño.Nombre;
                dueñoEncontrada.Apellido = dueño.Apellido;
                dueñoEncontrada.Direccion = dueño.Direccion;
                dueñoEncontrada.Telefono = dueño.Telefono;
                dueñoEncontrada.NombreMascota = dueño.NombreMascota;
                //personaEncontrada.Apellidos = persona.Apellidos;
                //personaEncontrada.NumeroTelefono = persona.NumeroTelefono;
                //personaEncontrada.Genero = persona.Genero;

                _appContext.SaveChanges();

            }
            return dueñoEncontrada;
        }
        //return dueñoEncontrada;

        //-------------------> filtrando dueño por identificacion <-------------
        IEnumerable<Dueño> IRepositorioDueñoBD.GetDueñoIdentificacion()
        {
            //throw new System.NotImplementedException();
            return _appContext.Dueño.Where(p => p.IdentificacionDueño == "77032726").ToList();

        }

        //------------------------> filtrando entidades relacionadas <--------------------------
        public IEnumerable<Dueño> GetDueñosPerros()
        {

            /*return _appContext.Dueño
                                   .Where(p => p.Mascota.Any(s => s.Tipo == "gato" && s.Raza == "Egipcia"))
                                   .ToList();*/
            return _appContext.Dueño
                                   .Where(p => p.Mascota.Any(s => s.Tipo == "Criollo" && s.Raza == "Criollo"))
                                   .ToList();                     
        }

        //----------------------> base de datos pagina web <--------------------------------------
        /*IEnumerable<Mascota> IRepositorioDueñoBD.GetMascotaDueño(int idDueño)
        {
            var dueño = _appContext.Dueño.Where(s => s.Id == idDueño).Include(s => s.Mascota).FirstOrDefault();

            return dueño.Mascota;
        }*/
    }
}
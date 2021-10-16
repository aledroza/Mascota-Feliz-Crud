using System;
using MascotaFeliz.App.Dominio;
using MascotaFeliz.App.Persistencia.AppRepositorios;
using System.Collections.Generic;

namespace MascotaFeliz.App.Consola
{
    class Program
    {
        private static IRepositorioDueñoBD _repoDueñoBD = new RepositorioDueñoBD(new Persistencia.AppContext());
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World Entity Framework!");
            //AddDueño();
            //BuscarDueño(1);
            //AddDueñoconMascota();
            //AddMascotaDueño(2);
            // ListarIdentificacionDueño();
            ListarDueñosPerros();

        }

        private static void AddDueño()
        {
            ///<summary>Interaccion con la base de datos</summary>
            var dueño = new Dueño
            {
                IdDueño = 1,
                IdentificacionDueño = "77032726",
                Nombre = "Cintia Marcela",
                Apellido = "Pedroza",
                Direccion = "Calle 44a # 45 -06",
                Telefono = "3207813976",
                NombreMascota = "inu"

            };
            _repoDueñoBD.AddDueño(dueño);
        }

        // Adicionar Dueño con Mascota
        private static void AddDueñoconMascota()
        {
            ///<summary>Interaccion con la base de datos</summary>
            var dueño = new Dueño
            {
                IdDueño = 2,
                IdentificacionDueño = "25434803",
                Nombre = "Ventura",
                Apellido = "Pedroza",
                Direccion = "Calle 44a # 45 -06",
                Telefono = "3117779971",
                NombreMascota = "ocrion",
                Mascota = new List<Mascota> {
                    new Mascota{IdMascota=1,CodigoMascota=001,NombreMascota="ocrion",Edad="1",Raza="Criollo",Tipo="Perro", Planes="Bienestar",IdentificacionDueño="25434803"}
                }

            };
            _repoDueñoBD.AddDueño(dueño);
        }

        //--------------------> adicionar Mascota con Dueño <------------------------
        private static void AddMascotaDueño(int idDueño)
        {
            var dueño = _repoDueñoBD.GetDueño(idDueño);
            if (dueño != null)
            {
                if (dueño.Mascota != null)
                {
                    dueño.Mascota.Add(new Mascota { IdMascota = 2, CodigoMascota = 002, NombreMascota = "sinfin", Edad = "2 años", Raza = "Egipcia", Tipo = "gato", Planes = "Diamante", IdentificacionDueño = "25434803" });
                }
                else
                {
                    dueño.Mascota = new List<Mascota>{
                         new Mascota{IdMascota=2,CodigoMascota=002,NombreMascota="sinfin",Edad="2 años",Raza="Egipcia",Tipo="gato", Planes="Diamante",IdentificacionDueño="25434803"}
                     };
                }
                _repoDueñoBD.UpdateDueño(dueño);
            }
        }

        // buscar persona
        private static void BuscarDueño(int idDueño)
        {
            var dueño = _repoDueñoBD.GetDueño(idDueño);
            Console.WriteLine(dueño.Nombre + " " + dueño.Apellido);

        }

        //escribiendo el filtro de dueños
        private static void ListarIdentificacionDueño()
        {
            var dueñoM = _repoDueñoBD.GetDueñoIdentificacion();
            foreach (Dueño p in dueñoM)
            {
                Console.WriteLine(p.Nombre + " " + p.Apellido);
            }

        }

        // listar dueño de gato de raza egipcia
        private static void ListarDueñosPerros()
        {
            var dueñoH = _repoDueñoBD.GetDueñosPerros();
            foreach (Dueño p in dueñoH)
            {
                Console.WriteLine(p.Nombre + " " + p.Apellido +" "+p.IdentificacionDueño);
            }

        }

    }
}

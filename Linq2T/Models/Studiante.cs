using Linq2T.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace Linq2T.Models
{
    public class Studiante
    {
        public int Carnet { get; set; }
        public string Nombre { get; set; }
        public string Materia { get; set; }
        public double Promedio { get; set; }
        public DateTime Fecha { get; set; }


        public List<Studiante> lista()
        {
            var estudiante1 = new Studiante()
            {
                Carnet = 001,
                Nombre = "Maria",
                Materia = "Gestion de Base de Datos",
                Promedio = 9,
                Fecha = DateTime.Now

            };
            var estudiante2 = new Studiante()
            {
                Carnet = 002,
                Nombre = "pepe",
                Materia = "Gestion de Base de Datos",
                Promedio = 4.5,
                Fecha = DateTime.Now

            };
            var estudiante3 = new Studiante()
            {
                Carnet = 003,
                Nombre = "leo",
                Materia = "psicologia",
                Promedio = 10,
                Fecha = DateTime.Now

            };
             var estudiante4 = new Studiante()
            {
                Carnet = 004,
                Nombre = "gerardo",
                Materia = "lenguage",
                Promedio = 9,
                Fecha = DateTime.Now

            };
            var estudiante5 = new Studiante()
            {
                Carnet = 005,
                Nombre = "pepe",
                Materia = "literatura",
                Promedio = 4.5,
                Fecha = DateTime.Now

            };
            var estudiante6 = new Studiante()
            {
                Carnet = 006,
                Nombre = "leo",
                Materia = "Ciencia",
                Promedio = 10,
                Fecha = DateTime.Now

            };


            return new List<Studiante>() {estudiante1,estudiante2,estudiante3, estudiante4, estudiante5, estudiante6 };

        }
    }  

 
}
    



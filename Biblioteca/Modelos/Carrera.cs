using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Carrera
    {
        static int i = 0;
        static List<Carrera> carreras = new List<Carrera>
        {
            new Carrera("Ingeniería en Infotecnología"),
            new Carrera("Ingeniería Civil"),
            new Carrera("Ingeniería Industrial")
        };

        ///Sólo SQL
        int id;
        public String codigo;
        public String nombre;

        ///Solo DEBUG
        public Carrera(String nombre)
        {
            this.id = i++;
            this.codigo = "00" + id;
            this.nombre = nombre;
        }
    }
}

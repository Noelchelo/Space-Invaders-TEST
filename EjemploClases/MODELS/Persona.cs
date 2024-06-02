using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace EjemploClases.MODELS
{
    class Persona
    {

        public Persona()
        {
            Nombre = "Noel";
            Apellido = "Arguello";
            Edad = 25;
        }

        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int Edad { get; set; }
        
    }
}

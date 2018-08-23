using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace constructores2
{
    class Materia
    {
        public string Nombre { get; set; }
        public string Identificador { get; set; }

        public Materia()
        {
            Nombre = "Materia nueva";
            Identificador = "0";
        }

        public Materia ( string nombre, string indentificador)
        {
            Nombre = nombre;
            Identificador = Identificador;
        }
    }
}
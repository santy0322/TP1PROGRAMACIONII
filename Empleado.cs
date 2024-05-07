using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1PROGRAMACIONII
{
    internal class Empleado
    {
        private int id;
        private string nombre;
        private string apellido;
        private long DNI;
        private Terminal terminal;

        public Empleado(string nombre,string apellido,long dni,Terminal terminal)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.DNI = dni;
            this.terminal = terminal;
        }
    }
}

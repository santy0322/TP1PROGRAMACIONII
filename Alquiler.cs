using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1PROGRAMACIONII
{
    internal class Alquiler
    {
        private long IdAlquiler;
        private Cliente Cliente;
        private List<Maquina> Maquinas;
        private DateTime FechaInicio;
        private DateTime FechaFinal;
        private double Precio;
        private Empleado Empleado;
        private Terminal terminal;

        public Alquiler(Cliente Cliente, List<Maquina> Maquinas, DateTime FechaFinal, double Precio, Empleado Empleado)
        {
            this.Cliente = Cliente;
            this.Empleado = Empleado;
            this.Maquinas = Maquinas;
            this.FechaInicio = DateTime.Now;
            this.FechaFinal = FechaFinal;
            this.Precio = Precio;
            
        }

    }
}

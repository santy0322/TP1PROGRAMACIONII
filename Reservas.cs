using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1PROGRAMACIONII
{
    internal class Reservas
    {
        private int IdReserva;
        private Cliente cliente;
        private Maquina Maquina;
        private DateTime FechaAdd; //Fecha que se agrego la reserva;
        private char status; //puede ser P(procesado), R(Rechazado) si paso mas de las 48hs,A(activo)

        public Reservas(Cliente cliente,Maquina maquina)
        {

            this.cliente = cliente;
            this.Maquina = maquina;
            this.FechaAdd = DateTime.Now;
            this.status ='A' ;
            
        }
    }
}

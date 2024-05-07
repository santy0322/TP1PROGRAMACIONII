using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1PROGRAMACIONII
{
    public class Maquina
    {
        private long codigo;
        private string marca;
        private string modelo;
        private string descripcion;
        private string status;
        private DateTime AddDate;

        public Maquina(long Codigo,string Marca,string Modelo,string descipcion, string status)
        {
            this.codigo = Codigo;
            this.marca = Marca;
            this.modelo = Modelo;
            this.descripcion = descipcion;
            this.status = status;
            this.AddDate = DateTime.Now;
        }


    }

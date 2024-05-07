using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1PROGRAMACIONII
{
    public class Cliente
    {
        public string? RazonSocial { get; set; }

        public string? Direccion { get; set; }

        public string? CodigoPostal { get; set; }

        public double Cuit { get; set; }

        public string? CondicionTributaria { get; set; }

        public string? Nombre { get; set; }

        public string? Apellido { get; set; }

        public int Telefono { get; set; }
        
        public string? CorreoElectronico { get; set;}

        public List<Maquina> Maquinas;

        public Cliente(string? razonSocial, string? direccion, string? codigoPostal, double cuit, string? condicionTributaria, string? nombre, string? apellido, int telefono, string? correoElectronico)
        {
            RazonSocial = razonSocial;
            Direccion = direccion;
            CodigoPostal = codigoPostal;
            Cuit = cuit;
            CondicionTributaria = condicionTributaria;
            Nombre = nombre;
            Apellido = apellido;
            Telefono = telefono;
            CorreoElectronico = correoElectronico;
        }
    }
}

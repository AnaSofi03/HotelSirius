using HotelSirius.CapaDatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelSirius.CapaLogica
{
    internal class PagoEfectivo
    {
        private string NombreTitular;
        private double Precio;
        private int DNI;
        private DateTime FechaIngreso, FechaSalida;

        public string NombreTitular1 { get => NombreTitular; set => NombreTitular = value; }
        public double Precio1 { get => Precio; set => Precio = value; }
        public int DNI1 { get => DNI; set => DNI = value; }
        public DateTime FechaIngreso1 { get => FechaIngreso; set => FechaIngreso = value; }
        public DateTime FechaSalida1 { get => FechaSalida; set => FechaSalida = value; }

        public void CrearPago(string nombre, int dni, double total)
        {
            this.NombreTitular1 = nombre;
            this.Precio1 = total;
            this.DNI1 = dni;
        }

        public void GuardarPago(PagoEfectivo pago)
        {
            Datos conex = new Datos();
            conex.guardarPagoEfectivo(pago);
        }
    }
}

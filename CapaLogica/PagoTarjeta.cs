using HotelSirius.CapaDatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelSirius.CapaLogica
{
    internal class PagoTarjeta
    {
        private string NombreTitular;
        private double Precio;
        private int DNI;
        private int CodigoSeguridad;
        private DateTime Vencimiento;
        private DateTime FechaIngreso, FechaSalida;

        public string NombreTitular1 { get => NombreTitular; set => NombreTitular = value; }
        public double Precio1 { get => Precio; set => Precio = value; }
        public int DNI1 { get => DNI; set => DNI = value; }
        public DateTime FechaIngreso1 { get => FechaIngreso; set => FechaIngreso = value; }
        public DateTime FechaSalida1 { get => FechaSalida; set => FechaSalida = value; }
        public int CodigoSeguridad1 { get => CodigoSeguridad; set => CodigoSeguridad = value; }
        public DateTime Vencimiento1 { get => Vencimiento; set => Vencimiento = value; }

        public void CrearPagoTarjeta(string nombre, double total, int dni, int CodSeg, DateTime Venc)
        {
            this.NombreTitular1 = nombre;
            this.Precio1 = total;
            this.DNI1 = dni;
            this.CodigoSeguridad1 = CodSeg;
            this.Vencimiento1 = Venc;
        }

        public void GuardarPagoTarjeta(PagoTarjeta pagoT)
        {
            Datos conex = new Datos();
            conex.guardarPagoTarjeta(pagoT);
        }
    }
}

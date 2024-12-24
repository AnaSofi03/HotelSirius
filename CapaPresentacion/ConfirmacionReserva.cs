using HotelSirius.CapaLogica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelSirius.CapaPresentacion
{
    public partial class ConfirmacionReserva : Form
    {
        public ConfirmacionReserva()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (comboBox1.SelectedIndex == 0)
            {
                // Código para la primera opción

                PagoEfectivo pagoEF = new PagoEfectivo();
                pagoEF.FechaIngreso1 = dateTimePicker1.Value.Date;
                pagoEF.FechaSalida1 = dateTimePicker2.Value.Date;

                FacturacionEfectivo pago = new FacturacionEfectivo();
                pago.Show();
            }
            else if (comboBox1.SelectedIndex == 1)
            {
                // Código para la segunda opción
                PagoTarjeta pagoT = new PagoTarjeta();
                pagoT.FechaIngreso1 = dateTimePicker1.Value.Date;
                pagoT.FechaSalida1 = dateTimePicker2.Value.Date;

                FacturacionTarjeta pagoTarjeta = new FacturacionTarjeta();
                pagoTarjeta.Show();
            }
            else
            {
                MessageBox.Show("Seleccione el tipo de pago");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

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
    public partial class FacturacionEfectivo : Form
    {
        public FacturacionEfectivo()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PagoEfectivo pago = new PagoEfectivo();
            pago.CrearPago(textBox1.Text, Convert.ToInt32(textBox3.Text), Convert.ToDouble(textBox4.Text));

            pago.GuardarPago(pago);
        }
    }
}

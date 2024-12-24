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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace HotelSirius.CapaPresentacion
{
    public partial class FacturacionTarjeta : Form
    {
        public FacturacionTarjeta()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PagoTarjeta pago = new PagoTarjeta();
            pago.CrearPagoTarjeta(textBox1.Text, Convert.ToDouble(textBox6.Text), Convert.ToInt32(textBox2.Text), Convert.ToInt32(textBox5.Text), dateTimePicker1.Value.Date);

            pago.GuardarPagoTarjeta(pago);
        }
    }
}

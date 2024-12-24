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
    public partial class HabitacionPremium : Form
    {
        public HabitacionPremium()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            ConfirmacionReserva confirmar = new ConfirmacionReserva();
            confirmar.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            ConfirmacionReserva confirmar = new ConfirmacionReserva();
            confirmar.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ConfirmacionReserva confirmar = new ConfirmacionReserva();
            confirmar.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ConfirmacionReserva confirmar = new ConfirmacionReserva();
            confirmar.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ConfirmacionReserva confirmar = new ConfirmacionReserva();
            confirmar.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            ConfirmacionReserva confirmar = new ConfirmacionReserva();
            confirmar.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

using HotelSirius.CapaDatos;
using HotelSirius.CapaLogica;
using HotelSirius.CapaPresentacion;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelSirius
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Register register = new Register();
            register.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Usuario user = new Usuario();

            user.loginUsuario(textBox1.Text, textBox2.Text);
        }
    }
}

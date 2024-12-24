using HotelSirius.CapaLogica;
using HotelSirius.CapaPresentacion;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelSirius.CapaDatos
{
    internal class Datos
    {

        SqlConnection conexion = new SqlConnection("Server = LUCAS-PC; Database = HotelSirius; Trusted_Connection = True;");

        public void guardarUser(Usuario user)
        {
            conexion.Open();

            string queryCheck = "SELECT COUNT (*) FROM FichaUsuario where Usuario = '" + user.User + "'";

            SqlCommand comandoCheck = new SqlCommand(queryCheck, conexion);

            int userExists = (int)comandoCheck.ExecuteScalar();

            if (userExists > 0)
            {

                MessageBox.Show("El usuario ya existe.");

            } else
            {
                string query = "INSERT INTO FichaUsuario(Usuario, Contraseña) VALUES ('" + user.User + "' , '" + user.Contraseña + "')";

                SqlCommand comando = new SqlCommand(query, conexion);

                comando.ExecuteReader();

                conexion.Close();

                MessageBox.Show("Usuario guardado con exito");
            }

        }

        public void loginUser(string user, string contra)
        {
            conexion.Open();

            // Consulta para verificar si el usuario y la contraseña son correctos
            string query = "SELECT COUNT(*) FROM FichaUsuario WHERE Usuario = '" + user + "' AND Contraseña = '" + contra + "'";
            SqlCommand comando = new SqlCommand(query, conexion);

            int loginCorrecto = (int)comando.ExecuteScalar();

            if (loginCorrecto > 0)
            {
                MessageBox.Show("Inicio de sesión exitoso.");

                MenuPrincipal menu = new MenuPrincipal();
                menu.Show();
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos.");
            }

            conexion.Close();
        }

        public void guardarPagoEfectivo(PagoEfectivo pago)
        {
            conexion.Open();

            string query = "INSERT INTO PagoEfectivo(NombreTitular, Precio, FechaIngreso, FechaSalida, DNI) " +
                "VALUES ('" + pago.NombreTitular1 + "' , '" + pago.Precio1 + "' , '"+ pago.FechaIngreso1 +"' , '"+ pago.FechaSalida1 +"' , '"+ pago.DNI1 +"')";

            SqlCommand comando = new SqlCommand(query, conexion);

            comando.ExecuteReader();

            conexion.Close();

            MessageBox.Show("Pago en efectivo realizado con exito");
        }

        public void guardarPagoTarjeta(PagoTarjeta pago)
        {
            conexion.Open();

            string query = "INSERT INTO PagoTarjeta(NombreTitular, DNI, Precio, CodigoSeguridad, FechaVencimiento, FechaIngreso, FechaSalida) VALUES ('" + pago.NombreTitular1 + "' , '" + pago.DNI1 + "' , '" + pago.Precio1 + "' , '"+ pago.CodigoSeguridad1 +"' , '"+ pago.Vencimiento1 +"' , '" + pago.FechaIngreso1 + "' , '" + pago.FechaSalida1 + "')";

            SqlCommand comando = new SqlCommand(query, conexion);

            comando.ExecuteReader();

            conexion.Close();

            MessageBox.Show("Pago con tarjeta realizado con exito");
        }
    }
}
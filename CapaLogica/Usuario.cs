using HotelSirius.CapaDatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelSirius.CapaLogica
{
    internal class Usuario
    {
        private string user, contraseña;

        public string User { get => user; set => user = value; }
        public string Contraseña { get => contraseña; set => contraseña = value; }

        public void crearUsuario(string usuario, string contra)
        {
            this.User = usuario;
            this.Contraseña = contra;
        }

        public void loginUsuario(string user, string contra)
        {
            Datos conex = new Datos();

            conex.loginUser(user, contra);
        }

        public void EnviarUsuario(Usuario user)
        {
            Datos conex = new Datos();
            conex.guardarUser(user);
        }

    }
}

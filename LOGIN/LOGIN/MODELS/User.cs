using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LOGIN.MODELS
{
    internal class User
    {
        private string usuario;
        private string contraseña;

        public Login(string usuario, string contraseña)
        {
            this.usuario = usuario;
            this.contraseña = contraseña;
        }

        public bool IniciarSesion(string usuario, string contraseña)
        {
            return this.usuario == usuario && this.contraseña == contraseña;
        }
    }
}

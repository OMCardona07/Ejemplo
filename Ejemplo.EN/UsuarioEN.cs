using System;
using System.Collections.Generic;
using System.Text;

namespace Ejemplo.EN
{
    public class UsuarioEN
    {
        public Int64 idUser { get; set; }
        public string userName { get; set; }
        public string pass { get; set; }

        public UsuarioEN() { }

        public UsuarioEN(Int64 pIdUser, string pUserName, string pPass)
        {
            idUser = pIdUser;
            userName = pUserName;
            pass = pPass;
        }
    }
}

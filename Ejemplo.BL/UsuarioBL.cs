using System;
using System.Collections.Generic;
using System.Text;
using Ejemplo.EN;
using Ejemplo.DAL;

namespace Ejemplo.BL
{
    public class UsuarioBL
    {
        UsuarioDAL DAL = new UsuarioDAL();

        public int AgregarUsuario(UsuarioEN pUsuario)
        {
            return DAL.AgregarUsuario(pUsuario);
        }
    }
}

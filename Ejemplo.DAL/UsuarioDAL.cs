using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using Ejemplo.EN;
using MySql.Data.MySqlClient;

namespace Ejemplo.DAL
{
    public class UsuarioDAL
    {
        
        public int AgregarUsuario(UsuarioEN pUsuario)
        {
            BDComun conexion = new BDComun();
            int retorno;
            MySqlCommand comando = new MySqlCommand(string.Format("INSERT INTO usuario1 (id, userName, pass) VALUES('{0}','{1}','{2}')", pUsuario.idUser, pUsuario.userName, pUsuario.pass),conexion.establecerConxion());
            retorno = comando.ExecuteNonQuery();
            try
            {
                return retorno;
            }

            catch(Exception e)
            {
                MessageBox.Show("Ha ocurrido un error inesperado"+e, "Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return retorno;
            }
            
        }
    }
}

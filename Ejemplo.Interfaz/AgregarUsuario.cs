using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Ejemplo.EN;
using Ejemplo.BL;

namespace Ejemplo.Interfaz
{
    public partial class AgregarUsuario : Form
    {
        UsuarioEN _user = new UsuarioEN();
        UsuarioBL _userBL = new UsuarioBL();
        public AgregarUsuario()
        {
            InitializeComponent();
        }

        private void btnAgregarUsuario_Click(object sender, EventArgs e)
        {
            if(txtId.Text !="" && txtUserName.Text!="" && txtPass.Text!="")
            {
                _user.idUser = int.Parse(txtId.Text);
                _user.userName = txtUserName.Text;
                _user.pass = txtPass.Text;

                _userBL.AgregarUsuario(_user);
                MessageBox.Show("El usuario fue registrado con exito");
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace ProyectoET
{
    public class Validacion 
    {
        string usuario;
        string password;

        public Validacion(string a, string b) {

            usuario = a;
            password = b;
        
        
        }





        public void validar()
        {


            //string user = txtUser.Text;
            //string pass = txtPass.Text;
        
            while (true)
            {

                if (usuario == "enzo" && password == "password")
                {

                    Administracion frm = new Administracion();
                    frm.Show();



                }
                else
                {
                    MessageBox.Show("Contraseña o usuario invalido", "Acceso no habilitado",MessageBoxButtons.OK,MessageBoxIcon.Information);
                }

                //txtUser.Text = "";
                //txtPass.Text = "";
                //txtUser.Focus();


                break;
            }
        }
    }
}

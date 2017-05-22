using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ProyectoET
{
    public partial class ingresar : Form
    {
        public ingresar()
        {
           
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            txtUser.Select();
        }

         string usr, pass;

           

        private void btnLogin_Click(object sender, EventArgs e)
        {
            usr = txtUser.Text;
            pass = txtPass.Text;

            Validacion obj = new Validacion(usr,pass);
            obj.validar();
            



        }

        private void txtPass_TextChanged(object sender, EventArgs e)
        {


            
           
          

           

            //usr = txtUser.Text;
            //pass = txtPass.Text;

        
         
           


            //if ((int)x.KeyCode==(int)Keys.Enter)
            //{
            //    Validacion obj = new Validacion(usr,pass);
            //    obj.validar();
            //}
        }
    }
}

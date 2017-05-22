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
    public partial class Administracion : Form
    {
        public Administracion()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            ingresar.ActiveForm.Hide();
        }

        private void Administracion_Load(object sender, EventArgs e)
        {

        }

        private void btnSalirSys_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnPing_Click(object sender, EventArgs e)
        {
            

            string URL = txtURL.Text;
            string requests = nUsolicitud.Value.ToString();




            string command = "ping "+URL;

            MessageBox.Show("Haciendo un ping a: "+URL+"\n"+
            "Solicitudes: "+requests,"Ping",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);


            comandosCMD obj = new comandosCMD(command);

            obj.ExecuteCommand();
            

           

        }
    }
}

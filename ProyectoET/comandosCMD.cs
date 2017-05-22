using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Security.Principal;
using System.Windows;
using System.Windows.Shell;

namespace ProyectoET
{
    class comandosCMD
    {
        private string cmd;

        public comandosCMD(string comando){


            cmd = comando;


        }

        public bool checkAdmin()
        {
            WindowsIdentity id = WindowsIdentity.GetCurrent();
            WindowsPrincipal pr = new WindowsPrincipal(id);

            return pr.IsInRole(WindowsBuiltInRole.Administrator);
        }




        public void startCMD(string comando) {


            string command = comando;
            Console.WriteLine("CMD Executer V.0.1");
            Console.WriteLine("Last Release 05 - Febraury - 2012");

          

            //while (true)
            //{
            //    Console.Write("#:");
            //    command = Console.ReadLine();
            //    if (command == "Salir" || command == "salir")
            //    {
            //        break;
            //    }
            //    ExecuteCommand(command);
            //}
        
        }



        public void ExecuteCommand()
        {

            if (checkAdmin() == false)
            {
                //// Restart program and run as admin
                //var exeName = System.Diagnostics.Process.GetCurrentProcess().MainModule.FileName;
                //System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo(exeName);
                //startInfo.Verb = "runas";
                //System.Diagnostics.Process.Start(startInfo);

                //Application.Current.Shutdown();
                //return;



                //Indicamos que deseamos inicializar el proceso cmd.exe junto a un comando de arranque. 
                //(/C, le indicamos al proceso cmd que deseamos que cuando termine la tarea asignada se cierre el proceso).
                //Para mas informacion consulte la ayuda de la consola con cmd.exe /? 
                System.Diagnostics.ProcessStartInfo procStartInfo = new System.Diagnostics.ProcessStartInfo("cmd","/c" + cmd);
                procStartInfo.Verb = "runas";
               

                // Indicamos que la salida del proceso se redireccione en un Stream
                procStartInfo.RedirectStandardOutput = true;
                procStartInfo.UseShellExecute = false;
                //Indica que el proceso no despliegue una pantalla negra (El proceso se ejecuta en background)
                procStartInfo.CreateNoWindow = true;
                //Inicializa el proceso
             


                System.Diagnostics.Process proc = new System.Diagnostics.Process();


                proc.StartInfo = procStartInfo;
     
                proc.Start();
                //Consigue la salida de la Consola(Stream) y devuelve una cadena de texto
                string result = proc.StandardOutput.ReadToEnd();

                
                //Muestra en pantalla la salida del Comando
                MessageBox.Show(result,"Resultado Ping",MessageBoxButton.OK,MessageBoxImage.Information);













            }
        }

    }
}

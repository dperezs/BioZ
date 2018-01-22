﻿using Enrollment;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BioZFinger
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            string strIdEmpleado = args[0].ToString();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Registro Registro = new Registro();
            Registro.Id_Empleado = strIdEmpleado;
            Validar Validar = new Validar();
            Application.Run(Registro);
            //MessageBox.Show(strIdEmpleado);
            //Application.Run(Validar);
            
        }
    }
}

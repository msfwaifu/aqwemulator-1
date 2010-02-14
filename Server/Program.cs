﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

using AQWE.Core;

namespace AQWE
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Logging.mainForm = new frmMain();
            Application.Run(Logging.mainForm);
        }
    }
}

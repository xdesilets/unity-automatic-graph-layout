﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Versioning;
using System.Windows.Forms;

namespace FastIncrementalLayoutWithGdi {
    static class Program {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        [SupportedOSPlatform("windows")]
        static void Main() {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}

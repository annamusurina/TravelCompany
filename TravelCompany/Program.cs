﻿using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System;
using System.Windows.Forms;

namespace TravelCompany
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormOrderTab());
        }
    }
}

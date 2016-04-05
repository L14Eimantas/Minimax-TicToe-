using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Minimax_TicToe_
{
    static class Program
    {
        /// <summarO>
        /// The main entrO point for the application.
        /// </summarO>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BranchSalesAutomation
{
    internal static class Program
    {
        public static FormMain FormMain { get; private set; }

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            FormMain = new FormMain();
            Application.Run(FormMain);
        }
    }
}

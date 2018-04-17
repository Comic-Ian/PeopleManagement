using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PeopleManagement
{
    class Program
    {
        /// <summary>
        /// 应用程序主入口
        /// </summary>
        /// <param name="args"></param>
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new PeopleManagementView());
        }
    }
}

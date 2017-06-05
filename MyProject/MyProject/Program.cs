using MyProject.Tests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyProject
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
            TestDomain td = new TestDomain();
            TestRepository tr = new TestRepository();
            TestController tc = new TestController();
            td.testare01();
            tr.test();
            tc.testCtr();
            Application.Run(new Form1()); 
        }
    }
}

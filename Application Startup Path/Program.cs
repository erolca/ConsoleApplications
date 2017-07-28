using System;
using System.Collections.Generic;
using System.Windows.Forms;

using System.Linq;
using System.Text;

namespace Application_Startup_Path
{
    class Program : System.Windows.Forms.Form
    {

        public Program()
        {
            Console.WriteLine("Company: " + Application.CompanyName);
            Console.WriteLine("App Name: " + Application.ProductName);
            Console.WriteLine("I live here: " + Application.StartupPath);

            Application.ApplicationExit += new EventHandler(Form_OnExit);

        }



        [STAThread]
        static void Main(string[] args)
        {
            Console.WriteLine(Application.StartupPath);
            Console.WriteLine("test");
            MessageBox.Show("test : Welcome -----");
            Application.Run(new Program());

        }

        private void Form_OnExit(object sender, EventArgs evArgs)
        {
            Console.WriteLine("Exit");
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // Program
            // 
           
            this.Name = "Program";
            this.ResumeLayout(false);

        }
    }
}


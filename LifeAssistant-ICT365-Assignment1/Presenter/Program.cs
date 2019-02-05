using System;
using System.Windows.Forms;
using LifeAssistant_ICT365_Assignment1.Model;
using LifeAssistant_ICT365_Assignment1.View;

namespace LifeAssistant_ICT365_Assignment1
{
    class Program
    {
        // API AIzaSyCa-nRilPzCfmKTOGMZnEKEPB3X9w2szGw
        static Viewer view = Viewer.Instance();
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.Run(view);
            //Application.ApplicationExit += new EventHandler(Application_ApplicationExit);
        }

        //private static void Application_ApplicationExit(object sender, EventArgs e)
        //{
        //    view.Form1_FormClosing(sender, e);
        //}
    }
}

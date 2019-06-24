using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using EasyTabs;
namespace StoreCSharpProject
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
              Application.Run(new LoginForm());


            //AppContainer container = new AppContainer();

            //// add itiail tab
            //container.Tabs.Add(
            //    new TitleBarTab(container)
            //    {
            //        Content = new Dashboard
            //        {
            //            Text = "الصفحة الرئيسية"
            //        }
            //    });
            //container.SelectedTabIndex = 0;
            //TitleBarTabsApplicationContext applicationContext = new TitleBarTabsApplicationContext();
            //applicationContext.Start(container);
            //Application.Run(applicationContext);

        }
    }
}

using System;
using EasyTabs;

namespace StoreCSharpProject
{
    public partial class AppContainer : TitleBarTabs
    {
        public AppContainer()
        {
            InitializeComponent();
            AeroPeekEnabled = true;
            TabRenderer = new ChromeTabRenderer(this);
        }

        public override TitleBarTab CreateTab()
        {
            return new TitleBarTab(this)
            {
                Content = new Dashboard
                {
                    Text = "New Tab"
                }
            };
        }

        private void AppContainer_Load(object sender, EventArgs e)
        {
           
        }
    }
}

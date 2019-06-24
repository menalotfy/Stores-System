using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EasyTabs;

namespace StoreCSharpProject
{
    public partial class Dashboard : Form
    {
        protected TitleBarTabs ParentTabs
        {
            get
            {
                return (ParentForm as TitleBarTabs); 
            }
        }

        public Dashboard()
        {
            InitializeComponent();
        
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {

        }



        private void btn_dashboard_supplier_Click(object sender, EventArgs e)
        {
            ParentTabs.Tabs.Add(new TitleBarTab(ParentTabs)
            {
                Content = new SupplierForm { Text = "الموردين" }
            });
            ParentTabs.SelectedTabIndex = ParentTabs.Tabs.Count - 1;

        }

        private void btn_dashboard_customer_Click(object sender, EventArgs e)
        {
            ParentTabs.Tabs.Add(new TitleBarTab(ParentTabs)
            {
                Content = new CustomerForm1 { Text = "العملاء" }
            });
            ParentTabs.SelectedTabIndex = ParentTabs.Tabs.Count - 1;

        }

        private void btn_generalbill_Click(object sender, EventArgs e)
        {
            ParentTabs.Tabs.Add(new TitleBarTab(ParentTabs)
            {
                Content = new GeneralBillForm { Text = "فاتورة بيع" }
            });
            ParentTabs.SelectedTabIndex = ParentTabs.Tabs.Count - 1;

        }

        //private void btn_dashboard_returned_Click(object sender, EventArgs e)
        //{
        //    ParentTabs.Tabs.Add(new TitleBarTab(ParentTabs)
        //    {
        //        Content = new ReturnedHomeForm { Text = "مرتجع " }
        //    });
        //    ParentTabs.SelectedTabIndex = ParentTabs.Tabs.Count - 1;
        //}

        private void button1_Click_1(object sender, EventArgs e)
        {
            ParentTabs.Tabs.Add(new TitleBarTab(ParentTabs)
            {
                Content = new ReturnFromCustomer { Text = "مرتجع عميل" }
            });
            ParentTabs.SelectedTabIndex = ParentTabs.Tabs.Count - 1;
        }

        private void btnDashboard_ReturnedFromCustomer_Click(object sender, EventArgs e)
        {
            ParentTabs.Tabs.Add(new TitleBarTab(ParentTabs)
            {
                Content = new retunedFromSalesCustomer { Text = "مرتجع من مندوب" }
            });
            ParentTabs.SelectedTabIndex = ParentTabs.Tabs.Count - 1;
        }

        private void btnDashboard_ReturnedToSupplier_Click(object sender, EventArgs e)
        {
            ParentTabs.Tabs.Add(new TitleBarTab(ParentTabs)
            {
                Content = new ReturnToSuplier { Text = "مرتجع إلي مورد" }
            });
            ParentTabs.SelectedTabIndex = ParentTabs.Tabs.Count - 1;
        }

        private void btn_dashboard_Employee_Click(object sender, EventArgs e)
        {
            ParentTabs.Tabs.Add(new TitleBarTab(ParentTabs)
            {
                Content = new EmployeeFormNew { Text = "الموظفين" }
            });
            ParentTabs.SelectedTabIndex = ParentTabs.Tabs.Count - 1;
        }

        private void btn_dashbpard_billbuy_Click(object sender, EventArgs e)
        {

            ParentTabs.Tabs.Add(new TitleBarTab(ParentTabs)
            {
                Content = new SalesOrderForm { Text = "فاتورة بيع" }
            });
            ParentTabs.SelectedTabIndex = ParentTabs.Tabs.Count - 1;
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            ParentTabs.Tabs.Add(new TitleBarTab(ParentTabs)
            {
                Content = new MandobeenForm { Text = "المندوبين" }
            });
            ParentTabs.SelectedTabIndex = ParentTabs.Tabs.Count - 1;
        }

        private void btn_dashboard_eznSarf_Click(object sender, EventArgs e)
        {
            ParentTabs.Tabs.Add(new TitleBarTab(ParentTabs)
            {
                Content = new OrderRepresantitve { Text = "إذن صرف" }
            });
            ParentTabs.SelectedTabIndex = ParentTabs.Tabs.Count - 1;
        }

        private void btn_dashboard_product_Click(object sender, EventArgs e)
        {
            ParentTabs.Tabs.Add(new TitleBarTab(ParentTabs)
            {
                Content = new ProductForm { Text = "المنتجات" }
            });
            ParentTabs.SelectedTabIndex = ParentTabs.Tabs.Count - 1;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ParentTabs.Tabs.Add(new TitleBarTab(ParentTabs)
            {
                Content = new ReturnedFromOrderRepresentative { Text = "مرتجع من إذن الصرف" }
            });
            ParentTabs.SelectedTabIndex = ParentTabs.Tabs.Count - 1;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ParentTabs.Tabs.Add(new TitleBarTab(ParentTabs)
            {
                Content = new SalesBillMandob { Text = "فواتير المندوب" }
            });
            ParentTabs.SelectedTabIndex = ParentTabs.Tabs.Count - 1;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ParentTabs.Tabs.Add(new TitleBarTab(ParentTabs)
            {
                Content = new www { Text = "new form" }
            });
            ParentTabs.SelectedTabIndex = ParentTabs.Tabs.Count - 1;
        }
    }
}

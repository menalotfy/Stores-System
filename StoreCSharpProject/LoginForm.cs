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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if(txt_username.Text == "Admin" && txt_password.Text == "12345")
            {
                AppContainer container = new AppContainer();
                // add itiail tab
                container.Tabs.Add(
                    new TitleBarTab(container)
                    {
                        Content = new Dashboard
                        {
                            Text = "الصفحة الرئيسية"
                        }
                    });
                container.SelectedTabIndex = 0;
                TitleBarTabsApplicationContext applicationContext = new TitleBarTabsApplicationContext();
                applicationContext.Start(container);
                //this.Hide();
              //  this.Visible = false;
               //  this.Close();
                this.Hide();
               
                container.Show();
                //this.Close();

                
            }

            else
            {
                MessageBox.Show("يجب إدخال اسم المستخدم وكلمة المرور بطريقة صحيحية");
            }




        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {


            if (txt_password.UseSystemPasswordChar == true)
            {
                txt_password.UseSystemPasswordChar = false;
                button3.Text = "إخفاء";
            }
            else
            {
                txt_password.UseSystemPasswordChar = true;
                button3.Text = "عرض";
            }
        }


    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelProject
{
    public partial class SystemLogin : Form
    {
        public SystemLogin()
        {
            InitializeComponent();
        }
        private void Login(object sender, EventArgs e)
        {
            if (username.Text.Length == 0)
            {
                MessageBox.Show("Enter Username ");
            }
            else if (password.Text.Length == 0)
            {
                MessageBox.Show("Enter passowrd ");
            }
            else
            {
                List<LoginInfo> log = new List<LoginInfo>();
                DataBase ds = new DataBase();
                log = ds.SelectLoginInfo();
                bool ok = false;
                for (int i = 0; i < log.Count(); i++)
                {
                    if (username.Text == log[i].username && password .Text== log[i].password)
                    {
                        if (log[i].role == "manager")
                        {
                            Manager_Homepage m = new Manager_Homepage(log[i].username);                           
                            m.Show();
                            this.Hide();
                            ok = true;
                            break;
                        }
                        else   // recptionist
                        {
                            Receptionist_Homepage h = new Receptionist_Homepage(log[i].username);
                            h.Show();
                            this.Hide();
                            ok = true;
                            break;
                        }}
                }
                if (ok==false)
                {
                    MessageBox.Show("Username and passowrd not Correct ");
                }
            }
        }

        private void Login(object sender, DragEventArgs e)
        {
            
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            DateTimePicker d;
            DateTime dd;
          //  dd = this.dateTimePicker2.Value;
          //  int y = dd.Year;

           // this.dateTimePicker2.Value = dd;
          //  MessageBox.Show(dd.Year.ToString());
        }

        private void SystemLogin_Load(object sender, EventArgs e)
        {

        }
    }
}

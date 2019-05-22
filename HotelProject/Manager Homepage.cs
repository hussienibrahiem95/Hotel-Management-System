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
    public partial class Manager_Homepage : Form
    {
        bool ok = false;

        public Manager_Homepage(string name)
        {
            ok = false;
            InitializeComponent();
            Well.Text += name;
        }
        private void monoFlat_Button3_Click(object sender, EventArgs e)
        {
            Add_Serveice ad = new Add_Serveice();
            ad.Show();
        }

        private void Manager_Homepage_Load(object sender, EventArgs e)
        {

        }

        private void Manager_Homepage_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (ok == false)
                Application.Restart();
        }
        private void LogOut(object sender, EventArgs e)
        {
            ok = true;
            Application.Restart();
        }
        private void miniTimer_HeaderLabel1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void monoFlat_Button1_Click(object sender, EventArgs e)
        {
            Addoffer ad = new Addoffer();
            ad.Show();
        }

        private void monoFlat_Button2_Click(object sender, EventArgs e)
        {
            deleteoffer del = new deleteoffer();
            del.Show();
        }

        private void monoFlat_Button4_Click(object sender, EventArgs e)
        {
            modifyservice mod = new modifyservice();
            mod.Show();
        }

        private void monoFlat_Button5_Click(object sender, EventArgs e)
        {
            
        }

        private void monoFlat_Button6_Click(object sender, EventArgs e)
        {
            deleteService del = new deleteService();
            del.Show();
        }
    }
}

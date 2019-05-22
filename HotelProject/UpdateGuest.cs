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
    public partial class UpdateGuest : Form
    {
        Receptionist f;
        public UpdateGuest(Receptionist w)
        {
            InitializeComponent();
            f = w;
        }

        private void UpdateGuest_Load(object sender, EventArgs e)
        {

        }

        private void SearchGuest(object sender, EventArgs e)
        {
            Guest g = new Guest();
            g = f.SearchGuest(Convert.ToInt64(ID11.Text));
            if (g.id != -1)
            {
                GuestID.Text = g.id.ToString();
                Fname.Text = g.name;
                Fname.Enabled = true;
                paddress.Text = g.address;
                paddress.Enabled = true;
                pcity.Text = g.city;
                pcity.Enabled = true;
                pmobile.Text = g.mobile.ToString();
                pmobile.Enabled = true;
                pnationality.Text = g.nationality;
                pnationality.Enabled = true;
                pemail.Text = g.email;
                pemail.Enabled = true;
                SaveGuest.Enabled = true;
                gender11.Enabled = true;
                if (g.Gender == false)
                    gender11.SelectedItem=0;
                else
                    gender11.SelectedValue = 1;
            }
            else
            {
                MessageBox.Show("NOT Found ");
            }
        }

        private void SaveGuest_Click(object sender, EventArgs e)
        {
            Guest g = new Guest();
            g.id = Convert.ToInt64(GuestID.Text);
            g.name = Fname.Text;
            g.address = paddress.Text;
            g.city = pcity.Text;
            g.mobile = Convert.ToInt32(pmobile.Text);
            g.nationality = pnationality.Text;
            g.email = pemail.Text;
            if (gender11.SelectedItem.ToString()== "male")
                g.Gender = true;
            else g.Gender = false;
            f.UpdateGuestInfo(g);
            MessageBox.Show("Done");
        }
    }
}

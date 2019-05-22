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
    public partial class BookingRoom : Form
    {
        Receptionist f ;
        public BookingRoom(Receptionist w)
        {
            InitializeComponent();
            f = w;
        }
        public BookingRoom()
        {
            InitializeComponent();
            
        }
        private void iTalk_GroupBox2_Click(object sender, EventArgs e)
        {

        }

        private void ambiance_TextBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void BookingRoom_Load(object sender, EventArgs e)
        {

        }

        private void CheckAva(object sender, EventArgs e)
        {
            List<int> avv;
            DateTime t1=start.Value;
            DateTime t2=end.Value;
            avv = f.checkAv(t1, t2);
            if (avv.Count > 0)
            {
                MessageBox.Show("There is Exist Room");
                for(int i=0;i<avv.Count;i++){
                    ComobRooms.Items.Add(avv[i]);
                }
                start11.Value = start.Value;
                end11.Value = end11.Value;
                start11.Enabled = false;
                end11.Enabled = false;
            }
            else
            {
                MessageBox.Show("Not Found Any Room");
            }
        }

        private void GetInfo(object sender, EventArgs e)
        {
            Guest g;
            g = f.Search(Convert.ToInt64(GuestID.Text));
            if (g.id != -1)
            {
                Fname.Text = g.name;
                Fname.Enabled = false;
                GuestID.Enabled = false;
                paddress.Text = g.address;
                paddress.Enabled = false;
                pcity.Text = g.city;
                pcity.Enabled = false;
                pmobile.Text = g.mobile.ToString();
                pmobile.Enabled = false;
                pnationality.Text = g.nationality;
                pnationality.Enabled = false;
                pemail.Text = g.email;
                pemail.Enabled = false;
                SaveGuest.Enabled = false;
            }
            else
            {
                MessageBox.Show("Not Found This ID ");
            }

        }

        private void SaveGuestInfo(object sender, EventArgs e)
        {
            Guest g = new Guest();
            g.id = Convert.ToInt64(GuestID.Text);
            g.name=Fname.Text;
            g.address=paddress.Text;
            g.city = pcity.Text;
            g.mobile = Convert.ToInt32(pmobile.Text);
            g.nationality=pnationality.Text ;
            g.email=pemail.Text;
            if (gender11.SelectedItem.ToString() == "male")
                g.Gender = true;
            else g.Gender = false;
            f.AddGuest(g);
            MessageBox.Show("Done");
        }

        private void BookRoom(object sender, EventArgs e)
        {
            List<int> avv;
            DateTime t1 = start11.Value;
            DateTime t2 = end11.Value;
            avv = f.checkAv(t1, t2);
            if (avv.Count > 0)
            {
                Booking b = new Booking();
                int Noroom;
                Noroom = Convert.ToInt32(ComobRooms.SelectedItem);
                b.id = Convert.ToInt64(GuestID.Text);
                b.room_id = Noroom;
                b.servis_id = 1;
                if (comboLunch.SelectedItem.ToString() == "Yes")
                    b.havelunch = true;
                else b.havelunch = false;
                string st="";
                if (t1.Day < 10)
                    st += "0";
                st += t1.Day.ToString();
                if (t1.Month < 10)
                    st += "0";
                st += t1.Month.ToString();
                st += t1.Year.ToString();
                b.start = st;
                t1 = t2;
                st = "";
                if (t1.Day < 10)
                    st += "0";
                st += t1.Day.ToString();
                if (t1.Month < 10)
                    st += "0";
                st += t1.Month.ToString();
                st += t1.Year.ToString();
                b.end = st;
                f.AddBook(b);
                MessageBox.Show("Done");
            }
            else
            {
                MessageBox.Show("Not Found Any Room ");
            }
        }

        private void ConfirmReservation(object sender, EventArgs e)
        {
            f.confimReservation(Convert.ToInt64(IDCon.Text), NameCon.Text);
            MessageBox.Show("Done ");
        }

        private void EditReservation(object sender, EventArgs e)
        {
            DateTime t = endedit.Value;
            string st = "";
            if (t.Day < 10)
                st += "0";
            st += t.Day.ToString();
            if (t.Month < 10)
                st += "0";
            st += t.Month.ToString();
            st += t.Year.ToString();
            f.EditReservation(st, IDEdit.Text);
            MessageBox.Show("Done ");
        }

        private void CancelReservation(object sender, EventArgs e)
        {
            f.CancelReservation(Convert.ToInt32(RoomNo.Text));
        }

        private void miniTimer_HeaderLabel2_Click(object sender, EventArgs e)
        {

        }


        

       
    }
}

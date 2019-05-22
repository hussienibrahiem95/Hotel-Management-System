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
    public partial class Booking_Conference_Room : Form
    {
        Receptionist f;
        public Booking_Conference_Room(Receptionist w)
        {
            InitializeComponent();
            f = w;
        }

        private void Booking_Conference_Room_Load(object sender, EventArgs e)
        {

        }

        private void miniTimer_HeaderLabel2_Click(object sender, EventArgs e)
        {

        }
    }
}

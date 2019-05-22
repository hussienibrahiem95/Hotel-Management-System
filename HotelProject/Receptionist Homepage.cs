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
    public partial class Receptionist_Homepage : Form
    {
        bool ok = false;
        Receptionist f = new Receptionist();
        public Receptionist_Homepage(string name)
        {
            ok = false;
            InitializeComponent();
            Well.Text += name;
            CalculateOccuipedRooms();
        }
        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
        private void LogOut(object sender, FormClosedEventArgs e)
        {
            if(ok==false)
            Application.Restart();
        }
        private void LogOut(object sender, EventArgs e)
        {
            ok = true;
            Application.Restart();
        }
        private void avaliabl_Click(object sender, EventArgs e)
        {

        }

        void CalculateOccuipedRooms()
        {
            List<int> roomsoc;

            roomsoc=f.DisplayroomInfo();
            //Room 101
            if (find(roomsoc, 101) == 1)
            {
                room1.BackColor = System.Drawing.Color.Red;
            }
            else
            {
                room1.BackColor = System.Drawing.Color.Lime;
            }
            //Room 102
            if (find(roomsoc, 102) == 1)
            {
                room2.BackColor = System.Drawing.Color.Red;
            }
            else
            {
                room2.BackColor = System.Drawing.Color.Lime;
            }

            if (find(roomsoc, 103) == 1)
            {
                room3.BackColor = System.Drawing.Color.Red;
            }
            else
            {
                room3.BackColor = System.Drawing.Color.Lime;
            } if (find(roomsoc, 104) == 1)
            {
                room4.BackColor = System.Drawing.Color.Red;
            }
            else
            {
                room4.BackColor = System.Drawing.Color.Lime;
            } 
            if (find(roomsoc, 105) == 1)
            {
                room5.BackColor = System.Drawing.Color.Red;
            }
            else
            {
                room5.BackColor = System.Drawing.Color.Lime;
            } 
            if (find(roomsoc, 106) == 1)
            {
                room6.BackColor = System.Drawing.Color.Red;
            }
            else
            {
                room6.BackColor = System.Drawing.Color.Lime;
            } if (find(roomsoc, 107) == 1)
            {
                room7.BackColor = System.Drawing.Color.Red;
            }
            else
            {
                room7.BackColor = System.Drawing.Color.Lime;
            } if (find(roomsoc, 108) == 1)
            {
                room8.BackColor = System.Drawing.Color.Red;
            }
            else
            {
                room8.BackColor = System.Drawing.Color.Lime;
            } if (find(roomsoc, 109) == 1)
            {
                room9.BackColor = System.Drawing.Color.Red;
            }
            else
            {
                room9.BackColor = System.Drawing.Color.Lime;
            } if (find(roomsoc, 110) == 1)
            {
                room10.BackColor = System.Drawing.Color.Red;
            }
            else
            {
                room10.BackColor = System.Drawing.Color.Lime;
            } if (find(roomsoc, 111) == 1)
            {
                room11.BackColor = System.Drawing.Color.Red;
            }
            else
            {
                room11.BackColor = System.Drawing.Color.Lime;
            } if (find(roomsoc, 112) == 1)
            {
                room12.BackColor = System.Drawing.Color.Red;
            }
            else
            {
                room12.BackColor = System.Drawing.Color.Lime;
            } if (find(roomsoc, 113) == 1)
            {
                room13.BackColor = System.Drawing.Color.Red;
            }
            else
            {
                room13.BackColor = System.Drawing.Color.Lime;
            } if (find(roomsoc, 114) == 1)
            {
                room14.BackColor = System.Drawing.Color.Red;
            }
            else
            {
                room14.BackColor = System.Drawing.Color.Lime;
            } if (find(roomsoc, 115) == 1)
            {
                room15.BackColor = System.Drawing.Color.Red;
            }
            else
            {
                room15.BackColor = System.Drawing.Color.Lime;
            } if (find(roomsoc, 116) == 1)
            {
                room16.BackColor = System.Drawing.Color.Red;
            }
            else
            {
                room16.BackColor = System.Drawing.Color.Lime;
            } if (find(roomsoc, 117) == 1)
            {
                room17.BackColor = System.Drawing.Color.Red;
            }
            else
            {
                room17.BackColor = System.Drawing.Color.Lime;
            } if (find(roomsoc, 118) == 1)
            {
                room18.BackColor = System.Drawing.Color.Red;
            }
            else
            {
                room18.BackColor = System.Drawing.Color.Lime;
            } if (find(roomsoc, 119) == 1)
            {
                room19.BackColor = System.Drawing.Color.Red;
            }
            else
            {
                room19.BackColor = System.Drawing.Color.Lime;
            } if (find(roomsoc, 120) == 1)
            {
                room20.BackColor = System.Drawing.Color.Red;
            }
            else
            {
                room20.BackColor = System.Drawing.Color.Lime;
            } if (find(roomsoc, 121) == 1)
            {
                room21.BackColor = System.Drawing.Color.Red;
            }
            else
            {
                room21.BackColor = System.Drawing.Color.Lime;
            } if (find(roomsoc, 122) == 1)
            {
                room22.BackColor = System.Drawing.Color.Red;
            }
            else
            {
                room22.BackColor = System.Drawing.Color.Lime;
            } if (find(roomsoc, 123) == 1)
            {
                room23.BackColor = System.Drawing.Color.Red;
            }
            else
            {
                room23.BackColor = System.Drawing.Color.Lime;
            } if (find(roomsoc, 124) == 1)
            {
                room24.BackColor = System.Drawing.Color.Red;
            }
            else
            {
                room24.BackColor = System.Drawing.Color.Lime;
            } if (find(roomsoc, 125) == 1)
            {
                room25.BackColor = System.Drawing.Color.Red;
            }
            else
            {
                room25.BackColor = System.Drawing.Color.Lime;
            } if (find(roomsoc, 126) == 1)
            {
                room26.BackColor = System.Drawing.Color.Red;
            }
            else
            {
                room26.BackColor = System.Drawing.Color.Lime;
            } if (find(roomsoc, 127) == 1)
            {
                room27.BackColor = System.Drawing.Color.Red;
            }
            else
            {
                room27.BackColor = System.Drawing.Color.Lime;
            } if (find(roomsoc, 128) == 1)
            {
                room28.BackColor = System.Drawing.Color.Red;
            }
            else
            {
                room28.BackColor = System.Drawing.Color.Lime;
            } if (find(roomsoc, 129) == 1)
            {
                room29.BackColor = System.Drawing.Color.Red;
            }
            else
            {
                room29.BackColor = System.Drawing.Color.Lime;
            } if (find(roomsoc, 130) == 1)
            {
                room30.BackColor = System.Drawing.Color.Red;
            }
            else
            {
                room30.BackColor = System.Drawing.Color.Lime;
            } if (find(roomsoc, 131) == 1)
            {
                room31.BackColor = System.Drawing.Color.Red;
            }
            else
            {
                room31.BackColor = System.Drawing.Color.Lime;
            } if (find(roomsoc, 132) == 1)
            {
                room32.BackColor = System.Drawing.Color.Red;
            }
            else
            {
                room32.BackColor = System.Drawing.Color.Lime;
            } if (find(roomsoc, 133) == 1)
            {
                room33.BackColor = System.Drawing.Color.Red;
            }
            else
            {
                room33.BackColor = System.Drawing.Color.Lime;
            } if (find(roomsoc, 134) == 1)
            {
                room34.BackColor = System.Drawing.Color.Red;
            }
            else
            {
                room34.BackColor = System.Drawing.Color.Lime;
            } if (find(roomsoc, 135) == 1)
            {
                room35.BackColor = System.Drawing.Color.Red;
            }
            else
            {
                room35.BackColor = System.Drawing.Color.Lime;
            } if (find(roomsoc, 136) == 1)
            {
                room36.BackColor = System.Drawing.Color.Red;
            }
            else
            {
                room36.BackColor = System.Drawing.Color.Lime;
            }

            avaliabl.Text = "Avaliable                     ";
            avaliabl.Text += (36-roomsoc.Count).ToString();
            Ocup.Text="Occupied                   ";
            Ocup.Text += (roomsoc.Count).ToString();
        }
        int find(List<int> f, int room)
        {
            for (int i = 0; i < f.Count; i++)
            {
                if (f[i] == room)
                    return 1;
            }
            return 0;
        }

        private void BookingRoom_(object sender, EventArgs e)
        {
            BookingRoom b = new BookingRoom(f);
            b.Show();
        }

        private void UpdateGuest(object sender, EventArgs e)
        {
            UpdateGuest up = new UpdateGuest(f);
            up.Show();
        }

        private void Receptionist_Homepage_Load(object sender, EventArgs e)
        {

        }

        private void AddService(object sender, EventArgs e)
        {
            AddroomService1 ad = new AddroomService1(f);
            ad.Show();
        }

        private void BookingConference(object sender, EventArgs e)
        {
            Booking_Conference_Room bk = new Booking_Conference_Room(f);
            bk.Show();
        }

        private void AddFeedBack_Click(object sender, EventArgs e)
        {
            AddFeedBack ad = new AddFeedBack();
            ad.Show();
        }

        private void CheckOutGuest(object sender, EventArgs e)
        {
            CheckoutGuest chk = new CheckoutGuest();
            chk.Show();
        }
    }
}
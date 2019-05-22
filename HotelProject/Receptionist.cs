using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace HotelProject
{
    public class Receptionist : DataBase
    {
        public List<Room> Rooms; //
        public List<Booking> resrves;  //
        public List<Services> servicess; //
        public List<Guest> guests; //
        static int c = 0;
        Receptionist_Homepage fo1;
        public Receptionist()
        {
            if (c == 0)
            {
                DataBase db = new DataBase();
                Rooms = new List<Room>();
                resrves = new List<Booking>();
                servicess = new List<Services>();
                guests = new List<Guest>();
                Rooms = db.SelectRoomsInfo();
                guests = db.SelectGuestsInfo();
                servicess = db.SelectServicesInfo();
                resrves = db.SelectBookingInfo();
            }
            c = 1;
        }
        public Receptionist(Receptionist_Homepage fo)
        {
             fo1= fo;
             //data.getrooms();
             //data.getRooms();
        }
        public List<int> DisplayroomInfo()
        {
            List<int> occupiedRooms=new List<int>();
            DateTime d;
            d = DateTime.Now;
            for (int i = 0; i < resrves.Count; i++)
            {
                string st = resrves[i].start;
                string en = resrves[i].end;
                string year1="", year2="", d1="", d2="", m1="", m2="";
                d1 += st.ElementAt(0);
                d1 += st.ElementAt(1);
                d2 += en.ElementAt(0);
                d2 += en.ElementAt(1);
                m1 += st.ElementAt(2);
                m1 += st.ElementAt(3);
                m2 += en.ElementAt(2);
                m2 += en.ElementAt(3);
                year1 += st.ElementAt(4);
                year1 += st.ElementAt(5);
                year1 += st.ElementAt(6);
                year1 += st.ElementAt(7);
                year2 += en.ElementAt(4);
                year2 += en.ElementAt(5);
                year2 += en.ElementAt(6);
                year2 += en.ElementAt(7);
                int year11=Convert.ToInt32(year1);
                int year22 = Convert.ToInt32(year2);
                int d11 = Convert.ToInt32(d1);
                int d22 = Convert.ToInt32(d2);
                int m11 = Convert.ToInt32(m1);
                int m22 = Convert.ToInt32(m2);
                if (d.Year >= year11&&d.Year<=year22&&d.Month>=m11&&d.Month<=m22&&d.Day>=d11&&d.Day<=d22)
                {
                    occupiedRooms.Add(resrves[i].room_id);
                }
            }
            return occupiedRooms;
        }

        public List<int> checkAv(DateTime t1, DateTime t2)
        {
            List<int> avRooms = new List<int>();

            for (int i = 101; i <= 136; i++)
            {
                bool av=true;
                for (int j = 0; j < resrves.Count; j++)
                {
                    if (resrves[j].id == i)
                    {
                        string st = resrves[j].start;
                        string en = resrves[j].end;
                        if (CompareToDate(st, t2) == true &&CompareToDate(en,t1)==false)
                        {
                            av = false;
                            break;
                        }
                    }
                }
                if (av)
                {
                    avRooms.Add(i);
                }
            }
                return avRooms;
        }
        public bool CompareToDate(string t1,DateTime t2){ // is t2 >=  t1 
            string st = t1;
            string year1 = "", d1 = "", m1 = "";
            d1 += st.ElementAt(0);
            d1 += st.ElementAt(1);
            m1 += st.ElementAt(2);
            m1 += st.ElementAt(3);
            year1 += st.ElementAt(4);
            year1 += st.ElementAt(5);
            year1 += st.ElementAt(6);
            year1 += st.ElementAt(7);
            int year11 = Convert.ToInt32(year1);
            int d11 = Convert.ToInt32(d1);
            int m11 = Convert.ToInt32(m1);
           if (t2.Year >= year11&&t2.Month>=m11&&t2.Day>=d11)
           {
               return true;    
           }
           return false;
        }

        public Guest Search(long id)
        {
            Guest g = new Guest();
            g.id = -1;
            for (int i = 0; i < guests.Count; i++)
            {
                if (guests[i].id == id)
                {
                    g.id = id;
                    g.name = guests[i].name;
                    g.mobile = guests[i].mobile;
                    g.nationality = guests[i].nationality;
                    g.address = guests[i].address;
                    g.email = guests[i].email;
                    g.Gender = guests[i].Gender;
                    g.city = guests[i].city;
                    break;
                }
            }
            return g;
        }

        public void AddGuest(Guest g){
            guests.Add(g);
            string quary="INSERT INTO customers (customer_id,customer_name,gender,address,city,nationality,email,mobile)VALUES('";
            quary += g.id.ToString()+"','";
            quary += g.name + "','";
            quary += g.Gender.ToString() + "','";
            quary += g.address + "','";
            quary += g.city + "','";
            quary += g.nationality + "','";
            quary += g.email + "','";
            quary += g.mobile.ToString() + "');";
            Insert(quary);
        }

        public void AddBook(Booking b)
        {
            
            resrves.Add(b);
            string quary = "INSERT INTO booking (id,start_date,end_date,have_launch,room_id,offer_id,service_id)VALUES('";
            quary += b.id+ "','";
            quary += b.start + "','";
            quary += b.end + "','";
            quary += b.havelunch.ToString() + "','";
            quary += b.room_id.ToString() + "','";
            quary += b.offer_id.ToString() + "','";
            quary += b.servis_id.ToString() + "');";
            Insert(quary);
        }

        public void confimReservation(long id,string name){
            for (int i = 0; i < resrves.Count; i++)
            {
                if (resrves[i].id == id)
                {
                    resrves[i].servis_id = 1;
                    string query = "UPDATE booking SET service_id='1' WHERE id='";
                    query += id.ToString()+"'";
                    Update(query);
                }
            }
        }
        public Booking SearchReservation(long id)
        {
            Booking p = new Booking();
            for (int i = 0; i < resrves.Count; i++)
            {
                if (resrves[i].id == id)
                {
                    return resrves[i];
                }
            }
            return p;
        }
        public void EditReservation(string end_date,string id)
        {
            for (int i = 0; i < resrves.Count; i++)
            {
                if (resrves[i].id.ToString() == id)
                {
                    resrves[i].end = end_date;
                }
            }
            string query = "UPDATE booking SET end_date='";
            query += end_date + "'WHERE id='";
            query += id + "'";
            Update(query);
        }


        public void CancelReservation(int room_id)
        {
            for (int i = 0; i < resrves.Count; i++) {
                if (resrves[i].room_id == room_id)
                {
                    resrves.RemoveAt(i);
                    break;
                }
            }
            string query = "DELETE FROM booking WHERE room_id='";
            query += room_id.ToString() + "'";
            Delete(query);
        }

        public Guest SearchGuest(long id)
        {
            Guest g = new Guest();
            for (int i = 0; i < guests.Count; i++)
            {
                if (guests[i].id == id)
                {
                    return guests[i];
                }
            }
            g.id = -1;
            return g;
        }
        public void UpdateGuestInfo(Guest s){
            string query = "DELETE FROM customers WHERE customer_id='";
            query += s.id.ToString() + "'";
            Delete(query);
            AddGuest(s);
        }
    }
}

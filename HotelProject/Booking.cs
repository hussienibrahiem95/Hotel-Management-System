using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject
{
    public class Booking
    {
        public long id;
        public string start,end;
        public bool havelunch;
        public int room_id;
        public int offer_id;
        public int servis_id;
        public List<Services> servces_ids;
    }
}

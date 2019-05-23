using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace mvcdemo3.Models
{
    public class GuestService
    {
        private static List<Guest> guestList = null;

        static GuestService()
        {
            guestList = new List<Guest>();
            guestList.Add(new Guest { GuestNo=101, GuestName="Anil patel",PhoneNumber="7792996145"});
            guestList.Add(new Guest{GuestNo = 102, GuestName = "Suresh patel", PhoneNumber = "7792776145"});
            guestList.Add(new Guest{ GuestNo = 103, GuestName = "patel", PhoneNumber = "7792992245"  });
            guestList.Add(new Guest { GuestNo = 105, GuestName = "asdad", PhoneNumber = "8892996245" });
            guestList.Add(new Guest { GuestNo = 106, GuestName = "dadsd", PhoneNumber = "8892952245" });
            guestList.Add(new Guest { GuestNo = 107, GuestName = "aadsad", PhoneNumber = "9992996245" });
            guestList.Add(new Guest { GuestNo = 108, GuestName = "adfasas", PhoneNumber = "7792996245" });

        }
        public bool AddGuest(Guest newGuest)
        {
            bool guestAdded = false;
            int oldcount = guestList.Count;
            guestList.Add(newGuest);
            int newCount = guestList.Count;
            if (newCount > oldcount)
                guestAdded = true;
            return guestAdded;
        }
        public List<Guest> GetAllGuests()
        {
            return guestList;
        }

        public Guest ShowGuest(int guestNumber)
        {
            return guestList.First(g => g.GuestNo == guestNumber);
        }

        public Guest UpdateGuest(Guest updateGuest)
        {
            Guest guest = guestList.First(g => g.GuestNo == updateGuest.GuestNo);
            guest.GuestName = updateGuest.GuestName;
            guest.PhoneNumber = updateGuest.PhoneNumber;
            return guest;
        }
        public bool RemoveGuest(int id)
        {
            Guest gs = guestList.First(g => g.GuestNo == id);
            return guestList.Remove(gs);
             
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PHN_Entity;
using PHN_Exception;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace PHN_DAL
{
    public class GuestOperation
    {
        static List<Guest> GuestList = new List<Guest>();
        static List<Guest> searchGuest = new List<Guest>();
        public bool AddGuestDAL(Guest newGuest)
        {
            bool isGuestAdded = false;
            try
            {
                GuestList.Add(newGuest);
                isGuestAdded = true;
            }
            catch (GuestException)
            {

                throw;
            }
            return isGuestAdded;
        }

        public List<Guest> SearchGuestRelationDAL(string relation)
        {

            try
            {
                foreach (Guest d in GuestList)
                {
                    if (!(relation.Equals(Guest.Relation.Father)|| relation.Equals(Guest.Relation.Mother)|| relation.Equals(Guest.Relation.Brother)|| relation.Equals(Guest.Relation.Sister)|| relation.Equals(Guest.Relation.Cousin)|| relation.Equals(Guest.Relation.Uncle)|| relation.Equals(Guest.Relation.Aunt)|| relation.Equals(Guest.Relation.Son)|| relation.Equals(Guest.Relation.Daughter)|| relation.Equals(Guest.Relation.Friend)))
                    {
                        searchGuest.Add(d);
                    }
                }
            }
            catch (GuestException)
            {

                throw;
            }
            return searchGuest;
        }
        public Guest SearchGuestDAL(int guestId)
        {
            Guest searchGuest = null;
            try
            {
                foreach (Guest a in GuestList)
                {
                    if (a.GuestId == guestId)
                    {
                        searchGuest = a;
                    }
                }
            }
            catch (GuestException)
            {

                throw;
            }
            return searchGuest;
        }
        public bool DeleteGuestDAL(int guestid)
        {
            bool isDeleted = false;
            try
            {
                Guest guestDelete = SearchGuestDAL(guestid);
                if (guestDelete != null)
                {
                    isDeleted = true;
                    GuestList.Remove(guestDelete);
                }
            }
            catch (GuestException)
            {

                throw;
            }
            return isDeleted;
        }
        public bool updateGuestDAL(Guest editguest)
        {
            Guest updateGuest;
            bool isguestUpdate = false;
            updateGuest = SearchGuestDAL(editguest.GuestId); 
            if (updateGuest != null)
            {
                isguestUpdate = true;
                updateGuest.GuestName = editguest.GuestName;
                updateGuest.ContactNumber = editguest.ContactNumber;
                updateGuest.relationship = editguest.relationship;
            }
            else
            {
                throw new GuestException("Invalid GuestId");
            } 
            return isguestUpdate;
        }
        public List<Guest> DisplayGuestDAL()
        {
            List<Guest> glist;
            try
            {
                glist = GuestList;
            }
            catch (GuestException)
            {

                throw;
            }
            return glist;
        }

        public static void SerializeGuestDAL()
        {
            FileStream fStream = null;
            try
            {
                fStream = new FileStream("Guest.txt", FileMode.Create, FileAccess.Write);
                BinaryFormatter binFormatter = new BinaryFormatter();
                binFormatter.Serialize(fStream, GuestList);
            }
            catch (IOException)
            {
                throw;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                fStream.Close();
            }

        }

        public static List<Guest> DeserializeGuestDAL()
        {
            List<Guest> deserializedData = null;
            FileStream fStream = null;
            try
            {
                fStream = new FileStream("Guest.txt", FileMode.Open, FileAccess.Read);
                BinaryFormatter binFormatter = new BinaryFormatter();
                deserializedData = (List<Guest>)binFormatter.Deserialize(fStream);
            }
            catch (IOException)
            {
                throw;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                fStream.Close();
            }
            return deserializedData;

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PHN_DAL;
using PHN_Entity;
using PHN_Exception;
using System.Text.RegularExpressions;

namespace PHN_BLL
{
    public class GuestValidation
    {
        static List<Guest> guestList = new List<Guest>();
        GuestOperation operationObj;
        static List<Guest> searchGuest = new List<Guest>();
        public bool ValidateGuest(Guest newGuest)
        {
            bool isValidGuest = true;
            StringBuilder sb = new StringBuilder();//new Class to store all the Exceptions and Display togeather 
            if (newGuest.GuestId <= 0)
            {
                isValidGuest = false;
                sb.Append("Guest ID cannot be Zero or Negative" + Environment.NewLine);
            }
            if (newGuest.GuestName.Length == 0)
            {
                isValidGuest = false;
                sb.Append("Guest Name cannot be Empty" + Environment.NewLine);
            }
            if (newGuest.GuestName.Length > 15)
            {
                isValidGuest = false;
                sb.Append("Guest Name cannot be more than 15 characters" + Environment.NewLine);
            }
            if (!(Regex.IsMatch(newGuest.ContactNumber, "[6,7,8,9]{0}[0-9]{10}")))
            {
                isValidGuest = false;
                sb.Append("Mobile Number should be 10 Characters and start with 6,7,8,9" + Environment.NewLine);
            }
            if (!(newGuest.relationship.Equals(Guest.Relation.Father) || newGuest.relationship.Equals(Guest.Relation.Mother) || newGuest.relationship.Equals(Guest.Relation.Brother) || newGuest.relationship.Equals(Guest.Relation.Sister) || newGuest.relationship.Equals(Guest.Relation.Cousin) || newGuest.relationship.Equals(Guest.Relation.Uncle) || newGuest.relationship.Equals(Guest.Relation.Aunt) || newGuest.relationship.Equals(Guest.Relation.Son) || newGuest.relationship.Equals(Guest.Relation.Daughter) || newGuest.relationship.Equals(Guest.Relation.Friend)))
            {
                isValidGuest = false;
                sb.Append("Relation Should be Father, Mother, Brother, Sister, Cousin, Uncle, Aunt, Son, Daughter, Friend" + Environment.NewLine);
            }
            if (!isValidGuest)
            {
                throw new GuestException(sb.ToString());
            }
            return isValidGuest;
        }

        public List<Guest> SearchGuestRelationBLL(string relation)
        {
            operationObj = new GuestOperation();
            List<Guest> searchGuest = null;
            searchGuest = operationObj.SearchGuestRelationDAL(relation);
            if (searchGuest == null)
            {
                throw new GuestException("Dealer not found");
            }
            return searchGuest;


        }
        public bool AddGuestBll(Guest newGuest)
        {
            bool isGuestAdded = false;
            operationObj = new GuestOperation();
            if (ValidateGuest(newGuest))
            {
                isGuestAdded = operationObj.AddGuestDAL(newGuest);
            }
            else
            {
                throw new GuestException("Validation Failed!!Agent Record could not be added");
            }
            return isGuestAdded;
        }

        public List<Guest> DisplayGuestBLL()
        {
            operationObj = new GuestOperation();
            guestList = operationObj.DisplayGuestDAL();
            if (guestList.Count <= 0)
            {
                throw new GuestException("No Records Found");
            }
            return guestList;
        }

        public bool UpdateGuestBLL(Guest editGuest)
        {
            operationObj = new GuestOperation();
            bool isupdated = false;
            isupdated = operationObj.updateGuestDAL(editGuest);
            if (isupdated == false)
            {
                throw new GuestException("GuestId  not found..");
            }
            return isupdated;

        }

        public bool DeleteGuestBll(int guestId)
        {
            bool isDeleted = false;
            operationObj = new GuestOperation();
            isDeleted = operationObj.DeleteGuestDAL(guestId);
            if (isDeleted == false)
            {
                throw new GuestException("Guest Id not found");
            }
            return isDeleted;
        }
        public Guest SearchGuestBLL(int guestId)
        {
            operationObj = new GuestOperation();
            Guest searchGuest = null;
            searchGuest = operationObj.SearchGuestDAL(guestId);
            if (searchGuest == null)
            {
                throw new GuestException("Guest not found");
            }
            return searchGuest;
        }

        public void SerializeGuestBLL()
        {
            operationObj = new GuestOperation();
            try
            {

                GuestOperation.SerializeGuestDAL();
            }
            //catch (IOException ex) { throw ex; }
            catch (Exception ex) { throw ex; }

        }
        public List<Guest> DeserializeGuestBLL()
        {
            List<Guest> guestList = null;
            try
            {
                guestList = GuestOperation.DeserializeGuestDAL();

                if (guestList.Count <= 0) throw new GuestException("No records found");
            }
            catch (GuestException ex) { throw ex; }
            //catch (IOException ex) { throw ex; }
            catch (Exception ex) { throw ex; }
            return guestList;
        }
    }
}

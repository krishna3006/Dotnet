using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PHN_BLL;
using PHN_DAL;
using PHN_Entity;
using PHN_Exception;

namespace PHN_Presentation
{
    class Program
    {
        static GuestValidation objValidation;

        public static void PrintMenu()
        {
            Console.WriteLine("======================================");
            Console.WriteLine("Guest Phonebook Management System Menu");
            Console.WriteLine("Press 1 to Add New Guest");
            Console.WriteLine("Press 2 to Display all Guest");
            Console.WriteLine("Press 3 to Search Guest By Guest ID");
            Console.WriteLine("Press 4 to Search By Relation");
            Console.WriteLine("Press 5 to Delete Guest");
            Console.WriteLine("Press 6 to Update Guest");
            Console.WriteLine("Press 7 To Store Data in File");
            Console.WriteLine("Press 8 To Display Data from File");
            Console.WriteLine("Press 9 to Exit");
            Console.WriteLine("======================================");

        }

        public static void DeleteGuest()
        {
            try
            {
                Console.WriteLine("Enter Guest Id to be Deleted");
                int guestId = Convert.ToInt32(Console.ReadLine());
                if (objValidation.DeleteGuestBll(guestId))
                {
                    Console.WriteLine("Guest Deleted");
                }
            }
            catch (GuestException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (Exception e)
            {

                Console.WriteLine(e.Message);
            }

        }

        public static void UpdateGuest()
        {
            try
            {
                Guest agt = new Guest();
                Console.WriteLine("Enter Guest Id  to be updated: ");
                agt.GuestId = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter Guest Name: ");
                agt.GuestName = Console.ReadLine();
                Console.WriteLine("Enter Relation: ");
                string relation = Console.ReadLine();
                if (relation.Equals("Father"))
                {
                    agt.relationship = Guest.Relation.Father;
                }
                if (relation.Equals("Mother"))
                {
                    agt.relationship = Guest.Relation.Mother;
                }
                if (relation.Equals("Brother"))
                {
                    agt.relationship = Guest.Relation.Brother;
                }
                if (relation.Equals("Sister"))
                {
                    agt.relationship = Guest.Relation.Sister;
                }
                if (relation.Equals("Cousin"))
                {
                    agt.relationship = Guest.Relation.Cousin;
                }
                if (relation.Equals("Uncle"))
                {
                    agt.relationship = Guest.Relation.Uncle;
                }
                if (relation.Equals("Aunt"))
                {
                    agt.relationship = Guest.Relation.Aunt;
                }
                if (relation.Equals("Son"))
                {
                    agt.relationship = Guest.Relation.Son;
                }
                if (relation.Equals("Daughter"))
                {
                    agt.relationship = Guest.Relation.Daughter;
                }
                if (relation.Equals("Friend"))
                {
                    agt.relationship = Guest.Relation.Friend;
                }
                Console.WriteLine("Enter Contact Number: ");
                agt.ContactNumber =Console.ReadLine();
                if (objValidation.UpdateGuestBLL(agt))
                {
                    Console.WriteLine("Guest Details have been updated");
                }
            }
            catch (GuestException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (Exception e)
            {

                Console.WriteLine(e.Message);
            }
        }

        public static void SearchGuestRelation()
        {
            try
            {
                
                List<Guest> guestSearch = null;                
                string category;
                Console.WriteLine("Enter Relation");
                category = Console.ReadLine();
                guestSearch = objValidation.SearchGuestRelationBLL(category);
                if (guestSearch != null)
                {
                    foreach (Guest d in guestSearch)
                    {
                        Console.WriteLine("Guest Id: " + d.GuestId);
                        Console.WriteLine("Guest Name: " + d.GuestName);
                        Console.WriteLine("Relation: " + d.relationship);
                        Console.WriteLine("Contact Number: " + d.ContactNumber);
                    }
                }
            }
            catch (GuestException e)
            {

                Console.WriteLine(e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public static void DisplayGuest()
        {
            try
            {
                objValidation = new GuestValidation();
                List<Guest> guestList = objValidation.DisplayGuestBLL();
                Console.WriteLine("List of Guest ");
                foreach (Guest a in guestList)
                {
                    Console.WriteLine("======================================");
                    Console.WriteLine("Guest Id: " + a.GuestId);
                    Console.WriteLine("Guest Name: " + a.GuestName);
                    Console.WriteLine("Relation: " + a.relationship);
                    Console.WriteLine("Contact Number: " + a.ContactNumber);
                    Console.WriteLine("======================================");
                }
            }
            catch (GuestException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (Exception e)
            {

                Console.WriteLine(e.Message);
            }
        }
        public static void SearchGuest()
        {
            try
            {
                Guest agtSearch = null;
                objValidation = new GuestValidation();
                int agtId;
                Console.WriteLine("Enter the Guest Id to be searched");
                agtId = Convert.ToInt32(Console.ReadLine());
                agtSearch = objValidation.SearchGuestBLL(agtId);
                if (agtSearch != null)
                {
                    Console.WriteLine("Guest Id: " + agtSearch.GuestId);
                    Console.WriteLine("Guest Name: " + agtSearch.GuestName);
                    Console.WriteLine("Relation: " + agtSearch.relationship);
                    Console.WriteLine("Contact Number: " + agtSearch.ContactNumber);
                }
            }
            catch (GuestException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (Exception e)
            {

                Console.WriteLine(e.Message);
            }
        }
        public static void AddGuest()
        {
            try
            {
                objValidation = new GuestValidation();
                Guest newAgent = new Guest();
                Console.WriteLine("Enter the Guest Id ");
                newAgent.GuestId = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter the Guest Name ");
                newAgent.GuestName = Console.ReadLine();
                Console.WriteLine("Enter the Relation ");
                string relation = Console.ReadLine();
                if(relation.Equals("Father"))
                {
                    newAgent.relationship = Guest.Relation.Father;
                }
                if (relation.Equals("Mother"))
                {
                    newAgent.relationship = Guest.Relation.Mother;
                }
                if (relation.Equals("Brother"))
                {
                    newAgent.relationship = Guest.Relation.Brother;
                }
                if (relation.Equals("Sister"))
                {
                    newAgent.relationship = Guest.Relation.Sister;
                }
                if (relation.Equals("Cousin"))
                {
                    newAgent.relationship = Guest.Relation.Cousin;
                }
                if (relation.Equals("Uncle"))
                {
                    newAgent.relationship = Guest.Relation.Uncle;
                }
                if (relation.Equals("Aunt"))
                {
                    newAgent.relationship = Guest.Relation.Aunt;
                }
                if (relation.Equals("Son"))
                {
                    newAgent.relationship = Guest.Relation.Son;
                }
                if (relation.Equals("Daughter"))
                {
                    newAgent.relationship = Guest.Relation.Daughter;
                }
                if (relation.Equals("Friend"))
                {
                    newAgent.relationship = Guest.Relation.Friend;
                }
                Console.WriteLine("Enter the Contact Number ");
                newAgent.ContactNumber = Console.ReadLine();               
                if (objValidation.ValidateGuest(newAgent))
                {
                    objValidation.AddGuestBll(newAgent);
                    Console.WriteLine("Guest Details added Successfully...");
                }
            }
            catch (GuestException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (Exception e)
            {

                Console.WriteLine(e.Message);
            }


        }
        private static void DeserializeGuest()
        {
            try
            {
                List<Guest> agtList = objValidation.DeserializeGuestBLL();
                Console.WriteLine("Records from File: ");
                foreach (Guest agt in agtList)
                {
                    Console.WriteLine("Guest Id: " + agt.GuestId);
                    Console.WriteLine("Guest Name: " + agt.GuestName);
                    Console.WriteLine("Relation: " + agt.relationship);
                    Console.WriteLine("Contact Number: " + agt.ContactNumber);
                }
            }
            catch (GuestException ex)
            {
                Console.WriteLine(ex.Message);
            }
            //catch (IOException ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }

        private static void SerializeGuest()
        {
            try
            {
                objValidation.SerializeGuestBLL();
                Console.WriteLine("Guest Record stored in File");
            }
            catch (GuestException ex)
            {
                Console.WriteLine(ex.Message);
            }
            //catch (IOException ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        static void Main(string[] args)
        {
            byte choice;
            do
            {
                PrintMenu();
                Console.WriteLine("Enter Your Choice:");
                bool chkChoice;

                chkChoice = byte.TryParse(Console.ReadLine(), out choice);
                if (!chkChoice) { Console.WriteLine("Invalid Input "); }
                switch (choice)
                {
                    case 1:
                        AddGuest();
                        break;
                    case 2:
                        DisplayGuest();
                        break;
                    case 3:
                        SearchGuest();
                        break;
                    case 4:
                        SearchGuestRelation();
                        break;
                    case 5:
                        DeleteGuest();
                        break;
                    case 6:
                        UpdateGuest();
                        break;
                    case 7:
                        SerializeGuest();
                        break;
                    case 8:
                        DeserializeGuest();
                        break;
                    case 9:
                        break;
                    default:
                        Console.WriteLine("Invalid Choice");
                        break;
                }
            } while (choice != 9);

            Console.ReadKey();
        }
    }
}

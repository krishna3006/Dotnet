using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AgentOperations;
using Agent_entity;
using Agent_Exceptions;
using Agent_Bll;

namespace AgentPresentation
{
    class Program
    {
        static AgentValidation objValidation;
        public static void Printmenu()
        {
            Console.WriteLine("**********************************************");
            Console.WriteLine("agent management system menu");
            Console.WriteLine("press 1 to add new agent");
            Console.WriteLine("press 2 to display all agents");
            Console.WriteLine("press 3 to search agent");
            Console.WriteLine("press 4 to delete agent");
            Console.WriteLine("press 5 to update agent");
            Console.WriteLine("press 6 to exit");
            Console.WriteLine("**********************************************");
        }
        public static void DeleteAgent()
        {
            try
            {
                Console.WriteLine("enter agent id to delete");
                int agentid = Convert.ToInt32(Console.ReadLine());
                if (objValidation.DeleteAgentDll(agentid))
                {
                    Console.WriteLine("agent deleted");
                }
            }
            catch (AgentException e)
            {


                Console.WriteLine(e.Message);
            }
            catch (Exception e)
            {


                Console.WriteLine(e.Message);
            }

        }
        public static void UpdateAgent()
        {
            try
            {
                Agent Emp = new Agent();
                Console.WriteLine("enter agent id to be updated");
                Emp.Agentid = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("enter agent name");
                Emp.AgentName = (Console.ReadLine());
                Console.WriteLine("enter agent dob");
                Emp.Dob = Convert.ToDateTime(Console.ReadLine());

                Console.WriteLine("enter the paymode option\n 1.check\n2.cash\n3.online transfer");
                Emp.Paymode = Convert.ToInt32(Console.ReadLine());

                if (objValidation.UpdateAgentDll(Emp))
                {
                    Console.WriteLine("Agent updated");
                }
            }
            catch (AgentException e)
            {

                Console.WriteLine(e.Message);
            }
            catch (Exception e)
            {

                Console.WriteLine(e.Message);
            }
        }
        public static void DisplayAgent()
        {
            try
            {
                objValidation = new AgentValidation();
                List<Agent> agentList = objValidation.DisplayAgentBll();
                Console.WriteLine("list of agents");
                foreach (Agent e in agentList)
                {
                    Console.WriteLine("agentid " + e.Agentid);
                    Console.WriteLine("agentname " + e.AgentName);
                    Console.WriteLine("dob " + e.Dob);
                    Console.WriteLine("paymode " + e.Paymode);

                }
            }
            catch (AgentException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);

            }
        }
        public static void SearchAgent()
        {
            try
            {
                Agent ageSearch = null;
                objValidation = new AgentValidation();
                int agentid;
                Console.WriteLine("enter agent id");
                agentid = Convert.ToInt32(Console.ReadLine());
                ageSearch = objValidation.SearchAgentBll(agentid);
                if (ageSearch is null)
                {
                    Console.WriteLine("Name " + ageSearch.AgentName);
                    Console.WriteLine("dob " + ageSearch.Dob);
                    Console.WriteLine("paymode" + ageSearch.Paymode);

                }
            }
            catch (AgentException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);

            }
        }
        public static void AddAgent()
        {
            try
            {
                objValidation = new AgentValidation();
                Agent newAgent = new Agent();
                Console.WriteLine("enter agent id");
                newAgent.Agentid = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("enter Agent name");
                newAgent.AgentName = (Console.ReadLine());

                Console.WriteLine("enter employ dob");
                newAgent.Dob = Convert.ToDateTime(Console.ReadLine());
                Console.WriteLine("enter employ paymode\n1.check\n2.cash\n3.online transfer");
                newAgent.Paymode = Convert.ToInt32(Console.ReadLine());
                if (objValidation.ValidateAgent(newAgent))
                {
                    objValidation.AddAgentBll(newAgent);
                    Console.WriteLine("agent record added successfully");
                }

            }
            catch (AgentException e)
            {

                Console.WriteLine(e.Message);
            }
            catch (Exception e)
            {

                Console.WriteLine(e.Message);
            }
        }

        static void Main(string[] args)
        {

            byte choice;
            do
            {
                Printmenu();
                Console.WriteLine("Enter Your Choice:");
                bool chkChoice;

                chkChoice = byte.TryParse(Console.ReadLine(), out choice);
                if (!chkChoice) { Console.WriteLine("Invalid Input "); }
                switch (choice)
                {
                    case 1:
                        AddAgent();
                        break;
                    case 2:
                        DisplayAgent();
                        break;
                    case 3:
                        SearchAgent();
                        break;
                    case 4:
                        DeleteAgent();
                        break;

                    case 6:
                        break;
                    default:
                        Console.WriteLine("Invalid Choice");
                        break;
                }
            } while (choice != 6);

            Console.ReadKey();
        }


    }
}



using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Agent_entity;
using Agent_Exceptions;

namespace AgentOperations
{
    public class AgentOperation
    {
        static List<Agent> agentlist = new List<Agent>();
        public bool AddAgentDll(Agent newAgent)
        {
            bool isAgentAdded = true;
            try
            {
                agentlist.Add(newAgent);
                isAgentAdded = true;
            }
            catch (AgentException)
            {

                throw;
            }
            return isAgentAdded;
        }
        public bool UpdateEmployDal(Agent editAgent)
        {
            Agent updateAgent;
            bool isAgentUpdate = false;
            updateAgent = SearchAgentDll(editAgent.Agentid);
            if (updateAgent != null)
            {
                isAgentUpdate = true;
                updateAgent.AgentName = editAgent.AgentName;
                updateAgent.Dob = editAgent.Dob;
                updateAgent.Paymode = editAgent.Paymode;

            }
            else
            {
                throw new AgentException("invalid Agent ID");
            }
            return isAgentUpdate;
        }
        public List<Agent> DisplayAgentDll()
        {
            List<Agent> alist;
            try
            {
                alist = agentlist;
            }
            catch (AgentException)
            {

                throw;
            }
            return alist;
        }
        public bool DeleteAgentDll(int agentid)
        {
            bool isDeleted = false;
            try
            {
                Agent agentDelete = SearchAgentDll(agentid);
                if (agentDelete != null)
                {
                    isDeleted = true;
                    agentlist.Remove(agentDelete);
                }
            }
            catch (AgentException)
            {

                throw;
            }
            return isDeleted;
        }
        public Agent SearchAgentDll(int agentid)
        {
            Agent SearchAgent = null;

            try
            {
                foreach (Agent e in agentlist)
                {
                    if (e.Agentid == agentid)
                    {
                        SearchAgent = e;
                    }
                }
            }
            catch (AgentException)
            {

                throw;
            }
            return SearchAgent;
        }
    }
}



using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Agent_entity;
using Agent_Exceptions;
using AgentOperations;

namespace Agent_Bll
{
    public class AgentValidation
    {
        static List<Agent> agentList = new List<Agent>();
        AgentOperation operationObj;
        public bool ValidateAgent(Agent newAgent)
        {

                
            bool isValidateAgent = true;
            StringBuilder sb = new StringBuilder();
            if (newAgent.Agentid <= 0)
            {
                isValidateAgent = false;
                sb.Append("Agent id cannot be zero or negative " + Environment.NewLine);
            }
            if (newAgent.AgentName.Length == 0 || newAgent.AgentName.Length > 15)
            {
                isValidateAgent = false;
                sb.Append("name cannot be empty and more than 15 characters " + Environment.NewLine);
            }
            int year = newAgent.Dob.Year;
            if (year >= 1995 && year <= 2000)
            {
                isValidateAgent = false;
                sb.Append("Date of birth cannot be in between 1995 to 2010" + Environment.NewLine);
            }
            if (newAgent.Paymode < 1 || newAgent.Paymode > 3)
            {
                isValidateAgent = false;
                sb.Append("enter the correct  paymode option");
            }
            if (!isValidateAgent)
            {
                throw new AgentException(sb.ToString());
            }
            return isValidateAgent;
        }
        public bool AddAgentBll(Agent newAgent)
        {
            bool isAgentAdded = false;
            operationObj = new AgentOperation();
            if (ValidateAgent(newAgent))
            {
                isAgentAdded = operationObj.AddAgentDll(newAgent);
            }
            else
            {
                throw new
                    AgentException("validation failed!!!Agent record cannot be added");
            }
            return isAgentAdded;
        }
        public List<Agent> DisplayAgentBll()
        {
            operationObj = new AgentOperation();
            agentList = operationObj.DisplayAgentDll();
            if (agentList.Count <= 0)
            {
                throw new AgentException("no records found");
            }
            return agentList;
        }
        public bool DeleteAgentDll(int empno)
        {
            bool isDeleted = false;
            operationObj = new AgentOperation();
            isDeleted = operationObj.DeleteAgentDll(empno);
            if (isDeleted == false)
            {
                throw new AgentException("agent id not found");
            }
            return isDeleted;
        }
        public bool UpdateAgentDll(Agent editEmploy)
        {
            operationObj = new AgentOperation();
            bool isUpdated = false;
            isUpdated = operationObj.UpdateEmployDal(editEmploy);
            if (isUpdated == false)
            {
                throw new AgentException("emp no not  found");
            }
            return isUpdated;
        }
        public Agent SearchAgentBll(int empno)
        {
            operationObj = new AgentOperation();
            Agent SearchAgent = null;
            SearchAgent = operationObj.SearchAgentDll(empno);
            if (SearchAgent == null)
            {
                throw new AgentException("agent not found");
            }
            return SearchAgent;
        }


    }
}




﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Data.SqlClient;
using System.Configuration;
using System.Text;
using System.Data;

namespace WCFEmpEmpService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "EmpService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select EmpService.svc or EmpService.svc.cs at the Solution Explorer and start debugging.
    public class EmpService : IEmpService
    {
        SqlConnection connection;
        SqlCommand cmdSql;
        SqlDataReader dataReader;

        public List<Emp> ShowEmp()
        {
            string strcon = ConfigurationManager.
              ConnectionStrings["sqlpracticeconn"].ConnectionString;
            connection = new SqlConnection(strcon);
            connection.Open();
            cmdSql = new SqlCommand("prcEmpShow", connection);
            cmdSql.CommandType = CommandType.StoredProcedure;
            dataReader = cmdSql.ExecuteReader();
            List<Emp> lstEmp = null;
            lstEmp = new List<Emp>();
            while (dataReader.Read())
            {

                Emp emp = new Emp();
                emp.Empno = Convert.ToInt32(dataReader["empno"]);
                emp.name = dataReader["nam"].ToString();
                emp.Dept = dataReader["dept"].ToString();
                emp.Desig = dataReader["desig"].ToString();
                emp.Basic = Convert.ToInt32(dataReader["basic"]);
                lstEmp.Add(emp);
            }
            return lstEmp;
        }
        public bool InsertEmp(Emp objEmp)
        {
            string strcon = ConfigurationManager.
          ConnectionStrings["sqlpracticeconn"].ConnectionString;
            connection = new SqlConnection(strcon);
            connection.Open();
            cmdSql = new SqlCommand("prcEmpInsert", connection);
            cmdSql.CommandType = CommandType.StoredProcedure;
            cmdSql.Parameters.AddWithValue("@empno", objEmp.Empno);
            cmdSql.Parameters.AddWithValue("@name", objEmp.name);
            cmdSql.Parameters.AddWithValue("@dept", objEmp.Dept);
            cmdSql.Parameters.AddWithValue("@desig", objEmp.Desig);
            cmdSql.Parameters.AddWithValue("@basic", objEmp.Basic);
            cmdSql.ExecuteNonQuery();
            return true;
        }
        public Emp SearchEmp(int empno)
        {
            string strcon = ConfigurationManager.
             ConnectionStrings["sqlpracticeconn"].ConnectionString;
            connection = new SqlConnection(strcon);
            connection.Open();
            cmdSql = new SqlCommand("prcEmpSearch", connection);
            cmdSql.CommandType = CommandType.StoredProcedure;
            cmdSql.Parameters.AddWithValue("@empno", empno);
            dataReader = cmdSql.ExecuteReader();
            Emp emp = null;
            if (dataReader.Read())
            {
                emp = new Emp();
                emp.name = dataReader["nam"].ToString();
                emp.Dept = dataReader["dept"].ToString();
                emp.Desig = dataReader["desig"].ToString();
                emp.Basic = Convert.ToInt32(dataReader["basic"]);
            }
            return emp;
        }

        public int AutoGenerateEmpno()
        {
            string strcon = ConfigurationManager.
            ConnectionStrings["sqlpracticeconn"].ConnectionString;
            connection = new SqlConnection(strcon);
            connection.Open();
            cmdSql = new SqlCommand("prcEmpAutoGen", connection);
            cmdSql.CommandType = CommandType.StoredProcedure;
            int empno = Convert.ToInt32(cmdSql.ExecuteScalar());
            return empno;
        }

        public bool UpdateEmp(Emp objEmp)
        {
            string strcon = ConfigurationManager.
            ConnectionStrings["sqlpracticeconn"].ConnectionString;
            connection = new SqlConnection(strcon);
            connection.Open();
            cmdSql = new SqlCommand("prcEmpUpdate", connection);
            cmdSql.CommandType = CommandType.StoredProcedure;
            cmdSql.Parameters.AddWithValue("@empno", objEmp.Empno);
            cmdSql.Parameters.AddWithValue("@nam", objEmp.name);
            cmdSql.Parameters.AddWithValue("@dept", objEmp.Dept);
            cmdSql.Parameters.AddWithValue("@desig", objEmp.Desig);
            cmdSql.Parameters.AddWithValue("@basic", objEmp.Basic);
            cmdSql.ExecuteNonQuery();
            return true;
        }
        public bool DeleteEmp(int empno)
        {
            string strcon = ConfigurationManager.ConnectionStrings["sqlpracticeconn"].ConnectionString;
            connection = new SqlConnection(strcon);
            connection.Open();
            cmdSql = new SqlCommand("prcDeleteEmp", connection);
            cmdSql.CommandType = CommandType.StoredProcedure;
            cmdSql.Parameters.AddWithValue("@empno", empno);
            cmdSql.ExecuteNonQuery();
            return true;
        }

    }
}
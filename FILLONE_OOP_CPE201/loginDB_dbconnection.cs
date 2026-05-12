using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace FILLONE_OOP_CPE201
{
    internal class loginDB_dbconnection
    {
        public String login_connectionString = null;
        public SqlConnection login_sql_connection;
        public SqlCommand login_sql_command;
        public DataSet login_sql_dataset;
        public SqlDataAdapter login_sql_dataadapter;
        public string login_sql = null;

        public void login_connString()
        {
            login_sql_connection = new SqlConnection();
            login_connectionString = "Data Source=ALI\\SQLEXPRESS;Initial Catalog = POSDB;Integrated Security=True;";
            login_sql_connection = new SqlConnection(login_connectionString);
            login_sql_connection.ConnectionString = login_connectionString;
            login_sql_connection.Open();
        }

        public void login_cmd()
        {
            login_sql_command = new SqlCommand(login_sql, login_sql_connection);
            login_sql_command.CommandType = CommandType.Text;
        }

        public void login_sqladapterSelect()
        {
            login_sql_dataadapter = new SqlDataAdapter();
            login_sql_dataadapter.SelectCommand = login_sql_command;
            login_sql_command.ExecuteNonQuery();
        }

        public void login_sqladapterInsert()
        {
            login_sql_dataadapter = new SqlDataAdapter();
            login_sql_dataadapter.InsertCommand = login_sql_command;
            login_sql_command.ExecuteNonQuery();
        }

        public void login_sqladapaterDelete()
        {
            login_sql_dataadapter = new SqlDataAdapter();
            login_sql_dataadapter.DeleteCommand = login_sql_command;
            login_sql_command.ExecuteNonQuery();
        }

        public void login_sqladapaterUpdate()
        { 
            login_sql_dataadapter = new SqlDataAdapter();
            login_sql_dataadapter.UpdateCommand = login_sql_command;
            login_sql_command.ExecuteNonQuery();
        }

        public void login_sqldatasetSELECT()
        {
            login_sql_dataset = new DataSet();
            login_sql_dataadapter.Fill(login_sql_dataset, "pos_empRegTbl");
        }
    }
}

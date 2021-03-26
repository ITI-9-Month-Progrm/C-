using System;
using Microsoft.Data.SqlClient;
using System.Configuration;
using System.Data;
using System.Collections.Generic;

namespace DataAccessLayer
{
    public class DBManager
    {
        SqlConnection sqlCon;
        SqlCommand sqlCmd;
        SqlDataAdapter sqlDA;
        DataTable resultDataTable;

        public DBManager()
        {
            try 
            {
                sqlCon = new SqlConnection();
                sqlCon.ConnectionString = ConfigurationManager.ConnectionStrings["Pubs"].ConnectionString;
                 
                sqlCmd = new SqlCommand("", sqlCon);
                sqlCmd.CommandType = CommandType.StoredProcedure;
                sqlDA = new SqlDataAdapter();
                resultDataTable = new DataTable();
            }
            catch (Exception ex) 
            { Console.WriteLine(ex); }
        }

        public DataTable executeDataTableQuiry(string SpName)
        {
            try 
            {
                resultDataTable.Clear();
                sqlCmd.Parameters.Clear();

                sqlCmd.CommandText = SpName;
                sqlDA.SelectCommand = sqlCmd;

                sqlDA.Fill(resultDataTable);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex);
            }

            return resultDataTable;
        }

        public int executeNonQuiry(string SpName, Dictionary<string, object> ParamList)
        {
            int result = -1;
            try
            {
                if (sqlCon?.State == ConnectionState.Closed)
                    sqlCon.Open();
                sqlCmd.Parameters.Clear();
                foreach (var item in ParamList)
                    sqlCmd.Parameters.AddWithValue(item.Key, item.Value);

                sqlCmd.CommandText = SpName;
                result = sqlCmd.ExecuteNonQuery();
                sqlCon.Close();
            }
            
            catch
            {

            }
            return result;
        }
    }
}




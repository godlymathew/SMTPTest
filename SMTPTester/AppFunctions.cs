using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

internal class AppFunctions
{
    public AppFunctions()
    {
    }

    public AppFunctions(string connectionString)
    {
        ConnectionString = connectionString;
    }

    public string errorMessage = "";
    public string ConnectionString { get; set; }

    public bool CheckDataConnection(string connectionString)
    {
        SqlConnection sqlCon = new SqlConnection(connectionString);
        try
        {
            sqlCon.Open();
            sqlCon.Close();
            return true;
        }
        catch (Exception ex)
        {
            errorMessage = ex.Message;
            return false;
        }
    }
}

//eDocsNet_SelecteDocsNetParameters
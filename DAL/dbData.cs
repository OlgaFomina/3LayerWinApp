using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
namespace DAL
{
    public class DbData
    {
        string CS = System.Configuration.ConfigurationManager.ConnectionStrings["dbConnection"].ConnectionString;

        public DataTable GetPhonesData()
        {
            using (SqlConnection connection = new SqlConnection(CS))
            {
                connection.Open();
                SqlCommand selectCommand = new SqlCommand("SELECT * FROM Phone", connection);
                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = selectCommand;
                DataSet myDataSet = new DataSet();
                adapter.Fill(myDataSet, "Ph");
                return myDataSet.Tables["Ph"];
            }
        }
    }
}

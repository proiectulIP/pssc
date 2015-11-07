using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Windows.Forms;


namespace pssc
{
    class DbaseFunctions
    {
        private string connectionString;
        private string userType;
        private OleDbConnection connection = new OleDbConnection();

        public DbaseFunctions(string dbasePath,string browseType)
        {
            connectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;" +
        @"Data source= "+ dbasePath;
            userType = browseType;

            connection.ConnectionString = connectionString;
        }

        public void dbaseConnect()
        {
            try
            {
                connection.Open();
            }

            catch(OleDbException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void checkLoginCredintials(string user, string pass)
        {
            OleDbCommand command = new OleDbCommand("select * from users", connection);
            OleDbDataReader reader;
            reader = command.ExecuteReader();

            while(reader.Read())
            {
                string username = reader["username"].ToString();
                string password = reader["pass"].ToString() ;

                if((user.Equals(username)) && (pass.Equals(password)))
                    {
                    MessageBox.Show("success");
                    break;
                }

            }
        }
    }
}

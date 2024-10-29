using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrahaNet
{
    public class DataBase
    {

        SqlConnection StrahaNetDB = new SqlConnection(@"Data Source=localhost\SQLEXPRESS; Initial Catalog=Straha.net; Integrated Security=True");

        virtual public void openConnection()
        {
            if (StrahaNetDB.State == System.Data.ConnectionState.Closed)
            {
                StrahaNetDB.Open();
            }
        }

        virtual public void closeConnection()
        {
            if (StrahaNetDB.State == System.Data.ConnectionState.Open)
            {
                StrahaNetDB.Close();
            }
        }

        virtual public SqlConnection GetConnection()
        {
            return StrahaNetDB;
        }

        virtual public void ExecuteScalar(string v, SqlParameter[] sqlParameters)
        {
            throw new NotImplementedException();
        }
    }
}

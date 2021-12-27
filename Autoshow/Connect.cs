using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autoshow
{
    class Connect
    {
        internal static string ConnectionStr = @"Data Source=DESKTOP-88400HU\SQLEXPRESS;Initial Catalog=Autoshow;User ID = Bozhko; Password=вфтшд;";
        internal static SqlConnection connection = new SqlConnection(ConnectionStr);
        internal static string userLogin = "";
    }
}

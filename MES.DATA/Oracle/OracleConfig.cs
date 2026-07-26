using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MES.DATA.Oracle
{
    public static class OracleConfig
    {
        public static string ConnectionString =>
            "User Id=HARIMOERP;" +
            "Password=HARIMOERP;" +
            "Data Source=(DESCRIPTION=" +
            "(ADDRESS=(PROTOCOL=TCP)(HOST=192.168.18.3)(PORT=1521))" +
            "(CONNECT_DATA=(SID=ORAKF))" +
            "(Connection Timeout=5)" +
            ")";
            
    }
}

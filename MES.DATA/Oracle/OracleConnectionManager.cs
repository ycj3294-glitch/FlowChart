using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MES.DATA.Oracle
{
    public class OracleConnectionManager
    {
        public OracleConnection CreateConnection()
        {
            return new OracleConnection(OracleConfig.ConnectionString);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySQLConnection
{
    class Program
    {
        static void Main(string[] args)
        {
            string parama = Sqlishe.run_mysql_return("select ostatok from cards where articul='0001'");
        }
    }
}

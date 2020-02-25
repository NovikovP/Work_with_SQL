using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FireBirdAndInterBase
{
    class Program
    {
        static void Main(string[] args)
        {

            //Подключение к FireBir.строка подключения хотя и большая но понятная
            string connectionString = "User=SYSDBA;Password=masterkey;Database=D:\SMDK\DBase\SmarketFood.fdb;DataSource=roman-book;Port=3050;Dialect=3;Charset=WIN1251;Role=;Connection lifetime=30;Pooling=true;MinPoolSize=0;MaxPoolSize=50;Packet Size=8192;ServerType=0;";
            FbConnection con = new FbConnection(connectionString);

            con.Open();
            FbCommand command = new FbCommand("select count(*) from table", con);
            con.Close();
            //FbDataReader - DataReader. (Всё как обычно работает аналогично)
            //FbDataAdapter - DataAdapter. (Точно так-же)
        }
    }
}

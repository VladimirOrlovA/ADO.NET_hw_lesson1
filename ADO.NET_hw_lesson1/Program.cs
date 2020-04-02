using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConnSqlClient;
using ConnOracleClient;
using ConnOleDb;
using ConnOdbc;


namespace ADO.NET_hw_lesson1
{
    class Program
    {   
        public static void SeparatorRow()
        {
            Console.WriteLine("\n" + new string('=', 110));
        }

        static void Main(string[] args)
        {
            #region TestSqlConnection
            /*
            TestSqlConnection testSQLconnection = new TestSqlConnection();
            SeparatorRow();

            TestSqlConnection testSQLconnection1 = 
                new TestSqlConnection(@"Server=VLADIMIR\SQLEXPRESS;"+
                                       "Database = MCS;" +
                                       "User Id = ova;" +
                                       "Password = 123;" +
                                       "Connection Timeout = 35; ");

            SeparatorRow();
            */
            #endregion
            // ==================================================================================================
            #region TestOracleClient
            TestOracleClient testOracleClient = new TestOracleClient();
            SeparatorRow();

            //TestOracleClient testOracleClient1 =
            //    new TestOracleClient(@"Data Source = MyOracleDB;" +
            //                           "Integrated Security = yes;");

            SeparatorRow();
            #endregion
            // ==================================================================================================
            #region TestOleDbConnection
            TestOleDbConnection testOleDbConnection = new TestOleDbConnection();
            SeparatorRow();

            TestOleDbConnection testOleDbConnection1 =
                new TestOleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;" +
                                      @"Data Source=C:\Users\Vladimir\source\repos\ADO.NET_hw_lesson1\DataBase\accessDb_00.mdb;" +
                                       "Persist Security Info = False;");

            SeparatorRow();
            #endregion
            // ==================================================================================================
            #region TestOdbcConnection
            TestOdbcConnection testOdbcConnection = new TestOdbcConnection();
            SeparatorRow();

            TestOdbcConnection testOdbcConnection1 =
                new TestOdbcConnection("Driver={Microsoft Access Driver (*.mdb)};" +
                                      @"Dbq=C:\Users\Vladimir\source\repos\ADO.NET_hw_lesson1\DataBase\accessDb_00.mdb;" +
                                       "Uid = Admin; Pwd =;");

            SeparatorRow();
            #endregion
            // ==================================================================================================

            Console.ReadKey();
        }
    }
}

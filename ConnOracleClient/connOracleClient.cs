using System;
using System.Configuration;
//using System.Data.OracleClient;
using Oracle.ManagedDataAccess.Client;





namespace ConnOracleClient
{
    public class TestOracleClient
    {
        public string connStr = "";
        public string ctorType = "";

        public TestOracleClient()
        {
            connStr = ConfigurationManager.ConnectionStrings[this.GetType().Name].ConnectionString;
            ctorType = "with connStr from App.config";
            Run();
        }

        public TestOracleClient(string connectionString)
        {
            connStr = connectionString;
            ctorType = "with connStr from Programm.Main";
            Run();
        }

        private void Run()
        {
            using (OracleConnection oracleConnection = new OracleConnection(connStr))
            {
                oracleConnection.Open();
                Console.WriteLine($"{this.GetType().Name} - {ctorType} \n\nПодключение открыто \n");

                //Получение информации о подключении
                // Вывод информации о подключении
                Console.WriteLine("Свойства подключения:");
                Console.WriteLine("\tСтрока подключения: {0}", oracleConnection.ConnectionString);
                Console.WriteLine("\tБаза данных: {0}", oracleConnection.Database);
                Console.WriteLine("\tСервер: {0}", oracleConnection.DataSource);
                Console.WriteLine("\tВерсия сервера: {0}", oracleConnection.ServerVersion);
                Console.WriteLine("\tСостояние: {0}", oracleConnection.State);
                Console.WriteLine("\tConnection Timeout: {0}", oracleConnection.ConnectionTimeout);
            }
        }

    }
}

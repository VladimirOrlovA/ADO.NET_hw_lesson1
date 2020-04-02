using System;
using System.Configuration;
using System.Data.SqlClient;

namespace ConnSqlClient
{
    public class TestSqlConnection
    {
        public string connStr = "";
        public string ctorType = "";

        public TestSqlConnection()
        {
            connStr = ConfigurationManager.ConnectionStrings[this.GetType().Name].ConnectionString;
            ctorType = "with connStr from App.config";
            Run();
        }

        public TestSqlConnection(string connectionString)
        {
            connStr = connectionString;
            ctorType = "with connStr from Programm.Main";
            Run();
        }

        private void Run()
        {
            using (SqlConnection sqlConnection = new SqlConnection(connStr))
            {
                sqlConnection.Open();
                Console.WriteLine($"{this.GetType().Name} - {ctorType} \n\nПодключение открыто \n");

                //Получение информации о подключении
                // Вывод информации о подключении
                Console.WriteLine("Свойства подключения:");
                Console.WriteLine("\tСтрока подключения: {0}", sqlConnection.ConnectionString);
                Console.WriteLine("\tБаза данных: {0}", sqlConnection.Database);
                Console.WriteLine("\tСервер: {0}", sqlConnection.DataSource);
                Console.WriteLine("\tВерсия сервера: {0}", sqlConnection.ServerVersion);
                Console.WriteLine("\tСостояние: {0}", sqlConnection.State);
                Console.WriteLine("\tConnection Timeout: {0}", sqlConnection.ConnectionTimeout);
            }
        }

    }
}

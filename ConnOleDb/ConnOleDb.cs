using System;
using System.Configuration;
using System.Data.OleDb;

namespace ConnOleDb
{
    public class TestOleDbConnection
    {
        public string connStr = "";
        public string ctorType = "";

        public TestOleDbConnection()
        {
            connStr = ConfigurationManager.ConnectionStrings[this.GetType().Name].ConnectionString;
            ctorType = "with connStr from App.config";
            Run();
        }

        public TestOleDbConnection(string connectionString)
        {
            connStr = connectionString;
            ctorType = "with connStr from Programm.Main";
            Run();
        }

        private void Run()
        {
            using (OleDbConnection oleDbConnection = new OleDbConnection(connStr))
            {
                oleDbConnection.Open();
                Console.WriteLine($"{this.GetType().Name} - {ctorType} \n\nПодключение открыто \n");
                

                //Получение информации о подключении
                // Вывод информации о подключении
                Console.WriteLine("Свойства подключения:");
                Console.WriteLine("\tСтрока подключения: {0}", oleDbConnection.ConnectionString);
                Console.WriteLine("\tБаза данных: {0}", oleDbConnection.Database);
                Console.WriteLine("\tСервер: {0}", oleDbConnection.DataSource);
                Console.WriteLine("\tВерсия сервера: {0}", oleDbConnection.ServerVersion);
                Console.WriteLine("\tСостояние: {0}", oleDbConnection.State);
                Console.WriteLine("\tConnection Timeout: {0}", oleDbConnection.ConnectionTimeout);
            }
        }

    }
}

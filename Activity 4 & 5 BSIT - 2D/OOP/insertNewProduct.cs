using System;
using MySql.Data.MySqlClient;
using static System.Console;

namespace OOP
{
    class ManageProduct
    {
        public class InsertNewProduct
        {
            private string server = "localhost";
            private string database = "csharpapp";
            private string username = "root";
            private string password = "";
            private string connString;

            public InsertNewProduct()
            {
                connString = $"Server={server};Database={database};User ID={username};Password={password};";
            }

            public void InsertData(string productName, int productPrice, string productDescription)
            {
                using (MySqlConnection conn = new MySqlConnection(connString))
                {
                    try
                    {
                        conn.Open();
                        WriteLine("\r\n   ____                            _           _   _          __  __       ____   ___  _       _ \r\n  / ___|___  _ __  _ __   ___  ___| |_ ___  __| | | |_ ___   |  \\/  |_   _/ ___| / _ \\| |     | |\r\n | |   / _ \\| '_ \\| '_ \\ / _ \\/ __| __/ _ \\/ _` | | __/ _ \\  | |\\/| | | | \\___ \\| | | | |     | |\r\n | |__| (_) | | | | | | |  __/ (__| ||  __/ (_| | | || (_) | | |  | | |_| |___) | |_| | |___  |_|\r\n  \\____\\___/|_| |_|_| |_|\\___|\\___|\\__\\___|\\__,_|  \\__\\___/  |_|  |_|\\__, |____/ \\__\\_\\_____| (_)\r\n                                                                     |___/                       \r\n");
                        Clear();

                        string query = "INSERT INTO products (productName, productPrice, productDescription) VALUES (@name, @price, @description)";

                        using (MySqlCommand cmd = new MySqlCommand(query, conn))
                        {
                            cmd.Parameters.AddWithValue("@name", productName);
                            cmd.Parameters.AddWithValue("@price", productPrice);
                            cmd.Parameters.AddWithValue("@description", productDescription);

                            int rowsAffected = cmd.ExecuteNonQuery();
                            
                            Clear();
                            WriteLine(rowsAffected > 0 ? "\r\n  ____        _          ___                     _           _   ____                      __       _ _       \r\n |  _ \\  __ _| |_ __ _  |_ _|_ __  ___  ___ _ __| |_ ___  __| | / ___| _   _  ___ ___ ___ / _|_   _| | |_   _ \r\n | | | |/ _` | __/ _` |  | || '_ \\/ __|/ _ \\ '__| __/ _ \\/ _` | \\___ \\| | | |/ __/ __/ __| |_| | | | | | | | |\r\n | |_| | (_| | || (_| |  | || | | \\__ \\  __/ |  | ||  __/ (_| |  ___) | |_| | (__\\__ \\__ \\  _| |_| | | | |_| |\r\n |____/ \\__,_|\\__\\__,_| |___|_| |_|___/\\___|_|   \\__\\___|\\__,_| |____/ \\__,_|\\___|___/___/_|  \\__,_|_|_|\\__, |\r\n                                                                                                        |___/ \r\n"
                                              : "\r\n  _____     _ _          _   _          _                     _         _       _        \r\n |  ___|_ _(_) | ___  __| | | |_ ___   (_)_ __  ___  ___ _ __| |_    __| | __ _| |_ __ _ \r\n | |_ / _` | | |/ _ \\/ _` | | __/ _ \\  | | '_ \\/ __|/ _ \\ '__| __|  / _` |/ _` | __/ _` |\r\n |  _| (_| | | |  __/ (_| | | || (_) | | | | | \\__ \\  __/ |  | |_  | (_| | (_| | || (_| |\r\n |_|  \\__,_|_|_|\\___|\\__,_|  \\__\\___/  |_|_| |_|___/\\___|_|   \\__|  \\__,_|\\__,_|\\__\\__,_|\r\n                                                                                         \r\n");
                        }
                    }
                    catch (Exception ex)
                    {
                        Clear();
                        WriteLine("Error: " + ex.Message);
                    }
                }
            }
        }
    }
}
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoP2.Singleton
{
    public sealed class Database
    {
        private static Database connection = null;

        private Database()
        {

        }

        public static Database getConnection()
        {

            if (connection == null)
            {
                connection = new Database();
                Console.WriteLine("Creating new connection...");
            }
            else
            {
                Console.WriteLine("Using existing connetion...");
            }

            return connection;
        }
    }
}
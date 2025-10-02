using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagementSystem.Data
{
    internal class DatabaseConnection
    {
        private SqlConnection connection;
        private SqlCommand command;
        private SqlDataReader reader;

        public SqlDataReader Reader
        {
            get { return reader; }
        }

        public DatabaseConnection()
        {
            connection = new SqlConnection("server=.\\SQLEXPRESS; database=Inventory_Management; integrated security=true");
            command = new SqlCommand();
        }

        public void setQuery(string consulta)
        {
            command.CommandType = System.Data.CommandType.Text;
            command.CommandText = consulta;
        }


        public void execRead()
        {
            command.Connection = connection;
            try
            {
                connection.Open();
                reader = command.ExecuteReader();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void execAction()
        {
            command.Connection = connection;
            try
            {
                connection.Open();
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void setParameter(string nombre, object valor)
        {
            command.Parameters.AddWithValue(nombre, valor);
        }

        public void closeConnection()
        {
            if (reader != null)
                reader.Close();
            connection.Close();
        }
    }
}

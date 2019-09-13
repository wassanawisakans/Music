using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Music
{
    class Manager
    {
        public static void Query(string Command)
        {
            Database.Connection.Open();
            SqlCommand cmd = new SqlCommand(Command, Database.Connection);
            cmd.ExecuteNonQuery();
            Database.Connection.Close();
        }
        public static void Inserta(string mid, string mname, string mtype, string mprice)
        {
            try
            {
                Database.Connection.Open();
                string sqlCommand = @"INSERT INTO Table_music(m_id,m_name,m_type,m_price) VALUES(@m_id,@m_name,@m_type,@m_price)";
                SqlCommand Command = new SqlCommand(sqlCommand, Database.Connection);
                Command.Prepare();
                Command.Parameters.AddWithValue("@m_id", mid);
                Command.Parameters.AddWithValue("@m_name", mname);
                Command.Parameters.AddWithValue("@m_type", mtype);
                Command.Parameters.AddWithValue("@m_price", mprice);
                Command.ExecuteNonQuery();



            }
            finally
            {
                Database.Connection.Close();
            }
        }
        public static void UpdateMusic(string mid, string mname, string mtype, string mprice)
        {
            try
            {
                Database.Connection.Open();
                string sqlCommand = @"UPDATE Table_music SET m_name=@m_name,m_type=@m_type,m_price=@m_price WHERE m_id='" + mid + "'";
                SqlCommand Command = new SqlCommand(sqlCommand, Database.Connection);
                Command.Prepare();
                Command.Parameters.AddWithValue("@m_id", mid);
                Command.Parameters.AddWithValue("@m_name", mname);
                Command.Parameters.AddWithValue("@m_type", mtype);
                Command.Parameters.AddWithValue("@m_price", mprice);
                Command.ExecuteNonQuery();
            }
            finally
            {
                Database.Connection.Close();
            }
        }
        public static void DeleteMusic(string mid)
        {
            try
            {
                Database.Connection.Open();
                string sqlCommand = @"DELETE FROM Table_music WHERE m_id=@m_id";
                SqlCommand Command = new SqlCommand(sqlCommand, Database.Connection);
                Command.Prepare();
                Command.Parameters.AddWithValue("@m_id", mid);
                Command.ExecuteNonQuery();
            }
            finally
            {
                Database.Connection.Close();
            }
        }
    }
}


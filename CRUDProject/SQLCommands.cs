using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Xml.Linq;

namespace CRUDProject
{
    public static class SQLCommands
    {
        private static MySqlConnection conn;
        private static MySqlCommand cmd;
        private static MySqlDataAdapter da;
        private static void openConnection()
        {
            string datasource = "Server=localhost;Database=CRUD;Username=root;Password=";
            try
            {
                conn = new MySqlConnection(datasource);
                conn.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private static void closeConnection()
        {
            conn.Close();
        }
        public static MySqlDataReader Read()
        {
            openConnection();
            cmd = new MySqlCommand("SELECT ID, Name, Number, Email FROM Client", conn);
            return cmd.ExecuteReader();
        }
        public static void Create(string name, string number, string email)
        {
            openConnection();
            cmd = new MySqlCommand("INSERT INTO Client(Name, Number, Email) VALUES (@name, @number, @email)", conn);
            cmd.Parameters.AddWithValue("@name", name);
            cmd.Parameters.AddWithValue("@number", number);
            cmd.Parameters.AddWithValue("@email", email);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Customer registred successfully! ", "Congratulations", MessageBoxButtons.OK, MessageBoxIcon.Information);
            closeConnection();
        }
        public static void Update(string name, string number, string email, string id)
        {
            openConnection();
            cmd = new MySqlCommand("UPDATE Client SET Name = @name, Number = @number, Email = @email WHERE ID = @id", conn);
            cmd.Parameters.AddWithValue("@id", int.Parse(id));
            cmd.Parameters.AddWithValue("@name", name);
            cmd.Parameters.AddWithValue("@number", number);
            cmd.Parameters.AddWithValue("@email", email);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Customer Successfully update! ", "Congratulations", MessageBoxButtons.OK, MessageBoxIcon.Information);
            closeConnection();
        }
        public static void Delete(string id)
        {
            openConnection();
            cmd = new MySqlCommand("DELETE FROM Client WHERE ID = @id", conn);
            cmd.Parameters.AddWithValue("@id", int.Parse(id));
            cmd.ExecuteNonQuery();
            MessageBox.Show("Customer successfully deletet! ", "Congratulations", MessageBoxButtons.OK, MessageBoxIcon.Information);
            closeConnection();
        }
        public static DataTable Table()
        {
            openConnection();
            da = new MySqlDataAdapter("SELECT * FROM Client", conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            closeConnection();
            return dt;
        }
        public static DataTable SearchName(string name)
        {
            openConnection();
            da = new MySqlDataAdapter($"SELECT * FROM Client WHERE Name LIKE '%{name}%'", conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            closeConnection();
            return dt;
        }
    }
}

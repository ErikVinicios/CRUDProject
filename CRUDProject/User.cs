using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRUDProject
{
    public class User
    {
        MySqlDataReader dr;

        private string name;
        private string number;
        private string email;
        public string Name
            { get { return name; } set { name = value; } }
        public string Number
            { get { return number; } set { number = value; } }
        public string Email
            { get { return email; } set { email = value; } }
        public bool NameIsValid(string name)
        {
            MySqlDataReader dr = SQLCommands.Read();
            while (dr.Read())
            {
                if (dr["Name"].ToString() == name)
                {
                    return false;
                }
            }
            Name = name;
            return true;
        }
        public bool NumberIsValid(string number)
        {
            dr = SQLCommands.Read();
            while (dr.Read())
            {
                if (dr["Number"].ToString() == number)
                {
                    return false;
                }
            }
            Number = number;
            return true;
        }
        public bool EmailIsValid(string email)
        {
            MySqlDataReader dr = SQLCommands.Read();
            while (dr.Read())
            {
                if (dr["Email"].ToString() == email)
                {
                    return false;
                }
            }
            Email = email;
            return true;
        }
    }
}

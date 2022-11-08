using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRUDProject
{
    public partial class ucUpdate : UserControl
    {
        User user = new User();
        public ucUpdate()
        {
            InitializeComponent();
        }
        private void close()
        {
            this.Parent.Controls.Remove(this);
        }
        private void resetLabels()
        {
            lbInvName.Visible = false;
            lbInvNumber.Visible = false;
            lbInvEmail.Visible = false;
        }
        private void btBack_Click(object sender, EventArgs e)
        {
            close();
        }
        private string oldName;
        private string oldNumber;
        private string oldEmail;
        private void mtbID_TextChanged(object sender, EventArgs e)
        {
            MySqlDataReader dr = SQLCommands.Read();
            while (dr.Read())
            {
                if (dr["ID"].ToString() == mtbID.Text)
                {
                    lbInvID.Visible = false;
                    tbName.Enabled = true;
                    tbName.Text = dr["Name"].ToString();
                    oldName = dr["Name"].ToString();
                    mtbNumber.Enabled = true;
                    mtbNumber.Text = dr["Number"].ToString();
                    oldNumber = dr["Number"].ToString();
                    tbEmail.Enabled = true;
                    tbEmail.Text = dr["Email"].ToString();
                    oldEmail = dr["Email"].ToString();
                    user.Name = oldName;
                    user.Number = oldNumber;
                    user.Email = oldEmail;
                    resetLabels();
                    return;
                }
                lbInvID.Visible = true;
                lbInvID.Text = "* ID not found";
                tbName.Enabled = false;
                tbName.Text = "";
                oldName = "";
                mtbNumber.Enabled = false;
                mtbNumber.Text = "";
                oldNumber = "";
                tbEmail.Enabled = false;
                tbEmail.Text = "";
                oldEmail = "";
                user.Name = null;
                user.Number = null;
                user.Email = null;
                resetLabels();
            }
        }
        private void tbName_TextChanged(object sender, EventArgs e)
        {
            lbInvName.Visible = false;
            btUpdate.Enabled = false;
            if (tbName.Text == oldName)
            {
                btUpdate.Enabled = true;
                return;
            }
            if (user.NameIsValid(tbName.Text) == false)
            {
                lbInvName.Visible = true;
                lbInvName.Text = "* Name in use";
                return;
            }
            btUpdate.Enabled = true;
        }
        private void mtbNumber_TextChanged(object sender, EventArgs e)
        {
            lbInvNumber.Visible = false;
            btUpdate.Enabled = false;
            if (Validations.NumberIsValid(mtbNumber.Text) == false)
            {
                lbInvNumber.Visible = true;
                lbInvNumber.Text = "* Invalid number";
                return;
            }
            if (mtbNumber.Text == oldNumber)
            {
                btUpdate.Enabled = true;
                return;
            }
            if (user.NumberIsValid(mtbNumber.Text) == false)
            {
                lbInvNumber.Visible = true;
                lbInvNumber.Text = "* Number in use";
                return;
            }
            btUpdate.Enabled = true;
        }
        private void tbEmail_TextChanged(object sender, EventArgs e)
        {
            lbInvEmail.Visible = false;
            btUpdate.Enabled = false;
            if (Validations.EmailIsValid(tbEmail.Text) == false)
            {
                lbInvEmail.Visible = true;
                lbInvEmail.Text = "* Invalid email";
                return;
            }
            if (oldEmail == tbEmail.Text)
            {
                btUpdate.Enabled = true;
                return;
            }
            if (user.EmailIsValid(tbEmail.Text) == false)
            {
                lbInvEmail.Visible = true;
                lbInvEmail.Text = "* Email in use";
                return;
            }
            btUpdate.Enabled = true;
        }
        private void btUpdate_Click(object sender, EventArgs e)
        {
            if (user.Name == tbName.Text && user.Email == tbEmail.Text && user.Number == mtbNumber.Text)
            {
                SQLCommands.Update(user.Name,user.Number,user.Email, mtbID.Text);
                close();
                return;
            }
            MessageBox.Show("there are invalid or empty fields. ", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}

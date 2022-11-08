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
    public partial class ucCreate : UserControl
    {
        User user = new User();
        public ucCreate()
        {
            InitializeComponent();
        }
        private void close()
        {
            this.Parent.Controls.Remove(this);
        }
        private void btBack_Click(object sender, EventArgs e)
        {
            close();
        }
        private void tbName_TextChanged(object sender, EventArgs e)
        {
            if (user.NameIsValid(tbName.Text) == false)
            {
                lbInvName.Visible = true;
                lbInvName.Text = "* Name in use";
                return;
            }
            lbInvName.Visible = false;
        }
        private void mtbNumber_TextChanged(object sender, EventArgs e)
        {
            lbInvNumber.Visible = false;
            if (Validations.NumberIsValid(mtbNumber.Text) == false)
            {
                lbInvNumber.Visible = true;
                lbInvNumber.Text = "* Invalid number";
                return;
            }
            if (user.NumberIsValid(mtbNumber.Text) == false)
            {
                lbInvNumber.Visible = true;
                lbInvNumber.Text = "* Number in use";
                return;
            }
        }
        private void tbEmail_TextChanged(object sender, EventArgs e)
        {
            lbInvEmail.Visible = false;
            if (Validations.EmailIsValid(tbEmail.Text) == false)
            {
                lbInvEmail.Visible = true;
                lbInvEmail.Text = "* Invalid email";
                return;
            }
            if (user.EmailIsValid(tbEmail.Text) == false)
            {
                lbInvEmail.Visible = true;
                lbInvEmail.Text = "* Email in use";
                return;
            }
        }
        private void btCreate_Click(object sender, EventArgs e)
        {
            if (user.Name == tbName.Text && user.Email == tbEmail.Text && user.Number == mtbNumber.Text)
            {
                SQLCommands.Create(user.Name, user.Number, user.Email);
                close();
                return;
            }
            MessageBox.Show("there are invalid or empty fields. ", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}

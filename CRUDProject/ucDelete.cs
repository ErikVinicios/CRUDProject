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
    public partial class ucDelete : UserControl
    {
        public ucDelete()
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
        private void mtbID_TextChanged(object sender, EventArgs e)
        {
            MySqlDataReader dr = SQLCommands.Read();
            while (dr.Read())
            {
                if (dr["ID"].ToString() == mtbID.Text)
                {
                    tbName.Text = dr["Name"].ToString();
                    mtbNumber.Text = dr["Number"].ToString();
                    tbEmail.Text = dr["Email"].ToString();
                    lbInvID.Visible = false;
                    btDelete.Enabled = true;
                    return;
                }
                tbName.Text = "";
                mtbNumber.Text = "";
                tbEmail.Text = "";
                lbInvID.Visible = true;
                lbInvID.Text = "* ID not found";
                btDelete.Enabled = false;
            }
        }
        private void btDelete_Click(object sender, EventArgs e)
        {
            SQLCommands.Delete(mtbID.Text);
            close();
        }
    }
}

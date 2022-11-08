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

using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace CRUDProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void btUpdate_Click(object sender, EventArgs e)
        {
            ucUpdate update = new ucUpdate();
            update.Dock = DockStyle.Fill;
            panel1.Controls.Add(update);
            update.BringToFront();
        }
        private void btCreate_Click(object sender, EventArgs e)
        {
            ucCreate create = new ucCreate();
            create.Dock = DockStyle.Fill;
            panel1.Controls.Add(create);
            create.BringToFront();
        }
        private void btDelete_Click(object sender, EventArgs e)
        {
            ucDelete delete = new ucDelete();
            delete.Dock = DockStyle.Fill;
            panel1.Controls.Add(delete);
            delete.BringToFront();
        }
        private void tbSearch_TextChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = SQLCommands.SearchName(tbSearch.Text);
        }
        private void btTable_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = SQLCommands.Table();
        }
    }
}

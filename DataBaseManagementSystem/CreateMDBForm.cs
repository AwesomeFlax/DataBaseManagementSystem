using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataBaseManagementSystem
{
    public partial class CreateMDBForm : Form
    {
        Connection con;

        public CreateMDBForm()
        {
            InitializeComponent();
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            if (textBoxDBName.Text != "")
            {
                con = new Connection();
                con.CreateMDBfile(textBoxDBName.Text);
                MessageBox.Show("DataBase `" + textBoxDBName.Text + "` was created.");
                Close();
            }
            else
            {
                MessageBox.Show("Enter DataBase name!");
            }
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

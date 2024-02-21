using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Trabajo4_Auditoria.Data;

namespace Trabajo4_Auditoria
{
    public partial class InputBD : Form
    {
        public InputBD()
        {
            InitializeComponent();
            panel3.Visible = false;
            panel4.Visible = false;
        }

        public void button1_Click(object sender, EventArgs e)
        {
            string serverName = serverNameInput.Text;
            string BDName = DBNameInput.Text;
            string userName = usernameInput.Text;
            string password = passwordInput.Text;
            try
            {
                ConnectionInfo connectionInfo = new ConnectionInfo(serverName, BDName, null, null, true);
                ConnectionString.connectionString = connectionInfo.GetConnectionString();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void checkBoxAuthentication_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxAuthentication.Checked)
            {
                panel3.Visible = true;
                panel4.Visible = true; 
            }
            else
            {
                panel3.Visible = false;
                panel4.Visible = false;
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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
                
                try
                {
                    using (SqlConnection connection = new SqlConnection(connectionInfo.GetConnectionString()))
                    {
                        connection.Open();
                        Console.WriteLine("¡Conexión exitosa!");
                    }
                    ConnectionString.connectionString = connectionInfo.GetConnectionString();
                    MessageBox.Show("Se realizó correctamente la conexión con la base de datos");
                    this.Hide();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error al conectar a la base de datos: " + ex.Message);
                    MessageBox.Show("No se pudo conectar con la base de datos");
                }

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

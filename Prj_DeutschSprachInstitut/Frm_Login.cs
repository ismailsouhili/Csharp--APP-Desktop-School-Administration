using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;

namespace Prj_DeutschSprachInstitut
{
    public partial class Frm_Login : Form
    {
        public Frm_Login()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnEinloggen_Click(object sender, EventArgs e)
        {
            string req = string.Format("select * from [Administration] where Name='{0}' and Passwort ={1}",txtuser.Text,txtpass.Text);
            SqlDataAdapter dA = new SqlDataAdapter(req, @"data source = DESKTOP-OF1I649\SQLEXPRESS ; initial catalog = Schulverwaltung; integrated security = true");
            DataTable dt = new DataTable();
            dA.Fill(dt);
            //txtuser.Text==dt.Rows[0][0].ToString() || txtpass.Text==dt.Rows[0][1].ToString()
            if (dt.Rows.Count>0)
            {
                Frm_Menu men = new Frm_Menu();
                this.Hide();
                men.Show();

            }
            else
            {
                MessageBox.Show("Überprüfen Sie Ihren Benutzernamen und Ihr Passwort");
            }
            
        }

        private void lblshließen_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnext_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

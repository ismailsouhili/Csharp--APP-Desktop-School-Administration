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
    public partial class Frm_Administration : Form
    {
        SqlConnection cnx = new SqlConnection(@"data source=DESKTOP-OF1I649\SQLEXPRESS ;initial catalog=Schulverwaltung ;integrated security=true");

        public Frm_Administration()
        {
            InitializeComponent();
        }

        private void lblshließen_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnHinzufügen_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("insert into Administration values(@Ref,@Name,@Vorname,@Status,@Passwort)", cnx);
           

            cmd.Parameters.AddWithValue("@Ref", txtrefnum.Text);
            cmd.Parameters.AddWithValue("@Name", txtname.Text);
            cmd.Parameters.AddWithValue("@Vorname", txtvorname.Text);
            cmd.Parameters.AddWithValue("@Status", txtstatus.Text);
            cmd.Parameters.AddWithValue("@Passwort", txtpass.Text);

            cnx.Open();
            int n = cmd.ExecuteNonQuery();
            cnx.Close();
            if (n == 1)
                MessageBox.Show("Hinzugefügt mit Erfolg");
            Feldlöschen();
        }

        private void btnBearbeiten_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("update Administration set Name=@Name  , Vorname=@Vorname , Statuss=@Status ,Passwort=@Passwort where RefNum=@Ref ", cnx);
          

            cmd.Parameters.AddWithValue("@Ref", txtrefnum.Text);
            cmd.Parameters.AddWithValue("@Name", txtname.Text);
            cmd.Parameters.AddWithValue("@Vorname", txtvorname.Text);
            cmd.Parameters.AddWithValue("@Status", txtstatus.Text);
            cmd.Parameters.AddWithValue("@Passwort", txtpass.Text);

            cnx.Open();
            int n = cmd.ExecuteNonQuery();
            cnx.Close();
            if (n == 1)
                MessageBox.Show("Bearbeitet mit Erfolg");
            Feldlöschen();
        }

        private void btnLöschen_Click(object sender, EventArgs e)
        {
          
            SqlCommand cmd = new SqlCommand("delete from Administration where RefNum=@Ref ", cnx);

           
            cmd.Parameters.AddWithValue("@Ref", txtrefnum.Text);
          
            cnx.Open();
            int n = cmd.ExecuteNonQuery();
            cnx.Close();
            if (n == 1)
                MessageBox.Show("Erfolgreich löschen");
            Feldlöschen();
        }

        private void Frm_Administration_Load(object sender, EventArgs e)
        {
            Table();
        }

        private void btnsuchen_Click(object sender, EventArgs e)
        {
            string req = string.Format("select * from Administration where RefNum={0}",txtSuchen.Text);
            SqlDataAdapter da = new SqlDataAdapter(req, cnx);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void btnWiederherstellen_Click(object sender, EventArgs e)
        {
            Table();
            Feldlöschen();
        }

        public void Table()
        {
            SqlDataAdapter da = new SqlDataAdapter("select * from Administration", cnx);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
        public void Feldlöschen()
        {
            txtSuchen.Text = string.Empty;
            txtrefnum.Text = string.Empty;
            txtname.Text = string.Empty;
            txtvorname.Text = string.Empty;
            txtstatus.Text = string.Empty;
            txtpass.Text = string.Empty;
        }

        private void btnListeKurs_Click(object sender, EventArgs e)
        {
            ListeAdmin la = new ListeAdmin();
            la.Show();
        }
    }
}

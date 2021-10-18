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

namespace Prj_DeutschSprachInstitut
{
    public partial class Frm_Teilnehmer : Form
    {
        SqlConnection cnx = new SqlConnection(@"data source=DESKTOP-OF1I649\SQLEXPRESS ;initial catalog=Schulverwaltung ;integrated security=true");

        public Frm_Teilnehmer()
        {
            InitializeComponent();
        }

        private void lblshließen_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Frm_Teilnehmer_Load(object sender, EventArgs e)
        {
            Table();
        }

        private void btnHinzufügen_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("insert into Teilnehmer values(@ref,@IDS,@Note)", cnx);

            cmd.Parameters.AddWithValue("@ref", txtREFKURS.Text);
            cmd.Parameters.AddWithValue("@IDS", txtIDSCHULER.Text);
            cmd.Parameters.AddWithValue("@Note", txtNote.Text);

            cnx.Open();
            int n = cmd.ExecuteNonQuery();
            cnx.Close();
            if (n == 1)
            {
                MessageBox.Show("Hinzugefügt mit Erfolg");
                Feldlöschen();
            }
            else
                MessageBox.Show("Schon gefunden !!");
        }

        private void btnBearbeiten_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("update Teilnehmer set  IDS=@ids  ,Note=@note where RefKurs=@ref ", cnx);

            cmd.Parameters.AddWithValue("@ref", txtREFKURS.Text);
            cmd.Parameters.AddWithValue("@ids", txtIDSCHULER.Text);
            cmd.Parameters.AddWithValue("@note", txtNote.Text);

            cnx.Open();
            int n = cmd.ExecuteNonQuery();
            cnx.Close();
            if (n == 1)
            {
                MessageBox.Show("Bearbeitet mit Erfolg");
                Feldlöschen();
            }
            else
                MessageBox.Show("Es ist nicht gefunden !!");
        }

        private void btnLöschen_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("delete from Teilnehmer where RefKurs=@ref ", cnx);

            cmd.Parameters.AddWithValue("@ref", txtREFKURS.Text);

            cnx.Open();
            int n = cmd.ExecuteNonQuery();
            cnx.Close();
            if (n == 1)
            {
                MessageBox.Show("Erfolgreich löschen");
                Feldlöschen();
            }

            else
                MessageBox.Show("Es ist nicht gefunden !!");
        }

        private void btnsuchen_Click(object sender, EventArgs e)
        {
            string req = string.Format("select * from Teilnehmer where RefKurs={0}", txtSuchen.Text);
            SqlDataAdapter da = new SqlDataAdapter(req, cnx);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        public void Table()
        {
            SqlDataAdapter da = new SqlDataAdapter("select * from Teilnehmer", cnx);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
        public void Feldlöschen()
        {
            txtREFKURS.Text = string.Empty;
            txtIDSCHULER.Text = string.Empty;
            txtNote.Text = string.Empty;
          
        }

        private void btnWiederherstellen_Click(object sender, EventArgs e)
        {
            Table();
            Feldlöschen();
        }

        private void btnListeTeilnehm_Click(object sender, EventArgs e)
        {
            ListeTeilnehmen lt = new ListeTeilnehmen();
            lt.Show();
        }
    }
}

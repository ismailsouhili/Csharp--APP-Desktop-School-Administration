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
    public partial class Frm_Kursen : Form
    {
        SqlConnection cnx = new SqlConnection(@"data source=DESKTOP-OF1I649\SQLEXPRESS ;initial catalog=Schulverwaltung ;integrated security=true");

        public Frm_Kursen()
        {
            InitializeComponent();
        }

        private void lblshließen_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnHinzufügen_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("insert into Kursen values(@ref,@Name,@AS,@IDT)", cnx);

            cmd.Parameters.AddWithValue("@ref", txtREFKURS.Text);
            cmd.Parameters.AddWithValue("@Name", txtNAMEKURS.Text);
            cmd.Parameters.AddWithValue("@AS", txtAS.Text);
            cmd.Parameters.AddWithValue("@IDT", cmbIDT.Text);

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
            SqlCommand cmd = new SqlCommand("update Kursen set  NameKurs=@Name , AnzahlSitze=@AS ,IDT=@IDT where RefKurs=@ref ", cnx);

            cmd.Parameters.AddWithValue("@ref", txtREFKURS.Text);
            cmd.Parameters.AddWithValue("@Name", txtNAMEKURS.Text);
            cmd.Parameters.AddWithValue("@AS", txtAS.Text);
            cmd.Parameters.AddWithValue("@IDT", cmbIDT.Text);

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
            SqlCommand cmd = new SqlCommand("delete from Kursen where RefKurs=@ref ", cnx);

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
            string req = string.Format("select * from Kursen where RefKurs={0}", txtSuchen.Text);
            SqlDataAdapter da = new SqlDataAdapter(req, cnx);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        public void Table()
        {
            SqlDataAdapter da = new SqlDataAdapter("select * from Kursen", cnx);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
        public void Feldlöschen()
        {
            txtREFKURS.Text = string.Empty;
            txtNAMEKURS.Text = string.Empty;
            txtAS.Text = string.Empty;
            cmbIDT.Text = string.Empty;
            txtSuchen.Text = string.Empty;


        }

        private void btnWiederherstellen_Click(object sender, EventArgs e)
        {
            Table();
            Feldlöschen();
        }

        private void Frm_Kursen_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'schulverwaltungDataSet2.Trainer'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.trainerTableAdapter.Fill(this.schulverwaltungDataSet2.Trainer);
            Table();
        }

        private void btnListeKurs_Click(object sender, EventArgs e)
        {
            ListeKursen lk = new ListeKursen();
            lk.Show();
        }
    }
}

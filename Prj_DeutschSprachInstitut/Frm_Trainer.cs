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
    public partial class Frm_Trainer : Form
    {
        SqlConnection cnx = new SqlConnection(@"data source=DESKTOP-OF1I649\SQLEXPRESS ;initial catalog=Schulverwaltung ;integrated security=true");

        public Frm_Trainer()
        {
            InitializeComponent();
        }

        private void lblshließen_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Frm_Trainer_Load(object sender, EventArgs e)
        {
            Table();
        }

        private void btnHinzufügen_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("insert into Trainer values(@ID,@Name,@Vorname,@Ab,@Gd)", cnx);

            cmd.Parameters.AddWithValue("@ID", txtID.Text);
            cmd.Parameters.AddWithValue("@Name", txtName.Text);
            cmd.Parameters.AddWithValue("@Vorname", txtVorname.Text);
            cmd.Parameters.AddWithValue("@Ab", txtAbteilung.Text);
            cmd.Parameters.AddWithValue("@Gd", txtGrad.Text);

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
            SqlCommand cmd = new SqlCommand("update Trainer set Name=@Name  , Vorname=@Vorname , Abteilung=@Ab ,Grad=@Gd where IDT=@ID ", cnx);

            cmd.Parameters.AddWithValue("@ID", txtID.Text);
            cmd.Parameters.AddWithValue("@Name", txtName.Text);
            cmd.Parameters.AddWithValue("@Vorname", txtVorname.Text);
            cmd.Parameters.AddWithValue("@Ab", txtAbteilung.Text);
            cmd.Parameters.AddWithValue("@Gd", txtGrad.Text);

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
            SqlCommand cmd = new SqlCommand("delete from Trainer where IDT=@ID ", cnx);

            cmd.Parameters.AddWithValue("@ID", txtID.Text);

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
            string req = string.Format("select * from Trainer where IDT={0}", txtSuchen.Text);
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
            SqlDataAdapter da = new SqlDataAdapter("select * from Trainer", cnx);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
        public void Feldlöschen()
        {
            txtID.Text = string.Empty;
            txtName.Text = string.Empty;
            txtVorname.Text = string.Empty;
            txtAbteilung.Text = string.Empty;
            txtGrad.Text = string.Empty;
            txtSuchen.Text = string.Empty;


        }

        private void btnListeTrainer_Click(object sender, EventArgs e)
        {
            ListeTrainer lt = new ListeTrainer();
            lt.Show();
        }
    }
}

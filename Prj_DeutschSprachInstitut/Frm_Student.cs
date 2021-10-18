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
    public partial class Frm_Student : Form
    {
        SqlConnection cnx = new SqlConnection(@"data source=DESKTOP-OF1I649\SQLEXPRESS ;initial catalog=Schulverwaltung ;integrated security=true");

        public Frm_Student()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblshließen_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Frm_Student_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'schulverwaltungDataSet1.Kursen'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.kursenTableAdapter1.Fill(this.schulverwaltungDataSet1.Kursen);
            // TODO: cette ligne de code charge les données dans la table 'schulverwaltungDataSet.Kursen'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.kursenTableAdapter.Fill(this.schulverwaltungDataSet.Kursen);
            Table();
        }

        private void btnHinzufügen_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("insert into Student values(@ID,@Name,@Vorname,@SN,@RK)", cnx);

            cmd.Parameters.AddWithValue("@ID", txtID.Text);
            cmd.Parameters.AddWithValue("@Name", txtName.Text);
            cmd.Parameters.AddWithValue("@Vorname", txtVorname.Text);
            cmd.Parameters.AddWithValue("@SN", cmbShulNiv.Text);
            cmd.Parameters.AddWithValue("@RK", cmbRefKurs.Text);

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
            SqlCommand cmd = new SqlCommand("update Student set Name=@Name  , Vorname=@Vorname , Schulniveau=@SN ,RefKurs=@RK where IDS=@ID ", cnx);

            cmd.Parameters.AddWithValue("@ID", txtID.Text);
            cmd.Parameters.AddWithValue("@Name", txtName.Text);
            cmd.Parameters.AddWithValue("@Vorname", txtVorname.Text);
            cmd.Parameters.AddWithValue("@SN", cmbShulNiv.Text);
            cmd.Parameters.AddWithValue("@RK", cmbRefKurs.Text);

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
            SqlCommand cmd = new SqlCommand("delete from Student where IDS=@ID ", cnx);

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
            string req = string.Format("select * from Student where IDS={0}", txtsuchen.Text);
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
            SqlDataAdapter da = new SqlDataAdapter("select * from Student", cnx);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
        public void Feldlöschen()
        {
            txtID.Text = string.Empty;
            txtName.Text = string.Empty;
            txtVorname.Text = string.Empty;
            cmbShulNiv.Text = string.Empty;
            cmbRefKurs.Text = string.Empty;

        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.kursenTableAdapter.FillBy(this.schulverwaltungDataSet.Kursen);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void btnListeSchule_Click(object sender, EventArgs e)
        {
            ListeStudenten ls = new ListeStudenten();
            ls.Show();
        }
    }
}

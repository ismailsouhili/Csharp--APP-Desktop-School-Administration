using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prj_DeutschSprachInstitut
{
    public partial class Frm_Menu : Form
    {

        private Form currentchildform;
        private Panel leftborderbtn;

        public Frm_Menu()
        {
            InitializeComponent();

            leftborderbtn = new Panel();
            leftborderbtn.Size = new Size(7, 40);
            homepanel.Controls.Add(leftborderbtn);
            //
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }

        private void openchildform(Form childform)
        {

            //open only one form
            currentchildform = childform;
            childform.TopLevel = false;
            childform.FormBorderStyle = FormBorderStyle.None;
            childform.Dock = DockStyle.Fill;
            homepanel.Controls.Add(childform);
            childform.BringToFront();
            childform.Show();


        }

        private void lblsignup_Click(object sender, EventArgs e)
        {

        }

        private void panelRight_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Frm_Student student = new Frm_Student();
            //student.Show();

            openchildform(new Frm_Student());
        }

        private void lblshließen_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Frm_Administration admin = new Frm_Administration();
            //admin.Show();

            openchildform(new Frm_Administration());

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Frm_Trainer trainer = new Frm_Trainer();
            //trainer.Show();

            openchildform(new Frm_Trainer());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //Frm_Kursen kurs = new Frm_Kursen();
            //kurs.Show();

            openchildform(new Frm_Kursen());
        }

        private void btnTeilnehmer_Click(object sender, EventArgs e)
        {
            //Frm_Teilnehmer teilnehm = new Frm_Teilnehmer();
            //teilnehm.Show();

         //   activatebutton(sender, rgbcolors.color1);
            openchildform(new Frm_Teilnehmer());
        }

       

        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            openchildform(new Frm_Administration());
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            openchildform(new Frm_Trainer());
        }

        private void btnAusgang_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnStudent_Click(object sender, EventArgs e)
        {
            openchildform(new Frm_Student());
        }

        private void btnKursen_Click(object sender, EventArgs e)
        {
            openchildform(new Frm_Kursen());
        }

        private void btnTeilnehmer_Click_1(object sender, EventArgs e)
        {
            openchildform(new Frm_Teilnehmer());
        }
    }
}

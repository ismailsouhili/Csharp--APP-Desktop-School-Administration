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
    public partial class Frm_Progress : Form
    {
        public Frm_Progress()
        {
            InitializeComponent();
        }

        int starpoint = 0;

        private void Frm_Progress_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            starpoint += 1;
            progres.Value = starpoint;
            if (progres.Value == 100)
            {
                progres.Value = 0;
                timer1.Stop();
                this.Hide();
                Frm_Login lg = new Frm_Login();
                lg.Show();
            }
        }
    }
}

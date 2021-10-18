namespace Prj_DeutschSprachInstitut
{
    partial class ListeStudenten
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.CR = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
         //   this.CrystalReport11 = new Prj_DeutschSprachInstitut.CrystalReport1();
            this.CR_Schüler1 = new Prj_DeutschSprachInstitut.CR_Schüler();
            this.SuspendLayout();
            // 
            // CR
            // 
            this.CR.ActiveViewIndex = 0;
            this.CR.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CR.Cursor = System.Windows.Forms.Cursors.Default;
            this.CR.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CR.Location = new System.Drawing.Point(0, 0);
            this.CR.Name = "CR";
            this.CR.ReportSource = this.CR_Schüler1;
            this.CR.Size = new System.Drawing.Size(800, 450);
            this.CR.TabIndex = 0;
            // 
            // ListeStudenten
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CR);
            this.Name = "ListeStudenten";
            this.Text = "ListeStudenten";
            this.Load += new System.EventHandler(this.ListeStudenten_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer CR;
       // private CrystalReport1 CrystalReport11;
        private CR_Schüler CR_Schüler1;
    }
}
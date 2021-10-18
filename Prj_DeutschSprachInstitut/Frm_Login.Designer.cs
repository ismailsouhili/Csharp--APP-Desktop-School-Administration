namespace Prj_DeutschSprachInstitut
{
    partial class Frm_Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Login));
            this.panelLeft = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelRight = new System.Windows.Forms.Panel();
            this.lblshließen = new System.Windows.Forms.Label();
            this.btnext = new System.Windows.Forms.Button();
            this.txtpass = new System.Windows.Forms.TextBox();
            this.txtuser = new System.Windows.Forms.TextBox();
            this.btnEinloggen = new System.Windows.Forms.Button();
            this.lblPasswort = new System.Windows.Forms.Label();
            this.lblNutzername = new System.Windows.Forms.Label();
            this.lblEinloggen = new System.Windows.Forms.Label();
            this.panelLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelRight.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelLeft
            // 
            this.panelLeft.BackColor = System.Drawing.Color.Gainsboro;
            this.panelLeft.Controls.Add(this.label1);
            this.panelLeft.Controls.Add(this.pictureBox1);
            this.panelLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeft.Location = new System.Drawing.Point(0, 0);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Size = new System.Drawing.Size(352, 496);
            this.panelLeft.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(38, 314);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(242, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "Wir lernen, wir entwickeln!";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pictureBox1.Location = new System.Drawing.Point(66, 103);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(190, 196);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panelRight
            // 
            this.panelRight.Controls.Add(this.lblshließen);
            this.panelRight.Controls.Add(this.btnext);
            this.panelRight.Controls.Add(this.txtpass);
            this.panelRight.Controls.Add(this.txtuser);
            this.panelRight.Controls.Add(this.btnEinloggen);
            this.panelRight.Controls.Add(this.lblPasswort);
            this.panelRight.Controls.Add(this.lblNutzername);
            this.panelRight.Controls.Add(this.lblEinloggen);
            this.panelRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelRight.Location = new System.Drawing.Point(352, 0);
            this.panelRight.Name = "panelRight";
            this.panelRight.Size = new System.Drawing.Size(404, 496);
            this.panelRight.TabIndex = 3;
            // 
            // lblshließen
            // 
            this.lblshließen.AutoSize = true;
            this.lblshließen.Font = new System.Drawing.Font("Century Gothic", 18F);
            this.lblshließen.ForeColor = System.Drawing.Color.Black;
            this.lblshließen.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblshließen.Location = new System.Drawing.Point(365, 9);
            this.lblshließen.Name = "lblshließen";
            this.lblshließen.Size = new System.Drawing.Size(25, 30);
            this.lblshließen.TabIndex = 6;
            this.lblshließen.Text = "x";
            this.lblshließen.Click += new System.EventHandler(this.lblshließen_Click);
            // 
            // btnext
            // 
            this.btnext.BackColor = System.Drawing.Color.Gray;
            this.btnext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnext.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.btnext.ForeColor = System.Drawing.Color.White;
            this.btnext.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnext.Location = new System.Drawing.Point(29, 335);
            this.btnext.Name = "btnext";
            this.btnext.Size = new System.Drawing.Size(297, 34);
            this.btnext.TabIndex = 5;
            this.btnext.Text = "Exit";
            this.btnext.UseVisualStyleBackColor = false;
            this.btnext.Click += new System.EventHandler(this.btnext_Click);
            // 
            // txtpass
            // 
            this.txtpass.Location = new System.Drawing.Point(29, 236);
            this.txtpass.Name = "txtpass";
            this.txtpass.PasswordChar = '*';
            this.txtpass.Size = new System.Drawing.Size(229, 20);
            this.txtpass.TabIndex = 4;
            // 
            // txtuser
            // 
            this.txtuser.Location = new System.Drawing.Point(29, 165);
            this.txtuser.Name = "txtuser";
            this.txtuser.Size = new System.Drawing.Size(229, 20);
            this.txtuser.TabIndex = 3;
            // 
            // btnEinloggen
            // 
            this.btnEinloggen.BackColor = System.Drawing.Color.Gray;
            this.btnEinloggen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEinloggen.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.btnEinloggen.ForeColor = System.Drawing.Color.White;
            this.btnEinloggen.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnEinloggen.Location = new System.Drawing.Point(29, 286);
            this.btnEinloggen.Name = "btnEinloggen";
            this.btnEinloggen.Size = new System.Drawing.Size(297, 34);
            this.btnEinloggen.TabIndex = 2;
            this.btnEinloggen.Text = "Einloggen";
            this.btnEinloggen.UseVisualStyleBackColor = false;
            this.btnEinloggen.Click += new System.EventHandler(this.btnEinloggen_Click);
            // 
            // lblPasswort
            // 
            this.lblPasswort.AutoSize = true;
            this.lblPasswort.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.lblPasswort.ForeColor = System.Drawing.Color.Black;
            this.lblPasswort.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblPasswort.Location = new System.Drawing.Point(25, 203);
            this.lblPasswort.Name = "lblPasswort";
            this.lblPasswort.Size = new System.Drawing.Size(78, 21);
            this.lblPasswort.TabIndex = 0;
            this.lblPasswort.Text = "Passwort";
            // 
            // lblNutzername
            // 
            this.lblNutzername.AutoSize = true;
            this.lblNutzername.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.lblNutzername.ForeColor = System.Drawing.Color.Black;
            this.lblNutzername.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblNutzername.Location = new System.Drawing.Point(25, 132);
            this.lblNutzername.Name = "lblNutzername";
            this.lblNutzername.Size = new System.Drawing.Size(107, 21);
            this.lblNutzername.TabIndex = 0;
            this.lblNutzername.Text = "Nutzername";
            // 
            // lblEinloggen
            // 
            this.lblEinloggen.AutoSize = true;
            this.lblEinloggen.Font = new System.Drawing.Font("Century Gothic", 18F);
            this.lblEinloggen.ForeColor = System.Drawing.Color.Black;
            this.lblEinloggen.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblEinloggen.Location = new System.Drawing.Point(24, 78);
            this.lblEinloggen.Name = "lblEinloggen";
            this.lblEinloggen.Size = new System.Drawing.Size(132, 30);
            this.lblEinloggen.TabIndex = 0;
            this.lblEinloggen.Text = "Einloggen";
            // 
            // Frm_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(756, 496);
            this.Controls.Add(this.panelRight);
            this.Controls.Add(this.panelLeft);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_Login";
            this.Text = "Frm_Login";
            this.panelLeft.ResumeLayout(false);
            this.panelLeft.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelRight.ResumeLayout(false);
            this.panelRight.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelLeft;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panelRight;
        private System.Windows.Forms.Button btnext;
        private System.Windows.Forms.TextBox txtpass;
        private System.Windows.Forms.TextBox txtuser;
        private System.Windows.Forms.Button btnEinloggen;
        private System.Windows.Forms.Label lblPasswort;
        private System.Windows.Forms.Label lblNutzername;
        private System.Windows.Forms.Label lblEinloggen;
        private System.Windows.Forms.Label lblshließen;
    }
}
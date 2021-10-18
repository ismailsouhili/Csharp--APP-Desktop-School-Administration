namespace Prj_DeutschSprachInstitut
{
    partial class Frm_Administration
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
            this.lblshließen = new System.Windows.Forms.Label();
            this.txtSuchen = new System.Windows.Forms.TextBox();
            this.btnsuchen = new System.Windows.Forms.Button();
            this.btnBearbeiten = new System.Windows.Forms.Button();
            this.btnHinzufügen = new System.Windows.Forms.Button();
            this.btnLöschen = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtpass = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.txtstatus = new System.Windows.Forms.TextBox();
            this.txtvorname = new System.Windows.Forms.TextBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblVorame = new System.Windows.Forms.Label();
            this.txtname = new System.Windows.Forms.TextBox();
            this.txtrefnum = new System.Windows.Forms.TextBox();
            this.lblPasswort = new System.Windows.Forms.Label();
            this.lblRefName = new System.Windows.Forms.Label();
            this.btnWiederherstellen = new System.Windows.Forms.Button();
            this.btnListeKurs = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblshließen
            // 
            this.lblshließen.AutoSize = true;
            this.lblshließen.Font = new System.Drawing.Font("Century Gothic", 18F);
            this.lblshließen.ForeColor = System.Drawing.Color.Black;
            this.lblshließen.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblshließen.Location = new System.Drawing.Point(929, 9);
            this.lblshließen.Name = "lblshließen";
            this.lblshließen.Size = new System.Drawing.Size(25, 30);
            this.lblshließen.TabIndex = 45;
            this.lblshließen.Text = "x";
            this.lblshließen.Click += new System.EventHandler(this.lblshließen_Click);
            // 
            // txtSuchen
            // 
            this.txtSuchen.Location = new System.Drawing.Point(573, 46);
            this.txtSuchen.Name = "txtSuchen";
            this.txtSuchen.Size = new System.Drawing.Size(174, 20);
            this.txtSuchen.TabIndex = 44;
            // 
            // btnsuchen
            // 
            this.btnsuchen.BackColor = System.Drawing.Color.Gray;
            this.btnsuchen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsuchen.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.btnsuchen.ForeColor = System.Drawing.Color.White;
            this.btnsuchen.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnsuchen.Location = new System.Drawing.Point(426, 36);
            this.btnsuchen.Name = "btnsuchen";
            this.btnsuchen.Size = new System.Drawing.Size(120, 34);
            this.btnsuchen.TabIndex = 43;
            this.btnsuchen.Text = "Suchen";
            this.btnsuchen.UseVisualStyleBackColor = false;
            this.btnsuchen.Click += new System.EventHandler(this.btnsuchen_Click);
            // 
            // btnBearbeiten
            // 
            this.btnBearbeiten.BackColor = System.Drawing.Color.Gray;
            this.btnBearbeiten.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBearbeiten.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.btnBearbeiten.ForeColor = System.Drawing.Color.White;
            this.btnBearbeiten.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnBearbeiten.Location = new System.Drawing.Point(139, 325);
            this.btnBearbeiten.Name = "btnBearbeiten";
            this.btnBearbeiten.Size = new System.Drawing.Size(120, 34);
            this.btnBearbeiten.TabIndex = 42;
            this.btnBearbeiten.Text = "Bearbeiten";
            this.btnBearbeiten.UseVisualStyleBackColor = false;
            this.btnBearbeiten.Click += new System.EventHandler(this.btnBearbeiten_Click);
            // 
            // btnHinzufügen
            // 
            this.btnHinzufügen.BackColor = System.Drawing.Color.Gray;
            this.btnHinzufügen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHinzufügen.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.btnHinzufügen.ForeColor = System.Drawing.Color.White;
            this.btnHinzufügen.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnHinzufügen.Location = new System.Drawing.Point(17, 325);
            this.btnHinzufügen.Name = "btnHinzufügen";
            this.btnHinzufügen.Size = new System.Drawing.Size(120, 34);
            this.btnHinzufügen.TabIndex = 41;
            this.btnHinzufügen.Text = "Hinzufügen";
            this.btnHinzufügen.UseVisualStyleBackColor = false;
            this.btnHinzufügen.Click += new System.EventHandler(this.btnHinzufügen_Click);
            // 
            // btnLöschen
            // 
            this.btnLöschen.BackColor = System.Drawing.Color.Gray;
            this.btnLöschen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLöschen.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.btnLöschen.ForeColor = System.Drawing.Color.White;
            this.btnLöschen.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnLöschen.Location = new System.Drawing.Point(265, 325);
            this.btnLöschen.Name = "btnLöschen";
            this.btnLöschen.Size = new System.Drawing.Size(120, 34);
            this.btnLöschen.TabIndex = 40;
            this.btnLöschen.Text = "Löschen";
            this.btnLöschen.UseVisualStyleBackColor = false;
            this.btnLöschen.Click += new System.EventHandler(this.btnLöschen_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(394, 77);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(560, 243);
            this.dataGridView1.TabIndex = 38;
            // 
            // txtpass
            // 
            this.txtpass.Location = new System.Drawing.Point(138, 252);
            this.txtpass.Name = "txtpass";
            this.txtpass.Size = new System.Drawing.Size(229, 20);
            this.txtpass.TabIndex = 36;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.lblName.ForeColor = System.Drawing.Color.Black;
            this.lblName.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblName.Location = new System.Drawing.Point(11, 115);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(58, 21);
            this.lblName.TabIndex = 35;
            this.lblName.Text = "Name";
            // 
            // txtstatus
            // 
            this.txtstatus.Location = new System.Drawing.Point(138, 206);
            this.txtstatus.Name = "txtstatus";
            this.txtstatus.Size = new System.Drawing.Size(229, 20);
            this.txtstatus.TabIndex = 33;
            // 
            // txtvorname
            // 
            this.txtvorname.Location = new System.Drawing.Point(138, 161);
            this.txtvorname.Name = "txtvorname";
            this.txtvorname.Size = new System.Drawing.Size(229, 20);
            this.txtvorname.TabIndex = 32;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.lblStatus.ForeColor = System.Drawing.Color.Black;
            this.lblStatus.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblStatus.Location = new System.Drawing.Point(16, 203);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(59, 21);
            this.lblStatus.TabIndex = 30;
            this.lblStatus.Text = "Status";
            // 
            // lblVorame
            // 
            this.lblVorame.AutoSize = true;
            this.lblVorame.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.lblVorame.ForeColor = System.Drawing.Color.Black;
            this.lblVorame.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblVorame.Location = new System.Drawing.Point(12, 158);
            this.lblVorame.Name = "lblVorame";
            this.lblVorame.Size = new System.Drawing.Size(82, 21);
            this.lblVorame.TabIndex = 31;
            this.lblVorame.Text = "Vorname";
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(138, 118);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(229, 20);
            this.txtname.TabIndex = 29;
            // 
            // txtrefnum
            // 
            this.txtrefnum.Location = new System.Drawing.Point(138, 77);
            this.txtrefnum.Name = "txtrefnum";
            this.txtrefnum.Size = new System.Drawing.Size(229, 20);
            this.txtrefnum.TabIndex = 28;
            // 
            // lblPasswort
            // 
            this.lblPasswort.AutoSize = true;
            this.lblPasswort.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.lblPasswort.ForeColor = System.Drawing.Color.Black;
            this.lblPasswort.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblPasswort.Location = new System.Drawing.Point(16, 249);
            this.lblPasswort.Name = "lblPasswort";
            this.lblPasswort.Size = new System.Drawing.Size(78, 21);
            this.lblPasswort.TabIndex = 26;
            this.lblPasswort.Text = "Passwort";
            // 
            // lblRefName
            // 
            this.lblRefName.AutoSize = true;
            this.lblRefName.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.lblRefName.ForeColor = System.Drawing.Color.Black;
            this.lblRefName.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblRefName.Location = new System.Drawing.Point(12, 74);
            this.lblRefName.Name = "lblRefName";
            this.lblRefName.Size = new System.Drawing.Size(106, 21);
            this.lblRefName.TabIndex = 27;
            this.lblRefName.Text = "Ref.Nummer";
            // 
            // btnWiederherstellen
            // 
            this.btnWiederherstellen.BackColor = System.Drawing.Color.Gray;
            this.btnWiederherstellen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWiederherstellen.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.btnWiederherstellen.ForeColor = System.Drawing.Color.White;
            this.btnWiederherstellen.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnWiederherstellen.Location = new System.Drawing.Point(764, 36);
            this.btnWiederherstellen.Name = "btnWiederherstellen";
            this.btnWiederherstellen.Size = new System.Drawing.Size(138, 34);
            this.btnWiederherstellen.TabIndex = 46;
            this.btnWiederherstellen.Text = "Wiederherstellen";
            this.btnWiederherstellen.UseVisualStyleBackColor = false;
            this.btnWiederherstellen.Click += new System.EventHandler(this.btnWiederherstellen_Click);
            // 
            // btnListeKurs
            // 
            this.btnListeKurs.BackColor = System.Drawing.Color.Gray;
            this.btnListeKurs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnListeKurs.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.btnListeKurs.ForeColor = System.Drawing.Color.White;
            this.btnListeKurs.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnListeKurs.Location = new System.Drawing.Point(494, 326);
            this.btnListeKurs.Name = "btnListeKurs";
            this.btnListeKurs.Size = new System.Drawing.Size(361, 34);
            this.btnListeKurs.TabIndex = 47;
            this.btnListeKurs.Text = "Liste der Administration";
            this.btnListeKurs.UseVisualStyleBackColor = false;
            this.btnListeKurs.Click += new System.EventHandler(this.btnListeKurs_Click);
            // 
            // Frm_Administration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(963, 371);
            this.Controls.Add(this.btnListeKurs);
            this.Controls.Add(this.btnWiederherstellen);
            this.Controls.Add(this.lblshließen);
            this.Controls.Add(this.txtSuchen);
            this.Controls.Add(this.btnsuchen);
            this.Controls.Add(this.btnBearbeiten);
            this.Controls.Add(this.btnHinzufügen);
            this.Controls.Add(this.btnLöschen);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtpass);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.txtstatus);
            this.Controls.Add(this.txtvorname);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.lblVorame);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.txtrefnum);
            this.Controls.Add(this.lblPasswort);
            this.Controls.Add(this.lblRefName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_Administration";
            this.Text = "Frm_Administration";
            this.Load += new System.EventHandler(this.Frm_Administration_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblshließen;
        private System.Windows.Forms.TextBox txtSuchen;
        private System.Windows.Forms.Button btnsuchen;
        private System.Windows.Forms.Button btnBearbeiten;
        private System.Windows.Forms.Button btnHinzufügen;
        private System.Windows.Forms.Button btnLöschen;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtpass;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtstatus;
        private System.Windows.Forms.TextBox txtvorname;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblVorame;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.TextBox txtrefnum;
        private System.Windows.Forms.Label lblPasswort;
        private System.Windows.Forms.Label lblRefName;
        private System.Windows.Forms.Button btnWiederherstellen;
        private System.Windows.Forms.Button btnListeKurs;
    }
}
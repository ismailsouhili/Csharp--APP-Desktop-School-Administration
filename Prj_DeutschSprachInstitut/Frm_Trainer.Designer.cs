namespace Prj_DeutschSprachInstitut
{
    partial class Frm_Trainer
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
            this.btnListeTrainer = new System.Windows.Forms.Button();
            this.txtGrad = new System.Windows.Forms.TextBox();
            this.lblGrad = new System.Windows.Forms.Label();
            this.txtAbteilung = new System.Windows.Forms.TextBox();
            this.txtVorname = new System.Windows.Forms.TextBox();
            this.lblAbteilung = new System.Windows.Forms.Label();
            this.lblVorname = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblIDTrainer = new System.Windows.Forms.Label();
            this.txtSuchen = new System.Windows.Forms.TextBox();
            this.btnsuchen = new System.Windows.Forms.Button();
            this.btnBearbeiten = new System.Windows.Forms.Button();
            this.btnHinzufügen = new System.Windows.Forms.Button();
            this.btnLöschen = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lblshließen = new System.Windows.Forms.Label();
            this.btnWiederherstellen = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnListeTrainer
            // 
            this.btnListeTrainer.BackColor = System.Drawing.Color.Gray;
            this.btnListeTrainer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnListeTrainer.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.btnListeTrainer.ForeColor = System.Drawing.Color.White;
            this.btnListeTrainer.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnListeTrainer.Location = new System.Drawing.Point(490, 316);
            this.btnListeTrainer.Name = "btnListeTrainer";
            this.btnListeTrainer.Size = new System.Drawing.Size(365, 34);
            this.btnListeTrainer.TabIndex = 39;
            this.btnListeTrainer.Text = "Liste der Trainer";
            this.btnListeTrainer.UseVisualStyleBackColor = false;
            this.btnListeTrainer.Click += new System.EventHandler(this.btnListeTrainer_Click);
            // 
            // txtGrad
            // 
            this.txtGrad.Location = new System.Drawing.Point(129, 242);
            this.txtGrad.Name = "txtGrad";
            this.txtGrad.Size = new System.Drawing.Size(229, 20);
            this.txtGrad.TabIndex = 36;
            // 
            // lblGrad
            // 
            this.lblGrad.AutoSize = true;
            this.lblGrad.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.lblGrad.ForeColor = System.Drawing.Color.Black;
            this.lblGrad.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblGrad.Location = new System.Drawing.Point(7, 239);
            this.lblGrad.Name = "lblGrad";
            this.lblGrad.Size = new System.Drawing.Size(51, 21);
            this.lblGrad.TabIndex = 35;
            this.lblGrad.Text = "Grad";
            // 
            // txtAbteilung
            // 
            this.txtAbteilung.Location = new System.Drawing.Point(129, 196);
            this.txtAbteilung.Name = "txtAbteilung";
            this.txtAbteilung.Size = new System.Drawing.Size(229, 20);
            this.txtAbteilung.TabIndex = 33;
            // 
            // txtVorname
            // 
            this.txtVorname.Location = new System.Drawing.Point(129, 151);
            this.txtVorname.Name = "txtVorname";
            this.txtVorname.Size = new System.Drawing.Size(229, 20);
            this.txtVorname.TabIndex = 32;
            // 
            // lblAbteilung
            // 
            this.lblAbteilung.AutoSize = true;
            this.lblAbteilung.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.lblAbteilung.ForeColor = System.Drawing.Color.Black;
            this.lblAbteilung.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblAbteilung.Location = new System.Drawing.Point(7, 193);
            this.lblAbteilung.Name = "lblAbteilung";
            this.lblAbteilung.Size = new System.Drawing.Size(88, 21);
            this.lblAbteilung.TabIndex = 30;
            this.lblAbteilung.Text = "Abteilung";
            // 
            // lblVorname
            // 
            this.lblVorname.AutoSize = true;
            this.lblVorname.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.lblVorname.ForeColor = System.Drawing.Color.Black;
            this.lblVorname.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblVorname.Location = new System.Drawing.Point(3, 148);
            this.lblVorname.Name = "lblVorname";
            this.lblVorname.Size = new System.Drawing.Size(82, 21);
            this.lblVorname.TabIndex = 31;
            this.lblVorname.Text = "Vorname";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(129, 108);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(229, 20);
            this.txtName.TabIndex = 29;
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(129, 67);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(229, 20);
            this.txtID.TabIndex = 28;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.lblName.ForeColor = System.Drawing.Color.Black;
            this.lblName.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblName.Location = new System.Drawing.Point(7, 105);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(58, 21);
            this.lblName.TabIndex = 26;
            this.lblName.Text = "Name";
            // 
            // lblIDTrainer
            // 
            this.lblIDTrainer.AutoSize = true;
            this.lblIDTrainer.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.lblIDTrainer.ForeColor = System.Drawing.Color.Black;
            this.lblIDTrainer.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblIDTrainer.Location = new System.Drawing.Point(3, 64);
            this.lblIDTrainer.Name = "lblIDTrainer";
            this.lblIDTrainer.Size = new System.Drawing.Size(83, 21);
            this.lblIDTrainer.TabIndex = 27;
            this.lblIDTrainer.Text = "ID Trainer";
            // 
            // txtSuchen
            // 
            this.txtSuchen.Location = new System.Drawing.Point(575, 37);
            this.txtSuchen.Name = "txtSuchen";
            this.txtSuchen.Size = new System.Drawing.Size(174, 20);
            this.txtSuchen.TabIndex = 56;
            // 
            // btnsuchen
            // 
            this.btnsuchen.BackColor = System.Drawing.Color.Gray;
            this.btnsuchen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsuchen.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.btnsuchen.ForeColor = System.Drawing.Color.White;
            this.btnsuchen.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnsuchen.Location = new System.Drawing.Point(422, 27);
            this.btnsuchen.Name = "btnsuchen";
            this.btnsuchen.Size = new System.Drawing.Size(120, 34);
            this.btnsuchen.TabIndex = 55;
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
            this.btnBearbeiten.Location = new System.Drawing.Point(264, 293);
            this.btnBearbeiten.Name = "btnBearbeiten";
            this.btnBearbeiten.Size = new System.Drawing.Size(120, 34);
            this.btnBearbeiten.TabIndex = 54;
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
            this.btnHinzufügen.Location = new System.Drawing.Point(12, 293);
            this.btnHinzufügen.Name = "btnHinzufügen";
            this.btnHinzufügen.Size = new System.Drawing.Size(120, 34);
            this.btnHinzufügen.TabIndex = 53;
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
            this.btnLöschen.Location = new System.Drawing.Point(138, 293);
            this.btnLöschen.Name = "btnLöschen";
            this.btnLöschen.Size = new System.Drawing.Size(120, 34);
            this.btnLöschen.TabIndex = 52;
            this.btnLöschen.Text = "Löschen";
            this.btnLöschen.UseVisualStyleBackColor = false;
            this.btnLöschen.Click += new System.EventHandler(this.btnLöschen_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(400, 67);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(560, 243);
            this.dataGridView1.TabIndex = 51;
            // 
            // lblshließen
            // 
            this.lblshließen.AutoSize = true;
            this.lblshließen.Font = new System.Drawing.Font("Century Gothic", 18F);
            this.lblshließen.ForeColor = System.Drawing.Color.Black;
            this.lblshließen.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblshließen.Location = new System.Drawing.Point(930, 9);
            this.lblshließen.Name = "lblshließen";
            this.lblshließen.Size = new System.Drawing.Size(25, 30);
            this.lblshließen.TabIndex = 57;
            this.lblshließen.Text = "x";
            this.lblshließen.Click += new System.EventHandler(this.lblshließen_Click);
            // 
            // btnWiederherstellen
            // 
            this.btnWiederherstellen.BackColor = System.Drawing.Color.Gray;
            this.btnWiederherstellen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWiederherstellen.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.btnWiederherstellen.ForeColor = System.Drawing.Color.White;
            this.btnWiederherstellen.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnWiederherstellen.Location = new System.Drawing.Point(776, 27);
            this.btnWiederherstellen.Name = "btnWiederherstellen";
            this.btnWiederherstellen.Size = new System.Drawing.Size(138, 34);
            this.btnWiederherstellen.TabIndex = 58;
            this.btnWiederherstellen.Text = "Wiederherstellen";
            this.btnWiederherstellen.UseVisualStyleBackColor = false;
            this.btnWiederherstellen.Click += new System.EventHandler(this.btnWiederherstellen_Click);
            // 
            // Frm_Trainer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(967, 358);
            this.Controls.Add(this.btnWiederherstellen);
            this.Controls.Add(this.lblshließen);
            this.Controls.Add(this.txtSuchen);
            this.Controls.Add(this.btnsuchen);
            this.Controls.Add(this.btnBearbeiten);
            this.Controls.Add(this.btnHinzufügen);
            this.Controls.Add(this.btnLöschen);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnListeTrainer);
            this.Controls.Add(this.txtGrad);
            this.Controls.Add(this.lblGrad);
            this.Controls.Add(this.txtAbteilung);
            this.Controls.Add(this.txtVorname);
            this.Controls.Add(this.lblAbteilung);
            this.Controls.Add(this.lblVorname);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblIDTrainer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_Trainer";
            this.Text = "Frm_Trainer";
            this.Load += new System.EventHandler(this.Frm_Trainer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnListeTrainer;
        private System.Windows.Forms.TextBox txtGrad;
        private System.Windows.Forms.Label lblGrad;
        private System.Windows.Forms.TextBox txtAbteilung;
        private System.Windows.Forms.TextBox txtVorname;
        private System.Windows.Forms.Label lblAbteilung;
        private System.Windows.Forms.Label lblVorname;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblIDTrainer;
        private System.Windows.Forms.TextBox txtSuchen;
        private System.Windows.Forms.Button btnsuchen;
        private System.Windows.Forms.Button btnBearbeiten;
        private System.Windows.Forms.Button btnHinzufügen;
        private System.Windows.Forms.Button btnLöschen;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblshließen;
        private System.Windows.Forms.Button btnWiederherstellen;
    }
}
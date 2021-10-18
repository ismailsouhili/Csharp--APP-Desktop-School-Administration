namespace Prj_DeutschSprachInstitut
{
    partial class Frm_Kursen
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
            this.components = new System.ComponentModel.Container();
            this.lblshließen = new System.Windows.Forms.Label();
            this.btnListeKurs = new System.Windows.Forms.Button();
            this.txtAS = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNAMEKURS = new System.Windows.Forms.TextBox();
            this.txtREFKURS = new System.Windows.Forms.TextBox();
            this.lblPasswort = new System.Windows.Forms.Label();
            this.xx = new System.Windows.Forms.Label();
            this.txtSuchen = new System.Windows.Forms.TextBox();
            this.btnsuchen = new System.Windows.Forms.Button();
            this.btnBearbeiten = new System.Windows.Forms.Button();
            this.btnHinzufügen = new System.Windows.Forms.Button();
            this.btnLöschen = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnWiederherstellen = new System.Windows.Forms.Button();
            this.cmbIDT = new System.Windows.Forms.ComboBox();
            this.trainerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.schulverwaltungDataSet2 = new Prj_DeutschSprachInstitut.SchulverwaltungDataSet2();
            this.trainerTableAdapter = new Prj_DeutschSprachInstitut.SchulverwaltungDataSet2TableAdapters.TrainerTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trainerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schulverwaltungDataSet2)).BeginInit();
            this.SuspendLayout();
            // 
            // lblshließen
            // 
            this.lblshließen.AutoSize = true;
            this.lblshließen.Font = new System.Drawing.Font("Century Gothic", 18F);
            this.lblshließen.ForeColor = System.Drawing.Color.Black;
            this.lblshließen.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblshließen.Location = new System.Drawing.Point(937, 0);
            this.lblshließen.Name = "lblshließen";
            this.lblshließen.Size = new System.Drawing.Size(25, 30);
            this.lblshließen.TabIndex = 45;
            this.lblshließen.Text = "x";
            this.lblshließen.Click += new System.EventHandler(this.lblshließen_Click);
            // 
            // btnListeKurs
            // 
            this.btnListeKurs.BackColor = System.Drawing.Color.Gray;
            this.btnListeKurs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnListeKurs.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.btnListeKurs.ForeColor = System.Drawing.Color.White;
            this.btnListeKurs.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnListeKurs.Location = new System.Drawing.Point(476, 300);
            this.btnListeKurs.Name = "btnListeKurs";
            this.btnListeKurs.Size = new System.Drawing.Size(361, 34);
            this.btnListeKurs.TabIndex = 39;
            this.btnListeKurs.Text = "Liste der Kurse";
            this.btnListeKurs.UseVisualStyleBackColor = false;
            this.btnListeKurs.Click += new System.EventHandler(this.btnListeKurs_Click);
            // 
            // txtAS
            // 
            this.txtAS.Location = new System.Drawing.Point(135, 175);
            this.txtAS.Name = "txtAS";
            this.txtAS.Size = new System.Drawing.Size(229, 20);
            this.txtAS.TabIndex = 32;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(13, 217);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 21);
            this.label1.TabIndex = 30;
            this.label1.Text = "ID Trainer";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(9, 172);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 21);
            this.label2.TabIndex = 31;
            this.label2.Text = "Anzahl Sitze";
            // 
            // txtNAMEKURS
            // 
            this.txtNAMEKURS.Location = new System.Drawing.Point(135, 132);
            this.txtNAMEKURS.Name = "txtNAMEKURS";
            this.txtNAMEKURS.Size = new System.Drawing.Size(229, 20);
            this.txtNAMEKURS.TabIndex = 29;
            // 
            // txtREFKURS
            // 
            this.txtREFKURS.Location = new System.Drawing.Point(135, 91);
            this.txtREFKURS.Name = "txtREFKURS";
            this.txtREFKURS.Size = new System.Drawing.Size(229, 20);
            this.txtREFKURS.TabIndex = 28;
            // 
            // lblPasswort
            // 
            this.lblPasswort.AutoSize = true;
            this.lblPasswort.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.lblPasswort.ForeColor = System.Drawing.Color.Black;
            this.lblPasswort.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblPasswort.Location = new System.Drawing.Point(13, 129);
            this.lblPasswort.Name = "lblPasswort";
            this.lblPasswort.Size = new System.Drawing.Size(92, 21);
            this.lblPasswort.TabIndex = 26;
            this.lblPasswort.Text = "Name Kurs";
            // 
            // xx
            // 
            this.xx.AutoSize = true;
            this.xx.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.xx.ForeColor = System.Drawing.Color.Black;
            this.xx.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.xx.Location = new System.Drawing.Point(9, 88);
            this.xx.Name = "xx";
            this.xx.Size = new System.Drawing.Size(69, 21);
            this.xx.TabIndex = 27;
            this.xx.Text = "Ref Kurs";
            // 
            // txtSuchen
            // 
            this.txtSuchen.Location = new System.Drawing.Point(577, 21);
            this.txtSuchen.Name = "txtSuchen";
            this.txtSuchen.Size = new System.Drawing.Size(174, 20);
            this.txtSuchen.TabIndex = 62;
            // 
            // btnsuchen
            // 
            this.btnsuchen.BackColor = System.Drawing.Color.Gray;
            this.btnsuchen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsuchen.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.btnsuchen.ForeColor = System.Drawing.Color.White;
            this.btnsuchen.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnsuchen.Location = new System.Drawing.Point(424, 11);
            this.btnsuchen.Name = "btnsuchen";
            this.btnsuchen.Size = new System.Drawing.Size(120, 34);
            this.btnsuchen.TabIndex = 61;
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
            this.btnBearbeiten.Location = new System.Drawing.Point(138, 275);
            this.btnBearbeiten.Name = "btnBearbeiten";
            this.btnBearbeiten.Size = new System.Drawing.Size(120, 34);
            this.btnBearbeiten.TabIndex = 60;
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
            this.btnHinzufügen.Location = new System.Drawing.Point(12, 275);
            this.btnHinzufügen.Name = "btnHinzufügen";
            this.btnHinzufügen.Size = new System.Drawing.Size(120, 34);
            this.btnHinzufügen.TabIndex = 59;
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
            this.btnLöschen.Location = new System.Drawing.Point(264, 275);
            this.btnLöschen.Name = "btnLöschen";
            this.btnLöschen.Size = new System.Drawing.Size(120, 34);
            this.btnLöschen.TabIndex = 58;
            this.btnLöschen.Text = "Löschen";
            this.btnLöschen.UseVisualStyleBackColor = false;
            this.btnLöschen.Click += new System.EventHandler(this.btnLöschen_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(393, 51);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(560, 243);
            this.dataGridView1.TabIndex = 57;
            // 
            // btnWiederherstellen
            // 
            this.btnWiederherstellen.BackColor = System.Drawing.Color.Gray;
            this.btnWiederherstellen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWiederherstellen.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.btnWiederherstellen.ForeColor = System.Drawing.Color.White;
            this.btnWiederherstellen.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnWiederherstellen.Location = new System.Drawing.Point(768, 11);
            this.btnWiederherstellen.Name = "btnWiederherstellen";
            this.btnWiederherstellen.Size = new System.Drawing.Size(138, 34);
            this.btnWiederherstellen.TabIndex = 63;
            this.btnWiederherstellen.Text = "Wiederherstellen";
            this.btnWiederherstellen.UseVisualStyleBackColor = false;
            this.btnWiederherstellen.Click += new System.EventHandler(this.btnWiederherstellen_Click);
            // 
            // cmbIDT
            // 
            this.cmbIDT.DataSource = this.trainerBindingSource;
            this.cmbIDT.DisplayMember = "IDT";
            this.cmbIDT.FormattingEnabled = true;
            this.cmbIDT.Location = new System.Drawing.Point(137, 220);
            this.cmbIDT.Name = "cmbIDT";
            this.cmbIDT.Size = new System.Drawing.Size(227, 21);
            this.cmbIDT.TabIndex = 64;
            this.cmbIDT.ValueMember = "IDT";
            // 
            // trainerBindingSource
            // 
            this.trainerBindingSource.DataMember = "Trainer";
            this.trainerBindingSource.DataSource = this.schulverwaltungDataSet2;
            // 
            // schulverwaltungDataSet2
            // 
            this.schulverwaltungDataSet2.DataSetName = "SchulverwaltungDataSet2";
            this.schulverwaltungDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // trainerTableAdapter
            // 
            this.trainerTableAdapter.ClearBeforeFill = true;
            // 
            // Frm_Kursen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(965, 346);
            this.Controls.Add(this.cmbIDT);
            this.Controls.Add(this.btnWiederherstellen);
            this.Controls.Add(this.txtSuchen);
            this.Controls.Add(this.btnsuchen);
            this.Controls.Add(this.btnBearbeiten);
            this.Controls.Add(this.btnHinzufügen);
            this.Controls.Add(this.btnLöschen);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lblshließen);
            this.Controls.Add(this.btnListeKurs);
            this.Controls.Add(this.txtAS);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNAMEKURS);
            this.Controls.Add(this.txtREFKURS);
            this.Controls.Add(this.lblPasswort);
            this.Controls.Add(this.xx);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_Kursen";
            this.Text = "Frm_Kursen";
            this.Load += new System.EventHandler(this.Frm_Kursen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trainerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schulverwaltungDataSet2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblshließen;
        private System.Windows.Forms.Button btnListeKurs;
        private System.Windows.Forms.TextBox txtAS;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNAMEKURS;
        private System.Windows.Forms.TextBox txtREFKURS;
        private System.Windows.Forms.Label lblPasswort;
        private System.Windows.Forms.Label xx;
        private System.Windows.Forms.TextBox txtSuchen;
        private System.Windows.Forms.Button btnsuchen;
        private System.Windows.Forms.Button btnBearbeiten;
        private System.Windows.Forms.Button btnHinzufügen;
        private System.Windows.Forms.Button btnLöschen;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnWiederherstellen;
        private System.Windows.Forms.ComboBox cmbIDT;
        private SchulverwaltungDataSet2 schulverwaltungDataSet2;
        private System.Windows.Forms.BindingSource trainerBindingSource;
        private SchulverwaltungDataSet2TableAdapters.TrainerTableAdapter trainerTableAdapter;
    }
}
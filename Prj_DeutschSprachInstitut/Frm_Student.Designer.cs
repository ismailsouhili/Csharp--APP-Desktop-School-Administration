namespace Prj_DeutschSprachInstitut
{
    partial class Frm_Student
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
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.lblIDS = new System.Windows.Forms.Label();
            this.txtVorname = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnListeSchule = new System.Windows.Forms.Button();
            this.lblshließen = new System.Windows.Forms.Label();
            this.txtsuchen = new System.Windows.Forms.TextBox();
            this.btnsuchen = new System.Windows.Forms.Button();
            this.btnBearbeiten = new System.Windows.Forms.Button();
            this.btnHinzufügen = new System.Windows.Forms.Button();
            this.btnLöschen = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lblName = new System.Windows.Forms.Label();
            this.lblVorame = new System.Windows.Forms.Label();
            this.btnWiederherstellen = new System.Windows.Forms.Button();
            this.cmbShulNiv = new System.Windows.Forms.ComboBox();
            this.cmbRefKurs = new System.Windows.Forms.ComboBox();
            this.kursenBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.schulverwaltungDataSet1 = new Prj_DeutschSprachInstitut.SchulverwaltungDataSet1();
            this.kursenBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.schulverwaltungDataSet = new Prj_DeutschSprachInstitut.SchulverwaltungDataSet();
            this.kursenTableAdapter = new Prj_DeutschSprachInstitut.SchulverwaltungDataSetTableAdapters.KursenTableAdapter();
            this.kursenTableAdapter1 = new Prj_DeutschSprachInstitut.SchulverwaltungDataSet1TableAdapters.KursenTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kursenBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schulverwaltungDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kursenBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schulverwaltungDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(131, 117);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(229, 20);
            this.txtName.TabIndex = 8;
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(131, 76);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(229, 20);
            this.txtID.TabIndex = 7;
            // 
            // lblIDS
            // 
            this.lblIDS.AutoSize = true;
            this.lblIDS.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.lblIDS.ForeColor = System.Drawing.Color.Black;
            this.lblIDS.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblIDS.Location = new System.Drawing.Point(5, 73);
            this.lblIDS.Name = "lblIDS";
            this.lblIDS.Size = new System.Drawing.Size(87, 21);
            this.lblIDS.TabIndex = 6;
            this.lblIDS.Text = "ID Schüler";
            // 
            // txtVorname
            // 
            this.txtVorname.Location = new System.Drawing.Point(131, 160);
            this.txtVorname.Name = "txtVorname";
            this.txtVorname.Size = new System.Drawing.Size(229, 20);
            this.txtVorname.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(9, 202);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 21);
            this.label1.TabIndex = 9;
            this.label1.Text = "Schulniveau";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label3.Location = new System.Drawing.Point(9, 248);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 21);
            this.label3.TabIndex = 13;
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label4.Location = new System.Drawing.Point(9, 248);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 21);
            this.label4.TabIndex = 14;
            this.label4.Text = "Ref Kurs";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // btnListeSchule
            // 
            this.btnListeSchule.BackColor = System.Drawing.Color.Gray;
            this.btnListeSchule.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnListeSchule.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.btnListeSchule.ForeColor = System.Drawing.Color.White;
            this.btnListeSchule.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnListeSchule.Location = new System.Drawing.Point(501, 322);
            this.btnListeSchule.Name = "btnListeSchule";
            this.btnListeSchule.Size = new System.Drawing.Size(348, 34);
            this.btnListeSchule.TabIndex = 19;
            this.btnListeSchule.Text = "Liste der Schüler";
            this.btnListeSchule.UseVisualStyleBackColor = false;
            this.btnListeSchule.Click += new System.EventHandler(this.btnListeSchule_Click);
            // 
            // lblshließen
            // 
            this.lblshließen.AutoSize = true;
            this.lblshließen.Font = new System.Drawing.Font("Century Gothic", 18F);
            this.lblshließen.ForeColor = System.Drawing.Color.Black;
            this.lblshließen.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblshließen.Location = new System.Drawing.Point(931, 0);
            this.lblshließen.Name = "lblshließen";
            this.lblshließen.Size = new System.Drawing.Size(25, 30);
            this.lblshließen.TabIndex = 25;
            this.lblshließen.Text = "x";
            this.lblshließen.Click += new System.EventHandler(this.lblshließen_Click);
            // 
            // txtsuchen
            // 
            this.txtsuchen.Location = new System.Drawing.Point(576, 43);
            this.txtsuchen.Name = "txtsuchen";
            this.txtsuchen.Size = new System.Drawing.Size(174, 20);
            this.txtsuchen.TabIndex = 50;
            // 
            // btnsuchen
            // 
            this.btnsuchen.BackColor = System.Drawing.Color.Gray;
            this.btnsuchen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsuchen.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.btnsuchen.ForeColor = System.Drawing.Color.White;
            this.btnsuchen.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnsuchen.Location = new System.Drawing.Point(428, 33);
            this.btnsuchen.Name = "btnsuchen";
            this.btnsuchen.Size = new System.Drawing.Size(120, 34);
            this.btnsuchen.TabIndex = 49;
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
            this.btnBearbeiten.Location = new System.Drawing.Point(144, 295);
            this.btnBearbeiten.Name = "btnBearbeiten";
            this.btnBearbeiten.Size = new System.Drawing.Size(120, 34);
            this.btnBearbeiten.TabIndex = 48;
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
            this.btnHinzufügen.Location = new System.Drawing.Point(9, 295);
            this.btnHinzufügen.Name = "btnHinzufügen";
            this.btnHinzufügen.Size = new System.Drawing.Size(120, 34);
            this.btnHinzufügen.TabIndex = 47;
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
            this.btnLöschen.Location = new System.Drawing.Point(270, 295);
            this.btnLöschen.Name = "btnLöschen";
            this.btnLöschen.Size = new System.Drawing.Size(120, 34);
            this.btnLöschen.TabIndex = 46;
            this.btnLöschen.Text = "Löschen";
            this.btnLöschen.UseVisualStyleBackColor = false;
            this.btnLöschen.Click += new System.EventHandler(this.btnLöschen_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(396, 73);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(560, 243);
            this.dataGridView1.TabIndex = 45;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.lblName.ForeColor = System.Drawing.Color.Black;
            this.lblName.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblName.Location = new System.Drawing.Point(5, 114);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(58, 21);
            this.lblName.TabIndex = 52;
            this.lblName.Text = "Name";
            // 
            // lblVorame
            // 
            this.lblVorame.AutoSize = true;
            this.lblVorame.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.lblVorame.ForeColor = System.Drawing.Color.Black;
            this.lblVorame.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblVorame.Location = new System.Drawing.Point(5, 159);
            this.lblVorame.Name = "lblVorame";
            this.lblVorame.Size = new System.Drawing.Size(82, 21);
            this.lblVorame.TabIndex = 51;
            this.lblVorame.Text = "Vorname";
            // 
            // btnWiederherstellen
            // 
            this.btnWiederherstellen.BackColor = System.Drawing.Color.Gray;
            this.btnWiederherstellen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWiederherstellen.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.btnWiederherstellen.ForeColor = System.Drawing.Color.White;
            this.btnWiederherstellen.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnWiederherstellen.Location = new System.Drawing.Point(771, 33);
            this.btnWiederherstellen.Name = "btnWiederherstellen";
            this.btnWiederherstellen.Size = new System.Drawing.Size(138, 34);
            this.btnWiederherstellen.TabIndex = 59;
            this.btnWiederherstellen.Text = "Wiederherstellen";
            this.btnWiederherstellen.UseVisualStyleBackColor = false;
            this.btnWiederherstellen.Click += new System.EventHandler(this.btnWiederherstellen_Click);
            // 
            // cmbShulNiv
            // 
            this.cmbShulNiv.FormattingEnabled = true;
            this.cmbShulNiv.Items.AddRange(new object[] {
            "A1",
            "A2",
            "B1",
            "B2",
            "C1",
            "C2"});
            this.cmbShulNiv.Location = new System.Drawing.Point(131, 205);
            this.cmbShulNiv.Name = "cmbShulNiv";
            this.cmbShulNiv.Size = new System.Drawing.Size(229, 21);
            this.cmbShulNiv.TabIndex = 60;
            // 
            // cmbRefKurs
            // 
            this.cmbRefKurs.DataSource = this.kursenBindingSource1;
            this.cmbRefKurs.DisplayMember = "RefKurs";
            this.cmbRefKurs.FormattingEnabled = true;
            this.cmbRefKurs.Location = new System.Drawing.Point(131, 251);
            this.cmbRefKurs.Name = "cmbRefKurs";
            this.cmbRefKurs.Size = new System.Drawing.Size(229, 21);
            this.cmbRefKurs.TabIndex = 61;
            this.cmbRefKurs.ValueMember = "RefKurs";
            // 
            // kursenBindingSource1
            // 
            this.kursenBindingSource1.DataMember = "Kursen";
            this.kursenBindingSource1.DataSource = this.schulverwaltungDataSet1;
            // 
            // schulverwaltungDataSet1
            // 
            this.schulverwaltungDataSet1.DataSetName = "SchulverwaltungDataSet1";
            this.schulverwaltungDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // kursenBindingSource
            // 
            this.kursenBindingSource.DataMember = "Kursen";
            this.kursenBindingSource.DataSource = this.schulverwaltungDataSet;
            // 
            // schulverwaltungDataSet
            // 
            this.schulverwaltungDataSet.DataSetName = "SchulverwaltungDataSet";
            this.schulverwaltungDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // kursenTableAdapter
            // 
            this.kursenTableAdapter.ClearBeforeFill = true;
            // 
            // kursenTableAdapter1
            // 
            this.kursenTableAdapter1.ClearBeforeFill = true;
            // 
            // Frm_Student
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(976, 376);
            this.Controls.Add(this.cmbRefKurs);
            this.Controls.Add(this.cmbShulNiv);
            this.Controls.Add(this.btnWiederherstellen);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblVorame);
            this.Controls.Add(this.txtsuchen);
            this.Controls.Add(this.btnsuchen);
            this.Controls.Add(this.btnBearbeiten);
            this.Controls.Add(this.btnHinzufügen);
            this.Controls.Add(this.btnLöschen);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lblshließen);
            this.Controls.Add(this.btnListeSchule);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtVorname);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.lblIDS);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_Student";
            this.Text = "Frm_Student";
            this.Load += new System.EventHandler(this.Frm_Student_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kursenBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schulverwaltungDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kursenBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schulverwaltungDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label lblIDS;
        private System.Windows.Forms.TextBox txtVorname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnListeSchule;
        private System.Windows.Forms.Label lblshließen;
        private System.Windows.Forms.TextBox txtsuchen;
        private System.Windows.Forms.Button btnsuchen;
        private System.Windows.Forms.Button btnBearbeiten;
        private System.Windows.Forms.Button btnHinzufügen;
        private System.Windows.Forms.Button btnLöschen;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblVorame;
        private System.Windows.Forms.Button btnWiederherstellen;
        private System.Windows.Forms.ComboBox cmbShulNiv;
        private System.Windows.Forms.ComboBox cmbRefKurs;
        private SchulverwaltungDataSet schulverwaltungDataSet;
        private System.Windows.Forms.BindingSource kursenBindingSource;
        private SchulverwaltungDataSetTableAdapters.KursenTableAdapter kursenTableAdapter;
        private SchulverwaltungDataSet1 schulverwaltungDataSet1;
        private System.Windows.Forms.BindingSource kursenBindingSource1;
        private SchulverwaltungDataSet1TableAdapters.KursenTableAdapter kursenTableAdapter1;
    }
}
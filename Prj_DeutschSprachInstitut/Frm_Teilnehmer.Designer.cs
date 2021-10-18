namespace Prj_DeutschSprachInstitut
{
    partial class Frm_Teilnehmer
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
            this.btnListeTeilnehm = new System.Windows.Forms.Button();
            this.txtNote = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtIDSCHULER = new System.Windows.Forms.TextBox();
            this.txtREFKURS = new System.Windows.Forms.TextBox();
            this.lblIDSchüler = new System.Windows.Forms.Label();
            this.lblRefKurs = new System.Windows.Forms.Label();
            this.txtSuchen = new System.Windows.Forms.TextBox();
            this.btnsuchen = new System.Windows.Forms.Button();
            this.btnBearbeiten = new System.Windows.Forms.Button();
            this.btnHinzufügen = new System.Windows.Forms.Button();
            this.btnLöschen = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnWiederherstellen = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblshließen
            // 
            this.lblshließen.AutoSize = true;
            this.lblshließen.Font = new System.Drawing.Font("Century Gothic", 18F);
            this.lblshließen.ForeColor = System.Drawing.Color.Black;
            this.lblshließen.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblshließen.Location = new System.Drawing.Point(942, -1);
            this.lblshließen.Name = "lblshließen";
            this.lblshließen.Size = new System.Drawing.Size(25, 30);
            this.lblshließen.TabIndex = 45;
            this.lblshließen.Text = "x";
            this.lblshließen.Click += new System.EventHandler(this.lblshließen_Click);
            // 
            // btnListeTeilnehm
            // 
            this.btnListeTeilnehm.BackColor = System.Drawing.Color.Gray;
            this.btnListeTeilnehm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnListeTeilnehm.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.btnListeTeilnehm.ForeColor = System.Drawing.Color.White;
            this.btnListeTeilnehm.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnListeTeilnehm.Location = new System.Drawing.Point(508, 301);
            this.btnListeTeilnehm.Name = "btnListeTeilnehm";
            this.btnListeTeilnehm.Size = new System.Drawing.Size(362, 34);
            this.btnListeTeilnehm.TabIndex = 39;
            this.btnListeTeilnehm.Text = "Liste der Teilnehmer";
            this.btnListeTeilnehm.UseVisualStyleBackColor = false;
            this.btnListeTeilnehm.Click += new System.EventHandler(this.btnListeTeilnehm_Click);
            // 
            // txtNote
            // 
            this.txtNote.Location = new System.Drawing.Point(141, 190);
            this.txtNote.Name = "txtNote";
            this.txtNote.Size = new System.Drawing.Size(229, 20);
            this.txtNote.TabIndex = 32;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(19, 187);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 21);
            this.label2.TabIndex = 31;
            this.label2.Text = "Note";
            // 
            // txtIDSCHULER
            // 
            this.txtIDSCHULER.Location = new System.Drawing.Point(141, 147);
            this.txtIDSCHULER.Name = "txtIDSCHULER";
            this.txtIDSCHULER.Size = new System.Drawing.Size(229, 20);
            this.txtIDSCHULER.TabIndex = 29;
            // 
            // txtREFKURS
            // 
            this.txtREFKURS.Location = new System.Drawing.Point(141, 106);
            this.txtREFKURS.Name = "txtREFKURS";
            this.txtREFKURS.Size = new System.Drawing.Size(229, 20);
            this.txtREFKURS.TabIndex = 28;
            // 
            // lblIDSchüler
            // 
            this.lblIDSchüler.AutoSize = true;
            this.lblIDSchüler.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.lblIDSchüler.ForeColor = System.Drawing.Color.Black;
            this.lblIDSchüler.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblIDSchüler.Location = new System.Drawing.Point(12, 144);
            this.lblIDSchüler.Name = "lblIDSchüler";
            this.lblIDSchüler.Size = new System.Drawing.Size(87, 21);
            this.lblIDSchüler.TabIndex = 26;
            this.lblIDSchüler.Text = "ID Schüler";
            // 
            // lblRefKurs
            // 
            this.lblRefKurs.AutoSize = true;
            this.lblRefKurs.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.lblRefKurs.ForeColor = System.Drawing.Color.Black;
            this.lblRefKurs.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblRefKurs.Location = new System.Drawing.Point(15, 103);
            this.lblRefKurs.Name = "lblRefKurs";
            this.lblRefKurs.Size = new System.Drawing.Size(110, 21);
            this.lblRefKurs.TabIndex = 27;
            this.lblRefKurs.Text = "Referenz kurs";
            // 
            // txtSuchen
            // 
            this.txtSuchen.Location = new System.Drawing.Point(544, 22);
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
            this.btnsuchen.Location = new System.Drawing.Point(407, 12);
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
            this.btnBearbeiten.Location = new System.Drawing.Point(141, 248);
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
            this.btnHinzufügen.Location = new System.Drawing.Point(5, 248);
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
            this.btnLöschen.Location = new System.Drawing.Point(281, 248);
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
            this.dataGridView1.Location = new System.Drawing.Point(407, 52);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(560, 243);
            this.dataGridView1.TabIndex = 51;
            // 
            // btnWiederherstellen
            // 
            this.btnWiederherstellen.BackColor = System.Drawing.Color.Gray;
            this.btnWiederherstellen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWiederherstellen.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.btnWiederherstellen.ForeColor = System.Drawing.Color.White;
            this.btnWiederherstellen.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnWiederherstellen.Location = new System.Drawing.Point(752, 12);
            this.btnWiederherstellen.Name = "btnWiederherstellen";
            this.btnWiederherstellen.Size = new System.Drawing.Size(138, 34);
            this.btnWiederherstellen.TabIndex = 59;
            this.btnWiederherstellen.Text = "Wiederherstellen";
            this.btnWiederherstellen.UseVisualStyleBackColor = false;
            this.btnWiederherstellen.Click += new System.EventHandler(this.btnWiederherstellen_Click);
            // 
            // Frm_Teilnehmer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(969, 343);
            this.Controls.Add(this.btnWiederherstellen);
            this.Controls.Add(this.txtSuchen);
            this.Controls.Add(this.btnsuchen);
            this.Controls.Add(this.btnBearbeiten);
            this.Controls.Add(this.btnHinzufügen);
            this.Controls.Add(this.btnLöschen);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lblshließen);
            this.Controls.Add(this.btnListeTeilnehm);
            this.Controls.Add(this.txtNote);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtIDSCHULER);
            this.Controls.Add(this.txtREFKURS);
            this.Controls.Add(this.lblIDSchüler);
            this.Controls.Add(this.lblRefKurs);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_Teilnehmer";
            this.Text = "Frm_Teilnehmer";
            this.Load += new System.EventHandler(this.Frm_Teilnehmer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblshließen;
        private System.Windows.Forms.Button btnListeTeilnehm;
        private System.Windows.Forms.TextBox txtNote;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtIDSCHULER;
        private System.Windows.Forms.TextBox txtREFKURS;
        private System.Windows.Forms.Label lblIDSchüler;
        private System.Windows.Forms.Label lblRefKurs;
        private System.Windows.Forms.TextBox txtSuchen;
        private System.Windows.Forms.Button btnsuchen;
        private System.Windows.Forms.Button btnBearbeiten;
        private System.Windows.Forms.Button btnHinzufügen;
        private System.Windows.Forms.Button btnLöschen;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnWiederherstellen;
    }
}
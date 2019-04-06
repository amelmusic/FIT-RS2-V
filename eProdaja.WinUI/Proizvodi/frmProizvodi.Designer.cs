namespace eProdaja.WinUI.Proizvodi
{
    partial class frmProizvodi
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSifra = new System.Windows.Forms.TextBox();
            this.txtNaziv = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCijena = new System.Windows.Forms.MaskedTextBox();
            this.cmbJedinicaMjere = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnDodajSliku = new System.Windows.Forms.Button();
            this.txtSlikaInput = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.proizvodiGrid = new System.Windows.Forms.DataGridView();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.proizvodiGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(98, 32);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(206, 21);
            this.comboBox1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 34);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Vrsta proizvoda:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(62, 57);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Šifra:";
            // 
            // txtSifra
            // 
            this.txtSifra.Location = new System.Drawing.Point(98, 57);
            this.txtSifra.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtSifra.Name = "txtSifra";
            this.txtSifra.Size = new System.Drawing.Size(206, 20);
            this.txtSifra.TabIndex = 3;
            // 
            // txtNaziv
            // 
            this.txtNaziv.Location = new System.Drawing.Point(98, 80);
            this.txtNaziv.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtNaziv.Name = "txtNaziv";
            this.txtNaziv.Size = new System.Drawing.Size(206, 20);
            this.txtNaziv.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(58, 80);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Naziv:";
            // 
            // txtCijena
            // 
            this.txtCijena.Location = new System.Drawing.Point(98, 103);
            this.txtCijena.Mask = "0000.00";
            this.txtCijena.Name = "txtCijena";
            this.txtCijena.Size = new System.Drawing.Size(65, 20);
            this.txtCijena.TabIndex = 48;
            // 
            // cmbJedinicaMjere
            // 
            this.cmbJedinicaMjere.FormattingEnabled = true;
            this.cmbJedinicaMjere.Location = new System.Drawing.Point(239, 102);
            this.cmbJedinicaMjere.Name = "cmbJedinicaMjere";
            this.cmbJedinicaMjere.Size = new System.Drawing.Size(65, 21);
            this.cmbJedinicaMjere.TabIndex = 49;
            this.cmbJedinicaMjere.SelectedIndexChanged += new System.EventHandler(this.cmbJedinicaMjere_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(172, 106);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 13);
            this.label5.TabIndex = 51;
            this.label5.Text = "Jed. mjere:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(52, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 50;
            this.label4.Text = "Cijena:";
            // 
            // btnDodajSliku
            // 
            this.btnDodajSliku.Location = new System.Drawing.Point(313, 126);
            this.btnDodajSliku.Name = "btnDodajSliku";
            this.btnDodajSliku.Size = new System.Drawing.Size(51, 23);
            this.btnDodajSliku.TabIndex = 52;
            this.btnDodajSliku.Text = "Dodaj";
            this.btnDodajSliku.UseVisualStyleBackColor = true;
            // 
            // txtSlikaInput
            // 
            this.txtSlikaInput.Location = new System.Drawing.Point(98, 128);
            this.txtSlikaInput.Name = "txtSlikaInput";
            this.txtSlikaInput.Size = new System.Drawing.Size(209, 20);
            this.txtSlikaInput.TabIndex = 53;
            this.txtSlikaInput.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(49, 131);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 13);
            this.label6.TabIndex = 54;
            this.label6.Text = "Slika:";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(490, 177);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(98, 43);
            this.btnSave.TabIndex = 55;
            this.btnSave.Text = "Sačuvaj";
            this.btnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // proizvodiGrid
            // 
            this.proizvodiGrid.AllowUserToAddRows = false;
            this.proizvodiGrid.AllowUserToDeleteRows = false;
            this.proizvodiGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.proizvodiGrid.BackgroundColor = System.Drawing.SystemColors.Control;
            this.proizvodiGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.proizvodiGrid.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.proizvodiGrid.Location = new System.Drawing.Point(0, 240);
            this.proizvodiGrid.Name = "proizvodiGrid";
            this.proizvodiGrid.ReadOnly = true;
            this.proizvodiGrid.RowTemplate.Height = 100;
            this.proizvodiGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.proizvodiGrid.Size = new System.Drawing.Size(600, 212);
            this.proizvodiGrid.TabIndex = 56;
            // 
            // pictureBox
            // 
            this.pictureBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox.Location = new System.Drawing.Point(468, 24);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(120, 120);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox.TabIndex = 57;
            this.pictureBox.TabStop = false;
            // 
            // frmProizvodi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 452);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.proizvodiGrid);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.btnDodajSliku);
            this.Controls.Add(this.txtSlikaInput);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtCijena);
            this.Controls.Add(this.cmbJedinicaMjere);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtNaziv);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtSifra);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmProizvodi";
            this.Text = "Proizvodi";
            ((System.ComponentModel.ISupportInitialize)(this.proizvodiGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSifra;
        private System.Windows.Forms.TextBox txtNaziv;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox txtCijena;
        private System.Windows.Forms.ComboBox cmbJedinicaMjere;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnDodajSliku;
        private System.Windows.Forms.TextBox txtSlikaInput;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.DataGridView proizvodiGrid;
        private System.Windows.Forms.PictureBox pictureBox;
    }
}
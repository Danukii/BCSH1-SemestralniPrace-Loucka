namespace ToDoApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dgvUkoly = new DataGridView();
            Nazev = new DataGridViewTextBoxColumn();
            DatumSplneni = new DataGridViewTextBoxColumn();
            JeSplneno = new DataGridViewCheckBoxColumn();
            Pridat = new Button();
            Smazat = new Button();
            Upravit = new Button();
            labelNazev = new Label();
            popis = new Label();
            labelDatumSplneni = new Label();
            nazevUkolu = new TextBox();
            txtPopisu = new TextBox();
            dtpDatumSplneni = new DateTimePicker();
            chbSplneno = new CheckBox();
            cmbUzivatel = new ComboBox();
            chlbLabely = new CheckedListBox();
            ((System.ComponentModel.ISupportInitialize)dgvUkoly).BeginInit();
            SuspendLayout();
            // 
            // dgvUkoly
            // 
            dgvUkoly.BackgroundColor = SystemColors.Control;
            dgvUkoly.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUkoly.Columns.AddRange(new DataGridViewColumn[] { Nazev, DatumSplneni, JeSplneno });
            dgvUkoly.Location = new Point(12, 12);
            dgvUkoly.MultiSelect = false;
            dgvUkoly.Name = "dgvUkoly";
            dgvUkoly.ReadOnly = true;
            dgvUkoly.Size = new Size(372, 426);
            dgvUkoly.TabIndex = 0;
            // 
            // Nazev
            // 
            Nazev.DataPropertyName = "Nazev";
            Nazev.HeaderText = "název";
            Nazev.Name = "Nazev";
            Nazev.ReadOnly = true;
            Nazev.Width = 150;
            // 
            // DatumSplneni
            // 
            DatumSplneni.DataPropertyName = "DatumSplneni";
            DatumSplneni.HeaderText = "datum splnění";
            DatumSplneni.Name = "DatumSplneni";
            DatumSplneni.ReadOnly = true;
            DatumSplneni.Width = 120;
            // 
            // JeSplneno
            // 
            JeSplneno.DataPropertyName = "JeSplneno";
            JeSplneno.HeaderText = "splněno";
            JeSplneno.Name = "JeSplneno";
            JeSplneno.ReadOnly = true;
            JeSplneno.Width = 60;
            // 
            // Pridat
            // 
            Pridat.DialogResult = DialogResult.OK;
            Pridat.Location = new Point(446, 285);
            Pridat.Name = "Pridat";
            Pridat.Size = new Size(75, 23);
            Pridat.TabIndex = 1;
            Pridat.Text = "přidat";
            Pridat.UseVisualStyleBackColor = true;
            Pridat.Click += Pridat_Click;
            // 
            // Smazat
            // 
            Smazat.DialogResult = DialogResult.OK;
            Smazat.Location = new Point(446, 373);
            Smazat.Name = "Smazat";
            Smazat.Size = new Size(75, 23);
            Smazat.TabIndex = 2;
            Smazat.Text = "smazat";
            Smazat.UseVisualStyleBackColor = true;
            Smazat.Click += Smazat_Click;
            // 
            // Upravit
            // 
            Upravit.DialogResult = DialogResult.OK;
            Upravit.Location = new Point(446, 329);
            Upravit.Name = "Upravit";
            Upravit.Size = new Size(75, 23);
            Upravit.TabIndex = 3;
            Upravit.Text = "upravit";
            Upravit.UseVisualStyleBackColor = true;
            Upravit.Click += Upravit_Click;
            // 
            // labelNazev
            // 
            labelNazev.AutoSize = true;
            labelNazev.Location = new Point(446, 42);
            labelNazev.Name = "labelNazev";
            labelNazev.Size = new Size(73, 15);
            labelNazev.TabIndex = 4;
            labelNazev.Text = "název úkolu:";
            labelNazev.TextAlign = ContentAlignment.TopCenter;
            // 
            // popis
            // 
            popis.AutoSize = true;
            popis.Location = new Point(446, 82);
            popis.Name = "popis";
            popis.Size = new Size(72, 15);
            popis.TabIndex = 5;
            popis.Text = "popis úkolu:";
            // 
            // labelDatumSplneni
            // 
            labelDatumSplneni.AccessibleRole = AccessibleRole.None;
            labelDatumSplneni.AutoSize = true;
            labelDatumSplneni.Location = new Point(446, 130);
            labelDatumSplneni.Name = "labelDatumSplneni";
            labelDatumSplneni.Size = new Size(86, 15);
            labelDatumSplneni.TabIndex = 6;
            labelDatumSplneni.Text = "datum splnění:";
            // 
            // nazevUkolu
            // 
            nazevUkolu.Location = new Point(584, 39);
            nazevUkolu.Name = "nazevUkolu";
            nazevUkolu.Size = new Size(174, 23);
            nazevUkolu.TabIndex = 7;
            // 
            // txtPopisu
            // 
            txtPopisu.Location = new Point(584, 79);
            txtPopisu.Name = "txtPopisu";
            txtPopisu.Size = new Size(174, 23);
            txtPopisu.TabIndex = 8;
            // 
            // dtpDatumSplneni
            // 
            dtpDatumSplneni.Location = new Point(584, 124);
            dtpDatumSplneni.Name = "dtpDatumSplneni";
            dtpDatumSplneni.Size = new Size(174, 23);
            dtpDatumSplneni.TabIndex = 9;
            // 
            // chbSplneno
            // 
            chbSplneno.AutoSize = true;
            chbSplneno.Location = new Point(451, 184);
            chbSplneno.Name = "chbSplneno";
            chbSplneno.Size = new Size(68, 19);
            chbSplneno.TabIndex = 10;
            chbSplneno.Text = "splněno";
            chbSplneno.UseVisualStyleBackColor = true;
            // 
            // cmbUzivatel
            // 
            cmbUzivatel.FormattingEnabled = true;
            cmbUzivatel.Location = new Point(617, 180);
            cmbUzivatel.Name = "cmbUzivatel";
            cmbUzivatel.Size = new Size(141, 23);
            cmbUzivatel.TabIndex = 11;
            // 
            // chlbLabely
            // 
            chlbLabely.FormattingEnabled = true;
            chlbLabely.Location = new Point(617, 240);
            chlbLabely.Name = "chlbLabely";
            chlbLabely.Size = new Size(141, 184);
            chlbLabely.TabIndex = 12;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(800, 450);
            Controls.Add(chlbLabely);
            Controls.Add(cmbUzivatel);
            Controls.Add(chbSplneno);
            Controls.Add(dtpDatumSplneni);
            Controls.Add(txtPopisu);
            Controls.Add(nazevUkolu);
            Controls.Add(labelDatumSplneni);
            Controls.Add(popis);
            Controls.Add(labelNazev);
            Controls.Add(Upravit);
            Controls.Add(Smazat);
            Controls.Add(Pridat);
            Controls.Add(dgvUkoly);
            Name = "Form1";
            Text = "ToDo App";
            ((System.ComponentModel.ISupportInitialize)dgvUkoly).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvUkoly;
        private DataGridViewTextBoxColumn Nazev;
        private DataGridViewTextBoxColumn DatumSplneni;
        private DataGridViewCheckBoxColumn JeSplneno;
        private Button Pridat;
        private Button Smazat;
        private Button Upravit;
        private Label labelNazev;
        private Label popis;
        private Label labelDatumSplneni;
        private TextBox nazevUkolu;
        private TextBox txtPopisu;
        private DateTimePicker dtpDatumSplneni;
        private CheckBox chbSplneno;
        private ComboBox cmbUzivatel;
        private CheckedListBox chlbLabely;
    }
}

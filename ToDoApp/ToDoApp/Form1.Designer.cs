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
            Pridat = new Button();
            Smazat = new Button();
            Upravit = new Button();
            labelNazev = new Label();
            labelPopis = new Label();
            labelDatumSplneni = new Label();
            nazevUkolu = new TextBox();
            txtPopisu = new TextBox();
            dtpDatumSplneni = new DateTimePicker();
            chbSplneno = new CheckBox();
            cmbUzivatel = new ComboBox();
            chlbLabely = new CheckedListBox();
            labelLabel = new Label();
            PridatLabel = new Button();
            labelNazevLabelu = new Label();
            txtLabel = new TextBox();
            labelUzivatel = new Label();
            jmenoUzivatele = new TextBox();
            pridatUzivatele = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvUkoly).BeginInit();
            SuspendLayout();
            // 
            // dgvUkoly
            // 
            dgvUkoly.BackgroundColor = SystemColors.Control;
            dgvUkoly.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUkoly.Location = new Point(12, 12);
            dgvUkoly.MultiSelect = false;
            dgvUkoly.Name = "dgvUkoly";
            dgvUkoly.ReadOnly = true;
            dgvUkoly.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvUkoly.Size = new Size(450, 426);
            dgvUkoly.TabIndex = 0;
            // 
            // Pridat
            // 
            Pridat.DialogResult = DialogResult.OK;
            Pridat.Location = new Point(483, 415);
            Pridat.Name = "Pridat";
            Pridat.Size = new Size(75, 23);
            Pridat.TabIndex = 1;
            Pridat.Text = "přidat";
            Pridat.UseVisualStyleBackColor = true;
            Pridat.Click += btnPridat_Click;
            // 
            // Smazat
            // 
            Smazat.DialogResult = DialogResult.OK;
            Smazat.Location = new Point(698, 415);
            Smazat.Name = "Smazat";
            Smazat.Size = new Size(75, 23);
            Smazat.TabIndex = 2;
            Smazat.Text = "smazat";
            Smazat.UseVisualStyleBackColor = true;
            Smazat.Click += btnSmazat_Click;
            // 
            // Upravit
            // 
            Upravit.DialogResult = DialogResult.OK;
            Upravit.Location = new Point(593, 415);
            Upravit.Name = "Upravit";
            Upravit.Size = new Size(75, 23);
            Upravit.TabIndex = 3;
            Upravit.Text = "upravit";
            Upravit.UseVisualStyleBackColor = true;
            Upravit.Click += btnUpravit_Click;
            // 
            // labelNazev
            // 
            labelNazev.AutoSize = true;
            labelNazev.Location = new Point(485, 25);
            labelNazev.Name = "labelNazev";
            labelNazev.Size = new Size(73, 15);
            labelNazev.TabIndex = 4;
            labelNazev.Text = "název úkolu:";
            labelNazev.TextAlign = ContentAlignment.TopCenter;
            // 
            // labelPopis
            // 
            labelPopis.AutoSize = true;
            labelPopis.Location = new Point(486, 54);
            labelPopis.Name = "labelPopis";
            labelPopis.Size = new Size(72, 15);
            labelPopis.TabIndex = 5;
            labelPopis.Text = "popis úkolu:";
            // 
            // labelDatumSplneni
            // 
            labelDatumSplneni.AccessibleRole = AccessibleRole.None;
            labelDatumSplneni.AutoSize = true;
            labelDatumSplneni.Location = new Point(486, 94);
            labelDatumSplneni.Name = "labelDatumSplneni";
            labelDatumSplneni.Size = new Size(86, 15);
            labelDatumSplneni.TabIndex = 6;
            labelDatumSplneni.Text = "datum splnění:";
            // 
            // nazevUkolu
            // 
            nazevUkolu.Location = new Point(599, 22);
            nazevUkolu.Name = "nazevUkolu";
            nazevUkolu.Size = new Size(174, 23);
            nazevUkolu.TabIndex = 7;
            // 
            // txtPopisu
            // 
            txtPopisu.Location = new Point(599, 51);
            txtPopisu.Name = "txtPopisu";
            txtPopisu.Size = new Size(174, 23);
            txtPopisu.TabIndex = 8;
            // 
            // dtpDatumSplneni
            // 
            dtpDatumSplneni.Location = new Point(599, 88);
            dtpDatumSplneni.Name = "dtpDatumSplneni";
            dtpDatumSplneni.Size = new Size(174, 23);
            dtpDatumSplneni.TabIndex = 9;
            // 
            // chbSplneno
            // 
            chbSplneno.AutoSize = true;
            chbSplneno.Location = new Point(614, 370);
            chbSplneno.Name = "chbSplneno";
            chbSplneno.Size = new Size(68, 19);
            chbSplneno.TabIndex = 10;
            chbSplneno.Text = "splněno";
            chbSplneno.UseVisualStyleBackColor = true;
            // 
            // cmbUzivatel
            // 
            cmbUzivatel.FormattingEnabled = true;
            cmbUzivatel.Location = new Point(599, 123);
            cmbUzivatel.Name = "cmbUzivatel";
            cmbUzivatel.Size = new Size(174, 23);
            cmbUzivatel.TabIndex = 11;
            // 
            // chlbLabely
            // 
            chlbLabely.FormattingEnabled = true;
            chlbLabely.Location = new Point(483, 241);
            chlbLabely.Name = "chlbLabely";
            chlbLabely.Size = new Size(100, 148);
            chlbLabely.TabIndex = 12;
            // 
            // labelLabel
            // 
            labelLabel.AutoSize = true;
            labelLabel.Location = new Point(483, 223);
            labelLabel.Name = "labelLabel";
            labelLabel.Size = new Size(35, 15);
            labelLabel.TabIndex = 13;
            labelLabel.Text = "štítky";
            // 
            // PridatLabel
            // 
            PridatLabel.Location = new Point(684, 288);
            PridatLabel.Name = "PridatLabel";
            PridatLabel.Size = new Size(89, 23);
            PridatLabel.TabIndex = 14;
            PridatLabel.Text = "přidat štítek";
            PridatLabel.UseVisualStyleBackColor = true;
            // 
            // labelNazevLabelu
            // 
            labelNazevLabelu.AutoSize = true;
            labelNazevLabelu.Location = new Point(599, 241);
            labelNazevLabelu.Name = "labelNazevLabelu";
            labelNazevLabelu.Size = new Size(69, 15);
            labelNazevLabelu.TabIndex = 15;
            labelNazevLabelu.Text = "název štítku";
            // 
            // txtLabel
            // 
            txtLabel.Location = new Point(599, 259);
            txtLabel.Name = "txtLabel";
            txtLabel.Size = new Size(174, 23);
            txtLabel.TabIndex = 16;
            // 
            // labelUzivatel
            // 
            labelUzivatel.AutoSize = true;
            labelUzivatel.Location = new Point(486, 131);
            labelUzivatel.Name = "labelUzivatel";
            labelUzivatel.Size = new Size(93, 15);
            labelUzivatel.TabIndex = 17;
            labelUzivatel.Text = "jméno uživatele:";
            // 
            // jmenoUzivatele
            // 
            jmenoUzivatele.Location = new Point(599, 152);
            jmenoUzivatele.Name = "jmenoUzivatele";
            jmenoUzivatele.Size = new Size(174, 23);
            jmenoUzivatele.TabIndex = 18;
            // 
            // pridatUzivatele
            // 
            pridatUzivatele.Location = new Point(672, 181);
            pridatUzivatele.Name = "pridatUzivatele";
            pridatUzivatele.RightToLeft = RightToLeft.Yes;
            pridatUzivatele.Size = new Size(101, 23);
            pridatUzivatele.TabIndex = 19;
            pridatUzivatele.Text = "přidat uživatele";
            pridatUzivatele.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(800, 450);
            Controls.Add(pridatUzivatele);
            Controls.Add(jmenoUzivatele);
            Controls.Add(labelUzivatel);
            Controls.Add(txtLabel);
            Controls.Add(labelNazevLabelu);
            Controls.Add(PridatLabel);
            Controls.Add(labelLabel);
            Controls.Add(chlbLabely);
            Controls.Add(cmbUzivatel);
            Controls.Add(chbSplneno);
            Controls.Add(dtpDatumSplneni);
            Controls.Add(txtPopisu);
            Controls.Add(nazevUkolu);
            Controls.Add(labelDatumSplneni);
            Controls.Add(labelPopis);
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
        private Button Pridat;
        private Button Smazat;
        private Button Upravit;
        private Label labelNazev;
        private Label labelPopis;
        private Label labelDatumSplneni;
        private TextBox nazevUkolu;
        private TextBox txtPopisu;
        private DateTimePicker dtpDatumSplneni;
        private CheckBox chbSplneno;
        private ComboBox cmbUzivatel;
        private CheckedListBox chlbLabely;
        private Label labelLabel;
        private Button PridatLabel;
        private Label labelNazevLabelu;
        private TextBox txtLabel;
        private Label labelUzivatel;
        private TextBox jmenoUzivatele;
        private Button pridatUzivatele;
    }
}

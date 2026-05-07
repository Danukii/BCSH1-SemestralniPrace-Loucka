namespace ToDoApp
{
    partial class FormUpravitUkol
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
            txtNazev = new TextBox();
            txtPopis = new TextBox();
            btnOk = new Button();
            btnZrusit = new Button();
            dtpDatum = new DateTimePicker();
            chbSplneno = new CheckBox();
            cmbUzivatel = new ComboBox();
            chlbStitky = new CheckedListBox();
            lblNazevUkolu = new Label();
            label2 = new Label();
            lblUzivatele = new Label();
            lblDatumSplneni = new Label();
            lblStitky = new Label();
            txtStitek = new TextBox();
            btnPridatStitek = new Button();
            txtUzivatel = new TextBox();
            btnPridatUzivatele = new Button();
            SuspendLayout();
            // 
            // txtNazev
            // 
            txtNazev.ForeColor = SystemColors.WindowText;
            txtNazev.Location = new Point(33, 41);
            txtNazev.Name = "txtNazev";
            txtNazev.Size = new Size(175, 23);
            txtNazev.TabIndex = 0;
            txtNazev.TextAlign = HorizontalAlignment.Right;
            // 
            // txtPopis
            // 
            txtPopis.ForeColor = SystemColors.WindowText;
            txtPopis.Location = new Point(33, 96);
            txtPopis.Multiline = true;
            txtPopis.Name = "txtPopis";
            txtPopis.Size = new Size(175, 67);
            txtPopis.TabIndex = 1;
            txtPopis.TextAlign = HorizontalAlignment.Right;
            // 
            // btnOk
            // 
            btnOk.BackColor = Color.MediumSpringGreen;
            btnOk.ForeColor = SystemColors.ControlText;
            btnOk.Location = new Point(318, 326);
            btnOk.Name = "btnOk";
            btnOk.Size = new Size(75, 23);
            btnOk.TabIndex = 2;
            btnOk.Text = "OK";
            btnOk.UseVisualStyleBackColor = false;
            btnOk.Click += btnOK_Click;
            // 
            // btnZrusit
            // 
            btnZrusit.BackColor = Color.DeepPink;
            btnZrusit.ForeColor = SystemColors.ControlLightLight;
            btnZrusit.Location = new Point(418, 326);
            btnZrusit.Name = "btnZrusit";
            btnZrusit.Size = new Size(75, 23);
            btnZrusit.TabIndex = 3;
            btnZrusit.Text = "zrušit";
            btnZrusit.UseVisualStyleBackColor = false;
            btnZrusit.Click += btnCancel_Click;
            // 
            // dtpDatum
            // 
            dtpDatum.Location = new Point(315, 41);
            dtpDatum.Name = "dtpDatum";
            dtpDatum.Size = new Size(178, 23);
            dtpDatum.TabIndex = 4;
            // 
            // chbSplneno
            // 
            chbSplneno.AutoSize = true;
            chbSplneno.Location = new Point(271, 246);
            chbSplneno.Name = "chbSplneno";
            chbSplneno.Size = new Size(68, 19);
            chbSplneno.TabIndex = 5;
            chbSplneno.Text = "splněno";
            chbSplneno.UseVisualStyleBackColor = true;
            // 
            // cmbUzivatel
            // 
            cmbUzivatel.FormattingEnabled = true;
            cmbUzivatel.Location = new Point(315, 96);
            cmbUzivatel.Name = "cmbUzivatel";
            cmbUzivatel.Size = new Size(178, 23);
            cmbUzivatel.TabIndex = 6;
            // 
            // chlbStitky
            // 
            chlbStitky.FormattingEnabled = true;
            chlbStitky.Location = new Point(33, 201);
            chlbStitky.Name = "chlbStitky";
            chlbStitky.Size = new Size(175, 148);
            chlbStitky.TabIndex = 7;
            // 
            // lblNazevUkolu
            // 
            lblNazevUkolu.AutoSize = true;
            lblNazevUkolu.BackColor = Color.Transparent;
            lblNazevUkolu.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 238);
            lblNazevUkolu.Location = new Point(118, 21);
            lblNazevUkolu.Name = "lblNazevUkolu";
            lblNazevUkolu.Size = new Size(91, 17);
            lblNazevUkolu.TabIndex = 8;
            lblNazevUkolu.Text = "zadejte název";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label2.Location = new Point(118, 76);
            label2.Name = "label2";
            label2.Size = new Size(90, 17);
            label2.TabIndex = 9;
            label2.Text = "zadejte popis";
            // 
            // lblUzivatele
            // 
            lblUzivatele.AutoSize = true;
            lblUzivatele.BackColor = Color.Transparent;
            lblUzivatele.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 238);
            lblUzivatele.Location = new Point(315, 76);
            lblUzivatele.Name = "lblUzivatele";
            lblUzivatele.Size = new Size(178, 17);
            lblUzivatele.TabIndex = 10;
            lblUzivatele.Text = "vyberte / vytvořte uživatele";
            // 
            // lblDatumSplneni
            // 
            lblDatumSplneni.AutoSize = true;
            lblDatumSplneni.BackColor = Color.Transparent;
            lblDatumSplneni.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 238);
            lblDatumSplneni.Location = new Point(346, 21);
            lblDatumSplneni.Name = "lblDatumSplneni";
            lblDatumSplneni.Size = new Size(147, 17);
            lblDatumSplneni.TabIndex = 11;
            lblDatumSplneni.Text = "vyberte datum splnění";
            // 
            // lblStitky
            // 
            lblStitky.AutoSize = true;
            lblStitky.BackColor = Color.Transparent;
            lblStitky.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 238);
            lblStitky.Location = new Point(57, 181);
            lblStitky.Name = "lblStitky";
            lblStitky.Size = new Size(152, 17);
            lblStitky.TabIndex = 12;
            lblStitky.Text = "vyberte / vytvořte šítek";
            // 
            // txtStitek
            // 
            txtStitek.ForeColor = SystemColors.WindowText;
            txtStitek.Location = new Point(393, 211);
            txtStitek.Name = "txtStitek";
            txtStitek.Size = new Size(100, 23);
            txtStitek.TabIndex = 13;
            txtStitek.Text = "nový štítek";
            txtStitek.TextAlign = HorizontalAlignment.Right;
            // 
            // btnPridatStitek
            // 
            btnPridatStitek.BackColor = Color.DarkViolet;
            btnPridatStitek.FlatStyle = FlatStyle.System;
            btnPridatStitek.ForeColor = SystemColors.WindowText;
            btnPridatStitek.Location = new Point(416, 240);
            btnPridatStitek.Name = "btnPridatStitek";
            btnPridatStitek.Size = new Size(77, 25);
            btnPridatStitek.TabIndex = 14;
            btnPridatStitek.Text = "+ štítek";
            btnPridatStitek.UseVisualStyleBackColor = false;
            // 
            // txtUzivatel
            // 
            txtUzivatel.ImeMode = ImeMode.NoControl;
            txtUzivatel.Location = new Point(393, 135);
            txtUzivatel.Name = "txtUzivatel";
            txtUzivatel.Size = new Size(100, 23);
            txtUzivatel.TabIndex = 15;
            txtUzivatel.Text = "nový uživatel";
            txtUzivatel.TextAlign = HorizontalAlignment.Right;
            // 
            // btnPridatUzivatele
            // 
            btnPridatUzivatele.BackColor = Color.DarkViolet;
            btnPridatUzivatele.FlatStyle = FlatStyle.System;
            btnPridatUzivatele.ForeColor = SystemColors.WindowText;
            btnPridatUzivatele.Location = new Point(410, 164);
            btnPridatUzivatele.Name = "btnPridatUzivatele";
            btnPridatUzivatele.Size = new Size(83, 25);
            btnPridatUzivatele.TabIndex = 16;
            btnPridatUzivatele.Text = "+ uživatel";
            btnPridatUzivatele.UseVisualStyleBackColor = false;
            // 
            // FormUpravitUkol
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Purple;
            ClientSize = new Size(526, 380);
            Controls.Add(btnPridatUzivatele);
            Controls.Add(txtUzivatel);
            Controls.Add(btnPridatStitek);
            Controls.Add(txtStitek);
            Controls.Add(lblStitky);
            Controls.Add(lblDatumSplneni);
            Controls.Add(lblUzivatele);
            Controls.Add(label2);
            Controls.Add(lblNazevUkolu);
            Controls.Add(chlbStitky);
            Controls.Add(cmbUzivatel);
            Controls.Add(chbSplneno);
            Controls.Add(dtpDatum);
            Controls.Add(btnZrusit);
            Controls.Add(btnOk);
            Controls.Add(txtPopis);
            Controls.Add(txtNazev);
            ForeColor = SystemColors.ControlLightLight;
            Name = "FormUpravitUkol";
            Text = "Upravení úkolu";
            TopMost = true;
            Load += FormUpravitUkol_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNazev;
        private TextBox txtPopis;
        private Button btnOk;
        private Button btnZrusit;
        private DateTimePicker dtpDatum;
        private CheckBox chbSplneno;
        private ComboBox cmbUzivatel;
        private CheckedListBox chlbStitky;
        private Label lblNazevUkolu;
        private Label label2;
        private Label lblUzivatele;
        private Label lblDatumSplneni;
        private Label lblStitky;
        private TextBox txtStitek;
        private Button btnPridatStitek;
        private TextBox txtUzivatel;
        private Button btnPridatUzivatele;
    }
}
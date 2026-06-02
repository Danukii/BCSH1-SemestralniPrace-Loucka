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
            txtNovyStitek = new TextBox();
            btnPridatStitek = new Button();
            txtNovyUzivatel = new TextBox();
            btnPridatUzivatele = new Button();
            lblNovyUzivatel = new Label();
            lblNovyStitek = new Label();
            btnSmazatUzivatele = new Button();
            btnSmazatStitek = new Button();
            tbProgress = new TrackBar();
            lblProgress = new Label();
            ((System.ComponentModel.ISupportInitialize)tbProgress).BeginInit();
            SuspendLayout();
            // 
            // txtNazev
            // 
            txtNazev.ForeColor = SystemColors.WindowText;
            txtNazev.Location = new Point(23, 41);
            txtNazev.Name = "txtNazev";
            txtNazev.Size = new Size(175, 23);
            txtNazev.TabIndex = 0;
            txtNazev.TextAlign = HorizontalAlignment.Right;
            // 
            // txtPopis
            // 
            txtPopis.ForeColor = SystemColors.WindowText;
            txtPopis.Location = new Point(23, 91);
            txtPopis.Multiline = true;
            txtPopis.Name = "txtPopis";
            txtPopis.Size = new Size(175, 80);
            txtPopis.TabIndex = 1;
            txtPopis.TextAlign = HorizontalAlignment.Right;
            // 
            // btnOk
            // 
            btnOk.BackColor = SystemColors.ControlLightLight;
            btnOk.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            btnOk.ForeColor = Color.MediumSpringGreen;
            btnOk.Location = new Point(455, 302);
            btnOk.Name = "btnOk";
            btnOk.Size = new Size(75, 33);
            btnOk.TabIndex = 2;
            btnOk.Text = "OK";
            btnOk.UseVisualStyleBackColor = false;
            btnOk.Click += btnOK_Click;
            // 
            // btnZrusit
            // 
            btnZrusit.BackColor = SystemColors.ControlLightLight;
            btnZrusit.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            btnZrusit.ForeColor = Color.DeepPink;
            btnZrusit.Location = new Point(558, 302);
            btnZrusit.Name = "btnZrusit";
            btnZrusit.Size = new Size(75, 33);
            btnZrusit.TabIndex = 3;
            btnZrusit.Text = "zrušit";
            btnZrusit.UseVisualStyleBackColor = false;
            btnZrusit.Click += btnCancel_Click;
            // 
            // dtpDatum
            // 
            dtpDatum.Location = new Point(20, 206);
            dtpDatum.Name = "dtpDatum";
            dtpDatum.Size = new Size(178, 23);
            dtpDatum.TabIndex = 4;
            dtpDatum.ValueChanged += dtpDatum_ValueChanged;
            // 
            // chbSplneno
            // 
            chbSplneno.AutoSize = true;
            chbSplneno.Location = new Point(346, 276);
            chbSplneno.Name = "chbSplneno";
            chbSplneno.Size = new Size(68, 19);
            chbSplneno.TabIndex = 5;
            chbSplneno.Text = "splněno";
            chbSplneno.UseVisualStyleBackColor = true;
            // 
            // cmbUzivatel
            // 
            cmbUzivatel.BackColor = Color.FromArgb(45, 45, 65);
            cmbUzivatel.ForeColor = Color.White;
            cmbUzivatel.FormattingEnabled = true;
            cmbUzivatel.Location = new Point(20, 272);
            cmbUzivatel.Name = "cmbUzivatel";
            cmbUzivatel.Size = new Size(178, 23);
            cmbUzivatel.TabIndex = 6;
            // 
            // chlbStitky
            // 
            chlbStitky.BackColor = Color.FromArgb(45, 45, 65);
            chlbStitky.ForeColor = Color.White;
            chlbStitky.FormattingEnabled = true;
            chlbStitky.Location = new Point(239, 41);
            chlbStitky.Name = "chlbStitky";
            chlbStitky.Size = new Size(175, 130);
            chlbStitky.TabIndex = 7;
            // 
            // lblNazevUkolu
            // 
            lblNazevUkolu.AutoSize = true;
            lblNazevUkolu.BackColor = Color.Transparent;
            lblNazevUkolu.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 238);
            lblNazevUkolu.Location = new Point(151, 21);
            lblNazevUkolu.Name = "lblNazevUkolu";
            lblNazevUkolu.Size = new Size(47, 17);
            lblNazevUkolu.TabIndex = 8;
            lblNazevUkolu.Text = "název:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label2.Location = new Point(152, 71);
            label2.Name = "label2";
            label2.Size = new Size(46, 17);
            label2.TabIndex = 9;
            label2.Text = "popis:";
            // 
            // lblUzivatele
            // 
            lblUzivatele.AutoSize = true;
            lblUzivatele.BackColor = Color.Transparent;
            lblUzivatele.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 238);
            lblUzivatele.Location = new Point(138, 250);
            lblUzivatele.Name = "lblUzivatele";
            lblUzivatele.Size = new Size(60, 17);
            lblUzivatele.TabIndex = 10;
            lblUzivatele.Text = "uživatel:";
            // 
            // lblDatumSplneni
            // 
            lblDatumSplneni.AutoSize = true;
            lblDatumSplneni.BackColor = Color.Transparent;
            lblDatumSplneni.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 238);
            lblDatumSplneni.Location = new Point(97, 186);
            lblDatumSplneni.Name = "lblDatumSplneni";
            lblDatumSplneni.Size = new Size(101, 17);
            lblDatumSplneni.TabIndex = 11;
            lblDatumSplneni.Text = "datum splnění:";
            // 
            // lblStitky
            // 
            lblStitky.AutoSize = true;
            lblStitky.BackColor = Color.Transparent;
            lblStitky.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 238);
            lblStitky.Location = new Point(239, 21);
            lblStitky.Name = "lblStitky";
            lblStitky.Size = new Size(86, 17);
            lblStitky.TabIndex = 12;
            lblStitky.Text = "štítek/štítky:";
            // 
            // txtNovyStitek
            // 
            txtNovyStitek.BackColor = Color.FromArgb(45, 45, 65);
            txtNovyStitek.ForeColor = Color.White;
            txtNovyStitek.Location = new Point(455, 148);
            txtNovyStitek.Name = "txtNovyStitek";
            txtNovyStitek.Size = new Size(175, 23);
            txtNovyStitek.TabIndex = 13;
            txtNovyStitek.TextAlign = HorizontalAlignment.Right;
            // 
            // btnPridatStitek
            // 
            btnPridatStitek.BackColor = Color.DarkViolet;
            btnPridatStitek.FlatStyle = FlatStyle.System;
            btnPridatStitek.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 238);
            btnPridatStitek.ForeColor = SystemColors.WindowText;
            btnPridatStitek.Location = new Point(598, 178);
            btnPridatStitek.Name = "btnPridatStitek";
            btnPridatStitek.Size = new Size(32, 32);
            btnPridatStitek.TabIndex = 14;
            btnPridatStitek.Text = "+";
            btnPridatStitek.UseVisualStyleBackColor = true;
            btnPridatStitek.Click += btnPridatStitek_Click;
            // 
            // txtNovyUzivatel
            // 
            txtNovyUzivatel.BackColor = Color.FromArgb(45, 45, 65);
            txtNovyUzivatel.ForeColor = Color.White;
            txtNovyUzivatel.ImeMode = ImeMode.NoControl;
            txtNovyUzivatel.Location = new Point(455, 41);
            txtNovyUzivatel.Name = "txtNovyUzivatel";
            txtNovyUzivatel.Size = new Size(178, 23);
            txtNovyUzivatel.TabIndex = 15;
            txtNovyUzivatel.TextAlign = HorizontalAlignment.Right;
            // 
            // btnPridatUzivatele
            // 
            btnPridatUzivatele.BackColor = Color.DarkViolet;
            btnPridatUzivatele.FlatStyle = FlatStyle.System;
            btnPridatUzivatele.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            btnPridatUzivatele.ForeColor = SystemColors.WindowText;
            btnPridatUzivatele.Location = new Point(599, 71);
            btnPridatUzivatele.Name = "btnPridatUzivatele";
            btnPridatUzivatele.Size = new Size(32, 32);
            btnPridatUzivatele.TabIndex = 16;
            btnPridatUzivatele.Text = "+";
            btnPridatUzivatele.UseVisualStyleBackColor = false;
            btnPridatUzivatele.Click += btnPridatUzivatele_Click_1;
            // 
            // lblNovyUzivatel
            // 
            lblNovyUzivatel.AutoSize = true;
            lblNovyUzivatel.BackColor = Color.Transparent;
            lblNovyUzivatel.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 238);
            lblNovyUzivatel.Location = new Point(539, 21);
            lblNovyUzivatel.Name = "lblNovyUzivatel";
            lblNovyUzivatel.Size = new Size(94, 17);
            lblNovyUzivatel.TabIndex = 17;
            lblNovyUzivatel.Text = "nový uživatel:";
            // 
            // lblNovyStitek
            // 
            lblNovyStitek.AutoSize = true;
            lblNovyStitek.BackColor = Color.Transparent;
            lblNovyStitek.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 238);
            lblNovyStitek.Location = new Point(552, 128);
            lblNovyStitek.Name = "lblNovyStitek";
            lblNovyStitek.Size = new Size(81, 17);
            lblNovyStitek.TabIndex = 18;
            lblNovyStitek.Text = "nový štítek:";
            // 
            // btnSmazatUzivatele
            // 
            btnSmazatUzivatele.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 238);
            btnSmazatUzivatele.ForeColor = SystemColors.ControlText;
            btnSmazatUzivatele.Location = new Point(561, 71);
            btnSmazatUzivatele.Name = "btnSmazatUzivatele";
            btnSmazatUzivatele.Size = new Size(32, 32);
            btnSmazatUzivatele.TabIndex = 19;
            btnSmazatUzivatele.Text = "-";
            btnSmazatUzivatele.UseVisualStyleBackColor = true;
            btnSmazatUzivatele.Click += btnSmazatUzivatele_Click;
            // 
            // btnSmazatStitek
            // 
            btnSmazatStitek.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 238);
            btnSmazatStitek.ForeColor = SystemColors.ControlText;
            btnSmazatStitek.Location = new Point(560, 178);
            btnSmazatStitek.Name = "btnSmazatStitek";
            btnSmazatStitek.Size = new Size(32, 32);
            btnSmazatStitek.TabIndex = 20;
            btnSmazatStitek.Text = "- štítek";
            btnSmazatStitek.UseVisualStyleBackColor = true;
            btnSmazatStitek.Click += btnSmazatStitek_Click;
            // 
            // tbProgress
            // 
            tbProgress.Cursor = Cursors.Hand;
            tbProgress.LargeChange = 1;
            tbProgress.Location = new Point(236, 222);
            tbProgress.Maximum = 100;
            tbProgress.Name = "tbProgress";
            tbProgress.Size = new Size(178, 45);
            tbProgress.TabIndex = 21;
            tbProgress.TickFrequency = 10;
            tbProgress.Scroll += tbProgress_Scroll;
            // 
            // lblProgress
            // 
            lblProgress.AutoSize = true;
            lblProgress.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 238);
            lblProgress.Location = new Point(239, 194);
            lblProgress.Name = "lblProgress";
            lblProgress.Size = new Size(44, 25);
            lblProgress.TabIndex = 22;
            lblProgress.Text = "0 %";
            // 
            // FormUpravitUkol
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(35, 35, 55);
            ClientSize = new Size(657, 347);
            Controls.Add(lblProgress);
            Controls.Add(tbProgress);
            Controls.Add(btnSmazatStitek);
            Controls.Add(btnSmazatUzivatele);
            Controls.Add(lblNovyStitek);
            Controls.Add(lblNovyUzivatel);
            Controls.Add(btnPridatUzivatele);
            Controls.Add(txtNovyUzivatel);
            Controls.Add(btnPridatStitek);
            Controls.Add(txtNovyStitek);
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
            ((System.ComponentModel.ISupportInitialize)tbProgress).EndInit();
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
        private TextBox txtNovyStitek;
        private Button btnPridatStitek;
        private TextBox txtNovyUzivatel;
        private Button btnPridatUzivatele;
        private Label lblNovyUzivatel;
        private Label lblNovyStitek;
        private Button btnSmazatUzivatele;
        private Button btnSmazatStitek;
        private TrackBar tbProgress;
        private Label lblProgress;
    }
}
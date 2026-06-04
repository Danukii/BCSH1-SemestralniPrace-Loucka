namespace ToDoApp
{
    partial class FormDetailUkol
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
            lblPopis = new Label();
            lblNazev = new Label();
            lblDatum = new Label();
            lblProgress = new Label();
            btnUpravit = new Button();
            btnSmazat = new Button();
            labelDatumSplneni = new Label();
            labelPrubeh = new Label();
            labelStav = new Label();
            labelStitky = new Label();
            labelUzivatel = new Label();
            lblStitky = new Label();
            lblUzivatel = new Label();
            lblStav = new Label();
            SuspendLayout();
            // 
            // lblPopis
            // 
            lblPopis.AutoEllipsis = true;
            lblPopis.AutoSize = true;
            lblPopis.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 238);
            lblPopis.ForeColor = SystemColors.ControlLightLight;
            lblPopis.Location = new Point(43, 77);
            lblPopis.MaximumSize = new Size(200, 140);
            lblPopis.Name = "lblPopis";
            lblPopis.Size = new Size(78, 25);
            lblPopis.TabIndex = 2;
            lblPopis.Text = "lblPopis";
            // 
            // lblNazev
            // 
            lblNazev.AutoSize = true;
            lblNazev.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 238);
            lblNazev.ForeColor = Color.Purple;
            lblNazev.Location = new Point(31, 33);
            lblNazev.Name = "lblNazev";
            lblNazev.Size = new Size(129, 37);
            lblNazev.TabIndex = 3;
            lblNazev.Text = "lblNazev";
            // 
            // lblDatum
            // 
            lblDatum.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblDatum.AutoSize = true;
            lblDatum.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 238);
            lblDatum.ForeColor = SystemColors.ControlLightLight;
            lblDatum.Location = new Point(337, 77);
            lblDatum.Name = "lblDatum";
            lblDatum.Size = new Size(82, 21);
            lblDatum.TabIndex = 4;
            lblDatum.Text = "lblDatum";
            // 
            // lblProgress
            // 
            lblProgress.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblProgress.AutoSize = true;
            lblProgress.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 238);
            lblProgress.ForeColor = SystemColors.ControlLightLight;
            lblProgress.Location = new Point(357, 278);
            lblProgress.Name = "lblProgress";
            lblProgress.Size = new Size(87, 20);
            lblProgress.TabIndex = 5;
            lblProgress.Text = "lblProgress";
            // 
            // btnUpravit
            // 
            btnUpravit.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnUpravit.BackColor = Color.Purple;
            btnUpravit.FlatAppearance.BorderSize = 0;
            btnUpravit.FlatStyle = FlatStyle.Flat;
            btnUpravit.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnUpravit.ForeColor = Color.WhiteSmoke;
            btnUpravit.Location = new Point(284, 362);
            btnUpravit.Name = "btnUpravit";
            btnUpravit.Size = new Size(70, 30);
            btnUpravit.TabIndex = 6;
            btnUpravit.Text = "upravit";
            btnUpravit.UseVisualStyleBackColor = false;
            btnUpravit.Click += btnUpravit_Click;
            // 
            // btnSmazat
            // 
            btnSmazat.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnSmazat.BackColor = Color.Crimson;
            btnSmazat.FlatAppearance.BorderSize = 0;
            btnSmazat.FlatStyle = FlatStyle.Flat;
            btnSmazat.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnSmazat.ForeColor = Color.WhiteSmoke;
            btnSmazat.Location = new Point(373, 362);
            btnSmazat.Name = "btnSmazat";
            btnSmazat.Size = new Size(70, 30);
            btnSmazat.TabIndex = 7;
            btnSmazat.Text = "smazat";
            btnSmazat.UseVisualStyleBackColor = false;
            btnSmazat.Click += btnSmazat_Click;
            // 
            // labelDatumSplneni
            // 
            labelDatumSplneni.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            labelDatumSplneni.AutoSize = true;
            labelDatumSplneni.Font = new Font("Segoe UI", 10F);
            labelDatumSplneni.ForeColor = SystemColors.ControlLightLight;
            labelDatumSplneni.Location = new Point(337, 51);
            labelDatumSplneni.Name = "labelDatumSplneni";
            labelDatumSplneni.Size = new Size(99, 19);
            labelDatumSplneni.TabIndex = 8;
            labelDatumSplneni.Text = "datum splnění:";
            // 
            // labelPrubeh
            // 
            labelPrubeh.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            labelPrubeh.AutoSize = true;
            labelPrubeh.Font = new Font("Segoe UI", 10F);
            labelPrubeh.ForeColor = SystemColors.ControlLightLight;
            labelPrubeh.Location = new Point(295, 280);
            labelPrubeh.Name = "labelPrubeh";
            labelPrubeh.Size = new Size(56, 19);
            labelPrubeh.TabIndex = 10;
            labelPrubeh.Text = "průběh:";
            // 
            // labelStav
            // 
            labelStav.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            labelStav.AutoSize = true;
            labelStav.Font = new Font("Segoe UI", 10F);
            labelStav.ForeColor = SystemColors.ControlLightLight;
            labelStav.Location = new Point(295, 253);
            labelStav.Name = "labelStav";
            labelStav.Size = new Size(37, 19);
            labelStav.TabIndex = 11;
            labelStav.Text = "stav:";
            // 
            // labelStitky
            // 
            labelStitky.AutoSize = true;
            labelStitky.Font = new Font("Segoe UI", 10F);
            labelStitky.ForeColor = SystemColors.ControlLightLight;
            labelStitky.Location = new Point(31, 280);
            labelStitky.Name = "labelStitky";
            labelStitky.Size = new Size(45, 19);
            labelStitky.TabIndex = 12;
            labelStitky.Text = "štítky:";
            // 
            // labelUzivatel
            // 
            labelUzivatel.AutoSize = true;
            labelUzivatel.Font = new Font("Segoe UI", 10F);
            labelUzivatel.ForeColor = SystemColors.ControlLightLight;
            labelUzivatel.Location = new Point(31, 253);
            labelUzivatel.Name = "labelUzivatel";
            labelUzivatel.Size = new Size(58, 19);
            labelUzivatel.TabIndex = 13;
            labelUzivatel.Text = "uživatel:";
            // 
            // lblStitky
            // 
            lblStitky.AutoSize = true;
            lblStitky.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 238);
            lblStitky.ForeColor = SystemColors.ControlLightLight;
            lblStitky.Location = new Point(43, 307);
            lblStitky.MinimumSize = new Size(200, 85);
            lblStitky.Name = "lblStitky";
            lblStitky.Size = new Size(200, 85);
            lblStitky.TabIndex = 14;
            lblStitky.Text = "lblStitky";
            // 
            // lblUzivatel
            // 
            lblUzivatel.AutoSize = true;
            lblUzivatel.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 238);
            lblUzivatel.ForeColor = SystemColors.ControlLightLight;
            lblUzivatel.Location = new Point(95, 253);
            lblUzivatel.Name = "lblUzivatel";
            lblUzivatel.Size = new Size(82, 20);
            lblUzivatel.TabIndex = 15;
            lblUzivatel.Text = "lblUzivatel";
            // 
            // lblStav
            // 
            lblStav.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblStav.AutoSize = true;
            lblStav.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 238);
            lblStav.ForeColor = SystemColors.ControlLightLight;
            lblStav.Location = new Point(356, 253);
            lblStav.Name = "lblStav";
            lblStav.Size = new Size(56, 20);
            lblStav.TabIndex = 16;
            lblStav.Text = "lblStav";
            // 
            // FormDetailUkol
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(20, 20, 35);
            ClientSize = new Size(472, 421);
            Controls.Add(lblStav);
            Controls.Add(lblUzivatel);
            Controls.Add(lblStitky);
            Controls.Add(labelUzivatel);
            Controls.Add(labelStitky);
            Controls.Add(labelStav);
            Controls.Add(labelPrubeh);
            Controls.Add(labelDatumSplneni);
            Controls.Add(btnSmazat);
            Controls.Add(btnUpravit);
            Controls.Add(lblProgress);
            Controls.Add(lblDatum);
            Controls.Add(lblNazev);
            Controls.Add(lblPopis);
            Name = "FormDetailUkol";
            Text = "Detail úkolu";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblPopis;
        private Label lblNazev;
        private Label lblDatum;
        private Label lblProgress;
        private Button btnUpravit;
        private Button btnSmazat;
        private Label labelDatumSplneni;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label labelUzivatel;
        private Label lblStitky;
        private Label lblUzivatel;
        private Label lblStav;
        private Label labelPrubeh;
        private Label labelStav;
        private Label labelStitky;
    }
}
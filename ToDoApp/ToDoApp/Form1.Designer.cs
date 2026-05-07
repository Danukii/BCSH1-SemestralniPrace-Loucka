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
            topPanel = new Panel();
            btnFiltrovat = new Button();
            btnPridat = new Button();
            cmbFilterStitek = new ComboBox();
            lblStatus = new Label();
            cmbFilterUzivatel = new ComboBox();
            lblDatum = new Label();
            cmbFilterStav = new ComboBox();
            lblPopis = new Label();
            lblNazev = new Label();
            flpUkoly = new FlowLayoutPanel();
            topPanel.SuspendLayout();
            SuspendLayout();
            // 
            // topPanel
            // 
            topPanel.BackColor = Color.Purple;
            topPanel.Controls.Add(btnFiltrovat);
            topPanel.Controls.Add(btnPridat);
            topPanel.Controls.Add(cmbFilterStitek);
            topPanel.Controls.Add(lblStatus);
            topPanel.Controls.Add(cmbFilterUzivatel);
            topPanel.Controls.Add(lblDatum);
            topPanel.Controls.Add(cmbFilterStav);
            topPanel.Controls.Add(lblPopis);
            topPanel.Controls.Add(lblNazev);
            topPanel.Dock = DockStyle.Top;
            topPanel.Location = new Point(0, 0);
            topPanel.Name = "topPanel";
            topPanel.Size = new Size(900, 109);
            topPanel.TabIndex = 1;
            topPanel.Paint += topPanel_Paint;
            // 
            // btnFiltrovat
            // 
            btnFiltrovat.BackColor = Color.DarkViolet;
            btnFiltrovat.FlatAppearance.BorderSize = 0;
            btnFiltrovat.FlatStyle = FlatStyle.Flat;
            btnFiltrovat.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 238);
            btnFiltrovat.ForeColor = Color.White;
            btnFiltrovat.Location = new Point(465, 16);
            btnFiltrovat.Name = "btnFiltrovat";
            btnFiltrovat.Size = new Size(100, 30);
            btnFiltrovat.TabIndex = 4;
            btnFiltrovat.Text = "Filtrovat";
            btnFiltrovat.UseVisualStyleBackColor = false;
            btnFiltrovat.Click += btnFiltrovat_Click;
            // 
            // btnPridat
            // 
            btnPridat.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnPridat.BackColor = Color.DarkViolet;
            btnPridat.FlatAppearance.BorderSize = 0;
            btnPridat.FlatStyle = FlatStyle.Flat;
            btnPridat.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 238);
            btnPridat.ForeColor = Color.White;
            btnPridat.Location = new Point(775, 58);
            btnPridat.Name = "btnPridat";
            btnPridat.Size = new Size(100, 30);
            btnPridat.TabIndex = 0;
            btnPridat.Text = "Přidat";
            btnPridat.UseVisualStyleBackColor = false;
            btnPridat.Click += btnPridat_Click;
            // 
            // cmbFilterStitek
            // 
            cmbFilterStitek.ForeColor = Color.FromArgb(35, 35, 55);
            cmbFilterStitek.Location = new Point(308, 22);
            cmbFilterStitek.Name = "cmbFilterStitek";
            cmbFilterStitek.Size = new Size(140, 23);
            cmbFilterStitek.TabIndex = 2;
            cmbFilterStitek.Text = "Štítky";
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 238);
            lblStatus.ForeColor = SystemColors.ControlLightLight;
            lblStatus.Location = new Point(653, 68);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(53, 20);
            lblStatus.TabIndex = 3;
            lblStatus.Text = "Status";
            // 
            // cmbFilterUzivatel
            // 
            cmbFilterUzivatel.ForeColor = Color.FromArgb(35, 35, 55);
            cmbFilterUzivatel.Location = new Point(162, 22);
            cmbFilterUzivatel.Name = "cmbFilterUzivatel";
            cmbFilterUzivatel.Size = new Size(140, 23);
            cmbFilterUzivatel.TabIndex = 1;
            cmbFilterUzivatel.Text = "Uživatel";
            // 
            // lblDatum
            // 
            lblDatum.AutoSize = true;
            lblDatum.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 238);
            lblDatum.ForeColor = SystemColors.ControlLightLight;
            lblDatum.Location = new Point(454, 68);
            lblDatum.Name = "lblDatum";
            lblDatum.Size = new Size(111, 20);
            lblDatum.TabIndex = 2;
            lblDatum.Text = "Datum splnění";
            // 
            // cmbFilterStav
            // 
            cmbFilterStav.ForeColor = Color.FromArgb(35, 35, 55);
            cmbFilterStav.Location = new Point(16, 22);
            cmbFilterStav.Name = "cmbFilterStav";
            cmbFilterStav.Size = new Size(140, 23);
            cmbFilterStav.TabIndex = 3;
            cmbFilterStav.Text = "Stav";
            // 
            // lblPopis
            // 
            lblPopis.AutoSize = true;
            lblPopis.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 238);
            lblPopis.ForeColor = SystemColors.ControlLightLight;
            lblPopis.Location = new Point(162, 68);
            lblPopis.Name = "lblPopis";
            lblPopis.Size = new Size(47, 20);
            lblPopis.TabIndex = 1;
            lblPopis.Text = "Popis";
            lblPopis.Click += lblPopis_Click;
            // 
            // lblNazev
            // 
            lblNazev.AutoSize = true;
            lblNazev.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 238);
            lblNazev.ForeColor = SystemColors.ControlLightLight;
            lblNazev.Location = new Point(33, 68);
            lblNazev.Name = "lblNazev";
            lblNazev.Size = new Size(41, 20);
            lblNazev.TabIndex = 0;
            lblNazev.Text = "Úkol";
            // 
            // flpUkoly
            // 
            flpUkoly.AutoScroll = true;
            flpUkoly.BackColor = Color.Transparent;
            flpUkoly.Dock = DockStyle.Fill;
            flpUkoly.FlowDirection = FlowDirection.TopDown;
            flpUkoly.Location = new Point(0, 109);
            flpUkoly.Name = "flpUkoly";
            flpUkoly.Padding = new Padding(10);
            flpUkoly.Size = new Size(900, 491);
            flpUkoly.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(20, 20, 35);
            ClientSize = new Size(900, 600);
            Controls.Add(flpUkoly);
            Controls.Add(topPanel);
            Name = "Form1";
            Text = "ToDo App";
            topPanel.ResumeLayout(false);
            topPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel topPanel;

        private ComboBox cmbFilterUzivatel;
        private ComboBox cmbFilterStitek;
        private ComboBox cmbFilterStav;

        private Button btnFiltrovat;

        private FlowLayoutPanel flpUkoly;
        private Label lblStatus;
        private Label lblDatum;
        private Label lblPopis;
        private Label lblNazev;
        public Button btnPridat;
    }
}

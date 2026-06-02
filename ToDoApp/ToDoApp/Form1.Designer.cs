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
            btnVymazatFiltry = new Button();
            btnFiltrovat = new Button();
            btnPridat = new Button();
            cmbFiltrStitek = new ComboBox();
            lblStatus = new Label();
            cmbFiltrUzivatel = new ComboBox();
            lblDatum = new Label();
            cmbFiltrStav = new ComboBox();
            lblPopis = new Label();
            flpUkoly = new FlowLayoutPanel();
            topPanel.SuspendLayout();
            SuspendLayout();
            // 
            // topPanel
            // 
            topPanel.BackColor = Color.Purple;
            topPanel.Controls.Add(btnVymazatFiltry);
            topPanel.Controls.Add(btnFiltrovat);
            topPanel.Controls.Add(btnPridat);
            topPanel.Controls.Add(cmbFiltrStitek);
            topPanel.Controls.Add(lblStatus);
            topPanel.Controls.Add(cmbFiltrUzivatel);
            topPanel.Controls.Add(lblDatum);
            topPanel.Controls.Add(cmbFiltrStav);
            topPanel.Controls.Add(lblPopis);
            topPanel.Dock = DockStyle.Top;
            topPanel.Location = new Point(0, 0);
            topPanel.Name = "topPanel";
            topPanel.Size = new Size(900, 92);
            topPanel.TabIndex = 1;
            topPanel.Paint += topPanel_Paint;
            // 
            // btnVymazatFiltry
            // 
            btnVymazatFiltry.BackColor = Color.DarkViolet;
            btnVymazatFiltry.FlatAppearance.BorderSize = 0;
            btnVymazatFiltry.FlatStyle = FlatStyle.Flat;
            btnVymazatFiltry.Font = new Font("Segoe UI Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 238);
            btnVymazatFiltry.ForeColor = Color.White;
            btnVymazatFiltry.Location = new Point(742, 11);
            btnVymazatFiltry.Name = "btnVymazatFiltry";
            btnVymazatFiltry.Size = new Size(30, 30);
            btnVymazatFiltry.TabIndex = 5;
            btnVymazatFiltry.Text = "↺";
            btnVymazatFiltry.UseVisualStyleBackColor = false;
            btnVymazatFiltry.Click += btnVymazatFiltry_Click;
            // 
            // btnFiltrovat
            // 
            btnFiltrovat.BackColor = Color.DarkViolet;
            btnFiltrovat.FlatAppearance.BorderSize = 0;
            btnFiltrovat.FlatStyle = FlatStyle.Flat;
            btnFiltrovat.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 238);
            btnFiltrovat.ForeColor = Color.White;
            btnFiltrovat.Location = new Point(778, 12);
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
            btnPridat.Location = new Point(778, 51);
            btnPridat.Name = "btnPridat";
            btnPridat.Size = new Size(100, 30);
            btnPridat.TabIndex = 0;
            btnPridat.Text = "Přidat úkol";
            btnPridat.UseVisualStyleBackColor = false;
            btnPridat.Click += btnPridat_Click;
            // 
            // cmbFiltrStitek
            // 
            cmbFiltrStitek.ForeColor = Color.FromArgb(35, 35, 55);
            cmbFiltrStitek.Location = new Point(596, 11);
            cmbFiltrStitek.Name = "cmbFiltrStitek";
            cmbFiltrStitek.Size = new Size(140, 23);
            cmbFiltrStitek.TabIndex = 2;
            cmbFiltrStitek.Text = "Štítky";
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 238);
            lblStatus.ForeColor = SystemColors.ControlLightLight;
            lblStatus.Location = new Point(265, 56);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(53, 20);
            lblStatus.TabIndex = 3;
            lblStatus.Text = "Status";
            // 
            // cmbFiltrUzivatel
            // 
            cmbFiltrUzivatel.ForeColor = Color.FromArgb(35, 35, 55);
            cmbFiltrUzivatel.Location = new Point(450, 11);
            cmbFiltrUzivatel.Name = "cmbFiltrUzivatel";
            cmbFiltrUzivatel.Size = new Size(140, 23);
            cmbFiltrUzivatel.TabIndex = 1;
            cmbFiltrUzivatel.Text = "Uživatel";
            // 
            // lblDatum
            // 
            lblDatum.AutoSize = true;
            lblDatum.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 238);
            lblDatum.ForeColor = SystemColors.ControlLightLight;
            lblDatum.Location = new Point(415, 56);
            lblDatum.Name = "lblDatum";
            lblDatum.Size = new Size(111, 20);
            lblDatum.TabIndex = 2;
            lblDatum.Text = "Datum splnění";
            // 
            // cmbFiltrStav
            // 
            cmbFiltrStav.ForeColor = Color.FromArgb(35, 35, 55);
            cmbFiltrStav.Location = new Point(304, 12);
            cmbFiltrStav.Name = "cmbFiltrStav";
            cmbFiltrStav.Size = new Size(140, 23);
            cmbFiltrStav.TabIndex = 3;
            cmbFiltrStav.Text = "Stav";
            // 
            // lblPopis
            // 
            lblPopis.AutoSize = true;
            lblPopis.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 238);
            lblPopis.ForeColor = SystemColors.ControlLightLight;
            lblPopis.Location = new Point(60, 56);
            lblPopis.Name = "lblPopis";
            lblPopis.Size = new Size(90, 20);
            lblPopis.TabIndex = 1;
            lblPopis.Text = "Popis úkolu";
            lblPopis.Click += lblPopis_Click;
            // 
            // flpUkoly
            // 
            flpUkoly.AutoScroll = true;
            flpUkoly.BackColor = Color.Transparent;
            flpUkoly.Dock = DockStyle.Fill;
            flpUkoly.FlowDirection = FlowDirection.TopDown;
            flpUkoly.Location = new Point(0, 92);
            flpUkoly.Name = "flpUkoly";
            flpUkoly.Padding = new Padding(10);
            flpUkoly.Size = new Size(900, 508);
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

        private ComboBox cmbFiltrUzivatel;
        private ComboBox cmbFiltrStitek;
        private ComboBox cmbFiltrStav;

        private Button btnFiltrovat;

        private FlowLayoutPanel flpUkoly;
        private Label lblStatus;
        private Label lblDatum;
        private Label lblPopis;
        public Button btnPridat;
        private Button btnVymazatFiltry;
    }
}

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
            components = new System.ComponentModel.Container();
            topPanel = new Panel();
            lblProcentoHotovo = new Label();
            lblHledat = new Label();
            btnZrusitHledani = new Button();
            txtHledat = new TextBox();
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
            toolTip1 = new ToolTip(components);
            toolTip2 = new ToolTip(components);
            toolTip3 = new ToolTip(components);
            topPanel.SuspendLayout();
            SuspendLayout();
            // 
            // topPanel
            // 
            topPanel.BackColor = Color.Purple;
            topPanel.Controls.Add(lblProcentoHotovo);
            topPanel.Controls.Add(lblHledat);
            topPanel.Controls.Add(btnZrusitHledani);
            topPanel.Controls.Add(txtHledat);
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
            // lblProcentoHotovo
            // 
            lblProcentoHotovo.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblProcentoHotovo.AutoSize = true;
            lblProcentoHotovo.BackColor = Color.Transparent;
            lblProcentoHotovo.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 238);
            lblProcentoHotovo.ForeColor = Color.FromArgb(20, 20, 35);
            lblProcentoHotovo.Location = new Point(596, 56);
            lblProcentoHotovo.Name = "lblProcentoHotovo";
            lblProcentoHotovo.Size = new Size(139, 20);
            lblProcentoHotovo.TabIndex = 11;
            lblProcentoHotovo.Text = "lblProcentoHotovo";
            // 
            // lblHledat
            // 
            lblHledat.AutoSize = true;
            lblHledat.BackColor = Color.Transparent;
            lblHledat.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 238);
            lblHledat.ForeColor = SystemColors.ControlLightLight;
            lblHledat.Location = new Point(20, 14);
            lblHledat.Name = "lblHledat";
            lblHledat.Size = new Size(27, 17);
            lblHledat.TabIndex = 10;
            lblHledat.Text = "🔍";
            // 
            // btnZrusitHledani
            // 
            btnZrusitHledani.BackColor = Color.DarkViolet;
            btnZrusitHledani.FlatAppearance.BorderSize = 0;
            btnZrusitHledani.FlatStyle = FlatStyle.Flat;
            btnZrusitHledani.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold);
            btnZrusitHledani.ForeColor = Color.White;
            btnZrusitHledani.Location = new Point(176, 13);
            btnZrusitHledani.Name = "btnZrusitHledani";
            btnZrusitHledani.Size = new Size(30, 30);
            btnZrusitHledani.TabIndex = 2;
            btnZrusitHledani.Text = "↻";
            btnZrusitHledani.UseVisualStyleBackColor = false;
            btnZrusitHledani.Click += btnZrusitHledani_Click;
            // 
            // txtHledat
            // 
            txtHledat.Location = new Point(50, 13);
            txtHledat.Name = "txtHledat";
            txtHledat.PlaceholderText = "hledat úkol...";
            txtHledat.Size = new Size(120, 23);
            txtHledat.TabIndex = 1;
            txtHledat.TextChanged += txtHledat_TextChanged;
            // 
            // btnVymazatFiltry
            // 
            btnVymazatFiltry.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnVymazatFiltry.BackColor = Color.DarkViolet;
            btnVymazatFiltry.FlatAppearance.BorderSize = 0;
            btnVymazatFiltry.FlatStyle = FlatStyle.Flat;
            btnVymazatFiltry.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold);
            btnVymazatFiltry.ForeColor = Color.White;
            btnVymazatFiltry.Location = new Point(742, 11);
            btnVymazatFiltry.Name = "btnVymazatFiltry";
            btnVymazatFiltry.Size = new Size(30, 30);
            btnVymazatFiltry.TabIndex = 6;
            btnVymazatFiltry.Text = "↻";
            btnVymazatFiltry.UseVisualStyleBackColor = false;
            btnVymazatFiltry.Click += btnVymazatFiltry_Click;
            // 
            // btnFiltrovat
            // 
            btnFiltrovat.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnFiltrovat.BackColor = Color.DarkViolet;
            btnFiltrovat.FlatAppearance.BorderSize = 0;
            btnFiltrovat.FlatStyle = FlatStyle.Flat;
            btnFiltrovat.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 238);
            btnFiltrovat.ForeColor = Color.White;
            btnFiltrovat.Location = new Point(778, 11);
            btnFiltrovat.Name = "btnFiltrovat";
            btnFiltrovat.Size = new Size(100, 30);
            btnFiltrovat.TabIndex = 7;
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
            cmbFiltrStitek.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            cmbFiltrStitek.ForeColor = Color.FromArgb(35, 35, 55);
            cmbFiltrStitek.Location = new Point(596, 11);
            cmbFiltrStitek.Name = "cmbFiltrStitek";
            cmbFiltrStitek.Size = new Size(140, 23);
            cmbFiltrStitek.TabIndex = 5;
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
            cmbFiltrUzivatel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            cmbFiltrUzivatel.ForeColor = Color.FromArgb(35, 35, 55);
            cmbFiltrUzivatel.Location = new Point(450, 11);
            cmbFiltrUzivatel.Name = "cmbFiltrUzivatel";
            cmbFiltrUzivatel.Size = new Size(140, 23);
            cmbFiltrUzivatel.TabIndex = 4;
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
            cmbFiltrStav.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            cmbFiltrStav.ForeColor = Color.FromArgb(35, 35, 55);
            cmbFiltrStav.Location = new Point(304, 11);
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
            flpUkoly.WrapContents = false;
            // 
            // toolTip1
            // 
            toolTip1.ToolTipIcon = ToolTipIcon.Info;
            // 
            // toolTip2
            // 
            toolTip2.ToolTipIcon = ToolTipIcon.Info;
            // 
            // toolTip3
            // 
            toolTip3.ToolTipIcon = ToolTipIcon.Info;
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

        private FlowLayoutPanel flpUkoly;
        private Label lblStatus;
        private Label lblDatum;
        private Label lblPopis;
        public Button btnPridat;
        private Button btnVymazatFiltry;
        private TextBox txtHledat;
        private Button btnZrusitHledani;
        private Label lblHledat;
        public Button btnFiltrovat;
        private ToolTip toolTip1;
        private ToolTip toolTip2;
        private ToolTip toolTip3;
        private Label lblProcentoHotovo;
    }
}

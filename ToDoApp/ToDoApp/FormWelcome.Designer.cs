namespace ToDoApp
{
    partial class FormWelcome
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
            lblToDoApp = new Label();
            lblUvitani = new Label();
            label1 = new Label();
            btnPokracovat = new Button();
            SuspendLayout();
            // 
            // lblToDoApp
            // 
            lblToDoApp.AutoSize = true;
            lblToDoApp.BackColor = Color.Transparent;
            lblToDoApp.FlatStyle = FlatStyle.Flat;
            lblToDoApp.Font = new Font("Broadway", 72F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblToDoApp.ForeColor = Color.Purple;
            lblToDoApp.Location = new Point(164, 83);
            lblToDoApp.Name = "lblToDoApp";
            lblToDoApp.Size = new Size(548, 109);
            lblToDoApp.TabIndex = 0;
            lblToDoApp.Text = "ToDo App";
            lblToDoApp.TextAlign = ContentAlignment.TopCenter;
            // 
            // lblUvitani
            // 
            lblUvitani.AutoSize = true;
            lblUvitani.BackColor = Color.Transparent;
            lblUvitani.Font = new Font("Segoe UI", 14F);
            lblUvitani.ForeColor = SystemColors.ControlLight;
            lblUvitani.Location = new Point(297, 211);
            lblUvitani.Name = "lblUvitani";
            lblUvitani.Size = new Size(300, 25);
            lblUvitani.TabIndex = 1;
            lblUvitani.Text = "Vítejte v aplikaci pro správu úkolů.";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 13F);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(340, 268);
            label1.Name = "label1";
            label1.Size = new Size(237, 150);
            label1.TabIndex = 2;
            label1.Text = "Můžete:\r\n• vytvářet úkoly\r\n• přiřazovat uživatele\r\n• přidávat štítky\r\n• sledovat průběh plnění\r\n• filtrovat a vyhledávat úkoly";
            // 
            // btnPokracovat
            // 
            btnPokracovat.Anchor = AnchorStyles.Bottom;
            btnPokracovat.BackColor = Color.DarkViolet;
            btnPokracovat.Cursor = Cursors.Hand;
            btnPokracovat.FlatAppearance.BorderSize = 0;
            btnPokracovat.FlatStyle = FlatStyle.Flat;
            btnPokracovat.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnPokracovat.ForeColor = Color.White;
            btnPokracovat.Location = new Point(398, 491);
            btnPokracovat.Name = "btnPokracovat";
            btnPokracovat.Size = new Size(100, 30);
            btnPokracovat.TabIndex = 8;
            btnPokracovat.Text = "Pokračovat";
            btnPokracovat.UseVisualStyleBackColor = false;
            btnPokracovat.Click += btnPokracovat_Click;
            // 
            // FormWelcome
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(20, 20, 35);
            ClientSize = new Size(900, 600);
            Controls.Add(btnPokracovat);
            Controls.Add(label1);
            Controls.Add(lblUvitani);
            Controls.Add(lblToDoApp);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "FormWelcome";
            Text = "ToDo App";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblToDoApp;
        private Label lblUvitani;
        private Label label1;
        public Button btnPokracovat;
    }
}
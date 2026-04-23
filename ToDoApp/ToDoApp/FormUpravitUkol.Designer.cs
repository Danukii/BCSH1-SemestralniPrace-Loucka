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
            chlbLabely = new CheckedListBox();
            SuspendLayout();
            // 
            // txtNazev
            // 
            txtNazev.ForeColor = SystemColors.ScrollBar;
            txtNazev.Location = new Point(12, 12);
            txtNazev.Name = "txtNazev";
            txtNazev.Size = new Size(175, 23);
            txtNazev.TabIndex = 0;
            txtNazev.Text = "zadejte název";
            txtNazev.TextAlign = HorizontalAlignment.Right;
            // 
            // txtPopis
            // 
            txtPopis.ForeColor = SystemColors.ScrollBar;
            txtPopis.Location = new Point(12, 41);
            txtPopis.Multiline = true;
            txtPopis.Name = "txtPopis";
            txtPopis.Size = new Size(175, 67);
            txtPopis.TabIndex = 1;
            txtPopis.Text = "zadejte popis";
            txtPopis.TextAlign = HorizontalAlignment.Right;
            // 
            // btnOk
            // 
            btnOk.Location = new Point(221, 185);
            btnOk.Name = "btnOk";
            btnOk.Size = new Size(75, 23);
            btnOk.TabIndex = 2;
            btnOk.Text = "OK";
            btnOk.UseVisualStyleBackColor = true;
            // 
            // btnZrusit
            // 
            btnZrusit.Location = new Point(321, 185);
            btnZrusit.Name = "btnZrusit";
            btnZrusit.Size = new Size(75, 23);
            btnZrusit.TabIndex = 3;
            btnZrusit.Text = "zrušit";
            btnZrusit.UseVisualStyleBackColor = true;
            // 
            // dtpDatum
            // 
            dtpDatum.Location = new Point(221, 12);
            dtpDatum.Name = "dtpDatum";
            dtpDatum.Size = new Size(175, 23);
            dtpDatum.TabIndex = 4;
            // 
            // chbSplneno
            // 
            chbSplneno.AutoSize = true;
            chbSplneno.Location = new Point(221, 114);
            chbSplneno.Name = "chbSplneno";
            chbSplneno.Size = new Size(68, 19);
            chbSplneno.TabIndex = 5;
            chbSplneno.Text = "splněno";
            chbSplneno.UseVisualStyleBackColor = true;
            // 
            // cmbUzivatel
            // 
            cmbUzivatel.FormattingEnabled = true;
            cmbUzivatel.Location = new Point(221, 41);
            cmbUzivatel.Name = "cmbUzivatel";
            cmbUzivatel.Size = new Size(175, 23);
            cmbUzivatel.TabIndex = 6;
            // 
            // chlbLabely
            // 
            chlbLabely.FormattingEnabled = true;
            chlbLabely.Location = new Point(12, 114);
            chlbLabely.Name = "chlbLabely";
            chlbLabely.Size = new Size(175, 94);
            chlbLabely.TabIndex = 7;
            // 
            // FormUpravitUkol
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(408, 219);
            Controls.Add(chlbLabely);
            Controls.Add(cmbUzivatel);
            Controls.Add(chbSplneno);
            Controls.Add(dtpDatum);
            Controls.Add(btnZrusit);
            Controls.Add(btnOk);
            Controls.Add(txtPopis);
            Controls.Add(txtNazev);
            Name = "FormUpravitUkol";
            Text = "Upravení úkolu";
            TopMost = true;
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
        private CheckedListBox chlbLabely;
    }
}
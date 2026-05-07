using System.ComponentModel;
using ToDoApp.Data;
using ToDoApp.Entity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;

namespace ToDoApp
{
    public partial class Form1 : Form
    {
        private Ukladani _data;
        private VytvoreniUkolu _vytvoreniUkolu;

        public Form1()
        {
            InitializeComponent();

            // načtení dat
            _data = Ukladani.Nacist();

            _data.Ukoly ??= new List<Ukol>();
            _data.Uzivatele ??= new List<Uzivatel>();
            _data.Stitky ??= new List<Stitek>();

            // testovací data (jen když je prázdno)
            if (!_data.Uzivatele.Any())
            {
                _data.Uzivatele.Add(new Uzivatel { Id = 1, Jmeno = "Já" });
            }

            if (!_data.Stitky.Any())
            {
                _data.Stitky.Add(new Stitek { Id = 1, Nazev = "Škola" });
                _data.Stitky.Add(new Stitek { Id = 2, Nazev = "Práce" });
            }

            _vytvoreniUkolu = new VytvoreniUkolu(_data);


            // naplnění uživatelů do ComboBoxu pro filtrování
            cmbFilterUzivatel.DataSource = _data.Uzivatele.ToList();
            cmbFilterUzivatel.DisplayMember = "Jmeno";
            cmbFilterUzivatel.ValueMember = "Id";
            cmbFilterUzivatel.SelectedIndex = -1;

            // naplnění štítků pro filtraci
            cmbFilterStitek.DataSource = _data.Stitky.ToList();
            cmbFilterStitek.DisplayMember = "Nazev";
            cmbFilterStitek.ValueMember = "Id";
            cmbFilterStitek.SelectedIndex = -1;

            // naplnění stavu pro filtraci
            cmbFilterStav.Items.AddRange(new[] { "všechny úkoly", "splněno", "nesplněno" });
            cmbFilterStav.SelectedIndex = 0;

            // první vykreslení
            ObnovUI();
        }


        // ============= UI =============

        // obnovení zobrazení úkolů (po změně dat) - znovu projít všechny úkoly a vytvořit pro ně „kartičky“
        private void ObnovUI(IEnumerable<Ukol> zdroj = null)
        {
            var data = zdroj ?? _data.Ukoly;

            flpUkoly.SuspendLayout();
            flpUkoly.Controls.Clear();

            foreach (var ukol in data)
                flpUkoly.Controls.Add(VytvorUkolPanel(ukol));

            flpUkoly.ResumeLayout();
        }

        // zobrazení úkolů v panelu (FlowLayoutPanel) - jak vytvořit „kartičku úkolu“
        private Panel VytvorUkolPanel(Ukol ukol)
        {
            var panel = new Panel
            {
                Width = flpUkoly.ClientSize.Width - 30,
                Height = 70,
                BackColor = Color.FromArgb(35, 35, 55),
                Margin = new Padding(8),
                Padding = new Padding(10)
            };

            // checkbox (stav) - tlačítko dokončit/odznačit
            var chkSplneno = new CheckBox
            {
                Checked = ukol.JeSplneno,
                Location = new Point(10, 25)
            };

            chkSplneno.CheckedChanged += (s, e) =>
            {
                ukol.JeSplneno = chkSplneno.Checked;
                _data.Ulozit();
                ObnovUI();
            };

            // název úkolu
            var lblNazev = new Label
            {
                Text = ukol.Nazev,
                ForeColor = Color.White,
                Font = new Font("Segoe UI", 10, FontStyle.Bold),
                Location = new Point(40, 10),
                AutoSize = true
            };

            // popis úkolu (zobrazit jen první řádek)
            var lblPopis = new Label
            {
                Text = ukol.Popis.Split('\n').FirstOrDefault() ?? "",
                ForeColor = Color.LightGray,
                Font = new Font("Segoe UI", 9, FontStyle.Regular),
                Location = new Point(50, 10),
                AutoSize = true
            };

            // stav úkolu (splněno/nedokončeno/nehotovo) - barevný
            var lblStatus = new Label
            {
                Location = new Point(250, 22),
                AutoSize = true,
                Font = new Font("Segoe UI", 9, FontStyle.Bold)
            };

            // ✅ STATUS (barevný)
            if (ukol.JeSplneno)
            {
                lblStatus.Text = "✔ splněno";
                lblStatus.ForeColor = Color.LightGreen;
            }
            else
            {
                lblStatus.Text = "❌ nehotovo";
                lblStatus.ForeColor = Color.Red;
            }

            // datum splnění
            var lblDatum = new Label
            {
                Text = ukol.DatumSplneni?.ToString("dd.MM.yyyy") ?? "",
                ForeColor = Color.Gray,
                Location = new Point(40, 35),
                AutoSize = true
            };

            // tlačítko upravit
            var btnUpravit = new Button
            {
                Text = "✏",
                BackColor = Color.MediumPurple,
                ForeColor = Color.White,
                FlatStyle = FlatStyle.Flat,
                Location = new Point(panel.Width - 110, 18),
                Width = 40
            };

            btnUpravit.FlatAppearance.BorderSize = 0;

            btnUpravit.Click += (s, e) =>
            {
                var form = new FormUpravitUkol(_data.Uzivatele, _data.Stitky, ukol);

                if (form.ShowDialog() == DialogResult.OK)
                {
                    _data.Ulozit();
                    ObnovUI();
                }
            };

            // tlačítko smazat
            var btnSmazat = new Button
            {
                Text = "🗑",
                BackColor = Color.IndianRed,
                ForeColor = Color.White,
                FlatStyle = FlatStyle.Flat,
                Location = new Point(panel.Width - 60, 18),
                Width = 40
            };

            btnSmazat.FlatAppearance.BorderSize = 0;

            btnSmazat.Click += (s, e) =>
            {
                _vytvoreniUkolu.SmazatUkol(ukol.Id);
                ObnovUI();
            };


            // přidání všech prvků do panelu
            panel.Controls.Add(chkSplneno);
            panel.Controls.Add(lblNazev);
            panel.Controls.Add(lblPopis);
            panel.Controls.Add(lblStatus);
            panel.Controls.Add(lblDatum);
            panel.Controls.Add(btnUpravit);
            panel.Controls.Add(btnSmazat);

            return panel;
        }


        // ============= Akce =============

        //přidání úkolu (spojení na UI)
        private void btnPridat_Click(object sender, EventArgs e)
        {
            var form = new FormUpravitUkol(_data.Uzivatele, _data.Stitky);

            if (form.ShowDialog() == DialogResult.OK && form.Ukol != null)
            {
                _vytvoreniUkolu.PridatUkol(form.Ukol);
                ObnovUI();
            }
        }

        // filtrování
        private void btnFiltrovat_Click(object sender, EventArgs e)
        {
            int? uzivatelId = cmbFilterUzivatel.SelectedIndex >= 0
                ? (int?)cmbFilterUzivatel.SelectedValue
                : null;

            int? stitekId = cmbFilterStitek.SelectedIndex >= 0
                ? (int?)cmbFilterStitek.SelectedValue
                : null;

            string stav = cmbFilterStav.SelectedItem?.ToString();

            var filtered = _data.Ukoly.AsEnumerable();

            if (uzivatelId != null)
                filtered = filtered.Where(u => u.UzivatelId == uzivatelId);

            if (stitekId != null)
                filtered = filtered.Where(u => u.StitekId.Contains(stitekId.Value));

            if (stav == "splněno")
                filtered = filtered.Where(u => u.JeSplneno);

            if (stav == "nedokončeno")
                filtered = filtered.Where(u => !u.JeSplneno);

            ObnovUI(filtered.ToList());
        }

        private void btnSmazat_Click(object sender, EventArgs e)
        {
        }

        private void btnUpravit_Click(object sender, EventArgs e)
        {
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void topPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblPopis_Click(object sender, EventArgs e)
        {

        }
    }
}

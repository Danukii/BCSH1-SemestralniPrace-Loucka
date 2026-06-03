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


            // filtr uživatelů
            cmbFiltrUzivatel.Items.Add("Všichni uživatelé");

            foreach (var user in _data.Uzivatele)
            {
                cmbFiltrUzivatel.Items.Add(user);
            }

            cmbFiltrUzivatel.DisplayMember = "Jmeno";

            cmbFiltrUzivatel.SelectedIndex = 0;

            // filtr štítků
            cmbFiltrStitek.Items.Add("Všechny štítky");

            foreach (var label in _data.Stitky)
            {
                cmbFiltrStitek.Items.Add(label);
            }

            cmbFiltrStitek.DisplayMember = "Nazev";

            cmbFiltrStitek.SelectedIndex = 0;

            // naplnění stavu pro filtraci
            cmbFiltrStav.Items.AddRange(new[] { "vše", "splněno", "nesplněno" });
            cmbFiltrStav.SelectedIndex = 0;

            toolTip1.SetToolTip(btnPridat, "Přidání nového úkolu");
            toolTip2.SetToolTip(btnFiltrovat, "Filtrování úkolů");
            toolTip3.SetToolTip(txtHledat, "Vyhledávání podle názvu");

            // obnovení filtrů (pro případ, že by se načetly nové položky)
            ObnovFiltry();

            // první vykreslení
            ObnovUI();
        }


        // ============= UI =============

        // obnovení zobrazení úkolů (po změně dat) - znovu projít všechny úkoly a vytvořit pro ně „kartičky“
        private void ObnovUI(IEnumerable<Ukol>? zdroj = null)
        {
            var data = zdroj ?? _data.Ukoly;

            flpUkoly.SuspendLayout();
            flpUkoly.Controls.Clear();

            foreach (var ukol in data)
                flpUkoly.Controls.Add(VytvorUkolPanel(ukol));

            flpUkoly.ResumeLayout();
            AktualizujStatistiky();
        }

        // obnovení filtrů (po změně uživatelů/štítků) - znovu naplnit ComboBoxy pro filtrování
        private void ObnovFiltry()
        {
            // Uživatelé
            cmbFiltrUzivatel.Items.Clear();
            cmbFiltrUzivatel.Items.Add("Všichni uživatelé");

            foreach (var user in _data.Uzivatele)
            {
                cmbFiltrUzivatel.Items.Add(user);
            }

            cmbFiltrUzivatel.DisplayMember = "Jmeno";

            // Štítky
            cmbFiltrStitek.Items.Clear();
            cmbFiltrStitek.Items.Add("Všechny štítky");

            foreach (var label in _data.Stitky)
            {
                cmbFiltrStitek.Items.Add(label);
            }

            cmbFiltrStitek.DisplayMember = "Nazev";
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

            // kliknutí na panel - otevřít detail úkolu
            panel.Cursor = Cursors.Hand;
            panel.Click += (s, e) =>
            {
                var detail = new FormDetailUkol(ukol, _data);

                if (detail.ShowDialog() == DialogResult.OK) {
                    ObnovUI();
                    ObnovFiltry();
                }
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
                Text = ukol.Popis, //ukol.Popis.Split('\n').FirstOrDefault() ?? ""
                ForeColor = Color.LightGray,
                Font = new Font("Segoe UI", 9, FontStyle.Regular),
                Location = new Point(40, 45),
                AutoSize = true
            };

            // stav úkolu (splněno/nedokončeno/nehotovo) - barevný
            var lblStatus = new Label
            {
                Location = new Point(250, 25),
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
                lblStatus.Text = "❌ nesplněno";
                lblStatus.ForeColor = Color.Red;
            }

            // datum splnění
            var lblDatum = new Label
            {
                Text = ukol.DatumSplneni.HasValue ? ukol.DatumSplneni.Value.ToString("dd.MM.yyyy") : "",
                ForeColor = Color.Gray,
                Location = new Point(400, 25),
                AutoSize = true
            };

            // progres úkolu (pokud není splněno) - zobrazení v procentech
            var progressBar = new ProgressBar
            {
                Location = new Point(540, 25),
                Width = 100,
                Height = 15,
                Value = ukol.Progress
            };

            // label %
            var lblProgress = new Label
            {
                Text = ukol.Progress + "%",
                ForeColor = Color.White,
                Location = new Point(650, 25),
                AutoSize = true
            };

            // tlačítko upravit
            var btnUpravit = new Button
            {
                Text = "✏",
                BackColor = Color.Transparent,
                ForeColor = Color.MediumPurple,
                Font = new Font("Segoe UI", 12, FontStyle.Regular),
                FlatStyle = FlatStyle.Flat,
                Location = new Point(panel.Width - 110, 20),
                Width = 32,
                Height = 32,
                Cursor = Cursors.Hand
            };

            btnUpravit.FlatAppearance.BorderSize = 0;
            btnUpravit.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnUpravit.FlatAppearance.MouseOverBackColor = Color.Transparent;

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
                BackColor = Color.Transparent,
                ForeColor = Color.IndianRed,
                Font = new Font("Segoe UI", 12, FontStyle.Regular),
                FlatStyle = FlatStyle.Flat,
                Location = new Point(panel.Width - 60, 20),
                Width = 32,
                Height = 32,
                Cursor = Cursors.Hand
            };

            btnSmazat.FlatAppearance.BorderSize = 0;
            btnSmazat.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnSmazat.FlatAppearance.MouseOverBackColor = Color.Transparent;

            btnSmazat.Click += (s, e) =>
            {
                var result = MessageBox.Show(
                    $"Opravdu chcete smazat úkol '{ukol.Nazev}'?\nTuto akci nelze vrátit zpět.",
                    "Smazání úkolu",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning,
                    MessageBoxDefaultButton.Button2);

                if (result == DialogResult.Yes)
                {
                    _vytvoreniUkolu.SmazatUkol(ukol.Id);
                    ObnovUI();
                }
            };


            // přidání všech prvků do panelu
            panel.Controls.Add(chkSplneno);
            panel.Controls.Add(lblNazev);
            panel.Controls.Add(lblPopis);
            panel.Controls.Add(lblStatus);
            panel.Controls.Add(lblDatum);

            if (ukol.ZobrazitProgressBar) {
                panel.Controls.Add(progressBar);
            }

            if (ukol.ZobrazitProcenta) {
                panel.Controls.Add(lblProgress);
            }

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
                ObnovFiltry();
            }
        }

        // filtrování
        private void btnFiltrovat_Click(object sender, EventArgs e)
        {
            int? uzivatelId = null;
            if (cmbFiltrUzivatel.SelectedItem is Uzivatel user)
            {
                uzivatelId = user.Id;
            }

            int? stitekId = null;
            if (cmbFiltrStitek.SelectedItem is Stitek stitek)
            {
                stitekId = stitek.Id;
            }

            string? stav = cmbFiltrStav.SelectedItem?.ToString();

            var filtered = _data.Ukoly.AsEnumerable();

            if (uzivatelId != null)
                filtered = filtered.Where(u => u.UzivatelId == uzivatelId);

            if (stitekId != null)
                filtered = filtered.Where(u => u.StitekId.Contains(stitekId.Value));

            if (stav == "splněno") {
                filtered = filtered.Where(u => u.JeSplneno);
            }
            else if (stav == "nesplněno") {
                filtered = filtered.Where(u => !u.JeSplneno);
            }

            ObnovUI(filtered.ToList());
        }

        private void btnSmazat_Click(object sender, EventArgs e)
        {
        }

        private void btnUpravit_Click(object sender, EventArgs e)
        {
            ObnovUI();
            ObnovFiltry();
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

        private void btnVymazatFiltry_Click(object sender, EventArgs e)
        {
            cmbFiltrUzivatel.SelectedIndex = 0;
            cmbFiltrStitek.SelectedIndex = 0;
            cmbFiltrStav.SelectedIndex = 0;

            ObnovUI(_data.Ukoly);
        }

        private void HledatUkoly()
        {
            string hledanyText = txtHledat.Text.Trim();

            if (string.IsNullOrWhiteSpace(hledanyText))
            {
                ObnovUI();
                return;
            }

            var vysledek = _data.Ukoly
                .Where(u => u.Nazev.Contains(
                    hledanyText,
                    StringComparison.OrdinalIgnoreCase))
                .ToList();

            ObnovUI(vysledek);
        }

        private void btnHledat_Click(object sender, EventArgs e)
        {
            HledatUkoly();
        }

        private void txtHledat_TextChanged(object sender, EventArgs e)
        {
            HledatUkoly();
        }

        private void btnZrusitHledani_Click(object sender, EventArgs e)
        {
            txtHledat.Text = "";
            ObnovUI();
        }

        // aktualizace statistik
        private void AktualizujStatistiky()
        {
            int celkem = _data.Ukoly.Count;

            int splneno = _data.Ukoly.Count(u => u.JeSplneno);

            double procenta = celkem == 0 ? 0 : (double)splneno / celkem * 100;

            lblProcentoHotovo.Text = $"{procenta:F0} % úkolů dokončeno"; //XX % úkolů dokončeno
            //lblPocetUkolu.Text = $"Úkolů: {celkem}";
            //lblSplneno.Text = $"Splněno: {splneno}";
            
        }
    }
}

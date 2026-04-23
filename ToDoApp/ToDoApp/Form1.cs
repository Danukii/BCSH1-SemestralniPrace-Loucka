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
        private BindingList<Ukol> _bindingUkoly;

        public Form1()
        {
            InitializeComponent();

            dgvUkoly.AutoGenerateColumns = false;
            dgvUkoly.Columns.Clear();

            dgvUkoly.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "název",
                DataPropertyName = "Nazev",
                Name = "Nazev",
                Width = 100
            });
            dgvUkoly.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "popis",
                DataPropertyName = "Popis",
                Name = "Popis",
                Width = 200
            });
            dgvUkoly.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "datum splnění",
                DataPropertyName = "DatumSplneni",
                Name = "DatumSplneni",
                Width = 80
            });
            dgvUkoly.Columns.Add(new DataGridViewCheckBoxColumn
            {
                HeaderText = "splněno",
                DataPropertyName = "JeSplneno",
                Name = "JeSplneno",
                Width = 50
            });


            _data = Ukladani.Nacist();

            if (_data.Ukoly == null)
                _data.Ukoly = new List<Ukol>();

            _vytvoreniUkolu = new VytvoreniUkolu(_data);

            // testovací data
            if (!_data.Uzivatele.Any())
            {
                _data.Uzivatele.Add(new Uzivatel { Id = 1, Jmeno = "Já" });
            }

            if (!_data.Labely.Any())
            {
                _data.Labely.Add(new Entity.Label { Id = 1, Nazev = "Škola" });
                _data.Labely.Add(new Entity.Label { Id = 2, Nazev = "Práce" });
            }

            // naplnění ComboBoxu (uživatelé)
            cmbUzivatel.DataSource = _data.Uzivatele;
            cmbUzivatel.DisplayMember = "Jmeno";
            cmbUzivatel.ValueMember = "Id";

            // naplnění CheckedListBoxu (labely)
            chlbLabely.Items.Clear();
            foreach (var label in _data.Labely)
            {
                chlbLabely.Items.Add(label);
            }

            chlbLabely.DisplayMember = "Nazev";


            // binding gridu
            _bindingUkoly = new BindingList<Ukol>(_data.Ukoly);
            dgvUkoly.DataSource = _bindingUkoly;

            _bindingUkoly.ResetBindings();
        }


        //kliknutí na řádek -> zobrazit detaily
        private void dgvUkoly_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvUkoly.CurrentRow == null || dgvUkoly.CurrentRow.DataBoundItem == null)
                return;

            var ukol = (Ukol)dgvUkoly.CurrentRow.DataBoundItem;

            nazevUkolu.Text = ukol.Nazev;
            txtPopisu.Text = ukol.Popis;
            chbSplneno.Checked = ukol.JeSplneno;

            if (ukol.DatumSplneni.HasValue)
                dtpDatumSplneni.Value = ukol.DatumSplneni.Value;

            for (int i = 0; i < chlbLabely.Items.Count; i++)
            {
                var label = (Entity.Label)chlbLabely.Items[i];
                chlbLabely.SetItemChecked(i, ukol.LabelIds.Contains(label.Id));
            }

            if (ukol.UzivatelId.HasValue)
                cmbUzivatel.SelectedValue = ukol.UzivatelId.Value;
            else
                cmbUzivatel.SelectedIndex = -1;
        }

        //přidání úkolu (spojení na UI)
        private void btnPridat_Click(object sender, EventArgs e)
        {
            var ukol = new Ukol
            {
                Nazev = nazevUkolu.Text,
                Popis = txtPopisu.Text,
                JeSplneno = chbSplneno.Checked,
                DatumSplneni = dtpDatumSplneni.Value
            };

            ukol.LabelIds.Clear();

            foreach (var item in chlbLabely.CheckedItems)
            {
                var label = (Entity.Label)item;
                ukol.LabelIds.Add(label.Id);
            }

            // vytvoření úkolu s přiřazením uživatele (pokud je vybrán)
            if (cmbUzivatel.SelectedItem != null)
                ukol.UzivatelId = (int)cmbUzivatel.SelectedValue;

            else
                ukol.UzivatelId = null;


            var form = new FormUpravitUkol(_data.Uzivatele, _data.Labely);

            if (form.ShowDialog() == DialogResult.OK && form.Ukol != null)
            {
                _vytvoreniUkolu.PridatUkol(form.Ukol);
                _bindingUkoly.ResetBindings();
            }
        }

        //Smazání úkolu
        private void btnSmazat_Click(object sender, EventArgs e)
        {
            if (dgvUkoly.CurrentRow == null || dgvUkoly.CurrentRow.DataBoundItem == null) //!!! indexOutOfRangeException to furt dava
                return;

            var ukol = (Ukol)dgvUkoly.CurrentRow.DataBoundItem;

            if (dgvUkoly.CurrentRow.IsNewRow)
                return;

            _vytvoreniUkolu.SmazatUkol(ukol.Id);

            _bindingUkoly.ResetBindings();   // jen refresh

            // volitelně zruš výběr
            dgvUkoly.ClearSelection();
        }

        //Upravení úkolu
        private void btnUpravit_Click(object sender, EventArgs e)
        {
            if (dgvUkoly.CurrentRow == null || dgvUkoly.CurrentRow.DataBoundItem == null)
                return;

            var ukol = (Ukol)dgvUkoly.CurrentRow.DataBoundItem;

            var form = new FormUpravitUkol(_data.Uzivatele, _data.Labely, ukol);

            if (form.ShowDialog() == DialogResult.OK)
            {
                _data.Ulozit();
                _bindingUkoly.ResetBindings();
            }
        }

        /* Labely(štítky)
         * - každý úkol může mít více labelů
         * 
         * CheckedListBox → clbLabely
         * TextBox → nový label
         * Button "+" → přidat label
        */
        private void btnPridatLabel_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtLabel.Text))
                return;

            var label = new Entity.Label
            {
                Id = _data.Labely.Any() ? _data.Labely.Max(l => l.Id) + 1 : 1,
                Nazev = txtLabel.Text
            };

            _data.Labely.Add(label);
            _data.Ulozit();

            //chlbLabely.DataSource = null;
            //chlbLabely.DataSource = _data.Labely;
            //chlbLabely.DisplayMember = "Nazev";

            // přidání do UI
            chlbLabely.Items.Add(label);

            txtLabel.Text = "";
        }

        private void btnPridatUzivatele_Click(object sender, EventArgs e)
        {
            var user = new Uzivatel
            {
                Id = _data.Uzivatele.Any() ? _data.Uzivatele.Max(u => u.Id) + 1 : 1,
                Jmeno = jmenoUzivatele.Text
            };

            _data.Uzivatele.Add(user);
            _data.Ulozit();

            cmbUzivatel.DataSource = null;
            cmbUzivatel.DataSource = _data.Uzivatele;
            cmbUzivatel.DisplayMember = "Jmeno";
            cmbUzivatel.ValueMember = "Id";
        }
    }
}

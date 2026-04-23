using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ToDoApp.Entity;

namespace ToDoApp
{
    public partial class FormUpravitUkol : Form
    {
        private List<Uzivatel> _uzivatele;
        private List<Entity.Label> _labely;

        public Ukol? Ukol { get; private set; }

        /*
         * Tato třída představuje formulář pro úpravu úkolu. Umožňuje uživateli změnit název, popis, datum splnění, stav úkolu, uživatele a štítky.
         * Formulář obsahuje textová pole pro název a popis, DateTimePicker pro datum splnění, CheckBox pro stav úkolu, ComboBox pro výběr uživatele a CheckedListBox pro výběr štítků.
         * Po potvrzení změn se aktualizované informace uloží do databáze nebo datové struktury, která uchovává úkoly.
         * Formulář může být otevřen z hlavního formuláře (Form1) při výběru úkolu a kliknutí na tlačítko "Upravit".
         *
         * otevře se při „Upravit“
         * předvyplní hodnoty
         * OK → uloží změny
         */
        public FormUpravitUkol(List<Uzivatel> uzivatele, List<Entity.Label> labely, Ukol ukol = null)
        {
            InitializeComponent();

            _uzivatele = uzivatele;
            _labely = labely;

            // ComboBox - uživatelé
            cmbUzivatel.DataSource = _uzivatele;
            cmbUzivatel.DisplayMember = "Nazev";
            cmbUzivatel.ValueMember = "Id";

            // Labely
            chlbLabely.Items.Clear();
            foreach (var l in _labely)
                chlbLabely.Items.Add(l);

            chlbLabely.DisplayMember = "Nazev";

            // pokud upravujeme existující úkol
            if (ukol != null)
            {
                Ukol = ukol;

                txtNazev.Text = ukol.Nazev;
                txtPopis.Text = ukol.Popis;
                chbSplneno.Checked = ukol.JeSplneno;

                if (ukol.DatumSplneni.HasValue)
                    dtpDatum.Value = ukol.DatumSplneni.Value;

                if (ukol.UzivatelId.HasValue)
                    cmbUzivatel.SelectedValue = ukol.UzivatelId.Value;

                // označení labelů
                for (int i = 0; i < chlbLabely.Items.Count; i++)
                {
                    var label = (Entity.Label)chlbLabely.Items[i];
                    chlbLabely.SetItemChecked(i, ukol.LabelIds.Contains(label.Id));
                }
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNazev.Text))
            {
                MessageBox.Show("Název nesmí být prázdný");
                return;
            }

            if (Ukol == null)
                Ukol = new Ukol();

            Ukol.Nazev = txtNazev.Text;
            Ukol.Popis = txtPopis.Text;
            Ukol.JeSplneno = chbSplneno.Checked;
            Ukol.DatumSplneni = dtpDatum.Value;

            // uživatel
            if (cmbUzivatel.SelectedItem != null)
                Ukol.UzivatelId = (int)cmbUzivatel.SelectedValue;
            else
                Ukol.UzivatelId = null;

            // labely
            Ukol.LabelIds.Clear();

            foreach (var item in chlbLabely.CheckedItems)
            {
                var label = (Entity.Label)item;
                Ukol.LabelIds.Add(label.Id);
            }

            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Reflection.Emit;
using System.Text;
using System.Windows.Forms;
using ToDoApp.Entity;

namespace ToDoApp
{
    public partial class FormUpravitUkol : Form
    {
        private List<Uzivatel> _uzivatele;
        private List<Stitek> _stitky;

        public Ukol? Ukol { get; private set; }

        /*
         * Tato třída představuje formulář pro založení/přidání úkolu. Umožňuje uživateli nastavit název, popis, datum splnění, stav úkolu, uživatele a štítky.
         * Formulář obsahuje textová pole pro název a popis, DateTimePicker pro datum splnění, CheckBox pro stav úkolu, ComboBox pro výběr uživatele a CheckedListBox pro výběr štítků.
         * Po potvrzení změn se aktualizované informace uloží do databáze nebo datové struktury, která uchovává úkoly.
         *
         * otevře se při „Přidat“ a „Upravit“ (s předaným úkolem)
         * předvyplní hodnoty
         * OK → uloží změny
         */
        public FormUpravitUkol(
            List<Uzivatel> uzivatele,
            List<Stitek> stitky,
            Ukol ukol = null)
        {
            InitializeComponent();

            _uzivatele = uzivatele;
            _stitky = stitky;

            // uživatelé
            cmbUzivatel.DataSource = _uzivatele;
            cmbUzivatel.DisplayMember = "Jmeno";
            cmbUzivatel.ValueMember = "Id";

            // štítky
            chlbStitky.Items.Clear();
            foreach (var l in _stitky)
                chlbStitky.Items.Add(l);

            chlbStitky.DisplayMember = "Nazev";

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

                // označení štítků
                for (int i = 0; i < chlbStitky.Items.Count; i++)
                {
                    var label = (Stitek)chlbStitky.Items[i];
                    chlbStitky.SetItemChecked(i, ukol.StitekId.Contains(label.Id));
                }
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNazev.Text))
            {
                MessageBox.Show("Zadej název úkolu");
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

            // štítky
            Ukol.StitekId.Clear();

            foreach (var item in chlbStitky.CheckedItems)
            {
                var stitek = (Stitek)item;
                Ukol.StitekId.Add(stitek.Id);
            }

            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void FormUpravitUkol_Load(object sender, EventArgs e)
        {

        }

        private void btnPridatUzivatele_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUzivatel.Text))
                return;

            var user = new Uzivatel
            {
                Id = _uzivatele.Any()
                    ? _uzivatele.Max(u => u.Id) + 1
                    : 1,

                Jmeno = txtUzivatel.Text
            };

            _uzivatele.Add(user);

            cmbUzivatel.DataSource = null;
            cmbUzivatel.DataSource = _uzivatele;
            cmbUzivatel.DisplayMember = "Jmeno";
            cmbUzivatel.ValueMember = "Id";

            txtUzivatel.Clear();
        }

        private void btnPridatLabel_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtStitek.Text))
                return;

            var label = new Stitek
            {
                Id = _stitky.Any()
                    ? _stitky.Max(l => l.Id) + 1
                    : 1,

                Nazev = txtStitek.Text
            };

            _stitky.Add(label);

            chlbStitky.Items.Clear();

            foreach (var l in _stitky)
            {
                chlbStitky.Items.Add(l);
            }

            chlbStitky.DisplayMember = "Nazev";

            txtStitek.Clear();
        }
    }
}
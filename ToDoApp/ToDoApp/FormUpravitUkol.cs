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
            Ukol? ukol = null)
        {
            InitializeComponent();

            if (ukol == null)
            {
                Text = "Přidat úkol";
                btnOk.Text = "Přidat";
            }
            else
            {
                Text = "Upravit úkol";
                btnOk.Text = "Uložit";
            }

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

            // upravujeme existující úkol
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

                // progres
                tbProgress.Value = ukol.Progress;
                lblProgress.Text = ukol.Progress + "%";

                // označení štítků
                for (int i = 0; i < chlbStitky.Items.Count; i++)
                {
                    var label = (Stitek)chlbStitky.Items[i];
                    chlbStitky.SetItemChecked(i, ukol.StitekId.Contains(label.Id));
                }

                chbProgressBar.Checked = ukol.ZobrazitProgressBar;
                chbProcenta.Checked = ukol.ZobrazitProcenta;
            }
        }

        private void btnOk_Click(object sender, EventArgs e)
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
            Ukol.Progress = tbProgress.Value;
            Ukol.ZobrazitProgressBar = chbProgressBar.Checked;
            Ukol.ZobrazitProcenta = chbProcenta.Checked;

            // uživatel
            if (cmbUzivatel.SelectedItem != null)
                Ukol.UzivatelId = (int?)cmbUzivatel.SelectedValue;
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
            if (string.IsNullOrWhiteSpace(txtNovyUzivatel.Text))
                return;

            var user = new Uzivatel
            {
                Id = _uzivatele.Any()
                    ? _uzivatele.Max(u => u.Id) + 1
                    : 1,

                Jmeno = txtNovyUzivatel.Text
            };

            _uzivatele.Add(user);

            cmbUzivatel.DataSource = null;
            cmbUzivatel.DataSource = _uzivatele;
            cmbUzivatel.DisplayMember = "Jmeno";
            cmbUzivatel.ValueMember = "Id";

            txtNovyUzivatel.Clear();
        }

        private void btnPridatLabel_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNovyStitek.Text))
                return;

            var label = new Stitek
            {
                Id = _stitky.Any()
                    ? _stitky.Max(l => l.Id) + 1
                    : 1,

                Nazev = txtNovyStitek.Text
            };

            _stitky.Add(label);

            chlbStitky.Items.Clear();

            foreach (var l in _stitky)
            {
                chlbStitky.Items.Add(l);
            }

            chlbStitky.DisplayMember = "Nazev";

            txtNovyStitek.Clear();
        }

        private void btnPridatUzivatele_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNovyUzivatel.Text))
                return;

            var user = new Uzivatel
            {
                Id = _uzivatele.Any()
                    ? _uzivatele.Max(u => u.Id) + 1
                    : 1,

                Jmeno = txtNovyUzivatel.Text
            };

            _uzivatele.Add(user);

            cmbUzivatel.DataSource = null;
            cmbUzivatel.DataSource = _uzivatele;
            cmbUzivatel.DisplayMember = "Jmeno";
            cmbUzivatel.ValueMember = "Id";

            cmbUzivatel.SelectedItem = user;

            txtNovyUzivatel.Clear();
        }

        private void btnPridatStitek_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNovyStitek.Text))
                return;

            var label = new Stitek
            {
                Id = _stitky.Any()
                    ? _stitky.Max(l => l.Id) + 1
                    : 1,

                Nazev = txtNovyStitek.Text
            };

            _stitky.Add(label);

            chlbStitky.Items.Clear();

            foreach (var l in _stitky)
            {
                chlbStitky.Items.Add(l);
            }

            chlbStitky.DisplayMember = "Nazev";

            txtNovyStitek.Clear();
        }

        private void dtpDatum_ValueChanged(object sender, EventArgs e)
        {

        }

        // mazání uživatele
        private void btnSmazatUzivatele_Click(object sender, EventArgs e)
        {
            if (cmbUzivatel.SelectedItem == null)
                return;

            var user = (Uzivatel)cmbUzivatel.SelectedItem;

            var result = MessageBox.Show(
                $"Smazat uživatele {user.Jmeno}?",
                "Potvrzení",
                MessageBoxButtons.YesNo);

            if (result != DialogResult.Yes)
                return;

            _uzivatele.Remove(user);

            cmbUzivatel.DataSource = null;
            cmbUzivatel.DataSource = _uzivatele;
            cmbUzivatel.DisplayMember = "Jmeno";
            cmbUzivatel.ValueMember = "Id";
        }

        // mazání štítku
        private void btnSmazatStitek_Click(object sender, EventArgs e)
        {
            if (chlbStitky.SelectedItem == null)
                return;

            var label = (Stitek)chlbStitky.SelectedItem;

            var result = MessageBox.Show(
                $"Smazat štítek {label.Nazev}?",
                "Potvrzení",
                MessageBoxButtons.YesNo);

            if (result != DialogResult.Yes)
                return;

            _stitky.Remove(label);

            chlbStitky.Items.Clear();

            foreach (var l in _stitky)
            {
                chlbStitky.Items.Add(l);
            }

            chlbStitky.DisplayMember = "Nazev";
        }

        private void tbProgress_Scroll(object sender, EventArgs e)
        {
            lblProgress.Text = tbProgress.Value + "%";
        }

        private void btnZrusit_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void txtNovyStitek_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
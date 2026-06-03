using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ToDoApp.Data;
using ToDoApp.Entity;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ToDoApp
{
    public partial class FormDetailUkol : Form
    {
        private readonly Ukol _ukol;
        private readonly Ukladani _data;

        public FormDetailUkol(Ukol ukol, Ukladani data)
        {
            InitializeComponent();

            _ukol = ukol;
            _data = data;


            lblNazev.Text = ukol.Nazev;
            lblPopis.Text = ukol.Popis;

            var uzivatel = data.Uzivatele.FirstOrDefault(u => u.Id == ukol.UzivatelId);
            lblUzivatel.Text = uzivatel?.Jmeno ?? "-";

            var stitky = data.Stitky.Where(s => ukol.StitekId.Contains(s.Id)).Select(s => s.Nazev);
            lblStitky.Text = string.Join(", ", stitky);

            lblDatum.Text = ukol.DatumSplneni?.ToString("dd. MM. yyyy") ?? "-";

            lblStav.Text = ukol.JeSplneno ? "Splněno" : "Nesplněno";

            lblProgress.Text = ukol.Progress + " %";
        }

        private void btnUpravit_Click(object sender, EventArgs e)
        {
            var form = new FormUpravitUkol(
                _data.Uzivatele,
                _data.Stitky,
                _ukol);

            if (form.ShowDialog() == DialogResult.OK) 
            {
                _data.Ulozit();

                lblNazev.Text = _ukol.Nazev;
                lblPopis.Text = _ukol.Popis;
                lblProgress.Text = _ukol.Progress + " %";
                lblStav.Text = _ukol.JeSplneno ? "Splněno" : "Nesplněno";

                DialogResult = DialogResult.OK;
                Close();
            }
        }

        private void btnSmazat_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show(
                "Opravdu chcete smazat tento úkol?",
                "Potvrzení smazání",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (result != DialogResult.Yes)
                return;

            _data.Ukoly.Remove(_ukol);
            _data.Ulozit();

            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
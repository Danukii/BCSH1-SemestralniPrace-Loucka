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


            _data = Ukladani.Nacist();

            if (_data.Ukoly == null)
                _data.Ukoly = new List<Ukol>();

            _vytvoreniUkolu = new VytvoreniUkolu(_data);

            _bindingUkoly = new BindingList<Ukol>(_data.Ukoly);
            dgvUkoly.DataSource = _bindingUkoly;

            _bindingUkoly.ResetBindings();
        }

        //kliknutí na řádek -> zobrazit detaily
        private void dgvUkoly_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvUkoly.CurrentRow == null)
                return;

            var ukol = (Ukol)dgvUkoly.CurrentRow.DataBoundItem;

            nazevUkolu.Text = ukol.Nazev;
            txtPopisu.Text = ukol.Popis;
            chbSplneno.Checked = ukol.JeSplneno;

            if (ukol.DatumSplneni.HasValue)
                dtpDatumSplneni.Value = ukol.DatumSplneni.Value;
        }

        //přidání úkolu (spojení na UI)
        private void btnPridat_Click(object sender, EventArgs e)
        {

            var ukol = new Ukol
            {
                Nazev = nazevUkolu.Text,
                Popis = popis.Text,
                JeSplneno = chbSplneno.Checked,
                DatumSplneni = dtpDatumSplneni.Value

            };

            _vytvoreniUkolu.PridatUkol(ukol);

            _bindingUkoly.ResetBindings();
        }

        //Smazání úkolu
        private void btnSmazat_Click(object sender, EventArgs e)
        {
            if (dgvUkoly.CurrentRow == null)
                return;

            var ukol = (Ukol)dgvUkoly.CurrentRow.DataBoundItem;

            _vytvoreniUkolu.SmazatUkol(ukol.Id);
            _bindingUkoly.Remove(ukol);
        }

        //Upravení úkolu
        private void btnUpravit_Click(object sender, EventArgs e)
        {
            if (dgvUkoly.CurrentRow == null)
                return;

            var ukol = (Ukol)dgvUkoly.CurrentRow.DataBoundItem;

            ukol.Nazev = nazevUkolu.Text;
            ukol.Popis = popis.Text;
            ukol.DatumSplneni = dtpDatumSplneni.Value;
            ukol.JeSplneno = dtpDatumSplneni.Checked;

            _data.Ulozit();
            _bindingUkoly.ResetBindings();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

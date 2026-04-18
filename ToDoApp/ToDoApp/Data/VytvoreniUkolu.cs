using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using ToDoApp.Entity;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;

namespace ToDoApp.Data
{
    internal class VytvoreniUkolu
    {
        private Ukladani _data;

        public VytvoreniUkolu(Ukladani data)
        {
            _data = data;
        }

        public void PridatUkol(Ukol ukol)
        {
            ukol.Id = _data.Ukoly.Any() ? _data.Ukoly.Max(t => t.Id) + 1 : 1;
            ukol.Vytvoreno = DateTime.Now;
            _data.Ukoly.Add(ukol);
            _data.Ulozit();
        }

        public void SmazatUkol(int id)
        {
            var ukol = _data.Ukoly.FirstOrDefault(t => t.Id == id);
            if (ukol != null)
            {
                _data.Ukoly.Remove(ukol);
                _data.Ulozit();
            }
        }

        public void PrepnoutNaSplneno(int id)
        {
            var ukol = _data.Ukoly.FirstOrDefault(t => t.Id == id);
            if (ukol != null)
            {
                ukol.JeSplneno = !ukol.JeSplneno;
                _data.Ulozit();
            }
        }

    }
}

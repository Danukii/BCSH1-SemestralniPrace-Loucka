using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace ToDoApp.Entity
{
    internal class Ukol
    {
        public int Id { get; set; }
        public string Nazev { get; set; }
        public string Popis { get; set; }
        public DateTime Vytvoreno { get; set; }
        public DateTime? DatumSplneni { get; set; }
        public bool JeSplneno { get; set; }

        public int? UzivatelId { get; set; }
        public List<int> LabelIds { get; set; } = new();
    }
}

using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace ToDoApp.Entity
{
    public class Ukol
    {
        public int Id { get; set; }
        public string Nazev { get; set; }
        public string Popis { get; set; }
        public DateTime Vytvoreno { get; set; }
        public DateTime? DatumSplneni { get; set; }
        public bool JeSplneno { get; set; }
        public string Stav { get; set; } // "hotovo", "nehotovo"
        public int Progress { get; set; } // 0-100
        public bool ZobrazitProgressBar { get; set; } = true;
        public bool ZobrazitProcenta { get; set; } = true;

        public int? UzivatelId { get; set; }
        public List<int> StitekId { get; set; } = new();
    }
}

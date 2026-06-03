using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using ToDoApp.Entity;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;

namespace ToDoApp.Data
{
    public class Ukladani
    {
        private const string FilePath = "data.json";

        public List<Ukol> Ukoly { get; set; } = new();
        public List<Uzivatel> Uzivatele { get; set; } = new();
        public List<Stitek> Stitky { get; set; } = new();
        public bool PrvniSpusteni { get; set; } = true;

        public void Ulozit()
        {
            var data = JsonSerializer.Serialize(this, new JsonSerializerOptions
            {
                WriteIndented = true
            });
            File.WriteAllText(FilePath, data);
        }

        public static Ukladani Nacist()
        {
            if (!File.Exists(FilePath))
                return new Ukladani();

            var json = File.ReadAllText(FilePath);
            var data = JsonSerializer.Deserialize<Ukladani>(json);

            if (data == null)
                return new Ukladani();

            data.Ukoly ??= new List<Ukol>();
            data.Uzivatele ??= new List<Uzivatel>();
            data.Stitky ??= new List<Stitek>();

            return data;
        }

    }
}

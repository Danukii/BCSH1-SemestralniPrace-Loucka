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
    internal class Ukladani
    {
        private const string FilePath = "data.json";

        public List<Ukol> Ukoly { get; set; } = new();
        public List<Uzivatel> Uzivatele { get; set; } = new();
        public List<Entity.Label> Labely { get; set; } = new();

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
            data.Labely ??= new List<Entity.Label>();

            return data;
        }

    }
}

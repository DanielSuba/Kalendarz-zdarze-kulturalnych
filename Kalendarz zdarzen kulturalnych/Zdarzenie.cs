using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kalendarz_zdarzen_kulturalnych
{
    public class Zdarzenie
    {
        private static int _nextId = 1;

        public int Id { get; private set; }
        public string Title { get; set; }
        public DateTime Date { get; set; }
        public string TimeStart { get; set; }
        public string TimeEnd { get; set; }
        public string Location { get; set; }
        public string Type { get; set; }
        public decimal Cost { get; set; }
        public string Description { get; set; }

        public List<string> Tags { get; set; }

        public Zdarzenie()
        {
            Id = _nextId++;
            Tags = new List<string>();
        }

        // 👇 Helper property ONLY for DataGridView
        public string DateTimeDisplay =>
            $"{Date:yyyy-MM-dd} {TimeStart}–{TimeEnd}";
    }
}

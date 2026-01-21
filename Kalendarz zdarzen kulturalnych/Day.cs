using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Kalendarz_zdarzen_kulturalnych
{
    public partial class Day : Form
    {
        private Zdarzenie currentEvent;
        private List<Zdarzenie> events;
        private Form1 parentForm;

        public Day(Zdarzenie ev, List<Zdarzenie> events, Form1 parent)
        {
            InitializeComponent();

            currentEvent = ev;
            this.events = events;
            parentForm = parent;

            LoadEvent();
        }

        // //////////////////////////////// Exsport day txt
        private void Export_day_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog
            {
                Filter = "Text files (*.txt)|*.txt",
                FileName = $"Event_{currentEvent.Date:yyyy-MM-dd}_{currentEvent.Title}.txt"
            };

            if (sfd.ShowDialog() != DialogResult.OK)
                return;

            using (StreamWriter sw = new StreamWriter(sfd.FileName))
            {
                sw.WriteLine("Event details");
                sw.WriteLine(new string('-', 40));

                sw.WriteLine($"Title: {currentEvent.Title}");
                sw.WriteLine($"Date: {currentEvent.Date:yyyy-MM-dd}");
                sw.WriteLine($"Time: {currentEvent.TimeStart} - {currentEvent.TimeEnd}");
                sw.WriteLine($"Location: {currentEvent.Location}");
                sw.WriteLine($"Type: {currentEvent.Type}");
                sw.WriteLine($"Cost: {currentEvent.Cost}");
                sw.WriteLine($"Tags: {string.Join(", ", currentEvent.Tags)}");
                sw.WriteLine();
                sw.WriteLine("Description:");
                sw.WriteLine(currentEvent.Description);
            }

            MessageBox.Show("Event exported successfully.");
        }
        // //////////////////////////////// Exsport day txt
        private void Edit_Event_Click(object sender, EventArgs e)
        {

        }
        // //////////////////////////////// Delete event
        private void Delete_Event_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show(
            "Are you sure you want to delete this event?",
            "Confirm delete",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Warning
            );

            if (result != DialogResult.Yes)
                return;

            events.Remove(currentEvent);
            parentForm.RefreshGrid();

            this.Close();
        }
        // //////////////////////////////// Delete event

        // //////////////////////////////// Ladowanie danych
        private void LoadEvent()
        {
            Title_texbox.Text = currentEvent.Title;
            Data_texbox.Text = currentEvent.Date.ToString("yyyy-MM-dd");
            Time_texbox.Text = $"{currentEvent.TimeStart} - {currentEvent.TimeEnd}";
            Location_texbox.Text = currentEvent.Location;
            Type_texbox.Text = currentEvent.Type;
            Cost_texbox.Text = currentEvent.Cost.ToString();
            Tags_texbox.Text = string.Join(", ", currentEvent.Tags);
            Description_texbox.Text = currentEvent.Description;
        }
        // //////////////////////////////// Ladowanie danych
        private void Title_texbox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

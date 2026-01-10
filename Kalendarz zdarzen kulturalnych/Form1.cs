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
    public partial class Form1 : Form
    {
        private List<Zdarzenie> events = new List<Zdarzenie>();
        public bool Event_Up=true;
        public Form1()
        {
            InitializeComponent();
            this.KeyPreview = true;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            textBox6.Text = "YYYY/MM/DD";
            textBox6.ForeColor = Color.Gray;
            textBox7.Text = "YYYY/MM/DD";
            textBox7.ForeColor = Color.Gray;
            SwitchEvent();
            dgvEvents.AutoGenerateColumns = false;

            dgvEvents.Columns.Add(new DataGridViewTextBoxColumn()
            {
                HeaderText = "Title",
                DataPropertyName = "Title"
            });

            dgvEvents.Columns.Add(new DataGridViewTextBoxColumn()
            {
                HeaderText = "Date & Time",
                DataPropertyName = "DateTimeDisplay",
                Width = 180
            });

            dgvEvents.Columns.Add(new DataGridViewTextBoxColumn()
            {
                HeaderText = "Location",
                DataPropertyName = "Location"
            });

            dgvEvents.Columns.Add(new DataGridViewTextBoxColumn()
            {
                HeaderText = "Type",
                DataPropertyName = "Type"
            });

            dgvEvents.Columns.Add(new DataGridViewTextBoxColumn()
            {
                HeaderText = "Cost",
                DataPropertyName = "Cost"
            });
            dgvEvents.EnableHeadersVisualStyles = false;

            dgvEvents.ColumnHeadersDefaultCellStyle.BackColor = Color.LightGray;
            dgvEvents.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;
            dgvEvents.ColumnHeadersDefaultCellStyle.Font =
                new Font("Segoe UI", 10, FontStyle.Bold);

            LoadDataOnStartup();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void textBox6_Enter(object sender, EventArgs e)
        {
            if (textBox6.Text == "YYYY/MM/DD")
            {
                textBox6.Text = "";
                textBox6.ForeColor = Color.Black;
            }
        }
        private void textBox6_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox6.Text))
            {
                textBox6.Text = "YYYY/MM/DD";
                textBox6.ForeColor = Color.Gray;
            }
        }

        private void textBox7_Enter(object sender, EventArgs e)
        {
            if (textBox7.Text == "YYYY/MM/DD")
            {
                textBox7.Text = "";
                textBox7.ForeColor = Color.Black;
            }
        }

        // ********************************************************** CSV **********************************************************

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == (Keys.Control | Keys.S))
            {
                SaveToCsv("data.csv");
                MessageBox.Show("Data saved successfully.");
                return true;
            }

            if (keyData == (Keys.Control | Keys.E))
            {
                LoadFromCsvWithBackup();
                return true;
            }

            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void SaveToCsv(string fileName)
        {
            using (StreamWriter sw = new StreamWriter(fileName))
            {
                sw.WriteLine("Id;Title;Date;TimeStart;TimeEnd;Location;Type;Cost;Description;Tags");

                foreach (var e in events)
                {
                    string tags = string.Join(",", e.Tags);

                    sw.WriteLine(
                        $"{e.Id};{e.Title};{e.Date:yyyy-MM-dd};{e.TimeStart};{e.TimeEnd};" +
                        $"{e.Location};{e.Type};{e.Cost};{e.Description};{tags}"
                    );
                }
            }
        }

        private string GetNextBackupFileName()
        {
            int i = 1;
            while (File.Exists($"backup{i}.csv"))
                i++;

            return $"backup{i}.csv";
        }

        private void LoadFromCsvWithBackup()
        {
            OpenFileDialog ofd = new OpenFileDialog
            {
                Filter = "CSV files (*.csv)|*.csv",
                Title = "Select CSV file"
            };

            if (ofd.ShowDialog() != DialogResult.OK)
                return;

            // Backup existing data
            if (events.Count > 0)
            {
                string backupName = GetNextBackupFileName();
                SaveToCsv(backupName);
            }

            LoadFromCsv(ofd.FileName);
            RefreshGrid();
        }

        private void LoadFromCsv(string fileName)
        {
            events.Clear();

            var lines = File.ReadAllLines(fileName).Skip(1); // skip header

            foreach (var line in lines)
            {
                var parts = line.Split(';');

                var ev = new Zdarzenie
                {
                    Title = parts[1],
                    Date = DateTime.Parse(parts[2]),
                    TimeStart = parts[3],
                    TimeEnd = parts[4],
                    Location = parts[5],
                    Type = parts[6],
                    Cost = decimal.Parse(parts[7]),
                    Description = parts[8],
                    Tags = parts[9]
                        .Split(',')
                        .Select(t => t.Trim())
                        .Where(t => t.Length > 0)
                        .ToList()
                };

                events.Add(ev);
            }
        }

        private void LoadDataOnStartup()
        {
            string fileName = "data.csv";

            if (!File.Exists(fileName))
                return;

            try
            {
                LoadFromCsv(fileName);
                RefreshGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Failed to load data.csv\n\n" + ex.Message,
                    "Load Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }
        private void EksportCal_Click(object sender, EventArgs e)
        {
            SaveToCsv("data.csv");
            MessageBox.Show("Data saved successfully.");
        }

        // ********************************************************** CSV **********************************************************

        private void textBox7_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox7.Text))
            {
                textBox7.Text = "YYYY/MM/DD";
                textBox7.ForeColor = Color.Gray;
            }
        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void Upcoming_Events_Click(object sender, EventArgs e)
        {
            Event_Up = true;
            SwitchEvent();
        }

        private void Past_Events_Click(object sender, EventArgs e)
        {
            Event_Up = false;
            SwitchEvent();
        }
        private void SwitchEvent()
        {
            if (Event_Up==true)
            {
                Upcoming_Events.BackColor = Color.WhiteSmoke;
                Past_Events.BackColor = Color.DodgerBlue;
                Upcoming_Events.ForeColor = Color.Black ;
                Past_Events.ForeColor = Color.White;
                Upcoming_Events.Enabled = false;
                Past_Events.Enabled = true;
            }
            else
            {
                Upcoming_Events.BackColor = Color.DodgerBlue;
                Past_Events.BackColor = Color.WhiteSmoke;
                Upcoming_Events.ForeColor = Color.White;
                Past_Events.ForeColor = Color.Black;
                Past_Events.Enabled = false;
                Upcoming_Events.Enabled = true;
            }
        }

        private void Import_Click(object sender, EventArgs e)
        {
            LoadFromCsvWithBackup();
        }

        private void Add_event_Click(object sender, EventArgs e)
        {
            using (Form2 f2 = new Form2())
            {
                if (f2.ShowDialog() == DialogResult.OK)
                {
                    events.Add(f2.NewEvent);
                    RefreshGrid();
                }
            }
        }
        public void RefreshGrid()
        {
            dgvEvents.DataSource = null;
            dgvEvents.DataSource = events;
        }
        private void Check_day_Click(object sender, EventArgs e)
        {
            if (dgvEvents.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select an event first.");
                return;
            }

            var selectedEvent =
                dgvEvents.SelectedRows[0].DataBoundItem as Zdarzenie;

            Day dayForm = new Day(selectedEvent, events, this);
            dayForm.Show();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {

        }

        private void Filt_Cost_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void Filt_Title_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgvEvents_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        // ********************************************************** Delete Event **********************************************************

        private void Delete_Event_Click(object sender, EventArgs e)
        {
            if (dgvEvents.SelectedRows.Count > 0)
            {
                Zdarzenie selected = dgvEvents.SelectedRows[0].DataBoundItem as Zdarzenie;
                events.Remove(selected);
                RefreshGrid();
            }
        }

        // ********************************************************** Delete Event **********************************************************

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {

        }

        

        // ********************************************************** Export event TXT **********************************************************

        private void Export_day_Click(object sender, EventArgs e)
        {
            if (dgvEvents.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select an event first.");
                return;
            }

            var ev =
                dgvEvents.SelectedRows[0].DataBoundItem as Zdarzenie;

            SaveFileDialog sfd = new SaveFileDialog
            {
                Filter = "Text files (*.txt)|*.txt",
                FileName = $"Event_{ev.Date:yyyy-MM-dd}.txt"
            };

            if (sfd.ShowDialog() != DialogResult.OK)
                return;

            using (StreamWriter sw = new StreamWriter(sfd.FileName))
            {
                sw.WriteLine("Event details");
                sw.WriteLine(new string('-', 40));

                sw.WriteLine($"Title: {ev.Title}");
                sw.WriteLine($"Date: {ev.Date:yyyy-MM-dd}");
                sw.WriteLine($"Time: {ev.TimeStart} - {ev.TimeEnd}");
                sw.WriteLine($"Location: {ev.Location}");
                sw.WriteLine($"Type: {ev.Type}");
                sw.WriteLine($"Cost: {ev.Cost}");
                sw.WriteLine($"Description: {ev.Description}");
                sw.WriteLine($"Tags: {string.Join(", ", ev.Tags)}");
            }
        }

        private void Edit_Event_Click(object sender, EventArgs e)
        {
            if (dgvEvents.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select an event first.");
                return;
            }

            var selectedEvent =
                dgvEvents.SelectedRows[0].DataBoundItem as Zdarzenie;

            using (Form2 f2 = new Form2(selectedEvent))
            {
                if (f2.ShowDialog() == DialogResult.OK)
                {
                    RefreshGrid();
                }
            }
        }

        // ********************************************************** Export event TXT **********************************************************

    }
}

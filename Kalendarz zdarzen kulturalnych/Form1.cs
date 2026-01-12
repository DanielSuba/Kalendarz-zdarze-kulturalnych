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
        private List<Zdarzenie> events = new List<Zdarzenie>(); // Origin
        public bool Event_Up=true;

        private List<Zdarzenie> allEvents = new List<Zdarzenie>(); // Filtrowane
        private List<Zdarzenie> currentView = new List<Zdarzenie>(); //Sortwanie

        private int currentSortColumnIndex = -1;
        private bool sortAscending = true;

        public Form1()
        {
            InitializeComponent();
            this.KeyPreview = true;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            DateStart.Text = "YYYY/MM/DD";
            DateStart.ForeColor = Color.Gray;
            DateEnd.Text = "YYYY/MM/DD";
            DateEnd.ForeColor = Color.Gray;
            SwitchEvent();
            dgvEvents.AutoGenerateColumns = false;

            // Generacja columnow

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

            // Generacja columnow
            // Sortowanie
            foreach (DataGridViewColumn col in dgvEvents.Columns)
            {
                col.SortMode = DataGridViewColumnSortMode.Programmatic;
            }
            // Sortowanie
            //currentView = allEvents.ToList();
            dgvEvents.EnableHeadersVisualStyles = false;

            dgvEvents.ColumnHeadersDefaultCellStyle.BackColor = Color.LightGray;
            dgvEvents.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;
            dgvEvents.ColumnHeadersDefaultCellStyle.Font =
                new Font("Segoe UI", 10, FontStyle.Bold);

            LoadDataOnStartup();

            monthCalendar1.Visible = false;
            monthCalendar2.Visible = false;

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void textBox6_Enter(object sender, EventArgs e)
        {
            monthCalendar1.Location = new Point(DateStart.Left, DateStart.Bottom);
            monthCalendar1.Visible = true;
            monthCalendar1.BringToFront();

            if (DateStart.Text == "YYYY/MM/DD")
            {
                DateStart.Text = "";
                DateStart.ForeColor = Color.Black;
            }
        }
        private void textBox6_Leave(object sender, EventArgs e)
        {
            monthCalendar2.Location = new Point(DateEnd.Left, DateEnd.Bottom);
            monthCalendar2.Visible = true;
            monthCalendar2.BringToFront();

            if (DateEnd.Text == "YYYY/MM/DD")
            {
                DateEnd.Text = "";
                DateEnd.ForeColor = Color.Black;
            }
        }

        private void textBox7_Enter(object sender, EventArgs e)
        {
            if (DateEnd.Text == "YYYY/MM/DD")
            {
                DateEnd.Text = "";
                DateEnd.ForeColor = Color.Black;
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
            RefreshFilterOptions();
            ClearSortGlyphs();
            UpdateRowColors();
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
                allEvents = events.ToList();
                currentView = allEvents.ToList();
                RefreshGrid();
                RefreshFilterOptions();
                ClearSortGlyphs();
                UpdateRowColors();
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
            if (string.IsNullOrWhiteSpace(DateEnd.Text))
            {
                DateEnd.Text = "YYYY/MM/DD";
                DateEnd.ForeColor = Color.Gray;
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
                    RefreshFilterOptions();
                    ClearSortGlyphs();
                    UpdateRowColors();
                }
            }
        }

        /// <summary>
        /// ////////////////////////////////Update/////////////////////////////////
        /// </summary>
        public void RefreshGrid()
        {
            allEvents = events.ToList();
            dgvEvents.DataSource = null;
            dgvEvents.DataSource = events;
            currentView = allEvents.ToList();
        }

        /// <summary>
        /// ////////////////////////////////Update/////////////////////////////////
        /// </summary>
 
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
                RefreshFilterOptions();
                //ClearSortGlyphs();
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
                    RefreshFilterOptions();
                    ClearSortGlyphs();
                    UpdateRowColors();
                }
            }
        }

        // ********************************************************** Export event TXT **********************************************************

        // ********************************************************** Filters **********************************************************
        private void DateStart_TextChanged(object sender, EventArgs e)
        {
            monthCalendar1.Visible = true;
            monthCalendar1.BringToFront();
        }

        private void DateEnd_TextChanged(object sender, EventArgs e)
        {
            monthCalendar2.Visible = true;
            monthCalendar2.BringToFront();
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

        private void monthCalendar1_DateSelected(object sender, DateRangeEventArgs e)
        {
            DateStart.Text = e.Start.ToString("yyyy-MM-dd");
            monthCalendar1.Visible = false;
        }

        private void monthCalendar2_DateSelected(object sender, DateRangeEventArgs e)
        {
            DateEnd.Text = e.Start.ToString("yyyy-MM-dd");
            monthCalendar2.Visible = false;
        }

        private void ApplyDateFilter()
        {
            DateTime from, to;
            bool hasFrom = DateTime.TryParse(DateStart.Text, out from);
            bool hasTo = DateTime.TryParse(DateEnd.Text, out to);

            var selectedTypes = clbType.CheckedItems.Cast<string>().ToList();
            var selectedLocations = clbLocation.CheckedItems.Cast<string>().ToList();
            var selectedTags = clbTags.CheckedItems.Cast<string>().ToList();

            var filtered = allEvents.AsEnumerable();

            // Date filter
            if (hasFrom)
                filtered = filtered.Where(e => e.Date.Date >= from.Date);

            if (hasTo)
                filtered = filtered.Where(e => e.Date.Date <= to.Date);

            // Type filter
            if (selectedTypes.Any())
                filtered = filtered.Where(e => selectedTypes.Contains(e.Type));

            // Location filter
            if (selectedLocations.Any())
                filtered = filtered.Where(e => selectedLocations.Contains(e.Location));

            // Tags filter
            if (selectedTags.Any())
                filtered = filtered.Where(e =>
                    e.Tags.Any(tag => selectedTags.Contains(tag)));

            dgvEvents.DataSource = null;
            dgvEvents.DataSource = filtered.ToList();
            currentView = filtered.ToList();
        }


        private void Form1_Click(object sender, EventArgs e)
        {
            monthCalendar1.Visible = false;
            monthCalendar2.Visible = false;
        }
        
        private void Apply_Filters_Click(object sender, EventArgs e)
        {
            ApplyDateFilter();
            UpdateRowColors();
        }

        private void Clear_Filters_Click(object sender, EventArgs e)
        {
            DateStart.Clear();
            DateEnd.Clear();

            for (int i = 0; i < clbType.Items.Count; i++)
                clbType.SetItemChecked(i, false);

            for (int i = 0; i < clbLocation.Items.Count; i++)
                clbLocation.SetItemChecked(i, false);

            for (int i = 0; i < clbTags.Items.Count; i++)
                clbTags.SetItemChecked(i, false);

            dgvEvents.DataSource = null;
            dgvEvents.DataSource = allEvents;

            currentView = allEvents.ToList();
            ClearSortGlyphs();
            UpdateRowColors();
            
            DateStart.Text = "YYYY/MM/DD";
            DateStart.ForeColor = Color.Gray;
            DateEnd.Text = "YYYY/MM/DD";
            DateEnd.ForeColor = Color.Gray;
            monthCalendar1.Visible = false;
            monthCalendar2.Visible = false;
        }

        private void monthCalendar1_Leave(object sender, EventArgs e)
        {
            monthCalendar1.Visible = false;
        }

        private void monthCalendar2_Leave(object sender, EventArgs e)
        {
            monthCalendar2.Visible = false;
        }

        private void DateStart_Click(object sender, EventArgs e)
        {
            monthCalendar1.Visible = true;
            monthCalendar2.Visible = false;
        }

        private void DateEnd_Click(object sender, EventArgs e)
        {
            monthCalendar1.Visible = false;
            monthCalendar2.Visible = true;
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            if (!DateStart.Bounds.Contains(e.Location) && !monthCalendar1.Bounds.Contains(e.Location))
            {
                monthCalendar1.Visible = false;
            }

            if (!DateEnd.Bounds.Contains(e.Location) && !monthCalendar2.Bounds.Contains(e.Location))
            {
                monthCalendar2.Visible = false;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            monthCalendar1.Visible = false;
            monthCalendar2.Visible = false;
        }

        private void RefreshFilterOptions()
        {
            clbType.Items.Clear();
            clbLocation.Items.Clear();
            clbTags.Items.Clear();

            var types = allEvents
                .Select(e => e.Type)
                .Where(t => !string.IsNullOrWhiteSpace(t))
                .Distinct()
                .OrderBy(t => t);

            var locations = allEvents
                .Select(e => e.Location)
                .Where(l => !string.IsNullOrWhiteSpace(l))
                .Distinct()
                .OrderBy(l => l);

            var tags = allEvents
                .SelectMany(e => e.Tags)
                .Where(t => !string.IsNullOrWhiteSpace(t))
                .Distinct()
                .OrderBy(t => t);

            foreach (var t in types)
                clbType.Items.Add(t);

            foreach (var l in locations)
                clbLocation.Items.Add(l);

            foreach (var tag in tags)
                clbTags.Items.Add(tag);
        }


        // ********************************************************** Filters **********************************************************
        // ********************************************************** Sort **********************************************************

        private void dgvEvents_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (currentView == null || currentView.Count == 0)
                return;

            if (currentSortColumnIndex == e.ColumnIndex)
                sortAscending = !sortAscending;
            else
            {
                currentSortColumnIndex = e.ColumnIndex;
                sortAscending = true;
            }

            ApplySorting();
        }
        private void ApplySorting()
        {
            if (currentView == null || currentView.Count == 0)
                return;

            if (currentSortColumnIndex < 0)
                return;

            string dataProperty =
                dgvEvents.Columns[currentSortColumnIndex].DataPropertyName;

            Func<Zdarzenie, object> keySelector = null;

            if (dataProperty == "Title")
                keySelector = e => e.Title;
            else if (dataProperty == "DateTimeDisplay")
                keySelector = e => e.Date;
            else if (dataProperty == "Location")
                keySelector = e => e.Location;
            else if (dataProperty == "Type")
                keySelector = e => e.Type;
            else if (dataProperty == "Cost")
                keySelector = e => e.Cost;

            if (keySelector == null)
                return;

            currentView = sortAscending
                ? currentView.OrderBy(keySelector).ToList()
                : currentView.OrderByDescending(keySelector).ToList();

            dgvEvents.DataSource = null;
            dgvEvents.DataSource = currentView;

            foreach (DataGridViewColumn col in dgvEvents.Columns)
                col.HeaderCell.SortGlyphDirection = SortOrder.None;

            dgvEvents.Columns[currentSortColumnIndex]
                .HeaderCell.SortGlyphDirection =
                    sortAscending ? SortOrder.Ascending : SortOrder.Descending;

            UpdateRowColors();
        }
        private void ClearSortGlyphs()
        {
            foreach (DataGridViewColumn col in dgvEvents.Columns)
                col.HeaderCell.SortGlyphDirection = SortOrder.None;
        }

        // ********************************************************** Sort **********************************************************

        // ********************************************************** Date colors **********************************************************
        private DateTime GetEventEndDateTime(Zdarzenie e)
        {
            TimeSpan end;
            TimeSpan.TryParse(e.TimeEnd, out end);
            return e.Date.Date.Add(end);
        }

        private bool TimesOverlap(Zdarzenie a, Zdarzenie b)
        {
            TimeSpan aStart, aEnd, bStart, bEnd;

            TimeSpan.TryParse(a.TimeStart, out aStart);
            TimeSpan.TryParse(a.TimeEnd, out aEnd);
            TimeSpan.TryParse(b.TimeStart, out bStart);
            TimeSpan.TryParse(b.TimeEnd, out bEnd);

            return aStart < bEnd && bStart < aEnd;
        }

        private void UpdateRowColors()
        {
            if (dgvEvents.Rows.Count == 0)
                return;

            var view = dgvEvents.DataSource as List<Zdarzenie>;
            if (view == null)
                return;

            DateTime now = DateTime.Now;

            foreach (DataGridViewRow row in dgvEvents.Rows)
                row.DefaultCellStyle.ForeColor = Color.Black;

            for (int i = 0; i < view.Count; i++)
            {
                if (GetEventEndDateTime(view[i]) < now)
                {
                    dgvEvents.Rows[i].DefaultCellStyle.ForeColor = Color.Red;
                }
            }

            for (int i = 0; i < view.Count; i++)
            {
                if (GetEventEndDateTime(view[i]) < now)
                    continue;

                for (int j = i + 1; j < view.Count; j++)
                {
                    if (GetEventEndDateTime(view[j]) < now)
                        continue;

                    if (view[i].Date.Date != view[j].Date.Date)
                        continue;

                    if (TimesOverlap(view[i], view[j]))
                    {
                        if (dgvEvents.Rows[i].DefaultCellStyle.ForeColor != Color.Red)
                            dgvEvents.Rows[i].DefaultCellStyle.ForeColor = Color.Goldenrod;

                        if (dgvEvents.Rows[j].DefaultCellStyle.ForeColor != Color.Red)
                            dgvEvents.Rows[j].DefaultCellStyle.ForeColor = Color.Goldenrod;
                    }
                }
            }
        }

        // ********************************************************** Date colors **********************************************************
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kalendarz_zdarzen_kulturalnych
{
    public partial class Form2 : Form
    {
        bool isDeleting = false;
        public Zdarzenie NewEvent { get; private set; }

        private Zdarzenie editingEvent = null;

        public Form2()
        {
            InitializeComponent();
            Newevent.Enabled = false;

            Event_title.TextChanged += (s, e) => ValidateForm();
            textBox7.TextChanged += (s, e) => ValidateForm();
            txtTime.TextChanged += (s, e) => ValidateForm();
            txtTimeEnd.TextChanged += (s, e) => ValidateForm();
            txt_Location.TextChanged += (s, e) => ValidateForm();
            txt_Type.TextChanged += (s, e) => ValidateForm();
            txt_Cost.TextChanged += (s, e) => ValidateForm();
            Description.TextChanged += (s, e) => ValidateForm();
        }
  
        private void Newevent_Click(object sender, EventArgs e)
        {
            if (editingEvent == null)
            {
                // ADD MODE
                NewEvent = new Zdarzenie();
                FillEvent(NewEvent);
            }
            else
            {
                // EDIT MODE
                FillEvent(editingEvent);
            }

            DialogResult = DialogResult.OK;
            Close();
        }

        private void textBox7_Click(object sender, EventArgs e)
        {
            monthCalendar1.Visible = true;
            monthCalendar1.BringToFront();
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            textBox7.Text = monthCalendar1.SelectionStart.ToString("d");
            monthCalendar1.Visible = false;
        }

        private void monthCalendar1_Leave(object sender, EventArgs e)
        {
            monthCalendar1.Visible = false;
        }

        private void txtTime_TextChanged(object sender, EventArgs e)
        {
            if (isDeleting) return;

            string input = txtTime.Text;

            if (input.Length == 2 && !input.Contains(":"))
            {
                txtTime.Text += ":";
                txtTime.SelectionStart = txtTime.Text.Length;
            }

            if (input.Length > 5)
            {
                txtTime.Text = input.Substring(0, 5);
                txtTime.SelectionStart = txtTime.Text.Length;
            }
        }

        private void txtTime_Validating(object sender, CancelEventArgs e)
        {
            string input = txtTime.Text;

            bool isValid = System.Text.RegularExpressions.Regex.IsMatch(input, @"^([01][0-9]|2[0-3]):[0-5][0-9]$");

            if (!isValid && !string.IsNullOrWhiteSpace(input))
            {
                MessageBox.Show("Invalid Time! Please use the 00:00 format (e.g., 14:30).",
                                "Format Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                txtTime.Clear();
            }
        }

        private void txtTime_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTime.Text)) return;

            bool isValid = System.Text.RegularExpressions.Regex.IsMatch(txtTime.Text, @"^([01][0-9]|2[0-3]):[0-5][0-9]$");

            if (!isValid)
            {
                MessageBox.Show("Invalid format! Please use 00:00", "Format Error");
                txtTime.Clear();
                txtTime.Focus();
            }
        }



        private void txtTime_KeyDown(object sender, KeyEventArgs e)
        {
            isDeleting = e.KeyCode == Keys.Back;
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void Description_TextChanged(object sender, EventArgs e)
        {
            var box = sender as RichTextBox;
            if (box == null)
                return;

            if (box.Text.Contains("\n") || box.Text.Contains("\r"))
            {
                int cursorPos = box.SelectionStart;

                box.Text = box.Text.Replace("\r", "").Replace("\n", "");

                box.SelectionStart = Math.Min(cursorPos - 1, box.Text.Length);
            }
        }

        private void txtTimeEnd_TextChanged(object sender, EventArgs e)
        {
            if (isDeleting) return;

            string input = txtTimeEnd.Text;

            if (input.Length == 2 && !input.Contains(":"))
            {
                txtTimeEnd.Text += ":";
                txtTimeEnd.SelectionStart = txtTimeEnd.Text.Length;
            }

            if (input.Length > 5)
            {
                txtTimeEnd.Text = input.Substring(0, 5);
                txtTimeEnd.SelectionStart = txtTimeEnd.Text.Length;
            }
        }

        private void txtTimeEnd_Validating(object sender, CancelEventArgs e)
        {
            string input = txtTimeEnd.Text;

            bool isValid = System.Text.RegularExpressions.Regex.IsMatch(input, @"^([01][0-9]|2[0-3]):[0-5][0-9]$");

            if (!isValid && !string.IsNullOrWhiteSpace(input))
            {
                MessageBox.Show("Invalid Time! Please use the 00:00 format (e.g., 14:30).",
                                "Format Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                txtTimeEnd.Clear();
            }
        }

        private void txtTimeEnd_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTimeEnd.Text)) return;

            bool isValid = System.Text.RegularExpressions.Regex.IsMatch(txtTimeEnd.Text, @"^([01][0-9]|2[0-3]):[0-5][0-9]$");

            if (!isValid)
            {
                MessageBox.Show("Invalid format! Please use 00:00", "Format Error");
                txtTimeEnd.Clear();
                txtTimeEnd.Focus();
            }
        }

        public Form2(Zdarzenie ev) : this()
        {
            editingEvent = ev;
            LoadEventForEdit();
        }

        private void LoadEventForEdit()
        {
            Event_title.Text = editingEvent.Title;
            textBox7.Text = editingEvent.Date.ToString("yyyy-MM-dd");
            txtTime.Text = editingEvent.TimeStart;
            txtTimeEnd.Text = editingEvent.TimeEnd;
            txt_Location.Text = editingEvent.Location;
            txt_Type.Text = editingEvent.Type;
            txt_Cost.Text = editingEvent.Cost.ToString();
            Tagslist.Text = string.Join(", ", editingEvent.Tags);
            Description.Text = editingEvent.Description;
            ValidateForm();
        }

        private void FillEvent(Zdarzenie ev)
        {
            ev.Title = Event_title.Text;
            ev.Date = DateTime.Parse(textBox7.Text);
            ev.TimeStart = txtTime.Text;
            ev.TimeEnd = txtTimeEnd.Text;
            ev.Location = txt_Location.Text;
            ev.Type = txt_Type.Text;
            ev.Cost = decimal.TryParse(txt_Cost.Text, out var c) ? c : 0;
            ev.Description = Description.Text;
            ev.Tags = Tagslist.Text
                .Split(',')
                .Select(t => t.Trim())
                .Where(t => t.Length > 0)
                .ToList();
        }

        private void Back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ValidateForm()
        {
            Newevent.Enabled =
                !string.IsNullOrWhiteSpace(Event_title.Text) &&
                !string.IsNullOrWhiteSpace(textBox7.Text) &&
                !string.IsNullOrWhiteSpace(txtTime.Text) &&
                !string.IsNullOrWhiteSpace(txtTimeEnd.Text) &&
                !string.IsNullOrWhiteSpace(txt_Location.Text) &&
                !string.IsNullOrWhiteSpace(txt_Type.Text) &&
                !string.IsNullOrWhiteSpace(txt_Cost.Text) &&
                !string.IsNullOrWhiteSpace(Description.Text);
        }

        private void txt_Cost_TextChanged(object sender, EventArgs e)
        {
            decimal cost;
            txt_Cost.BackColor = decimal.TryParse(txt_Cost.Text, out cost)
                ? Color.White
                : Color.MistyRose;

            ValidateForm();
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void Description_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;  // blokuje Enter
            }
        }
    }
}

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
        public string EventTitle { get; set; }
        public string EventDate { get; set; }
        public string EventTime { get; set; }
        public string EventLocation { get; set; }
        public string EventType { get; set; }
        public string EventCost { get; set; }

        public Zdarzenie NewEvent { get; private set; }
        public Form2()
        {
            InitializeComponent();
        }

        private void Newevent_Click(object sender, EventArgs e)
        {
            NewEvent = new Zdarzenie()
            {
                Title = Event_title.Text,
                Date = DateTime.Parse(textBox7.Text),
                Time = txtTime.Text,
                Location = txt_Location.Text,
                Type = txt_Type.Text,
                Cost = decimal.TryParse(txt_Cost.Text, out var c) ? c : 0,
                Description = Description.Text
            };

            this.DialogResult = DialogResult.OK;
            this.Close();
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

        }
    }
}

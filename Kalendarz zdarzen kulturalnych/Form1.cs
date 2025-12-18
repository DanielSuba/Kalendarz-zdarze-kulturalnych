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
    public partial class Form1 : Form
    {
        public bool Event_Up=true;
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            textBox6.Text = "YYYY/MM/DD";
            textBox6.ForeColor = Color.Gray;
            textBox7.Text = "YYYY/MM/DD";
            textBox7.ForeColor = Color.Gray;
            SwitchEvent();
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

        }

        private void Add_event_Click(object sender, EventArgs e)
        {
            using (Form2 f2 = new Form2())
            {
                if (f2.ShowDialog() == DialogResult.OK)
                {
                    dgvEvents.Rows.Add(f2.EventTitle, f2.EventDate, f2.EventLocation, f2.EventType, f2.EventCost);
                }
            }
            //Form2 newWindow = new Form2();
            //newWindow.Show();
        }

        private void Check_day_Click(object sender, EventArgs e)
        {
            Day newWindow = new Day();
            newWindow.Show();
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

        private void Delete_Event_Click(object sender, EventArgs e)
        {
            if (dgvEvents.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow row in dgvEvents.SelectedRows)
                {
                    dgvEvents.Rows.Remove(row);
                }
            }
            else
            {
                MessageBox.Show("Please select a full row to delete.");
            }
        }
    }
}

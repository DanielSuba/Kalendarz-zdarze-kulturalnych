
namespace Kalendarz_zdarzen_kulturalnych
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Import = new System.Windows.Forms.Button();
            this.Cultural_Events_Calendar = new System.Windows.Forms.TextBox();
            this.des1 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.Apply_Filters = new System.Windows.Forms.Button();
            this.Clear_Filters = new System.Windows.Forms.Button();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.Upcoming_Events = new System.Windows.Forms.Button();
            this.Past_Events = new System.Windows.Forms.Button();
            this.Add_event = new System.Windows.Forms.Button();
            this.Export_day = new System.Windows.Forms.Button();
            this.Edit_Event = new System.Windows.Forms.Button();
            this.Delete_Event = new System.Windows.Forms.Button();
            this.Check_day = new System.Windows.Forms.Button();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.dgvEvents = new System.Windows.Forms.DataGridView();
            this.EksportCal = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.des1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEvents)).BeginInit();
            this.SuspendLayout();
            // 
            // Import
            // 
            this.Import.BackColor = System.Drawing.Color.DodgerBlue;
            this.Import.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Import.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Import.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Import.ForeColor = System.Drawing.Color.White;
            this.Import.Location = new System.Drawing.Point(247, 103);
            this.Import.Name = "Import";
            this.Import.Size = new System.Drawing.Size(158, 40);
            this.Import.TabIndex = 0;
            this.Import.Text = "Import new calendar";
            this.Import.UseVisualStyleBackColor = false;
            this.Import.Click += new System.EventHandler(this.Import_Click);
            // 
            // Cultural_Events_Calendar
            // 
            this.Cultural_Events_Calendar.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Cultural_Events_Calendar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Cultural_Events_Calendar.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cultural_Events_Calendar.Location = new System.Drawing.Point(12, 31);
            this.Cultural_Events_Calendar.Name = "Cultural_Events_Calendar";
            this.Cultural_Events_Calendar.ReadOnly = true;
            this.Cultural_Events_Calendar.Size = new System.Drawing.Size(1240, 38);
            this.Cultural_Events_Calendar.TabIndex = 1;
            this.Cultural_Events_Calendar.Text = "Cultural Events Calendar";
            this.Cultural_Events_Calendar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Cultural_Events_Calendar.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // des1
            // 
            this.des1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.des1.Location = new System.Drawing.Point(12, 12);
            this.des1.Name = "des1";
            this.des1.Size = new System.Drawing.Size(1240, 74);
            this.des1.TabIndex = 2;
            this.des1.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.Menu;
            this.pictureBox1.Location = new System.Drawing.Point(12, 103);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(220, 566);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.Menu;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(26, 120);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(100, 30);
            this.textBox1.TabIndex = 4;
            this.textBox1.Text = "Filters";
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.Menu;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(26, 172);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(100, 23);
            this.textBox2.TabIndex = 5;
            this.textBox2.Text = "Event type";
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.SystemColors.Menu;
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox3.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(26, 259);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(100, 23);
            this.textBox3.TabIndex = 6;
            this.textBox3.Text = "Data range";
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.SystemColors.Menu;
            this.textBox4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox4.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox4.Location = new System.Drawing.Point(26, 381);
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(100, 23);
            this.textBox4.TabIndex = 7;
            this.textBox4.Text = "Location";
            // 
            // textBox5
            // 
            this.textBox5.BackColor = System.Drawing.SystemColors.Menu;
            this.textBox5.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox5.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox5.Location = new System.Drawing.Point(26, 463);
            this.textBox5.Name = "textBox5";
            this.textBox5.ReadOnly = true;
            this.textBox5.Size = new System.Drawing.Size(100, 23);
            this.textBox5.TabIndex = 8;
            this.textBox5.Text = "Tag";
            // 
            // Apply_Filters
            // 
            this.Apply_Filters.BackColor = System.Drawing.Color.DodgerBlue;
            this.Apply_Filters.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Apply_Filters.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Apply_Filters.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Apply_Filters.ForeColor = System.Drawing.Color.White;
            this.Apply_Filters.Location = new System.Drawing.Point(26, 570);
            this.Apply_Filters.Name = "Apply_Filters";
            this.Apply_Filters.Size = new System.Drawing.Size(192, 40);
            this.Apply_Filters.TabIndex = 9;
            this.Apply_Filters.Text = "Apply Filters";
            this.Apply_Filters.UseVisualStyleBackColor = false;
            // 
            // Clear_Filters
            // 
            this.Clear_Filters.BackColor = System.Drawing.Color.Gainsboro;
            this.Clear_Filters.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Clear_Filters.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Clear_Filters.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Clear_Filters.ForeColor = System.Drawing.Color.Black;
            this.Clear_Filters.Location = new System.Drawing.Point(26, 616);
            this.Clear_Filters.Name = "Clear_Filters";
            this.Clear_Filters.Size = new System.Drawing.Size(192, 40);
            this.Clear_Filters.TabIndex = 10;
            this.Clear_Filters.Text = "Clear All Filters";
            this.Clear_Filters.UseVisualStyleBackColor = false;
            // 
            // textBox6
            // 
            this.textBox6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox6.ForeColor = System.Drawing.Color.Black;
            this.textBox6.Location = new System.Drawing.Point(26, 297);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(125, 26);
            this.textBox6.TabIndex = 11;
            this.textBox6.Enter += new System.EventHandler(this.textBox6_Enter);
            this.textBox6.Leave += new System.EventHandler(this.textBox6_Leave);
            // 
            // textBox7
            // 
            this.textBox7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox7.ForeColor = System.Drawing.Color.Black;
            this.textBox7.Location = new System.Drawing.Point(26, 339);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(125, 26);
            this.textBox7.TabIndex = 12;
            this.textBox7.Enter += new System.EventHandler(this.textBox7_Enter);
            this.textBox7.Leave += new System.EventHandler(this.textBox7_Leave);
            // 
            // textBox8
            // 
            this.textBox8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox8.ForeColor = System.Drawing.Color.Black;
            this.textBox8.Location = new System.Drawing.Point(26, 410);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(192, 26);
            this.textBox8.TabIndex = 13;
            // 
            // textBox9
            // 
            this.textBox9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox9.ForeColor = System.Drawing.Color.Black;
            this.textBox9.Location = new System.Drawing.Point(26, 492);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(192, 26);
            this.textBox9.TabIndex = 14;
            this.textBox9.TextChanged += new System.EventHandler(this.textBox9_TextChanged);
            // 
            // Upcoming_Events
            // 
            this.Upcoming_Events.BackColor = System.Drawing.Color.DodgerBlue;
            this.Upcoming_Events.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Upcoming_Events.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Upcoming_Events.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Upcoming_Events.ForeColor = System.Drawing.Color.White;
            this.Upcoming_Events.Location = new System.Drawing.Point(930, 103);
            this.Upcoming_Events.Name = "Upcoming_Events";
            this.Upcoming_Events.Size = new System.Drawing.Size(158, 40);
            this.Upcoming_Events.TabIndex = 15;
            this.Upcoming_Events.Text = "Upcoming Events";
            this.Upcoming_Events.UseVisualStyleBackColor = false;
            this.Upcoming_Events.Click += new System.EventHandler(this.Upcoming_Events_Click);
            // 
            // Past_Events
            // 
            this.Past_Events.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Past_Events.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Past_Events.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Past_Events.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Past_Events.ForeColor = System.Drawing.Color.Black;
            this.Past_Events.Location = new System.Drawing.Point(1094, 103);
            this.Past_Events.Name = "Past_Events";
            this.Past_Events.Size = new System.Drawing.Size(158, 40);
            this.Past_Events.TabIndex = 16;
            this.Past_Events.Text = "Past Events";
            this.Past_Events.UseVisualStyleBackColor = false;
            this.Past_Events.Click += new System.EventHandler(this.Past_Events_Click);
            // 
            // Add_event
            // 
            this.Add_event.BackColor = System.Drawing.Color.DodgerBlue;
            this.Add_event.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Add_event.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Add_event.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Add_event.ForeColor = System.Drawing.Color.White;
            this.Add_event.Location = new System.Drawing.Point(247, 629);
            this.Add_event.Name = "Add_event";
            this.Add_event.Size = new System.Drawing.Size(158, 40);
            this.Add_event.TabIndex = 17;
            this.Add_event.Text = "Add event";
            this.Add_event.UseVisualStyleBackColor = false;
            this.Add_event.Click += new System.EventHandler(this.Add_event_Click);
            // 
            // Export_day
            // 
            this.Export_day.BackColor = System.Drawing.Color.DodgerBlue;
            this.Export_day.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Export_day.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Export_day.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Export_day.ForeColor = System.Drawing.Color.White;
            this.Export_day.Location = new System.Drawing.Point(1038, 629);
            this.Export_day.Name = "Export_day";
            this.Export_day.Size = new System.Drawing.Size(104, 40);
            this.Export_day.TabIndex = 18;
            this.Export_day.Text = "Export day";
            this.Export_day.UseVisualStyleBackColor = false;
            this.Export_day.Click += new System.EventHandler(this.Export_day_Click);
            // 
            // Edit_Event
            // 
            this.Edit_Event.BackColor = System.Drawing.Color.DodgerBlue;
            this.Edit_Event.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Edit_Event.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Edit_Event.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Edit_Event.ForeColor = System.Drawing.Color.White;
            this.Edit_Event.Location = new System.Drawing.Point(928, 629);
            this.Edit_Event.Name = "Edit_Event";
            this.Edit_Event.Size = new System.Drawing.Size(104, 40);
            this.Edit_Event.TabIndex = 19;
            this.Edit_Event.Text = "Edit Event";
            this.Edit_Event.UseVisualStyleBackColor = false;
            this.Edit_Event.Click += new System.EventHandler(this.Edit_Event_Click);
            // 
            // Delete_Event
            // 
            this.Delete_Event.BackColor = System.Drawing.Color.DodgerBlue;
            this.Delete_Event.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Delete_Event.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Delete_Event.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Delete_Event.ForeColor = System.Drawing.Color.White;
            this.Delete_Event.Location = new System.Drawing.Point(818, 629);
            this.Delete_Event.Name = "Delete_Event";
            this.Delete_Event.Size = new System.Drawing.Size(104, 40);
            this.Delete_Event.TabIndex = 20;
            this.Delete_Event.Text = "Delete Event";
            this.Delete_Event.UseVisualStyleBackColor = false;
            this.Delete_Event.Click += new System.EventHandler(this.Delete_Event_Click);
            // 
            // Check_day
            // 
            this.Check_day.BackColor = System.Drawing.Color.DodgerBlue;
            this.Check_day.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Check_day.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Check_day.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Check_day.ForeColor = System.Drawing.Color.White;
            this.Check_day.Location = new System.Drawing.Point(1148, 629);
            this.Check_day.Name = "Check_day";
            this.Check_day.Size = new System.Drawing.Size(104, 40);
            this.Check_day.TabIndex = 22;
            this.Check_day.Text = "Check day";
            this.Check_day.UseVisualStyleBackColor = false;
            this.Check_day.Click += new System.EventHandler(this.Check_day_Click);
            // 
            // pictureBox8
            // 
            this.pictureBox8.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pictureBox8.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBox8.ErrorImage")));
            this.pictureBox8.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox8.Image")));
            this.pictureBox8.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox8.InitialImage")));
            this.pictureBox8.Location = new System.Drawing.Point(12, 9);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(200, 88);
            this.pictureBox8.TabIndex = 35;
            this.pictureBox8.TabStop = false;
            this.pictureBox8.Click += new System.EventHandler(this.pictureBox8_Click);
            // 
            // dgvEvents
            // 
            this.dgvEvents.AllowUserToAddRows = false;
            this.dgvEvents.AllowUserToDeleteRows = false;
            this.dgvEvents.AllowUserToResizeColumns = false;
            this.dgvEvents.AllowUserToResizeRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvEvents.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvEvents.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvEvents.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvEvents.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.Padding = new System.Windows.Forms.Padding(0, 10, 0, 10);
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.InactiveCaption;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvEvents.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvEvents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvEvents.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvEvents.Location = new System.Drawing.Point(247, 149);
            this.dgvEvents.Name = "dgvEvents";
            this.dgvEvents.RowHeadersVisible = false;
            this.dgvEvents.RowTemplate.Height = 30;
            this.dgvEvents.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEvents.Size = new System.Drawing.Size(1005, 461);
            this.dgvEvents.TabIndex = 36;
            this.dgvEvents.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEvents_CellContentClick);
            // 
            // EksportCal
            // 
            this.EksportCal.BackColor = System.Drawing.Color.DodgerBlue;
            this.EksportCal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.EksportCal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EksportCal.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EksportCal.ForeColor = System.Drawing.Color.White;
            this.EksportCal.Location = new System.Drawing.Point(411, 103);
            this.EksportCal.Name = "EksportCal";
            this.EksportCal.Size = new System.Drawing.Size(158, 40);
            this.EksportCal.TabIndex = 37;
            this.EksportCal.Text = "Save calendar";
            this.EksportCal.UseVisualStyleBackColor = false;
            this.EksportCal.Click += new System.EventHandler(this.EksportCal_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1265, 681);
            this.Controls.Add(this.EksportCal);
            this.Controls.Add(this.dgvEvents);
            this.Controls.Add(this.pictureBox8);
            this.Controls.Add(this.Check_day);
            this.Controls.Add(this.Delete_Event);
            this.Controls.Add(this.Edit_Event);
            this.Controls.Add(this.Export_day);
            this.Controls.Add(this.Add_event);
            this.Controls.Add(this.Past_Events);
            this.Controls.Add(this.Upcoming_Events);
            this.Controls.Add(this.textBox9);
            this.Controls.Add(this.textBox8);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.Clear_Filters);
            this.Controls.Add(this.Apply_Filters);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Cultural_Events_Calendar);
            this.Controls.Add(this.Import);
            this.Controls.Add(this.des1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.des1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEvents)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Import;
        private System.Windows.Forms.TextBox Cultural_Events_Calendar;
        private System.Windows.Forms.PictureBox des1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Button Apply_Filters;
        private System.Windows.Forms.Button Clear_Filters;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.Button Upcoming_Events;
        private System.Windows.Forms.Button Past_Events;
        private System.Windows.Forms.Button Add_event;
        private System.Windows.Forms.Button Export_day;
        private System.Windows.Forms.Button Edit_Event;
        private System.Windows.Forms.Button Delete_Event;
        private System.Windows.Forms.Button Check_day;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.DataGridView dgvEvents;
        private System.Windows.Forms.Button EksportCal;
    }
}


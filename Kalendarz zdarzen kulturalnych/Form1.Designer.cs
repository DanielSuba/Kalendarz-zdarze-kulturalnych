
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.DateStart = new System.Windows.Forms.TextBox();
            this.DateEnd = new System.Windows.Forms.TextBox();
            this.Add_event = new System.Windows.Forms.Button();
            this.Export_day = new System.Windows.Forms.Button();
            this.Edit_Event = new System.Windows.Forms.Button();
            this.Delete_Event = new System.Windows.Forms.Button();
            this.Check_day = new System.Windows.Forms.Button();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.dgvEvents = new System.Windows.Forms.DataGridView();
            this.EksportCal = new System.Windows.Forms.Button();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.monthCalendar2 = new System.Windows.Forms.MonthCalendar();
            this.clbType = new System.Windows.Forms.CheckedListBox();
            this.clbTags = new System.Windows.Forms.CheckedListBox();
            this.clbLocation = new System.Windows.Forms.CheckedListBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
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
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
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
            this.Apply_Filters.Click += new System.EventHandler(this.Apply_Filters_Click);
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
            this.Clear_Filters.Click += new System.EventHandler(this.Clear_Filters_Click);
            // 
            // DateStart
            // 
            this.DateStart.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DateStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateStart.ForeColor = System.Drawing.Color.Black;
            this.DateStart.Location = new System.Drawing.Point(26, 297);
            this.DateStart.Name = "DateStart";
            this.DateStart.Size = new System.Drawing.Size(125, 26);
            this.DateStart.TabIndex = 11;
            this.DateStart.Click += new System.EventHandler(this.DateStart_Click);
            this.DateStart.TextChanged += new System.EventHandler(this.DateStart_TextChanged);
            this.DateStart.Enter += new System.EventHandler(this.textBox6_Enter);
            this.DateStart.Leave += new System.EventHandler(this.textBox6_Leave);
            // 
            // DateEnd
            // 
            this.DateEnd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DateEnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateEnd.ForeColor = System.Drawing.Color.Black;
            this.DateEnd.Location = new System.Drawing.Point(26, 339);
            this.DateEnd.Name = "DateEnd";
            this.DateEnd.Size = new System.Drawing.Size(125, 26);
            this.DateEnd.TabIndex = 12;
            this.DateEnd.Click += new System.EventHandler(this.DateEnd_Click);
            this.DateEnd.TextChanged += new System.EventHandler(this.DateEnd_TextChanged);
            this.DateEnd.Enter += new System.EventHandler(this.textBox7_Enter);
            this.DateEnd.Leave += new System.EventHandler(this.textBox7_Leave);
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
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvEvents.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvEvents.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvEvents.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvEvents.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(0, 10, 0, 10);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvEvents.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvEvents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.PaleGreen;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvEvents.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvEvents.Location = new System.Drawing.Point(247, 149);
            this.dgvEvents.Name = "dgvEvents";
            this.dgvEvents.RowHeadersVisible = false;
            this.dgvEvents.RowTemplate.Height = 30;
            this.dgvEvents.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEvents.Size = new System.Drawing.Size(1005, 461);
            this.dgvEvents.TabIndex = 36;
            this.dgvEvents.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEvents_CellContentClick);
            this.dgvEvents.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvEvents_ColumnHeaderMouseClick);
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
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(163, 297);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 38;
            this.monthCalendar1.Visible = false;
            this.monthCalendar1.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateChanged);
            this.monthCalendar1.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateSelected);
            this.monthCalendar1.Leave += new System.EventHandler(this.monthCalendar1_Leave);
            // 
            // monthCalendar2
            // 
            this.monthCalendar2.Location = new System.Drawing.Point(163, 339);
            this.monthCalendar2.Name = "monthCalendar2";
            this.monthCalendar2.TabIndex = 39;
            this.monthCalendar2.Visible = false;
            this.monthCalendar2.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar2_DateSelected);
            this.monthCalendar2.Leave += new System.EventHandler(this.monthCalendar2_Leave);
            // 
            // clbType
            // 
            this.clbType.FormattingEnabled = true;
            this.clbType.Location = new System.Drawing.Point(26, 201);
            this.clbType.Name = "clbType";
            this.clbType.Size = new System.Drawing.Size(192, 49);
            this.clbType.TabIndex = 41;
            // 
            // clbTags
            // 
            this.clbTags.FormattingEnabled = true;
            this.clbTags.Location = new System.Drawing.Point(26, 492);
            this.clbTags.Name = "clbTags";
            this.clbTags.Size = new System.Drawing.Size(192, 49);
            this.clbTags.TabIndex = 42;
            // 
            // clbLocation
            // 
            this.clbLocation.FormattingEnabled = true;
            this.clbLocation.Location = new System.Drawing.Point(26, 408);
            this.clbLocation.Name = "clbLocation";
            this.clbLocation.Size = new System.Drawing.Size(192, 49);
            this.clbLocation.TabIndex = 43;
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(818, 105);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(307, 38);
            this.txtSearch.TabIndex = 44;
            this.txtSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSearch_KeyDown);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(1148, 103);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(104, 40);
            this.btnSearch.TabIndex = 45;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1265, 681);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.clbLocation);
            this.Controls.Add(this.clbTags);
            this.Controls.Add(this.clbType);
            this.Controls.Add(this.monthCalendar2);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.EksportCal);
            this.Controls.Add(this.dgvEvents);
            this.Controls.Add(this.pictureBox8);
            this.Controls.Add(this.Check_day);
            this.Controls.Add(this.Delete_Event);
            this.Controls.Add(this.Edit_Event);
            this.Controls.Add(this.Export_day);
            this.Controls.Add(this.Add_event);
            this.Controls.Add(this.DateEnd);
            this.Controls.Add(this.DateStart);
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
            this.Text = "-*p 5w";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Click += new System.EventHandler(this.Form1_Click);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseClick);
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
        private System.Windows.Forms.TextBox DateStart;
        private System.Windows.Forms.TextBox DateEnd;
        private System.Windows.Forms.Button Add_event;
        private System.Windows.Forms.Button Export_day;
        private System.Windows.Forms.Button Edit_Event;
        private System.Windows.Forms.Button Delete_Event;
        private System.Windows.Forms.Button Check_day;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.DataGridView dgvEvents;
        private System.Windows.Forms.Button EksportCal;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.MonthCalendar monthCalendar2;
        private System.Windows.Forms.CheckedListBox clbType;
        private System.Windows.Forms.CheckedListBox clbTags;
        private System.Windows.Forms.CheckedListBox clbLocation;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;
    }
}


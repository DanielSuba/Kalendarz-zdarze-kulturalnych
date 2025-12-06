
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
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.Check_day = new System.Windows.Forms.Button();
            this.Kalendarz = new System.Windows.Forms.DataGridView();
            this.Filt_Title = new System.Windows.Forms.TextBox();
            this.Filt_Data = new System.Windows.Forms.TextBox();
            this.Filt_Locat = new System.Windows.Forms.TextBox();
            this.Filt_Type = new System.Windows.Forms.TextBox();
            this.Filt_Cost = new System.Windows.Forms.TextBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.Event_title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Location = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.des1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Kalendarz)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
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
            this.Upcoming_Events.Location = new System.Drawing.Point(508, 103);
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
            this.Past_Events.Location = new System.Drawing.Point(672, 103);
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
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pictureBox2.Location = new System.Drawing.Point(247, 149);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(1005, 46);
            this.pictureBox2.TabIndex = 21;
            this.pictureBox2.TabStop = false;
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
            // Kalendarz
            // 
            this.Kalendarz.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.Kalendarz.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.Kalendarz.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.Kalendarz.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Kalendarz.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Event_title,
            this.DateTime,
            this.Location,
            this.Type,
            this.Cost});
            this.Kalendarz.Location = new System.Drawing.Point(247, 202);
            this.Kalendarz.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.Kalendarz.Name = "Kalendarz";
            this.Kalendarz.RowHeadersWidth = 4;
            this.Kalendarz.RowTemplate.Height = 24;
            this.Kalendarz.Size = new System.Drawing.Size(1005, 408);
            this.Kalendarz.TabIndex = 23;
            // 
            // Filt_Title
            // 
            this.Filt_Title.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Filt_Title.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Filt_Title.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Filt_Title.Location = new System.Drawing.Point(357, 163);
            this.Filt_Title.Name = "Filt_Title";
            this.Filt_Title.ReadOnly = true;
            this.Filt_Title.Size = new System.Drawing.Size(104, 19);
            this.Filt_Title.TabIndex = 24;
            this.Filt_Title.Text = "Event title";
            this.Filt_Title.TextChanged += new System.EventHandler(this.Filt_Title_TextChanged);
            // 
            // Filt_Data
            // 
            this.Filt_Data.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Filt_Data.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Filt_Data.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Filt_Data.Location = new System.Drawing.Point(609, 163);
            this.Filt_Data.Name = "Filt_Data";
            this.Filt_Data.ReadOnly = true;
            this.Filt_Data.Size = new System.Drawing.Size(104, 19);
            this.Filt_Data.TabIndex = 25;
            this.Filt_Data.Text = "Data & Time";
            // 
            // Filt_Locat
            // 
            this.Filt_Locat.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Filt_Locat.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Filt_Locat.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Filt_Locat.Location = new System.Drawing.Point(865, 163);
            this.Filt_Locat.Name = "Filt_Locat";
            this.Filt_Locat.ReadOnly = true;
            this.Filt_Locat.Size = new System.Drawing.Size(104, 19);
            this.Filt_Locat.TabIndex = 26;
            this.Filt_Locat.Text = "Location";
            // 
            // Filt_Type
            // 
            this.Filt_Type.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Filt_Type.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Filt_Type.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Filt_Type.Location = new System.Drawing.Point(1055, 163);
            this.Filt_Type.Name = "Filt_Type";
            this.Filt_Type.ReadOnly = true;
            this.Filt_Type.Size = new System.Drawing.Size(104, 19);
            this.Filt_Type.TabIndex = 27;
            this.Filt_Type.Text = "Type";
            // 
            // Filt_Cost
            // 
            this.Filt_Cost.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Filt_Cost.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Filt_Cost.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Filt_Cost.Location = new System.Drawing.Point(1165, 163);
            this.Filt_Cost.Name = "Filt_Cost";
            this.Filt_Cost.ReadOnly = true;
            this.Filt_Cost.Size = new System.Drawing.Size(79, 19);
            this.Filt_Cost.TabIndex = 28;
            this.Filt_Cost.Text = "Cost";
            this.Filt_Cost.TextChanged += new System.EventHandler(this.Filt_Cost_TextChanged);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pictureBox3.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBox3.ErrorImage")));
            this.pictureBox3.Image = global::Kalendarz_zdarzen_kulturalnych.Properties.Resources.Down;
            this.pictureBox3.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox3.InitialImage")));
            this.pictureBox3.Location = new System.Drawing.Point(431, 152);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(30, 30);
            this.pictureBox3.TabIndex = 30;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pictureBox4.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBox4.ErrorImage")));
            this.pictureBox4.Image = global::Kalendarz_zdarzen_kulturalnych.Properties.Resources.Down;
            this.pictureBox4.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox4.InitialImage")));
            this.pictureBox4.Location = new System.Drawing.Point(692, 152);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(30, 30);
            this.pictureBox4.TabIndex = 31;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Visible = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pictureBox5.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBox5.ErrorImage")));
            this.pictureBox5.Image = global::Kalendarz_zdarzen_kulturalnych.Properties.Resources.Down;
            this.pictureBox5.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox5.InitialImage")));
            this.pictureBox5.Location = new System.Drawing.Point(924, 149);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(30, 30);
            this.pictureBox5.TabIndex = 32;
            this.pictureBox5.TabStop = false;
            this.pictureBox5.Visible = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pictureBox6.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBox6.ErrorImage")));
            this.pictureBox6.Image = global::Kalendarz_zdarzen_kulturalnych.Properties.Resources.Down;
            this.pictureBox6.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox6.InitialImage")));
            this.pictureBox6.Location = new System.Drawing.Point(1093, 152);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(30, 30);
            this.pictureBox6.TabIndex = 33;
            this.pictureBox6.TabStop = false;
            this.pictureBox6.Visible = false;
            // 
            // pictureBox7
            // 
            this.pictureBox7.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pictureBox7.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBox7.ErrorImage")));
            this.pictureBox7.Image = global::Kalendarz_zdarzen_kulturalnych.Properties.Resources.Down;
            this.pictureBox7.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox7.InitialImage")));
            this.pictureBox7.Location = new System.Drawing.Point(1200, 152);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(30, 30);
            this.pictureBox7.TabIndex = 34;
            this.pictureBox7.TabStop = false;
            this.pictureBox7.Visible = false;
            this.pictureBox7.Click += new System.EventHandler(this.pictureBox7_Click);
            // 
            // Event_title
            // 
            this.Event_title.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Event_title.HeaderText = "Event title";
            this.Event_title.Name = "Event_title";
            this.Event_title.ReadOnly = true;
            // 
            // DateTime
            // 
            this.DateTime.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DateTime.FillWeight = 120F;
            this.DateTime.HeaderText = "Date & Time";
            this.DateTime.Name = "DateTime";
            this.DateTime.ReadOnly = true;
            // 
            // Location
            // 
            this.Location.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Location.FillWeight = 90F;
            this.Location.HeaderText = "Location";
            this.Location.Name = "Location";
            this.Location.ReadOnly = true;
            // 
            // Type
            // 
            this.Type.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Type.FillWeight = 60F;
            this.Type.HeaderText = "Type";
            this.Type.Name = "Type";
            this.Type.ReadOnly = true;
            // 
            // Cost
            // 
            this.Cost.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Cost.FillWeight = 40F;
            this.Cost.HeaderText = "Cost";
            this.Cost.Name = "Cost";
            this.Cost.ReadOnly = true;
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
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.pictureBox8);
            this.Controls.Add(this.pictureBox7);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.Filt_Cost);
            this.Controls.Add(this.Filt_Type);
            this.Controls.Add(this.Filt_Locat);
            this.Controls.Add(this.Filt_Data);
            this.Controls.Add(this.Filt_Title);
            this.Controls.Add(this.Kalendarz);
            this.Controls.Add(this.Check_day);
            this.Controls.Add(this.pictureBox2);
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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Kalendarz)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
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
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button Check_day;
        private System.Windows.Forms.DataGridView Kalendarz;
        private System.Windows.Forms.TextBox Filt_Title;
        private System.Windows.Forms.TextBox Filt_Data;
        private System.Windows.Forms.TextBox Filt_Locat;
        private System.Windows.Forms.TextBox Filt_Type;
        private System.Windows.Forms.TextBox Filt_Cost;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Event_title;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn Location;
        private System.Windows.Forms.DataGridViewTextBoxColumn Type;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cost;
        private System.Windows.Forms.PictureBox pictureBox8;
    }
}



namespace Kalendarz_zdarzen_kulturalnych
{
    partial class Day
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
            this.Export_day = new System.Windows.Forms.Button();
            this.Delete_Event = new System.Windows.Forms.Button();
            this.Edit_Event = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Export_day
            // 
            this.Export_day.BackColor = System.Drawing.Color.DodgerBlue;
            this.Export_day.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Export_day.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Export_day.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Export_day.ForeColor = System.Drawing.Color.White;
            this.Export_day.Location = new System.Drawing.Point(468, 709);
            this.Export_day.Name = "Export_day";
            this.Export_day.Size = new System.Drawing.Size(104, 40);
            this.Export_day.TabIndex = 19;
            this.Export_day.Text = "Export day";
            this.Export_day.UseVisualStyleBackColor = false;
            // 
            // Delete_Event
            // 
            this.Delete_Event.BackColor = System.Drawing.Color.DodgerBlue;
            this.Delete_Event.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Delete_Event.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Delete_Event.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Delete_Event.ForeColor = System.Drawing.Color.White;
            this.Delete_Event.Location = new System.Drawing.Point(248, 709);
            this.Delete_Event.Name = "Delete_Event";
            this.Delete_Event.Size = new System.Drawing.Size(104, 40);
            this.Delete_Event.TabIndex = 21;
            this.Delete_Event.Text = "Delete";
            this.Delete_Event.UseVisualStyleBackColor = false;
            // 
            // Edit_Event
            // 
            this.Edit_Event.BackColor = System.Drawing.Color.DodgerBlue;
            this.Edit_Event.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Edit_Event.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Edit_Event.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Edit_Event.ForeColor = System.Drawing.Color.White;
            this.Edit_Event.Location = new System.Drawing.Point(358, 709);
            this.Edit_Event.Name = "Edit_Event";
            this.Edit_Event.Size = new System.Drawing.Size(104, 40);
            this.Edit_Event.TabIndex = 22;
            this.Edit_Event.Text = "Edit";
            this.Edit_Event.UseVisualStyleBackColor = false;
            // 
            // Day
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 761);
            this.Controls.Add(this.Edit_Event);
            this.Controls.Add(this.Delete_Event);
            this.Controls.Add(this.Export_day);
            this.Name = "Day";
            this.Text = "Day";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Export_day;
        private System.Windows.Forms.Button Delete_Event;
        private System.Windows.Forms.Button Edit_Event;
    }
}
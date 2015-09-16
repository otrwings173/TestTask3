namespace Calendar
{
    partial class CalendarForm
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
            this.StartDateLabel = new System.Windows.Forms.Label();
            this.CreateModify = new System.Windows.Forms.GroupBox();
            this.RemindersBox = new System.Windows.Forms.ComboBox();
            this.TitleBox = new System.Windows.Forms.TextBox();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.RemindeTime = new System.Windows.Forms.Label();
            this.EndDate = new System.Windows.Forms.DateTimePicker();
            this.StartDate = new System.Windows.Forms.DateTimePicker();
            this.EndTime = new System.Windows.Forms.DateTimePicker();
            this.StartTime = new System.Windows.Forms.DateTimePicker();
            this.EndTimeLabel = new System.Windows.Forms.Label();
            this.StartTimeLabel = new System.Windows.Forms.Label();
            this.EndDateLabel = new System.Windows.Forms.Label();
            this.Save = new System.Windows.Forms.Button();
            this.EventsForToday = new System.Windows.Forms.ListBox();
            this.EventsLabel = new System.Windows.Forms.Label();
            this.Delete = new System.Windows.Forms.Button();
            this.Create = new System.Windows.Forms.Button();
            this.Modify = new System.Windows.Forms.Button();
            this.CreateModify.SuspendLayout();
            this.SuspendLayout();
            // 
            // StartDateLabel
            // 
            this.StartDateLabel.AutoSize = true;
            this.StartDateLabel.Location = new System.Drawing.Point(6, 67);
            this.StartDateLabel.Name = "StartDateLabel";
            this.StartDateLabel.Size = new System.Drawing.Size(53, 13);
            this.StartDateLabel.TabIndex = 0;
            this.StartDateLabel.Text = "Start date";
            // 
            // CreateModify
            // 
            this.CreateModify.Controls.Add(this.RemindersBox);
            this.CreateModify.Controls.Add(this.TitleBox);
            this.CreateModify.Controls.Add(this.TitleLabel);
            this.CreateModify.Controls.Add(this.RemindeTime);
            this.CreateModify.Controls.Add(this.EndDate);
            this.CreateModify.Controls.Add(this.StartDate);
            this.CreateModify.Controls.Add(this.EndTime);
            this.CreateModify.Controls.Add(this.StartTime);
            this.CreateModify.Controls.Add(this.EndTimeLabel);
            this.CreateModify.Controls.Add(this.StartDateLabel);
            this.CreateModify.Controls.Add(this.StartTimeLabel);
            this.CreateModify.Controls.Add(this.EndDateLabel);
            this.CreateModify.Location = new System.Drawing.Point(279, 12);
            this.CreateModify.Name = "CreateModify";
            this.CreateModify.Size = new System.Drawing.Size(317, 178);
            this.CreateModify.TabIndex = 1;
            this.CreateModify.TabStop = false;
            this.CreateModify.Text = "Create/Modify";
            // 
            // RemindersBox
            // 
            this.RemindersBox.FormattingEnabled = true;
            this.RemindersBox.Location = new System.Drawing.Point(65, 148);
            this.RemindersBox.Name = "RemindersBox";
            this.RemindersBox.Size = new System.Drawing.Size(121, 21);
            this.RemindersBox.TabIndex = 12;
            // 
            // TitleBox
            // 
            this.TitleBox.Location = new System.Drawing.Point(39, 25);
            this.TitleBox.Name = "TitleBox";
            this.TitleBox.Size = new System.Drawing.Size(254, 20);
            this.TitleBox.TabIndex = 11;
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Location = new System.Drawing.Point(6, 25);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(27, 13);
            this.TitleLabel.TabIndex = 10;
            this.TitleLabel.Text = "Title";
            // 
            // RemindeTime
            // 
            this.RemindeTime.AutoSize = true;
            this.RemindeTime.Location = new System.Drawing.Point(6, 151);
            this.RemindeTime.Name = "RemindeTime";
            this.RemindeTime.Size = new System.Drawing.Size(52, 13);
            this.RemindeTime.TabIndex = 1;
            this.RemindeTime.Text = "Reminder";
            // 
            // EndDate
            // 
            this.EndDate.CustomFormat = "dd-MM-yyyy";
            this.EndDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.EndDate.Location = new System.Drawing.Point(212, 67);
            this.EndDate.Name = "EndDate";
            this.EndDate.Size = new System.Drawing.Size(81, 20);
            this.EndDate.TabIndex = 8;
            // 
            // StartDate
            // 
            this.StartDate.CustomFormat = "dd-MM-yyyy";
            this.StartDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.StartDate.Location = new System.Drawing.Point(65, 67);
            this.StartDate.Name = "StartDate";
            this.StartDate.Size = new System.Drawing.Size(77, 20);
            this.StartDate.TabIndex = 7;
            // 
            // EndTime
            // 
            this.EndTime.CustomFormat = "HH:mm";
            this.EndTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.EndTime.Location = new System.Drawing.Point(212, 114);
            this.EndTime.Name = "EndTime";
            this.EndTime.ShowUpDown = true;
            this.EndTime.Size = new System.Drawing.Size(56, 20);
            this.EndTime.TabIndex = 6;
            // 
            // StartTime
            // 
            this.StartTime.CustomFormat = "HH:mm";
            this.StartTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.StartTime.Location = new System.Drawing.Point(65, 113);
            this.StartTime.Name = "StartTime";
            this.StartTime.ShowUpDown = true;
            this.StartTime.Size = new System.Drawing.Size(60, 20);
            this.StartTime.TabIndex = 5;
            // 
            // EndTimeLabel
            // 
            this.EndTimeLabel.AutoSize = true;
            this.EndTimeLabel.Location = new System.Drawing.Point(156, 120);
            this.EndTimeLabel.Name = "EndTimeLabel";
            this.EndTimeLabel.Size = new System.Drawing.Size(52, 13);
            this.EndTimeLabel.TabIndex = 4;
            this.EndTimeLabel.Text = "End Time";
            // 
            // StartTimeLabel
            // 
            this.StartTimeLabel.AutoSize = true;
            this.StartTimeLabel.Location = new System.Drawing.Point(6, 113);
            this.StartTimeLabel.Name = "StartTimeLabel";
            this.StartTimeLabel.Size = new System.Drawing.Size(48, 13);
            this.StartTimeLabel.TabIndex = 3;
            this.StartTimeLabel.Text = "Sart time";
            // 
            // EndDateLabel
            // 
            this.EndDateLabel.AutoSize = true;
            this.EndDateLabel.Location = new System.Drawing.Point(156, 67);
            this.EndDateLabel.Name = "EndDateLabel";
            this.EndDateLabel.Size = new System.Drawing.Size(50, 13);
            this.EndDateLabel.TabIndex = 2;
            this.EndDateLabel.Text = "End date";
            // 
            // Save
            // 
            this.Save.Location = new System.Drawing.Point(399, 238);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(75, 23);
            this.Save.TabIndex = 9;
            this.Save.Text = "Save";
            this.Save.UseVisualStyleBackColor = true;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // EventsForToday
            // 
            this.EventsForToday.FormattingEnabled = true;
            this.EventsForToday.Location = new System.Drawing.Point(32, 28);
            this.EventsForToday.Name = "EventsForToday";
            this.EventsForToday.Size = new System.Drawing.Size(229, 212);
            this.EventsForToday.TabIndex = 2;
            this.EventsForToday.SelectedIndexChanged += new System.EventHandler(this.EventsForToday_SelectedIndexChanged);
            // 
            // EventsLabel
            // 
            this.EventsLabel.AutoSize = true;
            this.EventsLabel.Location = new System.Drawing.Point(29, 12);
            this.EventsLabel.Name = "EventsLabel";
            this.EventsLabel.Size = new System.Drawing.Size(40, 13);
            this.EventsLabel.TabIndex = 3;
            this.EventsLabel.Text = "Events";
            // 
            // Delete
            // 
            this.Delete.Location = new System.Drawing.Point(511, 196);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(75, 23);
            this.Delete.TabIndex = 4;
            this.Delete.Text = "Delete";
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // Create
            // 
            this.Create.Location = new System.Drawing.Point(288, 196);
            this.Create.Name = "Create";
            this.Create.Size = new System.Drawing.Size(75, 23);
            this.Create.TabIndex = 12;
            this.Create.Text = "Create";
            this.Create.UseVisualStyleBackColor = true;
            this.Create.Click += new System.EventHandler(this.Create_Click);
            // 
            // Modify
            // 
            this.Modify.Location = new System.Drawing.Point(399, 196);
            this.Modify.Name = "Modify";
            this.Modify.Size = new System.Drawing.Size(75, 23);
            this.Modify.TabIndex = 13;
            this.Modify.Text = "Modify";
            this.Modify.UseVisualStyleBackColor = true;
            this.Modify.Click += new System.EventHandler(this.Modify_Click);
            // 
            // CalendarForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(619, 285);
            this.Controls.Add(this.Modify);
            this.Controls.Add(this.Create);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.EventsLabel);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.EventsForToday);
            this.Controls.Add(this.CreateModify);
            this.Name = "CalendarForm";
            this.Text = "Calendar";
            this.Load += new System.EventHandler(this.CalendarForm_Load);
            this.Shown += new System.EventHandler(this.CalendarForm_Shown);
            this.CreateModify.ResumeLayout(false);
            this.CreateModify.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label StartDateLabel;
        private System.Windows.Forms.GroupBox CreateModify;
        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.DateTimePicker EndDate;
        private System.Windows.Forms.DateTimePicker StartDate;
        private System.Windows.Forms.DateTimePicker EndTime;
        private System.Windows.Forms.DateTimePicker StartTime;
        private System.Windows.Forms.Label EndTimeLabel;
        private System.Windows.Forms.Label StartTimeLabel;
        private System.Windows.Forms.Label EndDateLabel;
        private System.Windows.Forms.TextBox TitleBox;
        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.ListBox EventsForToday;
        private System.Windows.Forms.Label EventsLabel;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.Button Create;
        private System.Windows.Forms.Button Modify;
        private System.Windows.Forms.Label RemindeTime;
        private System.Windows.Forms.ComboBox RemindersBox;
    }
}


namespace LifeAssistant_ICT365_Assignment1.View
{
    partial class AddEvent
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
            this.modifyEvent = new System.Windows.Forms.Label();
            this.eventTypeLabel = new System.Windows.Forms.Label();
            this.dropdownEvent = new System.Windows.Forms.ComboBox();
            this.fileAttachDialog = new System.Windows.Forms.SaveFileDialog();
            this.panelAppointment = new System.Windows.Forms.Panel();
            this.apCancelButton = new System.Windows.Forms.Button();
            this.apOKButton = new System.Windows.Forms.Button();
            this.apTimeLabel = new System.Windows.Forms.Label();
            this.apFileAttachLabel = new System.Windows.Forms.Label();
            this.apDateLabel = new System.Windows.Forms.Label();
            this.apAddressLabel = new System.Windows.Forms.Label();
            this.apFreqLabel = new System.Windows.Forms.Label();
            this.apRecurLabel = new System.Windows.Forms.Label();
            this.apNotesLabel = new System.Windows.Forms.Label();
            this.apFreqDrop = new System.Windows.Forms.ComboBox();
            this.apRecurCheck = new System.Windows.Forms.CheckBox();
            this.apFileAttachButton = new System.Windows.Forms.Button();
            this.apNotesBox = new System.Windows.Forms.TextBox();
            this.apTimePicker = new System.Windows.Forms.DateTimePicker();
            this.apDatePicker = new System.Windows.Forms.DateTimePicker();
            this.apAddressBox = new System.Windows.Forms.TextBox();
            this.apNameBox = new System.Windows.Forms.TextBox();
            this.apNameLabel = new System.Windows.Forms.Label();
            this.apTitleLabel = new System.Windows.Forms.Label();
            this.panelMemory = new System.Windows.Forms.Panel();
            this.memCancelButton = new System.Windows.Forms.Button();
            this.memOKButton = new System.Windows.Forms.Button();
            this.memFileAttachLabel = new System.Windows.Forms.Label();
            this.memDateLabel = new System.Windows.Forms.Label();
            this.memAddressLabel = new System.Windows.Forms.Label();
            this.memFreqLabel = new System.Windows.Forms.Label();
            this.memReminderLabel = new System.Windows.Forms.Label();
            this.memNotesLabel = new System.Windows.Forms.Label();
            this.memFreqDrop = new System.Windows.Forms.ComboBox();
            this.memRemindCheck = new System.Windows.Forms.CheckBox();
            this.memFileAttachButton = new System.Windows.Forms.Button();
            this.memNotesBox = new System.Windows.Forms.TextBox();
            this.memDatePick = new System.Windows.Forms.DateTimePicker();
            this.memAddressBox = new System.Windows.Forms.TextBox();
            this.memNameBox = new System.Windows.Forms.TextBox();
            this.memNameLabel = new System.Windows.Forms.Label();
            this.memTitleLabel = new System.Windows.Forms.Label();
            this.panelPeople = new System.Windows.Forms.Panel();
            this.perRelationBox = new System.Windows.Forms.TextBox();
            this.perCancelButton = new System.Windows.Forms.Button();
            this.perOKButton = new System.Windows.Forms.Button();
            this.perFileAttachLabel = new System.Windows.Forms.Label();
            this.perDateLabel = new System.Windows.Forms.Label();
            this.perAddressLabel = new System.Windows.Forms.Label();
            this.perRelationshipLabel = new System.Windows.Forms.Label();
            this.perNotesLabel = new System.Windows.Forms.Label();
            this.perFileAttachButton = new System.Windows.Forms.Button();
            this.perNotesBox = new System.Windows.Forms.TextBox();
            this.perDatePicker = new System.Windows.Forms.DateTimePicker();
            this.perAddressBox = new System.Windows.Forms.TextBox();
            this.perNameBox = new System.Windows.Forms.TextBox();
            this.perNAmeLabel = new System.Windows.Forms.Label();
            this.perTitleLabel = new System.Windows.Forms.Label();
            this.panelTask = new System.Windows.Forms.Panel();
            this.taskCompleteCheck = new System.Windows.Forms.CheckBox();
            this.taskCancelButton = new System.Windows.Forms.Button();
            this.taskOKButton = new System.Windows.Forms.Button();
            this.taskFileAttachLabel = new System.Windows.Forms.Label();
            this.taskDateLabel = new System.Windows.Forms.Label();
            this.taskAddressLabel = new System.Windows.Forms.Label();
            this.taskCompletedLabel = new System.Windows.Forms.Label();
            this.taskNotesLabel = new System.Windows.Forms.Label();
            this.taskFileAttachButton = new System.Windows.Forms.Button();
            this.taskNotesBox = new System.Windows.Forms.TextBox();
            this.taskDatePicker = new System.Windows.Forms.DateTimePicker();
            this.taskAddressBox = new System.Windows.Forms.TextBox();
            this.taskNameBox = new System.Windows.Forms.TextBox();
            this.taskNameLabel = new System.Windows.Forms.Label();
            this.taskTitleLabel = new System.Windows.Forms.Label();
            this.panelAppointment.SuspendLayout();
            this.panelMemory.SuspendLayout();
            this.panelPeople.SuspendLayout();
            this.panelTask.SuspendLayout();
            this.SuspendLayout();
            // 
            // modifyEvent
            // 
            this.modifyEvent.AutoSize = true;
            this.modifyEvent.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modifyEvent.Location = new System.Drawing.Point(130, 9);
            this.modifyEvent.Name = "modifyEvent";
            this.modifyEvent.Size = new System.Drawing.Size(139, 25);
            this.modifyEvent.TabIndex = 2;
            this.modifyEvent.Text = "Event Editing";
            // 
            // eventTypeLabel
            // 
            this.eventTypeLabel.AutoSize = true;
            this.eventTypeLabel.Location = new System.Drawing.Point(85, 48);
            this.eventTypeLabel.Name = "eventTypeLabel";
            this.eventTypeLabel.Size = new System.Drawing.Size(62, 13);
            this.eventTypeLabel.TabIndex = 3;
            this.eventTypeLabel.Text = "Event Type";
            // 
            // dropdownEvent
            // 
            this.dropdownEvent.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.dropdownEvent.FormattingEnabled = true;
            this.dropdownEvent.Items.AddRange(new object[] {
            "Appointment",
            "Memory",
            "Person",
            "Task"});
            this.dropdownEvent.Location = new System.Drawing.Point(176, 45);
            this.dropdownEvent.Name = "dropdownEvent";
            this.dropdownEvent.Size = new System.Drawing.Size(121, 21);
            this.dropdownEvent.TabIndex = 4;
            this.dropdownEvent.SelectedIndexChanged += new System.EventHandler(this.dropdownEvent_SelectedIndexChanged);
            // 
            // panelAppointment
            // 
            this.panelAppointment.Controls.Add(this.apCancelButton);
            this.panelAppointment.Controls.Add(this.apOKButton);
            this.panelAppointment.Controls.Add(this.apTimeLabel);
            this.panelAppointment.Controls.Add(this.apFileAttachLabel);
            this.panelAppointment.Controls.Add(this.apDateLabel);
            this.panelAppointment.Controls.Add(this.apAddressLabel);
            this.panelAppointment.Controls.Add(this.apFreqLabel);
            this.panelAppointment.Controls.Add(this.apRecurLabel);
            this.panelAppointment.Controls.Add(this.apNotesLabel);
            this.panelAppointment.Controls.Add(this.apFreqDrop);
            this.panelAppointment.Controls.Add(this.apRecurCheck);
            this.panelAppointment.Controls.Add(this.apFileAttachButton);
            this.panelAppointment.Controls.Add(this.apNotesBox);
            this.panelAppointment.Controls.Add(this.apTimePicker);
            this.panelAppointment.Controls.Add(this.apDatePicker);
            this.panelAppointment.Controls.Add(this.apAddressBox);
            this.panelAppointment.Controls.Add(this.apNameBox);
            this.panelAppointment.Controls.Add(this.apNameLabel);
            this.panelAppointment.Controls.Add(this.apTitleLabel);
            this.panelAppointment.Location = new System.Drawing.Point(13, 84);
            this.panelAppointment.Name = "panelAppointment";
            this.panelAppointment.Size = new System.Drawing.Size(379, 461);
            this.panelAppointment.TabIndex = 5;
            // 
            // apCancelButton
            // 
            this.apCancelButton.Location = new System.Drawing.Point(200, 427);
            this.apCancelButton.Name = "apCancelButton";
            this.apCancelButton.Size = new System.Drawing.Size(75, 23);
            this.apCancelButton.TabIndex = 24;
            this.apCancelButton.Text = "Cancel";
            this.apCancelButton.UseVisualStyleBackColor = true;
            this.apCancelButton.Click += new System.EventHandler(this.CancelClick);
            // 
            // apOKButton
            // 
            this.apOKButton.Location = new System.Drawing.Point(103, 427);
            this.apOKButton.Name = "apOKButton";
            this.apOKButton.Size = new System.Drawing.Size(75, 23);
            this.apOKButton.TabIndex = 23;
            this.apOKButton.Text = "OK";
            this.apOKButton.UseVisualStyleBackColor = true;
            this.apOKButton.Click += new System.EventHandler(this.AddEventClick);
            // 
            // apTimeLabel
            // 
            this.apTimeLabel.AutoSize = true;
            this.apTimeLabel.Location = new System.Drawing.Point(104, 153);
            this.apTimeLabel.Name = "apTimeLabel";
            this.apTimeLabel.Size = new System.Drawing.Size(30, 13);
            this.apTimeLabel.TabIndex = 22;
            this.apTimeLabel.Text = "Time";
            // 
            // apFileAttachLabel
            // 
            this.apFileAttachLabel.AutoSize = true;
            this.apFileAttachLabel.Location = new System.Drawing.Point(77, 393);
            this.apFileAttachLabel.Name = "apFileAttachLabel";
            this.apFileAttachLabel.Size = new System.Drawing.Size(57, 13);
            this.apFileAttachLabel.TabIndex = 21;
            this.apFileAttachLabel.Text = "Attach File";
            // 
            // apDateLabel
            // 
            this.apDateLabel.AutoSize = true;
            this.apDateLabel.Location = new System.Drawing.Point(104, 122);
            this.apDateLabel.Name = "apDateLabel";
            this.apDateLabel.Size = new System.Drawing.Size(30, 13);
            this.apDateLabel.TabIndex = 20;
            this.apDateLabel.Text = "Date";
            // 
            // apAddressLabel
            // 
            this.apAddressLabel.AutoSize = true;
            this.apAddressLabel.Location = new System.Drawing.Point(89, 87);
            this.apAddressLabel.Name = "apAddressLabel";
            this.apAddressLabel.Size = new System.Drawing.Size(45, 13);
            this.apAddressLabel.TabIndex = 19;
            this.apAddressLabel.Text = "Address";
            // 
            // apFreqLabel
            // 
            this.apFreqLabel.AutoSize = true;
            this.apFreqLabel.Location = new System.Drawing.Point(77, 216);
            this.apFreqLabel.Name = "apFreqLabel";
            this.apFreqLabel.Size = new System.Drawing.Size(57, 13);
            this.apFreqLabel.TabIndex = 18;
            this.apFreqLabel.Text = "Frequency";
            // 
            // apRecurLabel
            // 
            this.apRecurLabel.AutoSize = true;
            this.apRecurLabel.Location = new System.Drawing.Point(77, 183);
            this.apRecurLabel.Name = "apRecurLabel";
            this.apRecurLabel.Size = new System.Drawing.Size(59, 13);
            this.apRecurLabel.TabIndex = 17;
            this.apRecurLabel.Text = "Recurring?";
            // 
            // apNotesLabel
            // 
            this.apNotesLabel.AutoSize = true;
            this.apNotesLabel.Location = new System.Drawing.Point(99, 253);
            this.apNotesLabel.Name = "apNotesLabel";
            this.apNotesLabel.Size = new System.Drawing.Size(35, 13);
            this.apNotesLabel.TabIndex = 16;
            this.apNotesLabel.Text = "Notes";
            // 
            // apFreqDrop
            // 
            this.apFreqDrop.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.apFreqDrop.FormattingEnabled = true;
            this.apFreqDrop.Items.AddRange(new object[] {
            "Daily",
            "Weekly",
            "Fortnightly",
            "Monthly",
            "Bimonthly",
            "Biannually",
            "Annually"});
            this.apFreqDrop.Location = new System.Drawing.Point(163, 213);
            this.apFreqDrop.Name = "apFreqDrop";
            this.apFreqDrop.Size = new System.Drawing.Size(121, 21);
            this.apFreqDrop.TabIndex = 15;
            // 
            // apRecurCheck
            // 
            this.apRecurCheck.AutoSize = true;
            this.apRecurCheck.Location = new System.Drawing.Point(163, 183);
            this.apRecurCheck.Name = "apRecurCheck";
            this.apRecurCheck.Size = new System.Drawing.Size(15, 14);
            this.apRecurCheck.TabIndex = 14;
            this.apRecurCheck.UseVisualStyleBackColor = true;
            // 
            // apFileAttachButton
            // 
            this.apFileAttachButton.Location = new System.Drawing.Point(163, 388);
            this.apFileAttachButton.Name = "apFileAttachButton";
            this.apFileAttachButton.Size = new System.Drawing.Size(37, 23);
            this.apFileAttachButton.TabIndex = 13;
            this.apFileAttachButton.Text = "...";
            this.apFileAttachButton.UseVisualStyleBackColor = true;
            // 
            // apNotesBox
            // 
            this.apNotesBox.Location = new System.Drawing.Point(163, 250);
            this.apNotesBox.Multiline = true;
            this.apNotesBox.Name = "apNotesBox";
            this.apNotesBox.Size = new System.Drawing.Size(182, 122);
            this.apNotesBox.TabIndex = 12;
            // 
            // apTimePicker
            // 
            this.apTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.apTimePicker.Location = new System.Drawing.Point(163, 147);
            this.apTimePicker.Name = "apTimePicker";
            this.apTimePicker.Size = new System.Drawing.Size(112, 20);
            this.apTimePicker.TabIndex = 11;
            // 
            // apDatePicker
            // 
            this.apDatePicker.Location = new System.Drawing.Point(163, 116);
            this.apDatePicker.Name = "apDatePicker";
            this.apDatePicker.Size = new System.Drawing.Size(182, 20);
            this.apDatePicker.TabIndex = 10;
            // 
            // apAddressBox
            // 
            this.apAddressBox.Location = new System.Drawing.Point(163, 84);
            this.apAddressBox.Name = "apAddressBox";
            this.apAddressBox.Size = new System.Drawing.Size(182, 20);
            this.apAddressBox.TabIndex = 9;
            // 
            // apNameBox
            // 
            this.apNameBox.Location = new System.Drawing.Point(163, 51);
            this.apNameBox.Name = "apNameBox";
            this.apNameBox.Size = new System.Drawing.Size(182, 20);
            this.apNameBox.TabIndex = 8;
            // 
            // apNameLabel
            // 
            this.apNameLabel.AutoSize = true;
            this.apNameLabel.Location = new System.Drawing.Point(99, 54);
            this.apNameLabel.Name = "apNameLabel";
            this.apNameLabel.Size = new System.Drawing.Size(35, 13);
            this.apNameLabel.TabIndex = 7;
            this.apNameLabel.Text = "Name";
            // 
            // apTitleLabel
            // 
            this.apTitleLabel.AutoSize = true;
            this.apTitleLabel.Font = new System.Drawing.Font("Calibri", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.apTitleLabel.Location = new System.Drawing.Point(125, 8);
            this.apTitleLabel.Name = "apTitleLabel";
            this.apTitleLabel.Size = new System.Drawing.Size(133, 27);
            this.apTitleLabel.TabIndex = 0;
            this.apTitleLabel.Text = "Appointment";
            // 
            // panelMemory
            // 
            this.panelMemory.Controls.Add(this.memCancelButton);
            this.panelMemory.Controls.Add(this.memOKButton);
            this.panelMemory.Controls.Add(this.memFileAttachLabel);
            this.panelMemory.Controls.Add(this.memDateLabel);
            this.panelMemory.Controls.Add(this.memAddressLabel);
            this.panelMemory.Controls.Add(this.memFreqLabel);
            this.panelMemory.Controls.Add(this.memReminderLabel);
            this.panelMemory.Controls.Add(this.memNotesLabel);
            this.panelMemory.Controls.Add(this.memFreqDrop);
            this.panelMemory.Controls.Add(this.memRemindCheck);
            this.panelMemory.Controls.Add(this.memFileAttachButton);
            this.panelMemory.Controls.Add(this.memNotesBox);
            this.panelMemory.Controls.Add(this.memDatePick);
            this.panelMemory.Controls.Add(this.memAddressBox);
            this.panelMemory.Controls.Add(this.memNameBox);
            this.panelMemory.Controls.Add(this.memNameLabel);
            this.panelMemory.Controls.Add(this.memTitleLabel);
            this.panelMemory.Location = new System.Drawing.Point(13, 84);
            this.panelMemory.Name = "panelMemory";
            this.panelMemory.Size = new System.Drawing.Size(379, 461);
            this.panelMemory.TabIndex = 6;
            // 
            // memCancelButton
            // 
            this.memCancelButton.Location = new System.Drawing.Point(194, 428);
            this.memCancelButton.Name = "memCancelButton";
            this.memCancelButton.Size = new System.Drawing.Size(75, 23);
            this.memCancelButton.TabIndex = 43;
            this.memCancelButton.Text = "Cancel";
            this.memCancelButton.UseVisualStyleBackColor = true;
            this.memCancelButton.Click += new System.EventHandler(this.CancelClick);
            // 
            // memOKButton
            // 
            this.memOKButton.Location = new System.Drawing.Point(97, 428);
            this.memOKButton.Name = "memOKButton";
            this.memOKButton.Size = new System.Drawing.Size(75, 23);
            this.memOKButton.TabIndex = 42;
            this.memOKButton.Text = "OK";
            this.memOKButton.UseVisualStyleBackColor = true;
            this.memOKButton.Click += new System.EventHandler(this.AddEventClick);
            // 
            // memFileAttachLabel
            // 
            this.memFileAttachLabel.AutoSize = true;
            this.memFileAttachLabel.Location = new System.Drawing.Point(71, 394);
            this.memFileAttachLabel.Name = "memFileAttachLabel";
            this.memFileAttachLabel.Size = new System.Drawing.Size(57, 13);
            this.memFileAttachLabel.TabIndex = 40;
            this.memFileAttachLabel.Text = "Attach File";
            // 
            // memDateLabel
            // 
            this.memDateLabel.AutoSize = true;
            this.memDateLabel.Location = new System.Drawing.Point(98, 123);
            this.memDateLabel.Name = "memDateLabel";
            this.memDateLabel.Size = new System.Drawing.Size(30, 13);
            this.memDateLabel.TabIndex = 39;
            this.memDateLabel.Text = "Date";
            // 
            // memAddressLabel
            // 
            this.memAddressLabel.AutoSize = true;
            this.memAddressLabel.Location = new System.Drawing.Point(83, 88);
            this.memAddressLabel.Name = "memAddressLabel";
            this.memAddressLabel.Size = new System.Drawing.Size(45, 13);
            this.memAddressLabel.TabIndex = 38;
            this.memAddressLabel.Text = "Address";
            // 
            // memFreqLabel
            // 
            this.memFreqLabel.AutoSize = true;
            this.memFreqLabel.Location = new System.Drawing.Point(77, 176);
            this.memFreqLabel.Name = "memFreqLabel";
            this.memFreqLabel.Size = new System.Drawing.Size(57, 13);
            this.memFreqLabel.TabIndex = 37;
            this.memFreqLabel.Text = "Frequency";
            // 
            // memReminderLabel
            // 
            this.memReminderLabel.AutoSize = true;
            this.memReminderLabel.Location = new System.Drawing.Point(76, 147);
            this.memReminderLabel.Name = "memReminderLabel";
            this.memReminderLabel.Size = new System.Drawing.Size(58, 13);
            this.memReminderLabel.TabIndex = 36;
            this.memReminderLabel.Text = "Reminder?";
            // 
            // memNotesLabel
            // 
            this.memNotesLabel.AutoSize = true;
            this.memNotesLabel.Location = new System.Drawing.Point(93, 216);
            this.memNotesLabel.Name = "memNotesLabel";
            this.memNotesLabel.Size = new System.Drawing.Size(35, 13);
            this.memNotesLabel.TabIndex = 35;
            this.memNotesLabel.Text = "Notes";
            // 
            // memFreqDrop
            // 
            this.memFreqDrop.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.memFreqDrop.FormattingEnabled = true;
            this.memFreqDrop.Items.AddRange(new object[] {
            "Daily",
            "Weekly",
            "Fortnightly",
            "Monthly",
            "Bimonthly",
            "Biannually",
            "Annually"});
            this.memFreqDrop.Location = new System.Drawing.Point(157, 173);
            this.memFreqDrop.Name = "memFreqDrop";
            this.memFreqDrop.Size = new System.Drawing.Size(121, 21);
            this.memFreqDrop.TabIndex = 34;
            // 
            // memRemindCheck
            // 
            this.memRemindCheck.AutoSize = true;
            this.memRemindCheck.Location = new System.Drawing.Point(157, 147);
            this.memRemindCheck.Name = "memRemindCheck";
            this.memRemindCheck.Size = new System.Drawing.Size(15, 14);
            this.memRemindCheck.TabIndex = 33;
            this.memRemindCheck.UseVisualStyleBackColor = true;
            // 
            // memFileAttachButton
            // 
            this.memFileAttachButton.Location = new System.Drawing.Point(157, 389);
            this.memFileAttachButton.Name = "memFileAttachButton";
            this.memFileAttachButton.Size = new System.Drawing.Size(37, 23);
            this.memFileAttachButton.TabIndex = 32;
            this.memFileAttachButton.Text = "...";
            this.memFileAttachButton.UseVisualStyleBackColor = true;
            // 
            // memNotesBox
            // 
            this.memNotesBox.Location = new System.Drawing.Point(157, 213);
            this.memNotesBox.Multiline = true;
            this.memNotesBox.Name = "memNotesBox";
            this.memNotesBox.Size = new System.Drawing.Size(182, 160);
            this.memNotesBox.TabIndex = 31;
            // 
            // memDatePick
            // 
            this.memDatePick.Location = new System.Drawing.Point(157, 117);
            this.memDatePick.Name = "memDatePick";
            this.memDatePick.Size = new System.Drawing.Size(182, 20);
            this.memDatePick.TabIndex = 29;
            // 
            // memAddressBox
            // 
            this.memAddressBox.Location = new System.Drawing.Point(157, 85);
            this.memAddressBox.Name = "memAddressBox";
            this.memAddressBox.Size = new System.Drawing.Size(182, 20);
            this.memAddressBox.TabIndex = 28;
            // 
            // memNameBox
            // 
            this.memNameBox.Location = new System.Drawing.Point(157, 52);
            this.memNameBox.Name = "memNameBox";
            this.memNameBox.Size = new System.Drawing.Size(182, 20);
            this.memNameBox.TabIndex = 27;
            // 
            // memNameLabel
            // 
            this.memNameLabel.AutoSize = true;
            this.memNameLabel.Location = new System.Drawing.Point(93, 55);
            this.memNameLabel.Name = "memNameLabel";
            this.memNameLabel.Size = new System.Drawing.Size(35, 13);
            this.memNameLabel.TabIndex = 26;
            this.memNameLabel.Text = "Name";
            // 
            // memTitleLabel
            // 
            this.memTitleLabel.AutoSize = true;
            this.memTitleLabel.Font = new System.Drawing.Font("Calibri", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.memTitleLabel.Location = new System.Drawing.Point(139, 8);
            this.memTitleLabel.Name = "memTitleLabel";
            this.memTitleLabel.Size = new System.Drawing.Size(90, 27);
            this.memTitleLabel.TabIndex = 25;
            this.memTitleLabel.Text = "Memory";
            // 
            // panelPeople
            // 
            this.panelPeople.Controls.Add(this.perRelationBox);
            this.panelPeople.Controls.Add(this.perCancelButton);
            this.panelPeople.Controls.Add(this.perOKButton);
            this.panelPeople.Controls.Add(this.perFileAttachLabel);
            this.panelPeople.Controls.Add(this.perDateLabel);
            this.panelPeople.Controls.Add(this.perAddressLabel);
            this.panelPeople.Controls.Add(this.perRelationshipLabel);
            this.panelPeople.Controls.Add(this.perNotesLabel);
            this.panelPeople.Controls.Add(this.perFileAttachButton);
            this.panelPeople.Controls.Add(this.perNotesBox);
            this.panelPeople.Controls.Add(this.perDatePicker);
            this.panelPeople.Controls.Add(this.perAddressBox);
            this.panelPeople.Controls.Add(this.perNameBox);
            this.panelPeople.Controls.Add(this.perNAmeLabel);
            this.panelPeople.Controls.Add(this.perTitleLabel);
            this.panelPeople.Location = new System.Drawing.Point(13, 84);
            this.panelPeople.Name = "panelPeople";
            this.panelPeople.Size = new System.Drawing.Size(379, 461);
            this.panelPeople.TabIndex = 6;
            // 
            // perRelationBox
            // 
            this.perRelationBox.Location = new System.Drawing.Point(156, 150);
            this.perRelationBox.Name = "perRelationBox";
            this.perRelationBox.Size = new System.Drawing.Size(180, 20);
            this.perRelationBox.TabIndex = 61;
            // 
            // perCancelButton
            // 
            this.perCancelButton.Location = new System.Drawing.Point(193, 429);
            this.perCancelButton.Name = "perCancelButton";
            this.perCancelButton.Size = new System.Drawing.Size(75, 23);
            this.perCancelButton.TabIndex = 60;
            this.perCancelButton.Text = "Cancel";
            this.perCancelButton.UseVisualStyleBackColor = true;
            this.perCancelButton.Click += new System.EventHandler(this.CancelClick);
            // 
            // perOKButton
            // 
            this.perOKButton.Location = new System.Drawing.Point(96, 429);
            this.perOKButton.Name = "perOKButton";
            this.perOKButton.Size = new System.Drawing.Size(75, 23);
            this.perOKButton.TabIndex = 59;
            this.perOKButton.Text = "OK";
            this.perOKButton.UseVisualStyleBackColor = true;
            this.perOKButton.Click += new System.EventHandler(this.AddEventClick);
            // 
            // perFileAttachLabel
            // 
            this.perFileAttachLabel.AutoSize = true;
            this.perFileAttachLabel.Location = new System.Drawing.Point(70, 395);
            this.perFileAttachLabel.Name = "perFileAttachLabel";
            this.perFileAttachLabel.Size = new System.Drawing.Size(57, 13);
            this.perFileAttachLabel.TabIndex = 58;
            this.perFileAttachLabel.Text = "Attach File";
            // 
            // perDateLabel
            // 
            this.perDateLabel.AutoSize = true;
            this.perDateLabel.Location = new System.Drawing.Point(54, 122);
            this.perDateLabel.Name = "perDateLabel";
            this.perDateLabel.Size = new System.Drawing.Size(73, 13);
            this.perDateLabel.TabIndex = 57;
            this.perDateLabel.Text = "Date You Met";
            // 
            // perAddressLabel
            // 
            this.perAddressLabel.AutoSize = true;
            this.perAddressLabel.Location = new System.Drawing.Point(82, 89);
            this.perAddressLabel.Name = "perAddressLabel";
            this.perAddressLabel.Size = new System.Drawing.Size(45, 13);
            this.perAddressLabel.TabIndex = 56;
            this.perAddressLabel.Text = "Address";
            // 
            // perRelationshipLabel
            // 
            this.perRelationshipLabel.AutoSize = true;
            this.perRelationshipLabel.Location = new System.Drawing.Point(62, 153);
            this.perRelationshipLabel.Name = "perRelationshipLabel";
            this.perRelationshipLabel.Size = new System.Drawing.Size(65, 13);
            this.perRelationshipLabel.TabIndex = 54;
            this.perRelationshipLabel.Text = "Relationship";
            // 
            // perNotesLabel
            // 
            this.perNotesLabel.AutoSize = true;
            this.perNotesLabel.Location = new System.Drawing.Point(94, 183);
            this.perNotesLabel.Name = "perNotesLabel";
            this.perNotesLabel.Size = new System.Drawing.Size(35, 13);
            this.perNotesLabel.TabIndex = 53;
            this.perNotesLabel.Text = "Notes";
            // 
            // perFileAttachButton
            // 
            this.perFileAttachButton.Location = new System.Drawing.Point(156, 390);
            this.perFileAttachButton.Name = "perFileAttachButton";
            this.perFileAttachButton.Size = new System.Drawing.Size(37, 23);
            this.perFileAttachButton.TabIndex = 50;
            this.perFileAttachButton.Text = "...";
            this.perFileAttachButton.UseVisualStyleBackColor = true;
            // 
            // perNotesBox
            // 
            this.perNotesBox.Location = new System.Drawing.Point(156, 180);
            this.perNotesBox.Multiline = true;
            this.perNotesBox.Name = "perNotesBox";
            this.perNotesBox.Size = new System.Drawing.Size(182, 198);
            this.perNotesBox.TabIndex = 49;
            // 
            // perDatePicker
            // 
            this.perDatePicker.Location = new System.Drawing.Point(156, 118);
            this.perDatePicker.Name = "perDatePicker";
            this.perDatePicker.Size = new System.Drawing.Size(182, 20);
            this.perDatePicker.TabIndex = 48;
            // 
            // perAddressBox
            // 
            this.perAddressBox.Location = new System.Drawing.Point(156, 86);
            this.perAddressBox.Name = "perAddressBox";
            this.perAddressBox.Size = new System.Drawing.Size(182, 20);
            this.perAddressBox.TabIndex = 47;
            // 
            // perNameBox
            // 
            this.perNameBox.Location = new System.Drawing.Point(156, 53);
            this.perNameBox.Name = "perNameBox";
            this.perNameBox.Size = new System.Drawing.Size(182, 20);
            this.perNameBox.TabIndex = 46;
            // 
            // perNAmeLabel
            // 
            this.perNAmeLabel.AutoSize = true;
            this.perNAmeLabel.Location = new System.Drawing.Point(92, 56);
            this.perNAmeLabel.Name = "perNAmeLabel";
            this.perNAmeLabel.Size = new System.Drawing.Size(35, 13);
            this.perNAmeLabel.TabIndex = 45;
            this.perNAmeLabel.Text = "Name";
            // 
            // perTitleLabel
            // 
            this.perTitleLabel.AutoSize = true;
            this.perTitleLabel.Font = new System.Drawing.Font("Calibri", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.perTitleLabel.Location = new System.Drawing.Point(151, 8);
            this.perTitleLabel.Name = "perTitleLabel";
            this.perTitleLabel.Size = new System.Drawing.Size(75, 27);
            this.perTitleLabel.TabIndex = 44;
            this.perTitleLabel.Text = "Person";
            // 
            // panelTask
            // 
            this.panelTask.Controls.Add(this.taskCompleteCheck);
            this.panelTask.Controls.Add(this.taskCancelButton);
            this.panelTask.Controls.Add(this.taskOKButton);
            this.panelTask.Controls.Add(this.taskFileAttachLabel);
            this.panelTask.Controls.Add(this.taskDateLabel);
            this.panelTask.Controls.Add(this.taskAddressLabel);
            this.panelTask.Controls.Add(this.taskCompletedLabel);
            this.panelTask.Controls.Add(this.taskNotesLabel);
            this.panelTask.Controls.Add(this.taskFileAttachButton);
            this.panelTask.Controls.Add(this.taskNotesBox);
            this.panelTask.Controls.Add(this.taskDatePicker);
            this.panelTask.Controls.Add(this.taskAddressBox);
            this.panelTask.Controls.Add(this.taskNameBox);
            this.panelTask.Controls.Add(this.taskNameLabel);
            this.panelTask.Controls.Add(this.taskTitleLabel);
            this.panelTask.Location = new System.Drawing.Point(13, 84);
            this.panelTask.Name = "panelTask";
            this.panelTask.Size = new System.Drawing.Size(379, 461);
            this.panelTask.TabIndex = 6;
            // 
            // taskCompleteCheck
            // 
            this.taskCompleteCheck.AutoSize = true;
            this.taskCompleteCheck.Location = new System.Drawing.Point(156, 152);
            this.taskCompleteCheck.Name = "taskCompleteCheck";
            this.taskCompleteCheck.Size = new System.Drawing.Size(15, 14);
            this.taskCompleteCheck.TabIndex = 76;
            this.taskCompleteCheck.UseVisualStyleBackColor = true;
            // 
            // taskCancelButton
            // 
            this.taskCancelButton.Location = new System.Drawing.Point(194, 429);
            this.taskCancelButton.Name = "taskCancelButton";
            this.taskCancelButton.Size = new System.Drawing.Size(75, 23);
            this.taskCancelButton.TabIndex = 75;
            this.taskCancelButton.Text = "Cancel";
            this.taskCancelButton.UseVisualStyleBackColor = true;
            this.taskCancelButton.Click += new System.EventHandler(this.CancelClick);
            // 
            // taskOKButton
            // 
            this.taskOKButton.Location = new System.Drawing.Point(97, 429);
            this.taskOKButton.Name = "taskOKButton";
            this.taskOKButton.Size = new System.Drawing.Size(75, 23);
            this.taskOKButton.TabIndex = 74;
            this.taskOKButton.Text = "OK";
            this.taskOKButton.UseVisualStyleBackColor = true;
            this.taskOKButton.Click += new System.EventHandler(this.AddEventClick);
            // 
            // taskFileAttachLabel
            // 
            this.taskFileAttachLabel.AutoSize = true;
            this.taskFileAttachLabel.Location = new System.Drawing.Point(71, 395);
            this.taskFileAttachLabel.Name = "taskFileAttachLabel";
            this.taskFileAttachLabel.Size = new System.Drawing.Size(57, 13);
            this.taskFileAttachLabel.TabIndex = 73;
            this.taskFileAttachLabel.Text = "Attach File";
            // 
            // taskDateLabel
            // 
            this.taskDateLabel.AutoSize = true;
            this.taskDateLabel.Location = new System.Drawing.Point(75, 122);
            this.taskDateLabel.Name = "taskDateLabel";
            this.taskDateLabel.Size = new System.Drawing.Size(53, 13);
            this.taskDateLabel.TabIndex = 72;
            this.taskDateLabel.Text = "Date Due";
            // 
            // taskAddressLabel
            // 
            this.taskAddressLabel.AutoSize = true;
            this.taskAddressLabel.Location = new System.Drawing.Point(83, 89);
            this.taskAddressLabel.Name = "taskAddressLabel";
            this.taskAddressLabel.Size = new System.Drawing.Size(45, 13);
            this.taskAddressLabel.TabIndex = 71;
            this.taskAddressLabel.Text = "Address";
            // 
            // taskCompletedLabel
            // 
            this.taskCompletedLabel.AutoSize = true;
            this.taskCompletedLabel.Location = new System.Drawing.Point(66, 153);
            this.taskCompletedLabel.Name = "taskCompletedLabel";
            this.taskCompletedLabel.Size = new System.Drawing.Size(63, 13);
            this.taskCompletedLabel.TabIndex = 70;
            this.taskCompletedLabel.Text = "Completed?";
            // 
            // taskNotesLabel
            // 
            this.taskNotesLabel.AutoSize = true;
            this.taskNotesLabel.Location = new System.Drawing.Point(95, 183);
            this.taskNotesLabel.Name = "taskNotesLabel";
            this.taskNotesLabel.Size = new System.Drawing.Size(35, 13);
            this.taskNotesLabel.TabIndex = 69;
            this.taskNotesLabel.Text = "Notes";
            // 
            // taskFileAttachButton
            // 
            this.taskFileAttachButton.Location = new System.Drawing.Point(157, 390);
            this.taskFileAttachButton.Name = "taskFileAttachButton";
            this.taskFileAttachButton.Size = new System.Drawing.Size(37, 23);
            this.taskFileAttachButton.TabIndex = 68;
            this.taskFileAttachButton.Text = "...";
            this.taskFileAttachButton.UseVisualStyleBackColor = true;
            // 
            // taskNotesBox
            // 
            this.taskNotesBox.Location = new System.Drawing.Point(157, 180);
            this.taskNotesBox.Multiline = true;
            this.taskNotesBox.Name = "taskNotesBox";
            this.taskNotesBox.Size = new System.Drawing.Size(182, 198);
            this.taskNotesBox.TabIndex = 67;
            // 
            // taskDatePicker
            // 
            this.taskDatePicker.Location = new System.Drawing.Point(157, 118);
            this.taskDatePicker.Name = "taskDatePicker";
            this.taskDatePicker.Size = new System.Drawing.Size(182, 20);
            this.taskDatePicker.TabIndex = 66;
            // 
            // taskAddressBox
            // 
            this.taskAddressBox.Location = new System.Drawing.Point(157, 86);
            this.taskAddressBox.Name = "taskAddressBox";
            this.taskAddressBox.Size = new System.Drawing.Size(182, 20);
            this.taskAddressBox.TabIndex = 65;
            // 
            // taskNameBox
            // 
            this.taskNameBox.Location = new System.Drawing.Point(157, 53);
            this.taskNameBox.Name = "taskNameBox";
            this.taskNameBox.Size = new System.Drawing.Size(182, 20);
            this.taskNameBox.TabIndex = 64;
            // 
            // taskNameLabel
            // 
            this.taskNameLabel.AutoSize = true;
            this.taskNameLabel.Location = new System.Drawing.Point(93, 56);
            this.taskNameLabel.Name = "taskNameLabel";
            this.taskNameLabel.Size = new System.Drawing.Size(35, 13);
            this.taskNameLabel.TabIndex = 63;
            this.taskNameLabel.Text = "Name";
            // 
            // taskTitleLabel
            // 
            this.taskTitleLabel.AutoSize = true;
            this.taskTitleLabel.Font = new System.Drawing.Font("Calibri", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.taskTitleLabel.Location = new System.Drawing.Point(158, 8);
            this.taskTitleLabel.Name = "taskTitleLabel";
            this.taskTitleLabel.Size = new System.Drawing.Size(51, 27);
            this.taskTitleLabel.TabIndex = 62;
            this.taskTitleLabel.Text = "Task";
            // 
            // AddEvent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 553);
            this.Controls.Add(this.panelTask);
            this.Controls.Add(this.panelPeople);
            this.Controls.Add(this.panelMemory);
            this.Controls.Add(this.panelAppointment);
            this.Controls.Add(this.dropdownEvent);
            this.Controls.Add(this.eventTypeLabel);
            this.Controls.Add(this.modifyEvent);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddEvent";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Event Editing";
            this.panelAppointment.ResumeLayout(false);
            this.panelAppointment.PerformLayout();
            this.panelMemory.ResumeLayout(false);
            this.panelMemory.PerformLayout();
            this.panelPeople.ResumeLayout(false);
            this.panelPeople.PerformLayout();
            this.panelTask.ResumeLayout(false);
            this.panelTask.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label modifyEvent;
        private System.Windows.Forms.Label eventTypeLabel;
        private System.Windows.Forms.ComboBox dropdownEvent;
        private System.Windows.Forms.Panel panelAppointment;
        private System.Windows.Forms.Panel panelMemory;
        private System.Windows.Forms.Panel panelPeople;
        private System.Windows.Forms.Panel panelTask;
        private System.Windows.Forms.SaveFileDialog fileAttachDialog;
        private System.Windows.Forms.Button apCancelButton;
        private System.Windows.Forms.Button apOKButton;
        private System.Windows.Forms.Label apTimeLabel;
        private System.Windows.Forms.Label apFileAttachLabel;
        private System.Windows.Forms.Label apDateLabel;
        private System.Windows.Forms.Label apAddressLabel;
        private System.Windows.Forms.Label apFreqLabel;
        private System.Windows.Forms.Label apRecurLabel;
        private System.Windows.Forms.Label apNotesLabel;
        private System.Windows.Forms.ComboBox apFreqDrop;
        private System.Windows.Forms.CheckBox apRecurCheck;
        private System.Windows.Forms.Button apFileAttachButton;
        private System.Windows.Forms.TextBox apNotesBox;
        private System.Windows.Forms.DateTimePicker apTimePicker;
        private System.Windows.Forms.DateTimePicker apDatePicker;
        private System.Windows.Forms.TextBox apAddressBox;
        private System.Windows.Forms.TextBox apNameBox;
        private System.Windows.Forms.Label apNameLabel;
        private System.Windows.Forms.Label apTitleLabel;
        private System.Windows.Forms.Button memCancelButton;
        private System.Windows.Forms.Button memOKButton;
        private System.Windows.Forms.Label memFileAttachLabel;
        private System.Windows.Forms.Label memDateLabel;
        private System.Windows.Forms.Label memAddressLabel;
        private System.Windows.Forms.Label memFreqLabel;
        private System.Windows.Forms.Label memReminderLabel;
        private System.Windows.Forms.Label memNotesLabel;
        private System.Windows.Forms.ComboBox memFreqDrop;
        private System.Windows.Forms.CheckBox memRemindCheck;
        private System.Windows.Forms.Button memFileAttachButton;
        private System.Windows.Forms.TextBox memNotesBox;
        private System.Windows.Forms.DateTimePicker memDatePick;
        private System.Windows.Forms.TextBox memAddressBox;
        private System.Windows.Forms.TextBox memNameBox;
        private System.Windows.Forms.Label memNameLabel;
        private System.Windows.Forms.Label memTitleLabel;
        private System.Windows.Forms.TextBox perRelationBox;
        private System.Windows.Forms.Button perCancelButton;
        private System.Windows.Forms.Button perOKButton;
        private System.Windows.Forms.Label perFileAttachLabel;
        private System.Windows.Forms.Label perDateLabel;
        private System.Windows.Forms.Label perAddressLabel;
        private System.Windows.Forms.Label perRelationshipLabel;
        private System.Windows.Forms.Label perNotesLabel;
        private System.Windows.Forms.Button perFileAttachButton;
        private System.Windows.Forms.TextBox perNotesBox;
        private System.Windows.Forms.DateTimePicker perDatePicker;
        private System.Windows.Forms.TextBox perAddressBox;
        private System.Windows.Forms.TextBox perNameBox;
        private System.Windows.Forms.Label perNAmeLabel;
        private System.Windows.Forms.Label perTitleLabel;
        private System.Windows.Forms.CheckBox taskCompleteCheck;
        private System.Windows.Forms.Button taskCancelButton;
        private System.Windows.Forms.Button taskOKButton;
        private System.Windows.Forms.Label taskFileAttachLabel;
        private System.Windows.Forms.Label taskDateLabel;
        private System.Windows.Forms.Label taskAddressLabel;
        private System.Windows.Forms.Label taskCompletedLabel;
        private System.Windows.Forms.Label taskNotesLabel;
        private System.Windows.Forms.Button taskFileAttachButton;
        private System.Windows.Forms.TextBox taskNotesBox;
        private System.Windows.Forms.DateTimePicker taskDatePicker;
        private System.Windows.Forms.TextBox taskAddressBox;
        private System.Windows.Forms.TextBox taskNameBox;
        private System.Windows.Forms.Label taskNameLabel;
        private System.Windows.Forms.Label taskTitleLabel;
    }
}
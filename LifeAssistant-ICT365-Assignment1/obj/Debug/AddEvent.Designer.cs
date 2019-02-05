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
            this.appointPanel = new System.Windows.Forms.Panel();
            this.appFileAttachButton = new System.Windows.Forms.Button();
            this.appFrequency = new System.Windows.Forms.ComboBox();
            this.appRecurCheck = new System.Windows.Forms.CheckBox();
            this.appNotesBox = new System.Windows.Forms.TextBox();
            this.appAddressText = new System.Windows.Forms.TextBox();
            this.appNameText = new System.Windows.Forms.TextBox();
            this.appTimePick = new System.Windows.Forms.DateTimePicker();
            this.appDatePick = new System.Windows.Forms.DateTimePicker();
            this.appCancel = new System.Windows.Forms.Button();
            this.appOK = new System.Windows.Forms.Button();
            this.appFile = new System.Windows.Forms.Label();
            this.appFreq = new System.Windows.Forms.Label();
            this.appRecur = new System.Windows.Forms.Label();
            this.appNotes = new System.Windows.Forms.Label();
            this.appLocation = new System.Windows.Forms.Label();
            this.appTime = new System.Windows.Forms.Label();
            this.appDate = new System.Windows.Forms.Label();
            this.appointTitle = new System.Windows.Forms.Label();
            this.appName = new System.Windows.Forms.Label();
            this.memoryPanel = new System.Windows.Forms.Panel();
            this.memoryFileAttach = new System.Windows.Forms.Button();
            this.memoryFrequencyDrop = new System.Windows.Forms.ComboBox();
            this.memoryReminderCheck = new System.Windows.Forms.CheckBox();
            this.memoryNotes = new System.Windows.Forms.TextBox();
            this.memoryAddressbox = new System.Windows.Forms.TextBox();
            this.memoryTitleBox = new System.Windows.Forms.TextBox();
            this.memoryDateTime = new System.Windows.Forms.DateTimePicker();
            this.memoryCancel = new System.Windows.Forms.Button();
            this.memoryOKButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.memoryTitle = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.peoplePanel = new System.Windows.Forms.Panel();
            this.peopleAddress = new System.Windows.Forms.TextBox();
            this.peopleFileAttach = new System.Windows.Forms.Button();
            this.peopleNotes = new System.Windows.Forms.TextBox();
            this.peopleRelationship = new System.Windows.Forms.TextBox();
            this.peopleName = new System.Windows.Forms.TextBox();
            this.peopleDateTime = new System.Windows.Forms.DateTimePicker();
            this.peopleCancel = new System.Windows.Forms.Button();
            this.peopleOK = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.personTitle = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.taskPanel = new System.Windows.Forms.Panel();
            this.taskFileAttach = new System.Windows.Forms.Button();
            this.taskCheckBox = new System.Windows.Forms.CheckBox();
            this.taskNotes = new System.Windows.Forms.TextBox();
            this.taskAddress = new System.Windows.Forms.TextBox();
            this.taskTitleBox = new System.Windows.Forms.TextBox();
            this.taskDateTime = new System.Windows.Forms.DateTimePicker();
            this.taskCancel = new System.Windows.Forms.Button();
            this.taskOKButton = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.taskTitle = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.filePicker = new System.Windows.Forms.OpenFileDialog();
            this.appointPanel.SuspendLayout();
            this.memoryPanel.SuspendLayout();
            this.peoplePanel.SuspendLayout();
            this.taskPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // modifyEvent
            // 
            this.modifyEvent.AutoSize = true;
            this.modifyEvent.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modifyEvent.Location = new System.Drawing.Point(130, 9);
            this.modifyEvent.Name = "modifyEvent";
            this.modifyEvent.Size = new System.Drawing.Size(139, 24);
            this.modifyEvent.TabIndex = 2;
            this.modifyEvent.Text = "Event Editing";
            // 
            // eventTypeLabel
            // 
            this.eventTypeLabel.AutoSize = true;
            this.eventTypeLabel.Location = new System.Drawing.Point(95, 54);
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
            this.dropdownEvent.Location = new System.Drawing.Point(163, 51);
            this.dropdownEvent.Name = "dropdownEvent";
            this.dropdownEvent.Size = new System.Drawing.Size(121, 21);
            this.dropdownEvent.TabIndex = 4;
            this.dropdownEvent.SelectedIndexChanged += new System.EventHandler(this.dropdownEvent_SelectedIndexChanged);
            // 
            // appointPanel
            // 
            this.appointPanel.Controls.Add(this.appFileAttachButton);
            this.appointPanel.Controls.Add(this.appFrequency);
            this.appointPanel.Controls.Add(this.appRecurCheck);
            this.appointPanel.Controls.Add(this.appNotesBox);
            this.appointPanel.Controls.Add(this.appAddressText);
            this.appointPanel.Controls.Add(this.appNameText);
            this.appointPanel.Controls.Add(this.appTimePick);
            this.appointPanel.Controls.Add(this.appDatePick);
            this.appointPanel.Controls.Add(this.appCancel);
            this.appointPanel.Controls.Add(this.appOK);
            this.appointPanel.Controls.Add(this.appFile);
            this.appointPanel.Controls.Add(this.appFreq);
            this.appointPanel.Controls.Add(this.appRecur);
            this.appointPanel.Controls.Add(this.appNotes);
            this.appointPanel.Controls.Add(this.appLocation);
            this.appointPanel.Controls.Add(this.appTime);
            this.appointPanel.Controls.Add(this.appDate);
            this.appointPanel.Controls.Add(this.appointTitle);
            this.appointPanel.Controls.Add(this.appName);
            this.appointPanel.Location = new System.Drawing.Point(24, 88);
            this.appointPanel.Name = "appointPanel";
            this.appointPanel.Size = new System.Drawing.Size(336, 432);
            this.appointPanel.TabIndex = 5;
            // 
            // appFileAttachButton
            // 
            this.appFileAttachButton.Location = new System.Drawing.Point(136, 345);
            this.appFileAttachButton.Name = "appFileAttachButton";
            this.appFileAttachButton.Size = new System.Drawing.Size(24, 23);
            this.appFileAttachButton.TabIndex = 38;
            this.appFileAttachButton.Text = "...";
            this.appFileAttachButton.UseVisualStyleBackColor = true;
            this.appFileAttachButton.Click += new System.EventHandler(this.FileAttachment);
            // 
            // appFrequency
            // 
            this.appFrequency.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.appFrequency.FormattingEnabled = true;
            this.appFrequency.Items.AddRange(new object[] {
            "Daily",
            "Weekly",
            "Fortnightly",
            "Monthly",
            "Bimonthly",
            "Biannually",
            "Annually"});
            this.appFrequency.Location = new System.Drawing.Point(136, 217);
            this.appFrequency.Name = "appFrequency";
            this.appFrequency.Size = new System.Drawing.Size(113, 21);
            this.appFrequency.TabIndex = 37;
            // 
            // appRecurCheck
            // 
            this.appRecurCheck.AutoSize = true;
            this.appRecurCheck.Location = new System.Drawing.Point(136, 185);
            this.appRecurCheck.Name = "appRecurCheck";
            this.appRecurCheck.Size = new System.Drawing.Size(15, 14);
            this.appRecurCheck.TabIndex = 36;
            this.appRecurCheck.UseVisualStyleBackColor = true;
            // 
            // appNotesBox
            // 
            this.appNotesBox.Location = new System.Drawing.Point(136, 249);
            this.appNotesBox.Multiline = true;
            this.appNotesBox.Name = "appNotesBox";
            this.appNotesBox.Size = new System.Drawing.Size(168, 88);
            this.appNotesBox.TabIndex = 35;
            // 
            // appAddressText
            // 
            this.appAddressText.Location = new System.Drawing.Point(136, 153);
            this.appAddressText.Name = "appAddressText";
            this.appAddressText.Size = new System.Drawing.Size(168, 20);
            this.appAddressText.TabIndex = 34;
            // 
            // appNameText
            // 
            this.appNameText.Location = new System.Drawing.Point(136, 57);
            this.appNameText.Name = "appNameText";
            this.appNameText.Size = new System.Drawing.Size(168, 20);
            this.appNameText.TabIndex = 33;
            // 
            // appTimePick
            // 
            this.appTimePick.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.appTimePick.Location = new System.Drawing.Point(136, 121);
            this.appTimePick.Name = "appTimePick";
            this.appTimePick.ShowUpDown = true;
            this.appTimePick.Size = new System.Drawing.Size(80, 20);
            this.appTimePick.TabIndex = 32;
            // 
            // appDatePick
            // 
            this.appDatePick.Location = new System.Drawing.Point(136, 89);
            this.appDatePick.Name = "appDatePick";
            this.appDatePick.Size = new System.Drawing.Size(168, 20);
            this.appDatePick.TabIndex = 31;
            // 
            // appCancel
            // 
            this.appCancel.Location = new System.Drawing.Point(184, 393);
            this.appCancel.Name = "appCancel";
            this.appCancel.Size = new System.Drawing.Size(75, 23);
            this.appCancel.TabIndex = 30;
            this.appCancel.Text = "Cancel";
            this.appCancel.UseVisualStyleBackColor = true;
            this.appCancel.Click += new System.EventHandler(this.CancelForm);
            // 
            // appOK
            // 
            this.appOK.Location = new System.Drawing.Point(80, 393);
            this.appOK.Name = "appOK";
            this.appOK.Size = new System.Drawing.Size(80, 23);
            this.appOK.TabIndex = 29;
            this.appOK.Text = "OK";
            this.appOK.UseVisualStyleBackColor = true;
            this.appOK.Click += new System.EventHandler(this.EnterEvent);
            // 
            // appFile
            // 
            this.appFile.AutoSize = true;
            this.appFile.Location = new System.Drawing.Point(32, 353);
            this.appFile.Name = "appFile";
            this.appFile.Size = new System.Drawing.Size(80, 13);
            this.appFile.TabIndex = 28;
            this.appFile.Text = "File Attachment";
            // 
            // appFreq
            // 
            this.appFreq.AutoSize = true;
            this.appFreq.Location = new System.Drawing.Point(48, 217);
            this.appFreq.Name = "appFreq";
            this.appFreq.Size = new System.Drawing.Size(57, 13);
            this.appFreq.TabIndex = 27;
            this.appFreq.Text = "Frequency";
            // 
            // appRecur
            // 
            this.appRecur.AutoSize = true;
            this.appRecur.Location = new System.Drawing.Point(48, 185);
            this.appRecur.Name = "appRecur";
            this.appRecur.Size = new System.Drawing.Size(59, 13);
            this.appRecur.TabIndex = 26;
            this.appRecur.Text = "Recurring?";
            // 
            // appNotes
            // 
            this.appNotes.AutoSize = true;
            this.appNotes.Location = new System.Drawing.Point(72, 249);
            this.appNotes.Name = "appNotes";
            this.appNotes.Size = new System.Drawing.Size(35, 13);
            this.appNotes.TabIndex = 25;
            this.appNotes.Text = "Notes";
            // 
            // appLocation
            // 
            this.appLocation.AutoSize = true;
            this.appLocation.Location = new System.Drawing.Point(64, 161);
            this.appLocation.Name = "appLocation";
            this.appLocation.Size = new System.Drawing.Size(45, 13);
            this.appLocation.TabIndex = 24;
            this.appLocation.Text = "Address";
            // 
            // appTime
            // 
            this.appTime.AutoSize = true;
            this.appTime.Location = new System.Drawing.Point(80, 129);
            this.appTime.Name = "appTime";
            this.appTime.Size = new System.Drawing.Size(30, 13);
            this.appTime.TabIndex = 23;
            this.appTime.Text = "Time";
            // 
            // appDate
            // 
            this.appDate.AutoSize = true;
            this.appDate.Location = new System.Drawing.Point(80, 97);
            this.appDate.Name = "appDate";
            this.appDate.Size = new System.Drawing.Size(30, 13);
            this.appDate.TabIndex = 22;
            this.appDate.Text = "Date";
            // 
            // appointTitle
            // 
            this.appointTitle.AutoSize = true;
            this.appointTitle.Font = new System.Drawing.Font("Calibri", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.appointTitle.Location = new System.Drawing.Point(104, 17);
            this.appointTitle.Name = "appointTitle";
            this.appointTitle.Size = new System.Drawing.Size(133, 27);
            this.appointTitle.TabIndex = 21;
            this.appointTitle.Text = "Appointment";
            // 
            // appName
            // 
            this.appName.AutoSize = true;
            this.appName.Location = new System.Drawing.Point(16, 65);
            this.appName.Name = "appName";
            this.appName.Size = new System.Drawing.Size(97, 13);
            this.appName.TabIndex = 20;
            this.appName.Text = "Appointment Name";
            // 
            // memoryPanel
            // 
            this.memoryPanel.Controls.Add(this.memoryFileAttach);
            this.memoryPanel.Controls.Add(this.memoryFrequencyDrop);
            this.memoryPanel.Controls.Add(this.memoryReminderCheck);
            this.memoryPanel.Controls.Add(this.memoryNotes);
            this.memoryPanel.Controls.Add(this.memoryAddressbox);
            this.memoryPanel.Controls.Add(this.memoryTitleBox);
            this.memoryPanel.Controls.Add(this.memoryDateTime);
            this.memoryPanel.Controls.Add(this.memoryCancel);
            this.memoryPanel.Controls.Add(this.memoryOKButton);
            this.memoryPanel.Controls.Add(this.label1);
            this.memoryPanel.Controls.Add(this.label2);
            this.memoryPanel.Controls.Add(this.label3);
            this.memoryPanel.Controls.Add(this.label4);
            this.memoryPanel.Controls.Add(this.label5);
            this.memoryPanel.Controls.Add(this.label6);
            this.memoryPanel.Controls.Add(this.memoryTitle);
            this.memoryPanel.Controls.Add(this.label8);
            this.memoryPanel.Location = new System.Drawing.Point(24, 88);
            this.memoryPanel.Name = "memoryPanel";
            this.memoryPanel.Size = new System.Drawing.Size(336, 432);
            this.memoryPanel.TabIndex = 6;
            // 
            // memoryFileAttach
            // 
            this.memoryFileAttach.Location = new System.Drawing.Point(128, 344);
            this.memoryFileAttach.Name = "memoryFileAttach";
            this.memoryFileAttach.Size = new System.Drawing.Size(40, 23);
            this.memoryFileAttach.TabIndex = 36;
            this.memoryFileAttach.Text = "...";
            this.memoryFileAttach.UseVisualStyleBackColor = true;
            this.memoryFileAttach.Click += new System.EventHandler(this.FileAttachment);
            // 
            // memoryFrequencyDrop
            // 
            this.memoryFrequencyDrop.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.memoryFrequencyDrop.FormattingEnabled = true;
            this.memoryFrequencyDrop.Items.AddRange(new object[] {
            "Daily",
            "Weekly",
            "Fortnightly",
            "Monthly",
            "Bimonthly",
            "Biannually",
            "Annually"});
            this.memoryFrequencyDrop.Location = new System.Drawing.Point(128, 176);
            this.memoryFrequencyDrop.Name = "memoryFrequencyDrop";
            this.memoryFrequencyDrop.Size = new System.Drawing.Size(129, 21);
            this.memoryFrequencyDrop.TabIndex = 35;
            // 
            // memoryReminderCheck
            // 
            this.memoryReminderCheck.AutoSize = true;
            this.memoryReminderCheck.Location = new System.Drawing.Point(128, 152);
            this.memoryReminderCheck.Name = "memoryReminderCheck";
            this.memoryReminderCheck.Size = new System.Drawing.Size(15, 14);
            this.memoryReminderCheck.TabIndex = 34;
            this.memoryReminderCheck.UseVisualStyleBackColor = true;
            // 
            // memoryNotes
            // 
            this.memoryNotes.Location = new System.Drawing.Point(128, 208);
            this.memoryNotes.Multiline = true;
            this.memoryNotes.Name = "memoryNotes";
            this.memoryNotes.Size = new System.Drawing.Size(184, 128);
            this.memoryNotes.TabIndex = 33;
            // 
            // memoryAddressbox
            // 
            this.memoryAddressbox.Location = new System.Drawing.Point(128, 120);
            this.memoryAddressbox.Name = "memoryAddressbox";
            this.memoryAddressbox.Size = new System.Drawing.Size(184, 20);
            this.memoryAddressbox.TabIndex = 32;
            // 
            // memoryTitleBox
            // 
            this.memoryTitleBox.Location = new System.Drawing.Point(128, 56);
            this.memoryTitleBox.Name = "memoryTitleBox";
            this.memoryTitleBox.Size = new System.Drawing.Size(184, 20);
            this.memoryTitleBox.TabIndex = 31;
            // 
            // memoryDateTime
            // 
            this.memoryDateTime.Location = new System.Drawing.Point(128, 88);
            this.memoryDateTime.Name = "memoryDateTime";
            this.memoryDateTime.Size = new System.Drawing.Size(184, 20);
            this.memoryDateTime.TabIndex = 30;
            // 
            // memoryCancel
            // 
            this.memoryCancel.Location = new System.Drawing.Point(176, 392);
            this.memoryCancel.Name = "memoryCancel";
            this.memoryCancel.Size = new System.Drawing.Size(91, 23);
            this.memoryCancel.TabIndex = 29;
            this.memoryCancel.Text = "Cancel";
            this.memoryCancel.UseVisualStyleBackColor = true;
            this.memoryCancel.Click += new System.EventHandler(this.CancelForm);
            // 
            // memoryOKButton
            // 
            this.memoryOKButton.Location = new System.Drawing.Point(72, 392);
            this.memoryOKButton.Name = "memoryOKButton";
            this.memoryOKButton.Size = new System.Drawing.Size(96, 23);
            this.memoryOKButton.TabIndex = 28;
            this.memoryOKButton.Text = "OK";
            this.memoryOKButton.UseVisualStyleBackColor = true;
            this.memoryOKButton.Click += new System.EventHandler(this.EnterEvent);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 352);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 27;
            this.label1.Text = "File Attachment";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 176);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 26;
            this.label2.Text = "Frequency";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 25;
            this.label3.Text = "Reminder?";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(64, 208);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 24;
            this.label4.Text = "Notes";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(56, 120);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 23;
            this.label5.Text = "Address";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(72, 96);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 13);
            this.label6.TabIndex = 22;
            this.label6.Text = "Date";
            // 
            // memoryTitle
            // 
            this.memoryTitle.AutoSize = true;
            this.memoryTitle.Font = new System.Drawing.Font("Calibri", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.memoryTitle.Location = new System.Drawing.Point(128, 16);
            this.memoryTitle.Name = "memoryTitle";
            this.memoryTitle.Size = new System.Drawing.Size(90, 27);
            this.memoryTitle.TabIndex = 21;
            this.memoryTitle.Text = "Memory";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(72, 64);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(27, 13);
            this.label8.TabIndex = 20;
            this.label8.Text = "Title";
            // 
            // peoplePanel
            // 
            this.peoplePanel.Controls.Add(this.peopleAddress);
            this.peoplePanel.Controls.Add(this.peopleFileAttach);
            this.peoplePanel.Controls.Add(this.peopleNotes);
            this.peoplePanel.Controls.Add(this.peopleRelationship);
            this.peoplePanel.Controls.Add(this.peopleName);
            this.peoplePanel.Controls.Add(this.peopleDateTime);
            this.peoplePanel.Controls.Add(this.peopleCancel);
            this.peoplePanel.Controls.Add(this.peopleOK);
            this.peoplePanel.Controls.Add(this.label9);
            this.peoplePanel.Controls.Add(this.label10);
            this.peoplePanel.Controls.Add(this.label11);
            this.peoplePanel.Controls.Add(this.label12);
            this.peoplePanel.Controls.Add(this.label13);
            this.peoplePanel.Controls.Add(this.personTitle);
            this.peoplePanel.Controls.Add(this.label15);
            this.peoplePanel.Location = new System.Drawing.Point(24, 88);
            this.peoplePanel.Name = "peoplePanel";
            this.peoplePanel.Size = new System.Drawing.Size(336, 432);
            this.peoplePanel.TabIndex = 6;
            // 
            // peopleAddress
            // 
            this.peopleAddress.Location = new System.Drawing.Point(132, 121);
            this.peopleAddress.Name = "peopleAddress";
            this.peopleAddress.Size = new System.Drawing.Size(176, 20);
            this.peopleAddress.TabIndex = 35;
            // 
            // peopleFileAttach
            // 
            this.peopleFileAttach.Location = new System.Drawing.Point(132, 345);
            this.peopleFileAttach.Name = "peopleFileAttach";
            this.peopleFileAttach.Size = new System.Drawing.Size(32, 23);
            this.peopleFileAttach.TabIndex = 34;
            this.peopleFileAttach.Text = "...";
            this.peopleFileAttach.UseVisualStyleBackColor = true;
            this.peopleFileAttach.Click += new System.EventHandler(this.FileAttachment);
            // 
            // peopleNotes
            // 
            this.peopleNotes.Location = new System.Drawing.Point(132, 185);
            this.peopleNotes.Multiline = true;
            this.peopleNotes.Name = "peopleNotes";
            this.peopleNotes.Size = new System.Drawing.Size(176, 152);
            this.peopleNotes.TabIndex = 33;
            // 
            // peopleRelationship
            // 
            this.peopleRelationship.Location = new System.Drawing.Point(132, 89);
            this.peopleRelationship.Name = "peopleRelationship";
            this.peopleRelationship.Size = new System.Drawing.Size(176, 20);
            this.peopleRelationship.TabIndex = 32;
            // 
            // peopleName
            // 
            this.peopleName.Location = new System.Drawing.Point(132, 57);
            this.peopleName.Name = "peopleName";
            this.peopleName.Size = new System.Drawing.Size(176, 20);
            this.peopleName.TabIndex = 31;
            // 
            // peopleDateTime
            // 
            this.peopleDateTime.Location = new System.Drawing.Point(132, 153);
            this.peopleDateTime.Name = "peopleDateTime";
            this.peopleDateTime.Size = new System.Drawing.Size(176, 20);
            this.peopleDateTime.TabIndex = 30;
            // 
            // peopleCancel
            // 
            this.peopleCancel.Location = new System.Drawing.Point(180, 393);
            this.peopleCancel.Name = "peopleCancel";
            this.peopleCancel.Size = new System.Drawing.Size(83, 23);
            this.peopleCancel.TabIndex = 29;
            this.peopleCancel.Text = "Cancel";
            this.peopleCancel.UseVisualStyleBackColor = true;
            this.peopleCancel.Click += new System.EventHandler(this.CancelForm);
            // 
            // peopleOK
            // 
            this.peopleOK.Location = new System.Drawing.Point(76, 393);
            this.peopleOK.Name = "peopleOK";
            this.peopleOK.Size = new System.Drawing.Size(88, 23);
            this.peopleOK.TabIndex = 28;
            this.peopleOK.Text = "OK";
            this.peopleOK.UseVisualStyleBackColor = true;
            this.peopleOK.Click += new System.EventHandler(this.EnterEvent);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(28, 353);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(80, 13);
            this.label9.TabIndex = 27;
            this.label9.Text = "File Attachment";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(44, 97);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(65, 13);
            this.label10.TabIndex = 26;
            this.label10.Text = "Relationship";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(68, 185);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(35, 13);
            this.label11.TabIndex = 25;
            this.label11.Text = "Notes";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(60, 129);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(45, 13);
            this.label12.TabIndex = 24;
            this.label12.Text = "Address";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(36, 161);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(73, 13);
            this.label13.TabIndex = 23;
            this.label13.Text = "Date You Met";
            // 
            // personTitle
            // 
            this.personTitle.AutoSize = true;
            this.personTitle.Font = new System.Drawing.Font("Calibri", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.personTitle.Location = new System.Drawing.Point(132, 17);
            this.personTitle.Name = "personTitle";
            this.personTitle.Size = new System.Drawing.Size(75, 27);
            this.personTitle.TabIndex = 22;
            this.personTitle.Text = "Person";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(68, 65);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(35, 13);
            this.label15.TabIndex = 21;
            this.label15.Text = "Name";
            // 
            // taskPanel
            // 
            this.taskPanel.Controls.Add(this.taskFileAttach);
            this.taskPanel.Controls.Add(this.taskCheckBox);
            this.taskPanel.Controls.Add(this.taskNotes);
            this.taskPanel.Controls.Add(this.taskAddress);
            this.taskPanel.Controls.Add(this.taskTitleBox);
            this.taskPanel.Controls.Add(this.taskDateTime);
            this.taskPanel.Controls.Add(this.taskCancel);
            this.taskPanel.Controls.Add(this.taskOKButton);
            this.taskPanel.Controls.Add(this.label16);
            this.taskPanel.Controls.Add(this.label17);
            this.taskPanel.Controls.Add(this.label18);
            this.taskPanel.Controls.Add(this.label19);
            this.taskPanel.Controls.Add(this.label20);
            this.taskPanel.Controls.Add(this.taskTitle);
            this.taskPanel.Controls.Add(this.label22);
            this.taskPanel.Location = new System.Drawing.Point(24, 88);
            this.taskPanel.Name = "taskPanel";
            this.taskPanel.Size = new System.Drawing.Size(336, 432);
            this.taskPanel.TabIndex = 6;
            // 
            // taskFileAttach
            // 
            this.taskFileAttach.Location = new System.Drawing.Point(132, 345);
            this.taskFileAttach.Name = "taskFileAttach";
            this.taskFileAttach.Size = new System.Drawing.Size(32, 23);
            this.taskFileAttach.TabIndex = 34;
            this.taskFileAttach.Text = "...";
            this.taskFileAttach.UseVisualStyleBackColor = true;
            this.taskFileAttach.Click += new System.EventHandler(this.FileAttachment);
            // 
            // taskCheckBox
            // 
            this.taskCheckBox.AutoSize = true;
            this.taskCheckBox.Location = new System.Drawing.Point(132, 153);
            this.taskCheckBox.Name = "taskCheckBox";
            this.taskCheckBox.Size = new System.Drawing.Size(15, 14);
            this.taskCheckBox.TabIndex = 33;
            this.taskCheckBox.UseVisualStyleBackColor = true;
            // 
            // taskNotes
            // 
            this.taskNotes.Location = new System.Drawing.Point(132, 177);
            this.taskNotes.Multiline = true;
            this.taskNotes.Name = "taskNotes";
            this.taskNotes.Size = new System.Drawing.Size(176, 160);
            this.taskNotes.TabIndex = 32;
            // 
            // taskAddress
            // 
            this.taskAddress.Location = new System.Drawing.Point(132, 121);
            this.taskAddress.Name = "taskAddress";
            this.taskAddress.Size = new System.Drawing.Size(176, 20);
            this.taskAddress.TabIndex = 31;
            // 
            // taskTitleBox
            // 
            this.taskTitleBox.Location = new System.Drawing.Point(132, 57);
            this.taskTitleBox.Name = "taskTitleBox";
            this.taskTitleBox.Size = new System.Drawing.Size(176, 20);
            this.taskTitleBox.TabIndex = 30;
            // 
            // taskDateTime
            // 
            this.taskDateTime.Location = new System.Drawing.Point(132, 89);
            this.taskDateTime.Name = "taskDateTime";
            this.taskDateTime.Size = new System.Drawing.Size(176, 20);
            this.taskDateTime.TabIndex = 29;
            // 
            // taskCancel
            // 
            this.taskCancel.Location = new System.Drawing.Point(180, 393);
            this.taskCancel.Name = "taskCancel";
            this.taskCancel.Size = new System.Drawing.Size(83, 23);
            this.taskCancel.TabIndex = 28;
            this.taskCancel.Text = "Cancel";
            this.taskCancel.UseVisualStyleBackColor = true;
            this.taskCancel.Click += new System.EventHandler(this.CancelForm);
            // 
            // taskOKButton
            // 
            this.taskOKButton.Location = new System.Drawing.Point(76, 393);
            this.taskOKButton.Name = "taskOKButton";
            this.taskOKButton.Size = new System.Drawing.Size(88, 23);
            this.taskOKButton.TabIndex = 27;
            this.taskOKButton.Text = "OK";
            this.taskOKButton.UseVisualStyleBackColor = true;
            this.taskOKButton.Click += new System.EventHandler(this.EnterEvent);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(28, 353);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(80, 13);
            this.label16.TabIndex = 26;
            this.label16.Text = "File Attachment";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(52, 153);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(57, 13);
            this.label17.TabIndex = 25;
            this.label17.Text = "Completed";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(68, 177);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(35, 13);
            this.label18.TabIndex = 24;
            this.label18.Text = "Notes";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(60, 121);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(45, 13);
            this.label19.TabIndex = 23;
            this.label19.Text = "Address";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(76, 97);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(30, 13);
            this.label20.TabIndex = 22;
            this.label20.Text = "Date";
            // 
            // taskTitle
            // 
            this.taskTitle.AutoSize = true;
            this.taskTitle.Font = new System.Drawing.Font("Calibri", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.taskTitle.Location = new System.Drawing.Point(140, 17);
            this.taskTitle.Name = "taskTitle";
            this.taskTitle.Size = new System.Drawing.Size(51, 27);
            this.taskTitle.TabIndex = 21;
            this.taskTitle.Text = "Task";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(76, 65);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(27, 13);
            this.label22.TabIndex = 20;
            this.label22.Text = "Title";
            // 
            // AddEvent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(386, 534);
            this.ControlBox = false;
            this.Controls.Add(this.appointPanel);
            this.Controls.Add(this.memoryPanel);
            this.Controls.Add(this.peoplePanel);
            this.Controls.Add(this.taskPanel);
            this.Controls.Add(this.dropdownEvent);
            this.Controls.Add(this.eventTypeLabel);
            this.Controls.Add(this.modifyEvent);
            this.Name = "AddEvent";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddEvent";
            this.appointPanel.ResumeLayout(false);
            this.appointPanel.PerformLayout();
            this.memoryPanel.ResumeLayout(false);
            this.memoryPanel.PerformLayout();
            this.peoplePanel.ResumeLayout(false);
            this.peoplePanel.PerformLayout();
            this.taskPanel.ResumeLayout(false);
            this.taskPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label modifyEvent;
        private System.Windows.Forms.Label eventTypeLabel;
        private System.Windows.Forms.ComboBox dropdownEvent;
        private System.Windows.Forms.Panel appointPanel;
        private System.Windows.Forms.Button appFileAttachButton;
        private System.Windows.Forms.ComboBox appFrequency;
        private System.Windows.Forms.CheckBox appRecurCheck;
        private System.Windows.Forms.TextBox appAddressText;
        private System.Windows.Forms.TextBox appNameText;
        private System.Windows.Forms.DateTimePicker appTimePick;
        private System.Windows.Forms.DateTimePicker appDatePick;
        private System.Windows.Forms.Button appCancel;
        private System.Windows.Forms.Button appOK;
        private System.Windows.Forms.Label appFile;
        private System.Windows.Forms.Label appFreq;
        private System.Windows.Forms.Label appRecur;
        private System.Windows.Forms.Label appNotes;
        private System.Windows.Forms.Label appLocation;
        private System.Windows.Forms.Label appTime;
        private System.Windows.Forms.Label appDate;
        private System.Windows.Forms.Label appointTitle;
        private System.Windows.Forms.Label appName;
        private System.Windows.Forms.TextBox appNotesBox;
        private System.Windows.Forms.Panel memoryPanel;
        private System.Windows.Forms.Button memoryFileAttach;
        private System.Windows.Forms.ComboBox memoryFrequencyDrop;
        private System.Windows.Forms.CheckBox memoryReminderCheck;
        private System.Windows.Forms.TextBox memoryNotes;
        private System.Windows.Forms.TextBox memoryAddressbox;
        private System.Windows.Forms.TextBox memoryTitleBox;
        private System.Windows.Forms.DateTimePicker memoryDateTime;
        private System.Windows.Forms.Button memoryCancel;
        private System.Windows.Forms.Button memoryOKButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label memoryTitle;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel peoplePanel;
        private System.Windows.Forms.TextBox peopleAddress;
        private System.Windows.Forms.Button peopleFileAttach;
        private System.Windows.Forms.TextBox peopleNotes;
        private System.Windows.Forms.TextBox peopleRelationship;
        private System.Windows.Forms.TextBox peopleName;
        private System.Windows.Forms.DateTimePicker peopleDateTime;
        private System.Windows.Forms.Button peopleCancel;
        private System.Windows.Forms.Button peopleOK;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label personTitle;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Panel taskPanel;
        private System.Windows.Forms.Button taskFileAttach;
        private System.Windows.Forms.CheckBox taskCheckBox;
        private System.Windows.Forms.TextBox taskNotes;
        private System.Windows.Forms.TextBox taskAddress;
        private System.Windows.Forms.TextBox taskTitleBox;
        private System.Windows.Forms.DateTimePicker taskDateTime;
        private System.Windows.Forms.Button taskCancel;
        private System.Windows.Forms.Button taskOKButton;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label taskTitle;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.OpenFileDialog filePicker;
    }
}
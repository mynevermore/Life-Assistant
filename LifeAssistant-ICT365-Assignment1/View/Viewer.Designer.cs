using System.Windows.Forms;
using GMap.NET.WindowsForms;

namespace LifeAssistant_ICT365_Assignment1
{
    partial class Viewer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Viewer));
            this.menuPanel = new System.Windows.Forms.Panel();
            this.routeButton = new System.Windows.Forms.Button();
            this.menuButton = new System.Windows.Forms.Button();
            this.settingsButton = new System.Windows.Forms.Button();
            this.peopleButton = new System.Windows.Forms.Button();
            this.helpButton = new System.Windows.Forms.Button();
            this.toDoButton = new System.Windows.Forms.Button();
            this.calendarButton = new System.Windows.Forms.Button();
            this.homeButton = new System.Windows.Forms.Button();
            this.menuPane = new System.Windows.Forms.Panel();
            this.showMarkers = new System.Windows.Forms.Button();
            this.newEvent = new System.Windows.Forms.Button();
            this.markerSearchLabel = new System.Windows.Forms.Label();
            this.markerSearchButton = new System.Windows.Forms.Button();
            this.markerSearch = new System.Windows.Forms.TextBox();
            this.locationLabel = new System.Windows.Forms.Label();
            this.locationSearchButton = new System.Windows.Forms.Button();
            this.locationSearch = new System.Windows.Forms.TextBox();
            this.menuLabel = new System.Windows.Forms.Label();
            this.settingsPane = new System.Windows.Forms.Panel();
            this.setHomeButton = new System.Windows.Forms.Button();
            this.homeLocationBox = new System.Windows.Forms.TextBox();
            this.enterHomeLabel = new System.Windows.Forms.Label();
            this.settingsLabel = new System.Windows.Forms.Label();
            this.calendarPane = new System.Windows.Forms.Panel();
            this.dayEvents = new System.Windows.Forms.ListView();
            this.calendar = new System.Windows.Forms.MonthCalendar();
            this.calendarLabel = new System.Windows.Forms.Label();
            this.taskPane = new System.Windows.Forms.Panel();
            this.taskLabel = new System.Windows.Forms.Label();
            this.checkList = new System.Windows.Forms.CheckedListBox();
            this.peoplePane = new System.Windows.Forms.Panel();
            this.peopleLabel = new System.Windows.Forms.Label();
            this.peopleList = new System.Windows.Forms.ListView();
            this.gmap = new GMap.NET.WindowsForms.GMapControl();
            this.routePanel = new System.Windows.Forms.Panel();
            this.walkBox = new System.Windows.Forms.CheckBox();
            this.selectRouteLabel = new System.Windows.Forms.Label();
            this.trackList = new System.Windows.Forms.ListView();
            this.endAddressBox = new System.Windows.Forms.TextBox();
            this.endAddressLabel = new System.Windows.Forms.Label();
            this.setRouteButton = new System.Windows.Forms.Button();
            this.startAddressBox = new System.Windows.Forms.TextBox();
            this.startLabel = new System.Windows.Forms.Label();
            this.routeLabel = new System.Windows.Forms.Label();
            this.menuPanel.SuspendLayout();
            this.menuPane.SuspendLayout();
            this.settingsPane.SuspendLayout();
            this.calendarPane.SuspendLayout();
            this.taskPane.SuspendLayout();
            this.peoplePane.SuspendLayout();
            this.routePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuPanel
            // 
            this.menuPanel.BackColor = System.Drawing.Color.DarkSlateGray;
            this.menuPanel.Controls.Add(this.routeButton);
            this.menuPanel.Controls.Add(this.menuButton);
            this.menuPanel.Controls.Add(this.settingsButton);
            this.menuPanel.Controls.Add(this.peopleButton);
            this.menuPanel.Controls.Add(this.helpButton);
            this.menuPanel.Controls.Add(this.toDoButton);
            this.menuPanel.Controls.Add(this.calendarButton);
            this.menuPanel.Controls.Add(this.homeButton);
            this.menuPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuPanel.Location = new System.Drawing.Point(0, 0);
            this.menuPanel.Name = "menuPanel";
            this.menuPanel.Size = new System.Drawing.Size(67, 652);
            this.menuPanel.TabIndex = 1;
            // 
            // routeButton
            // 
            this.routeButton.BackColor = System.Drawing.Color.Transparent;
            this.routeButton.FlatAppearance.BorderSize = 0;
            this.routeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.routeButton.Image = ((System.Drawing.Image)(resources.GetObject("routeButton.Image")));
            this.routeButton.Location = new System.Drawing.Point(10, 286);
            this.routeButton.Name = "routeButton";
            this.routeButton.Size = new System.Drawing.Size(48, 48);
            this.routeButton.TabIndex = 11;
            this.routeButton.UseVisualStyleBackColor = false;
            // 
            // menuButton
            // 
            this.menuButton.BackColor = System.Drawing.Color.Transparent;
            this.menuButton.FlatAppearance.BorderSize = 0;
            this.menuButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.menuButton.Image = ((System.Drawing.Image)(resources.GetObject("menuButton.Image")));
            this.menuButton.Location = new System.Drawing.Point(10, 12);
            this.menuButton.Name = "menuButton";
            this.menuButton.Size = new System.Drawing.Size(48, 48);
            this.menuButton.TabIndex = 10;
            this.menuButton.UseVisualStyleBackColor = false;
            // 
            // settingsButton
            // 
            this.settingsButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.settingsButton.BackColor = System.Drawing.Color.Transparent;
            this.settingsButton.FlatAppearance.BorderSize = 0;
            this.settingsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.settingsButton.Image = ((System.Drawing.Image)(resources.GetObject("settingsButton.Image")));
            this.settingsButton.Location = new System.Drawing.Point(10, 601);
            this.settingsButton.Name = "settingsButton";
            this.settingsButton.Size = new System.Drawing.Size(48, 48);
            this.settingsButton.TabIndex = 9;
            this.settingsButton.UseVisualStyleBackColor = false;
            // 
            // peopleButton
            // 
            this.peopleButton.BackColor = System.Drawing.Color.Transparent;
            this.peopleButton.FlatAppearance.BorderSize = 0;
            this.peopleButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.peopleButton.Image = ((System.Drawing.Image)(resources.GetObject("peopleButton.Image")));
            this.peopleButton.Location = new System.Drawing.Point(10, 232);
            this.peopleButton.Name = "peopleButton";
            this.peopleButton.Size = new System.Drawing.Size(48, 48);
            this.peopleButton.TabIndex = 8;
            this.peopleButton.UseVisualStyleBackColor = false;
            // 
            // helpButton
            // 
            this.helpButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.helpButton.BackColor = System.Drawing.Color.Transparent;
            this.helpButton.FlatAppearance.BorderSize = 0;
            this.helpButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.helpButton.Image = ((System.Drawing.Image)(resources.GetObject("helpButton.Image")));
            this.helpButton.Location = new System.Drawing.Point(10, 547);
            this.helpButton.Name = "helpButton";
            this.helpButton.Size = new System.Drawing.Size(48, 48);
            this.helpButton.TabIndex = 6;
            this.helpButton.UseVisualStyleBackColor = false;
            // 
            // toDoButton
            // 
            this.toDoButton.BackColor = System.Drawing.Color.Transparent;
            this.toDoButton.FlatAppearance.BorderSize = 0;
            this.toDoButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.toDoButton.Image = ((System.Drawing.Image)(resources.GetObject("toDoButton.Image")));
            this.toDoButton.Location = new System.Drawing.Point(10, 178);
            this.toDoButton.Name = "toDoButton";
            this.toDoButton.Size = new System.Drawing.Size(48, 48);
            this.toDoButton.TabIndex = 7;
            this.toDoButton.UseVisualStyleBackColor = false;
            // 
            // calendarButton
            // 
            this.calendarButton.BackColor = System.Drawing.Color.Transparent;
            this.calendarButton.FlatAppearance.BorderSize = 0;
            this.calendarButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.calendarButton.Image = ((System.Drawing.Image)(resources.GetObject("calendarButton.Image")));
            this.calendarButton.Location = new System.Drawing.Point(10, 124);
            this.calendarButton.Name = "calendarButton";
            this.calendarButton.Size = new System.Drawing.Size(48, 48);
            this.calendarButton.TabIndex = 4;
            this.calendarButton.UseVisualStyleBackColor = false;
            // 
            // homeButton
            // 
            this.homeButton.BackColor = System.Drawing.Color.Transparent;
            this.homeButton.FlatAppearance.BorderSize = 0;
            this.homeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.homeButton.Image = ((System.Drawing.Image)(resources.GetObject("homeButton.Image")));
            this.homeButton.Location = new System.Drawing.Point(10, 66);
            this.homeButton.Name = "homeButton";
            this.homeButton.Size = new System.Drawing.Size(48, 48);
            this.homeButton.TabIndex = 3;
            this.homeButton.UseVisualStyleBackColor = false;
            // 
            // menuPane
            // 
            this.menuPane.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.menuPane.BackColor = System.Drawing.Color.SlateGray;
            this.menuPane.Controls.Add(this.showMarkers);
            this.menuPane.Controls.Add(this.newEvent);
            this.menuPane.Controls.Add(this.markerSearchLabel);
            this.menuPane.Controls.Add(this.markerSearchButton);
            this.menuPane.Controls.Add(this.markerSearch);
            this.menuPane.Controls.Add(this.locationLabel);
            this.menuPane.Controls.Add(this.locationSearchButton);
            this.menuPane.Controls.Add(this.locationSearch);
            this.menuPane.Controls.Add(this.menuLabel);
            this.menuPane.Location = new System.Drawing.Point(67, 0);
            this.menuPane.Name = "menuPane";
            this.menuPane.Size = new System.Drawing.Size(315, 652);
            this.menuPane.TabIndex = 2;
            // 
            // showMarkers
            // 
            this.showMarkers.BackColor = System.Drawing.Color.Lavender;
            this.showMarkers.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.showMarkers.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showMarkers.ForeColor = System.Drawing.SystemColors.ControlText;
            this.showMarkers.Location = new System.Drawing.Point(38, 325);
            this.showMarkers.Name = "showMarkers";
            this.showMarkers.Size = new System.Drawing.Size(237, 34);
            this.showMarkers.TabIndex = 8;
            this.showMarkers.Text = "Show All Markers";
            this.showMarkers.UseVisualStyleBackColor = false;
            // 
            // newEvent
            // 
            this.newEvent.BackColor = System.Drawing.Color.Lavender;
            this.newEvent.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.newEvent.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newEvent.ForeColor = System.Drawing.SystemColors.ControlText;
            this.newEvent.Location = new System.Drawing.Point(38, 285);
            this.newEvent.Name = "newEvent";
            this.newEvent.Size = new System.Drawing.Size(237, 34);
            this.newEvent.TabIndex = 7;
            this.newEvent.Text = "Add New Marker";
            this.newEvent.UseVisualStyleBackColor = false;
            // 
            // markerSearchLabel
            // 
            this.markerSearchLabel.AutoSize = true;
            this.markerSearchLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.markerSearchLabel.ForeColor = System.Drawing.Color.Lavender;
            this.markerSearchLabel.Location = new System.Drawing.Point(34, 85);
            this.markerSearchLabel.Name = "markerSearchLabel";
            this.markerSearchLabel.Size = new System.Drawing.Size(135, 19);
            this.markerSearchLabel.TabIndex = 6;
            this.markerSearchLabel.Text = "Search for a Marker";
            // 
            // markerSearchButton
            // 
            this.markerSearchButton.BackColor = System.Drawing.Color.Lavender;
            this.markerSearchButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.markerSearchButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.markerSearchButton.Location = new System.Drawing.Point(200, 138);
            this.markerSearchButton.Name = "markerSearchButton";
            this.markerSearchButton.Size = new System.Drawing.Size(75, 23);
            this.markerSearchButton.TabIndex = 5;
            this.markerSearchButton.Text = "Search";
            this.markerSearchButton.UseVisualStyleBackColor = false;
            // 
            // markerSearch
            // 
            this.markerSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.markerSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.markerSearch.Location = new System.Drawing.Point(38, 109);
            this.markerSearch.Name = "markerSearch";
            this.markerSearch.Size = new System.Drawing.Size(237, 23);
            this.markerSearch.TabIndex = 4;
            this.markerSearch.Text = "Enter text to search here";
            // 
            // locationLabel
            // 
            this.locationLabel.AutoSize = true;
            this.locationLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.locationLabel.ForeColor = System.Drawing.Color.Lavender;
            this.locationLabel.Location = new System.Drawing.Point(34, 182);
            this.locationLabel.Name = "locationLabel";
            this.locationLabel.Size = new System.Drawing.Size(145, 19);
            this.locationLabel.TabIndex = 3;
            this.locationLabel.Text = "Search for a Location";
            // 
            // locationSearchButton
            // 
            this.locationSearchButton.BackColor = System.Drawing.Color.Lavender;
            this.locationSearchButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.locationSearchButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.locationSearchButton.Location = new System.Drawing.Point(200, 235);
            this.locationSearchButton.Name = "locationSearchButton";
            this.locationSearchButton.Size = new System.Drawing.Size(75, 23);
            this.locationSearchButton.TabIndex = 2;
            this.locationSearchButton.Text = "Search";
            this.locationSearchButton.UseVisualStyleBackColor = false;
            // 
            // locationSearch
            // 
            this.locationSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.locationSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.locationSearch.Location = new System.Drawing.Point(38, 206);
            this.locationSearch.Name = "locationSearch";
            this.locationSearch.Size = new System.Drawing.Size(237, 23);
            this.locationSearch.TabIndex = 1;
            this.locationSearch.Text = "Enter location here";
            // 
            // menuLabel
            // 
            this.menuLabel.AutoSize = true;
            this.menuLabel.BackColor = System.Drawing.Color.Transparent;
            this.menuLabel.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuLabel.ForeColor = System.Drawing.Color.Lavender;
            this.menuLabel.Location = new System.Drawing.Point(79, 16);
            this.menuLabel.Name = "menuLabel";
            this.menuLabel.Size = new System.Drawing.Size(149, 30);
            this.menuLabel.TabIndex = 0;
            this.menuLabel.Text = "Main Menu";
            // 
            // settingsPane
            // 
            this.settingsPane.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.settingsPane.BackColor = System.Drawing.Color.SlateGray;
            this.settingsPane.Controls.Add(this.setHomeButton);
            this.settingsPane.Controls.Add(this.homeLocationBox);
            this.settingsPane.Controls.Add(this.enterHomeLabel);
            this.settingsPane.Controls.Add(this.settingsLabel);
            this.settingsPane.Location = new System.Drawing.Point(632, 0);
            this.settingsPane.Name = "settingsPane";
            this.settingsPane.Size = new System.Drawing.Size(315, 652);
            this.settingsPane.TabIndex = 4;
            // 
            // setHomeButton
            // 
            this.setHomeButton.BackColor = System.Drawing.Color.Lavender;
            this.setHomeButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.setHomeButton.Location = new System.Drawing.Point(207, 142);
            this.setHomeButton.Name = "setHomeButton";
            this.setHomeButton.Size = new System.Drawing.Size(75, 23);
            this.setHomeButton.TabIndex = 3;
            this.setHomeButton.Text = "Set Home";
            this.setHomeButton.UseVisualStyleBackColor = false;
            // 
            // homeLocationBox
            // 
            this.homeLocationBox.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.homeLocationBox.Location = new System.Drawing.Point(39, 112);
            this.homeLocationBox.Name = "homeLocationBox";
            this.homeLocationBox.Size = new System.Drawing.Size(243, 24);
            this.homeLocationBox.TabIndex = 2;
            // 
            // enterHomeLabel
            // 
            this.enterHomeLabel.AutoSize = true;
            this.enterHomeLabel.BackColor = System.Drawing.Color.Transparent;
            this.enterHomeLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enterHomeLabel.ForeColor = System.Drawing.Color.Lavender;
            this.enterHomeLabel.Location = new System.Drawing.Point(36, 84);
            this.enterHomeLabel.Name = "enterHomeLabel";
            this.enterHomeLabel.Size = new System.Drawing.Size(144, 19);
            this.enterHomeLabel.TabIndex = 1;
            this.enterHomeLabel.Text = "Enter Home Location";
            // 
            // settingsLabel
            // 
            this.settingsLabel.AutoSize = true;
            this.settingsLabel.BackColor = System.Drawing.Color.Transparent;
            this.settingsLabel.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.settingsLabel.ForeColor = System.Drawing.Color.Lavender;
            this.settingsLabel.Location = new System.Drawing.Point(108, 16);
            this.settingsLabel.Name = "settingsLabel";
            this.settingsLabel.Size = new System.Drawing.Size(104, 30);
            this.settingsLabel.TabIndex = 0;
            this.settingsLabel.Text = "Settings";
            // 
            // calendarPane
            // 
            this.calendarPane.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.calendarPane.BackColor = System.Drawing.Color.SlateGray;
            this.calendarPane.Controls.Add(this.dayEvents);
            this.calendarPane.Controls.Add(this.calendar);
            this.calendarPane.Controls.Add(this.calendarLabel);
            this.calendarPane.Location = new System.Drawing.Point(67, 0);
            this.calendarPane.Name = "calendarPane";
            this.calendarPane.Size = new System.Drawing.Size(0, 652);
            this.calendarPane.TabIndex = 3;
            // 
            // dayEvents
            // 
            this.dayEvents.BackColor = System.Drawing.Color.SlateGray;
            this.dayEvents.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dayEvents.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dayEvents.ForeColor = System.Drawing.Color.Lavender;
            this.dayEvents.Location = new System.Drawing.Point(12, 238);
            this.dayEvents.Name = "dayEvents";
            this.dayEvents.Size = new System.Drawing.Size(289, 402);
            this.dayEvents.TabIndex = 2;
            this.dayEvents.UseCompatibleStateImageBehavior = false;
            // 
            // calendar
            // 
            this.calendar.Location = new System.Drawing.Point(43, 64);
            this.calendar.Name = "calendar";
            this.calendar.TabIndex = 1;
            // 
            // calendarLabel
            // 
            this.calendarLabel.AutoSize = true;
            this.calendarLabel.BackColor = System.Drawing.Color.Transparent;
            this.calendarLabel.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calendarLabel.ForeColor = System.Drawing.Color.Lavender;
            this.calendarLabel.Location = new System.Drawing.Point(56, 16);
            this.calendarLabel.Name = "calendarLabel";
            this.calendarLabel.Size = new System.Drawing.Size(203, 30);
            this.calendarLabel.TabIndex = 0;
            this.calendarLabel.Text = "Calendar Picker";
            // 
            // taskPane
            // 
            this.taskPane.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.taskPane.BackColor = System.Drawing.Color.SlateGray;
            this.taskPane.Controls.Add(this.taskLabel);
            this.taskPane.Controls.Add(this.checkList);
            this.taskPane.Location = new System.Drawing.Point(67, 0);
            this.taskPane.Name = "taskPane";
            this.taskPane.Size = new System.Drawing.Size(315, 652);
            this.taskPane.TabIndex = 5;
            // 
            // taskLabel
            // 
            this.taskLabel.AutoSize = true;
            this.taskLabel.BackColor = System.Drawing.Color.Transparent;
            this.taskLabel.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.taskLabel.ForeColor = System.Drawing.Color.Lavender;
            this.taskLabel.Location = new System.Drawing.Point(98, 16);
            this.taskLabel.Name = "taskLabel";
            this.taskLabel.Size = new System.Drawing.Size(123, 30);
            this.taskLabel.TabIndex = 1;
            this.taskLabel.Text = "To Do List";
            // 
            // checkList
            // 
            this.checkList.BackColor = System.Drawing.Color.SlateGray;
            this.checkList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.checkList.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkList.ForeColor = System.Drawing.Color.Lavender;
            this.checkList.FormattingEnabled = true;
            this.checkList.Location = new System.Drawing.Point(18, 64);
            this.checkList.Name = "checkList";
            this.checkList.Size = new System.Drawing.Size(280, 560);
            this.checkList.TabIndex = 0;
            // 
            // peoplePane
            // 
            this.peoplePane.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.peoplePane.BackColor = System.Drawing.Color.SlateGray;
            this.peoplePane.Controls.Add(this.peopleLabel);
            this.peoplePane.Controls.Add(this.peopleList);
            this.peoplePane.Location = new System.Drawing.Point(67, 0);
            this.peoplePane.Name = "peoplePane";
            this.peoplePane.Size = new System.Drawing.Size(315, 652);
            this.peoplePane.TabIndex = 6;
            // 
            // peopleLabel
            // 
            this.peopleLabel.AutoSize = true;
            this.peopleLabel.BackColor = System.Drawing.Color.Transparent;
            this.peopleLabel.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.peopleLabel.ForeColor = System.Drawing.Color.Lavender;
            this.peopleLabel.Location = new System.Drawing.Point(36, 16);
            this.peopleLabel.Name = "peopleLabel";
            this.peopleLabel.Size = new System.Drawing.Size(223, 30);
            this.peopleLabel.TabIndex = 1;
            this.peopleLabel.Text = "People You Know";
            // 
            // peopleList
            // 
            this.peopleList.BackColor = System.Drawing.Color.SlateGray;
            this.peopleList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.peopleList.Location = new System.Drawing.Point(16, 55);
            this.peopleList.Name = "peopleList";
            this.peopleList.Size = new System.Drawing.Size(284, 585);
            this.peopleList.TabIndex = 0;
            this.peopleList.UseCompatibleStateImageBehavior = false;
            // 
            // gmap
            // 
            this.gmap.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gmap.Bearing = 0F;
            this.gmap.CanDragMap = true;
            this.gmap.EmptyTileColor = System.Drawing.Color.Navy;
            this.gmap.GrayScaleMode = false;
            this.gmap.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.gmap.LevelsKeepInMemmory = 5;
            this.gmap.Location = new System.Drawing.Point(67, 0);
            this.gmap.MarkersEnabled = true;
            this.gmap.MaxZoom = 18;
            this.gmap.MinZoom = 0;
            this.gmap.MouseWheelZoomEnabled = true;
            this.gmap.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            this.gmap.Name = "gmap";
            this.gmap.NegativeMode = false;
            this.gmap.PolygonsEnabled = true;
            this.gmap.RetryLoadTile = 0;
            this.gmap.RoutesEnabled = true;
            this.gmap.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            this.gmap.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.gmap.ShowTileGridLines = false;
            this.gmap.Size = new System.Drawing.Size(1082, 652);
            this.gmap.TabIndex = 7;
            this.gmap.Zoom = 12D;
            // 
            // routePanel
            // 
            this.routePanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.routePanel.BackColor = System.Drawing.Color.SlateGray;
            this.routePanel.Controls.Add(this.walkBox);
            this.routePanel.Controls.Add(this.selectRouteLabel);
            this.routePanel.Controls.Add(this.trackList);
            this.routePanel.Controls.Add(this.endAddressBox);
            this.routePanel.Controls.Add(this.endAddressLabel);
            this.routePanel.Controls.Add(this.setRouteButton);
            this.routePanel.Controls.Add(this.startAddressBox);
            this.routePanel.Controls.Add(this.startLabel);
            this.routePanel.Controls.Add(this.routeLabel);
            this.routePanel.Location = new System.Drawing.Point(417, 0);
            this.routePanel.Name = "routePanel";
            this.routePanel.Size = new System.Drawing.Size(315, 652);
            this.routePanel.TabIndex = 8;
            // 
            // walkBox
            // 
            this.walkBox.AutoSize = true;
            this.walkBox.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.walkBox.ForeColor = System.Drawing.Color.Lavender;
            this.walkBox.Location = new System.Drawing.Point(39, 207);
            this.walkBox.Name = "walkBox";
            this.walkBox.Size = new System.Drawing.Size(87, 23);
            this.walkBox.TabIndex = 8;
            this.walkBox.Text = "Walking?";
            this.walkBox.UseVisualStyleBackColor = true;
            // 
            // selectRouteLabel
            // 
            this.selectRouteLabel.AutoSize = true;
            this.selectRouteLabel.BackColor = System.Drawing.Color.Transparent;
            this.selectRouteLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectRouteLabel.ForeColor = System.Drawing.Color.Lavender;
            this.selectRouteLabel.Location = new System.Drawing.Point(38, 261);
            this.selectRouteLabel.Name = "selectRouteLabel";
            this.selectRouteLabel.Size = new System.Drawing.Size(201, 19);
            this.selectRouteLabel.TabIndex = 7;
            this.selectRouteLabel.Text = "Select a route to view on map";
            // 
            // trackList
            // 
            this.trackList.BackColor = System.Drawing.Color.SlateGray;
            this.trackList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.trackList.Location = new System.Drawing.Point(42, 285);
            this.trackList.Name = "trackList";
            this.trackList.Size = new System.Drawing.Size(240, 310);
            this.trackList.TabIndex = 6;
            this.trackList.UseCompatibleStateImageBehavior = false;
            // 
            // endAddressBox
            // 
            this.endAddressBox.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.endAddressBox.Location = new System.Drawing.Point(39, 177);
            this.endAddressBox.Name = "endAddressBox";
            this.endAddressBox.Size = new System.Drawing.Size(243, 24);
            this.endAddressBox.TabIndex = 5;
            // 
            // endAddressLabel
            // 
            this.endAddressLabel.AutoSize = true;
            this.endAddressLabel.BackColor = System.Drawing.Color.Transparent;
            this.endAddressLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.endAddressLabel.ForeColor = System.Drawing.Color.Lavender;
            this.endAddressLabel.Location = new System.Drawing.Point(36, 149);
            this.endAddressLabel.Name = "endAddressLabel";
            this.endAddressLabel.Size = new System.Drawing.Size(127, 19);
            this.endAddressLabel.TabIndex = 4;
            this.endAddressLabel.Text = "Enter End Address";
            // 
            // setRouteButton
            // 
            this.setRouteButton.BackColor = System.Drawing.Color.Lavender;
            this.setRouteButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.setRouteButton.Location = new System.Drawing.Point(207, 207);
            this.setRouteButton.Name = "setRouteButton";
            this.setRouteButton.Size = new System.Drawing.Size(75, 23);
            this.setRouteButton.TabIndex = 3;
            this.setRouteButton.Text = "Set Route";
            this.setRouteButton.UseVisualStyleBackColor = false;
            // 
            // startAddressBox
            // 
            this.startAddressBox.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startAddressBox.Location = new System.Drawing.Point(39, 112);
            this.startAddressBox.Name = "startAddressBox";
            this.startAddressBox.Size = new System.Drawing.Size(243, 24);
            this.startAddressBox.TabIndex = 2;
            // 
            // startLabel
            // 
            this.startLabel.AutoSize = true;
            this.startLabel.BackColor = System.Drawing.Color.Transparent;
            this.startLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startLabel.ForeColor = System.Drawing.Color.Lavender;
            this.startLabel.Location = new System.Drawing.Point(36, 84);
            this.startLabel.Name = "startLabel";
            this.startLabel.Size = new System.Drawing.Size(133, 19);
            this.startLabel.TabIndex = 1;
            this.startLabel.Text = "Enter Start Address";
            // 
            // routeLabel
            // 
            this.routeLabel.AutoSize = true;
            this.routeLabel.BackColor = System.Drawing.Color.Transparent;
            this.routeLabel.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.routeLabel.ForeColor = System.Drawing.Color.Lavender;
            this.routeLabel.Location = new System.Drawing.Point(108, 16);
            this.routeLabel.Name = "routeLabel";
            this.routeLabel.Size = new System.Drawing.Size(93, 30);
            this.routeLabel.TabIndex = 0;
            this.routeLabel.Text = "Routes";
            // 
            // Viewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1148, 652);
            this.Controls.Add(this.routePanel);
            this.Controls.Add(this.menuPane);
            this.Controls.Add(this.taskPane);
            this.Controls.Add(this.peoplePane);
            this.Controls.Add(this.calendarPane);
            this.Controls.Add(this.settingsPane);
            this.Controls.Add(this.menuPanel);
            this.Controls.Add(this.gmap);
            this.Name = "Viewer";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Life Assistant";
            //this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuPanel.ResumeLayout(false);
            this.menuPane.ResumeLayout(false);
            this.menuPane.PerformLayout();
            this.settingsPane.ResumeLayout(false);
            this.settingsPane.PerformLayout();
            this.calendarPane.ResumeLayout(false);
            this.calendarPane.PerformLayout();
            this.taskPane.ResumeLayout(false);
            this.taskPane.PerformLayout();
            this.peoplePane.ResumeLayout(false);
            this.peoplePane.PerformLayout();
            this.routePanel.ResumeLayout(false);
            this.routePanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel menuPanel;
        private Button helpButton;
        private Button calendarButton;
        private Button homeButton;
        private Button toDoButton;
        private Button peopleButton;
        private Button settingsButton;
        private Button menuButton;
        private Panel menuPane;
        private Panel calendarPane;
        private Panel settingsPane;
        private Panel taskPane;
        private Panel peoplePane;
        private Label menuLabel;
        private Label taskLabel;
        private CheckedListBox checkList;
        private ListView dayEvents;
        private MonthCalendar calendar;
        private Label calendarLabel;
        private Label peopleLabel;
        private ListView peopleList;
        private Label settingsLabel;
        private Button newEvent;
        private Label markerSearchLabel;
        private Button markerSearchButton;
        private TextBox markerSearch;
        private Label locationLabel;
        private Button locationSearchButton;
        private TextBox locationSearch;
        private Button setHomeButton;
        private TextBox homeLocationBox;
        private Label enterHomeLabel;
        private GMapControl gmap;
        private Button showMarkers;
        private Button routeButton;
        private Panel routePanel;
        private Label selectRouteLabel;
        private ListView trackList;
        private TextBox endAddressBox;
        private Label endAddressLabel;
        private Button setRouteButton;
        private TextBox startAddressBox;
        private Label startLabel;
        private Label routeLabel;
        private CheckBox walkBox;

        public Panel MenuPanel { get { return menuPanel; } set { menuPanel = value; } }
        public Button HelperButton { get { return helpButton; } set { helpButton = value; } }
        public Button CalendarButton { get { return calendarButton; } set { calendarButton = value; } }
        public Button HomeButton { get { return homeButton; } set { homeButton = value; } }
        public Button ToDoButton { get { return toDoButton; } set { toDoButton = value; } }
        public Button PeopleButton { get { return peopleButton; } set { peopleButton = value; } }
        public Button SettingsButton { get { return settingsButton; } set { settingsButton = value; } }
        public Button MenuButton { get { return menuButton; } set { menuButton = value; } }
        public Panel MenuPane { get { return menuPane; } set { menuPane = value; } }
        public Panel CalendarPane { get { return calendarPane; } set { calendarPane = value; } }
        public Panel SettingsPane { get { return settingsPane; } set { settingsPane = value; } }
        public Panel TaskPane { get { return taskPane; } set { taskPane = value; } }
        public Panel PeoplePane { get { return peoplePane; } set { peoplePane = value; } }
        public Label MenuLabel { get { return menuLabel; } set { menuLabel = value; } }
        public Label TaskLabel { get { return taskLabel; } set { taskLabel = value; } }
        public CheckedListBox CheckList { get { return checkList; } set { checkList = value; } }
        public ListView DayEvents { get { return dayEvents; } set { dayEvents = value; } }
        public MonthCalendar Calendar { get { return calendar; } set { calendar = value; } }
        public Label CalendarLabel { get { return calendarLabel; } set { calendarLabel = value; } }
        public Label PeopleLabel { get { return peopleLabel; } set { peopleLabel = value; } }
        public ListView PeopleList { get { return peopleList; } set { peopleList = value; } }
        public Label SettingsLabel { get { return settingsLabel; } set { settingsLabel = value; } }
        public Button NewEvent { get { return newEvent; } set { newEvent = value; } }
        public Label MarkerSearchLabel { get { return markerSearchLabel; } set { markerSearchLabel = value; } }
        public Button MarkerSearchButton { get { return markerSearchButton; } set { markerSearchButton = value; } }
        public TextBox MarkerSearch { get { return markerSearch; } set { markerSearch = value; } }
        public Label LocationLabel { get { return locationLabel; } set { locationLabel = value; } }
        public Button LocationSearchButton { get { return locationSearchButton; } set { locationSearchButton = value; } }
        public TextBox LocationSearch { get { return locationSearch; } set { locationSearch = value; } }
        public Button SetHomeButton { get { return setHomeButton; } set { setHomeButton = value; } }
        public TextBox HomeLocationBox { get { return homeLocationBox; } set { homeLocationBox = value; } }
        public Label EnterHomeLabel { get { return enterHomeLabel; } set { enterHomeLabel = value; } }
        public GMapControl Gmap { get { return gmap; } set { gmap = value; } }
        public Button ShowMarkers { get { return showMarkers; } set { showMarkers = value; } }
        public Button RouteButton { get { return routeButton; } set { routeButton = value; } }
        public Panel RoutePanel { get { return routePanel; } set { routePanel = value; } }
        public Label SelectRouteLabel { get { return selectRouteLabel; } set { selectRouteLabel = value; } }
        public ListView TrackList { get { return trackList; } set { trackList = value; } }
        public TextBox EndAddressBox { get { return endAddressBox; } set { endAddressBox = value; } }
        public Label EndAddressLabel { get { return endAddressLabel; } set { endAddressLabel = value; } }
        public Button SetRouteButton { get { return setRouteButton; } set { setRouteButton = value; } }
        public TextBox StartAddressBox { get { return startAddressBox; } set { startAddressBox = value; } }
        public Label StartLabel { get { return startLabel; } set { startLabel = value; } }
        public Label RouteLabel { get { return routeLabel; } set { routeLabel = value; } }
        public CheckBox WalkBox { get { return walkBox; } set { walkBox = value; } }
    }
}


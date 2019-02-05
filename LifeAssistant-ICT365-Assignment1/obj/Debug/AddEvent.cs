using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace LifeAssistant_ICT365_Assignment1.View
{
    public partial class AddEvent : Form
    {
        Viewer view = Viewer.Instance();
        string file = "";
        bool exceptionCatch = false;
        public AddEvent()
        {
            InitializeComponent();
            appointPanel.Visible = false;
            taskPanel.Visible = false;
            memoryPanel.Visible = false;
            peoplePanel.Visible = false;
        }

        private void dropdownEvent_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(dropdownEvent.Text == "Appointment")
            {
                appointPanel.Visible = true;
                taskPanel.Visible = false;
                memoryPanel.Visible = false;
                peoplePanel.Visible = false;
            }
            else if(dropdownEvent.Text == "Memory")
            {
                appointPanel.Visible = false;
                taskPanel.Visible = false;
                memoryPanel.Visible = true;
                peoplePanel.Visible = false;
            }
            else if(dropdownEvent.Text == "Task")
            {
                appointPanel.Visible = false;
                taskPanel.Visible = true;
                memoryPanel.Visible = false;
                peoplePanel.Visible = false;
            }
            else if(dropdownEvent.Text == "Person")
            {
                appointPanel.Visible = false;
                taskPanel.Visible = false;
                memoryPanel.Visible = false;
                peoplePanel.Visible = true;
            }
        }

        private void CancelForm(object sender, EventArgs e)
        {
            Close();
        }

        private void EnterEvent(object sender, EventArgs e)
        {
            var button = (Button)sender;
            string type = ReturnType(button);

            if (type == "appointment")
            {
                SanitiseInput(appNameText.Text, appAddressText.Text, appNotesBox.Text);

                if (!exceptionCatch)
                {
                    List<object> list = new List<object>();
                    list.Add(appNameText.Text);
                    list.Add(appDatePick.Value);
                    list.Add(appTimePick.Value);
                    list.Add(appAddressText.Text);
                    list.Add(appRecurCheck.Checked);
                    list.Add(appFrequency.Text);
                    list.Add(appNotesBox.Text);
                    list.Add(file);

                    view.addAppointment(list);
                    Close();
                }
            }
            else if(type == "task")
            {
                SanitiseInput(taskTitleBox.Text, taskAddress.Text, taskNotes.Text);

                if (!exceptionCatch)
                {
                    List<object> list = new List<object>();

                    list.Add(taskTitleBox.Text);
                    list.Add(taskDateTime.Value);
                    list.Add(taskAddress.Text);
                    list.Add(taskCheckBox.Checked);
                    list.Add(taskNotes.Text);
                    list.Add(file);

                    view.addTask(list);
                    Close();
                }
            }
            else if(type == "memory")
            {
                SanitiseInput(memoryTitleBox.Text, memoryAddressbox.Text, memoryNotes.Text);

                if (!exceptionCatch)
                {
                    List<object> list = new List<object>();

                    list.Add(memoryTitleBox.Text);
                    list.Add(memoryDateTime.Value);
                    list.Add(memoryAddressbox.Text);
                    list.Add(memoryReminderCheck.Checked);
                    list.Add(memoryFrequencyDrop.SelectedText);
                    list.Add(memoryNotes.Text);
                    list.Add(file);

                    view.addMemory(list);
                    Close();
                }
            }
            else if(type == "person")
            {
                SanitiseInput(peopleName.Text, peopleAddress.Text, peopleNotes.Text);

                if (!exceptionCatch)
                {
                    List<object> list = new List<object>();

                    list.Add(peopleName.Text);
                    list.Add(peopleDateTime.Value);
                    list.Add(peopleAddress.Text);
                    list.Add(peopleRelationship.Text);
                    list.Add(peopleNotes.Text);
                    list.Add(file);

                    view.addPerson(list);
                    Close();
                }
            }
            else
            {
                MessageBox.Show("Invalid Event Type");
            }
        }

        private void SanitiseInput(string text1, string text2, string text3)
        {
            var regexItem = new Regex("^[a-zA-Z0-9 ,-]*$");
            try
            {
                if (string.IsNullOrWhiteSpace(text1) || string.IsNullOrWhiteSpace(text2))
                {
                    throw new ListEmptyException();
                }
                else if(regexItem.IsMatch(text1) || regexItem.IsMatch(text2) || regexItem.IsMatch(text3))
                {
                    throw new ListEmptyException();
                }
            }
            catch(Exception)
            {
                MessageBox.Show("Name/Title and Address must be entered.\r\nOnly letters, numbers, hyphens and commas are accepted as input.", "Invalid Input!");
                exceptionCatch = true;
            }
        }

        private string ReturnType(Button button)
        {
            if (button.Name == "memoryOKButton")
            {
                return "memory";
            }
            else if (button.Name == "appOK")
            {
                return "appointment";
            }
            else if (button.Name == "taskOKButton")
            {
                return "task";
            }
            else if (button.Name == "peopleOK")
            {
                return "person";
            }
            else
            {
                return null;
            }
        }

        private void FileAttachment(object sender, EventArgs e)
        {
            DialogResult result = filePicker.ShowDialog();
            if (result == DialogResult.OK)
            {
                file = filePicker.FileName;
            }
        }
    }

    public class ListEmptyException : Exception
    {
        public ListEmptyException()
        {

        }

        public ListEmptyException(string message)
        : base(message)
        {
        }

        public ListEmptyException(string message, Exception inner)
        : base(message, inner)
        {
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace LifeAssistant_ICT365_Assignment1.View
{
    public partial class AddEvent : Form
    {
        Viewer view = Viewer.Instance();
        bool exceptionThrown = false;
        string file = "";
        public AddEvent()
        {
            InitializeComponent();
            panelAppointment.Visible = false;
            panelMemory.Visible = false;
            panelPeople.Visible = false;
            panelTask.Visible = false;
        }

        private void dropdownEvent_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(dropdownEvent.Text == "Appointment")
            {
                panelAppointment.Visible = true;
                panelMemory.Visible = false;
                panelPeople.Visible = false;
                panelTask.Visible = false;
            }
            else if(dropdownEvent.Text == "Memory")
            {
                panelAppointment.Visible = false;
                panelMemory.Visible = true;
                panelPeople.Visible = false;
                panelTask.Visible = false;
            }
            else if(dropdownEvent.Text == "Task")
            {
                panelAppointment.Visible = false;
                panelMemory.Visible = false;
                panelPeople.Visible = false;
                panelTask.Visible = true;
            }
            else if(dropdownEvent.Text == "Person")
            {
                panelAppointment.Visible = false;
                panelMemory.Visible = false;
                panelPeople.Visible = true;
                panelTask.Visible = false;
            }
        }

        private void CancelClick(object sender, EventArgs e)
        {
            Close();
        }

        private void AddEventClick(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            var type = CheckSender(button);
            List<object> list = new List<object>();

            if(type == "Appointment")
            {
                SanitiseInput(apNameBox.Text, apAddressBox.Text, apNotesBox.Text, null);

                if(!exceptionThrown)
                {
                    list.Add(apNameBox.Text);
                    list.Add(apAddressBox.Text);
                    list.Add(apDatePicker.Value);
                    list.Add(apTimePicker.Value);
                    list.Add(apNotesBox.Text);
                    list.Add(file);
                    list.Add(apRecurCheck.Checked);
                    list.Add(apFreqDrop.Text);

                    view.AddAppointment(list);
                    Close();
                }
            }
            else if(type == "Memory")
            {
                SanitiseInput(memNameBox.Text, memAddressBox.Text, memNotesBox.Text, null);

                if (!exceptionThrown)
                {
                    list.Add(memNameBox.Text);
                    list.Add(memAddressBox.Text);
                    list.Add(memDatePick.Value);
                    list.Add(memNotesBox.Text);
                    list.Add(file);
                    list.Add(memRemindCheck.Checked);
                    list.Add(memFreqDrop.Text);

                    view.AddMemory(list);
                    Close();
                }
            }
            else if(type == "Person")
            {
                SanitiseInput(perNameBox.Text, perAddressBox.Text, perNotesBox.Text, perRelationBox.Text);

                if (!exceptionThrown)
                {
                    list.Add(perNameBox.Text);
                    list.Add(perAddressBox.Text);
                    list.Add(perDatePicker.Value);
                    list.Add(perNotesBox.Text);
                    list.Add(file);
                    list.Add(perRelationBox.Text);

                    view.AddPerson(list);
                    Close();
                }
            }
            else if(type == "Task")
            {
                SanitiseInput(taskNameBox.Text, taskAddressBox.Text, taskNotesBox.Text, null);

                if (!exceptionThrown)
                {
                    list.Add(taskNameBox.Text);
                    list.Add(taskAddressBox.Text);
                    list.Add(taskDatePicker.Value);
                    list.Add(taskNotesBox.Text);
                    list.Add(file);
                    list.Add(taskCompleteCheck.Checked);

                    view.AddTask(list);
                    Close();
                }
            }
        }

        private string CheckSender(Button b)
        {
            if(b.Name == apOKButton.Name)
            {
                return "Appointment";
            }
            else if(b.Name == memOKButton.Name)
            {
                return "Memory";
            }
            else if(b.Name == perOKButton.Name)
            {
                return "Person";
            }
            else if(b.Name == taskOKButton.Name)
            {
                return "Task";
            }
            else
            {
                return "";
            }
        }

        private void SanitiseInput(string name, string address, string notes, string relationship)
        {
            exceptionThrown = false;
            Regex input = new Regex("^[-a-zA-Z0-9 ,.']*$");
            try
            {
                if (string.IsNullOrWhiteSpace(name))
                {
                    throw new NullValueException();
                }

                if (string.IsNullOrWhiteSpace(address))
                {
                    throw new NullValueException();
                }

                if(!input.IsMatch(name))
                {
                    throw new NaughtyValueException();
                }

                if(!input.IsMatch(address))
                {
                    throw new NaughtyValueException();
                }

                if (!string.IsNullOrWhiteSpace(notes))
                {
                    if (!input.IsMatch(notes))
                    {
                        throw new NaughtyValueException();
                    }
                }

                if (!string.IsNullOrWhiteSpace(relationship))
                {
                    if (!input.IsMatch(relationship))
                    {
                        throw new NaughtyValueException();
                    }
                }
            }
            catch(NullValueException)
            {
                exceptionThrown = true;

                MessageBox.Show("Invalid input.\r\nName and address must be entered.", "Error Window");
            }
            catch(NaughtyValueException)
            {
                exceptionThrown = true;

                MessageBox.Show("Please stick to letters, numbers, commas, hyphens, full stops and apostrophes");
            }
            catch(Exception e)
            {
                exceptionThrown = true;

                MessageBox.Show("Uh oh..something else went wrong. " + e.Message);
            }
        }
    }

    public class NullValueException : Exception
    {
        public NullValueException()
        {

        }
    }

    public class NaughtyValueException : Exception
    {
        public NaughtyValueException()
        {

        }
    }
}

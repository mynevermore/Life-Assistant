using System;
using System.Windows.Forms;

namespace LifeAssistant_ICT365_Assignment1.View
{
    public partial class HelpBox : Form
    {
        public HelpBox()
        {
            InitializeComponent();
        }

        private bool okButton = false;

        public bool OKButtonClicked
        {
            get { return okButton; }
        }

        private void buttonClick(object sender, EventArgs e)
        {
            okButton = true;
            this.Close();
        }
    }
}

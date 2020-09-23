namespace Chatr.Forms
{
    using System;
    using System.Windows.Forms;

    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void AddDestinationButton_Click(object sender, EventArgs e)
        {
            string destinationName = DestinationTextBox.Text;

            DestinationsCheckedListBox.Items.Add(destinationName);
        }

        private void AddSourceButton_Click(object sender, EventArgs e)
        {
            string sourceName = SourceTextBox.Text;

            SourcesCheckedListBox.Items.Add(sourceName);
        }
    }
}
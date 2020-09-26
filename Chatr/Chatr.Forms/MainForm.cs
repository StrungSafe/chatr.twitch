namespace Chatr.Forms
{
    using System;
    using System.Linq;
    using System.Threading;
    using System.Threading.Tasks;
    using System.Windows.Forms;

    using Microsoft.Extensions.Logging.Abstractions;

    public partial class MainForm : Form
    {
        private bool isRunning;

        private Bot twitchBot;

        public MainForm()
        {
            InitializeComponent();
        }

        private void AddDestinationButton_Click(object sender, EventArgs e)
        {
            HandleAddToListBox(DestinationsCheckedListBox, DestinationTextBox);
        }

        private void AddSourceButton_Click(object sender, EventArgs e)
        {
            HandleAddToListBox(SourcesCheckedListBox, SourceTextBox);
        }

        private void DeleteDestinationsButton_Click(object sender, EventArgs e)
        {
            var destination = new string[DestinationsCheckedListBox.SelectedItems.Count];
            DestinationsCheckedListBox.SelectedItems.CopyTo(destination, 0);

            foreach (string selectedItem in destination)
            {
                DestinationsCheckedListBox.Items.Remove(selectedItem);
            }
        }

        private void DeleteSourcesButton_Click(object sender, EventArgs e)
        {
            var destination = new string[SourcesCheckedListBox.SelectedItems.Count];
            SourcesCheckedListBox.SelectedItems.CopyTo(destination, 0);

            foreach (string selectedItem in destination)
            {
                SourcesCheckedListBox.Items.Remove(selectedItem);
            }
        }

        private void DiscordEnabledCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (DiscordEnabledCheckBox.Checked)
            {
                DiscordChannelTextBox.Enabled = true;
                DiscordTokenTextBox.Enabled = true;
            }
            else
            {
                DiscordChannelTextBox.Enabled = false;
                DiscordTokenTextBox.Enabled = false;
            }
        }

        private void HandleAddToListBox(CheckedListBox box, TextBox text)
        {
            if (string.IsNullOrEmpty(text.Text))
            {
                return;
            }

            if (box.Items.Contains(text.Text))
            {
                return;
            }

            string sourceName = text.Text;

            box.Items.Add(sourceName);

            text.Text = string.Empty;
        }

        private void IgnoreChatFromAddButton_Click(object sender, EventArgs e)
        {
            HandleAddToListBox(IgnoreChatFromListBox, IgnoreChatFromTextBox);
        }

        private void IgnoreChatFromDeleteButton_Click(object sender, EventArgs e)
        {
            var destination = new string[IgnoreChatFromListBox.SelectedItems.Count];
            IgnoreChatFromListBox.SelectedItems.CopyTo(destination, 0);

            foreach (string selectedItem in destination)
            {
                IgnoreChatFromListBox.Items.Remove(selectedItem);
            }
        }

        private void IgnoreCommandsFromDeleteButton_Click(object sender, EventArgs e)
        {
            var destination = new string[IgnoreCommandsFromListBox.SelectedItems.Count];
            IgnoreCommandsFromListBox.SelectedItems.CopyTo(destination, 0);

            foreach (string selectedItem in destination)
            {
                IgnoreCommandsFromListBox.Items.Remove(selectedItem);
            }
        }

        private void IgnoreFromCommandsAddButton_Click(object sender, EventArgs e)
        {
            HandleAddToListBox(IgnoreCommandsFromListBox, IgnoreCommandsFromTextBox);
        }

        private async void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            await Stop();
        }

        private async void StartButton_Click(object sender, EventArgs e)
        {
            if (isRunning)
            {
                return;
            }

            isRunning = true;

            StartButton.Enabled = false;
            StopButton.Enabled = true;

            TwitchGroupBox.Enabled = false;
            DiscordGroupBox.Enabled = false;

            var twitchBotConfig = new BotConfig
                                  {
                                      Name = TwitchNameTextBox.Text,
                                      Channel = TwitchChannelTextBox.Text,
                                      Token = TwitchTokenTextBox.Text,
                                      Sources = SourcesCheckedListBox.Items.Cast<string>().ToArray(),
                                      Destinations = DestinationsCheckedListBox.Items.Cast<string>().ToArray(),
                                      MaxConnections = 6
                                  };
            twitchBot = new Bot(twitchBotConfig, NullLogger<Bot>.Instance);
            await twitchBot.StartAsync(CancellationToken.None);
        }

        private async Task Stop()
        {
            if (!isRunning)
            {
                return;
            }

            isRunning = false;

            StartButton.Enabled = true;
            StopButton.Enabled = false;

            TwitchGroupBox.Enabled = true;
            DiscordGroupBox.Enabled = true;

            await twitchBot.StopAsync(CancellationToken.None);
        }

        private async void StopButton_Click(object sender, EventArgs e)
        {
            await Stop();
        }
    }
}
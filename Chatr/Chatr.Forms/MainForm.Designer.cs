namespace Chatr.Forms
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.StartButton = new System.Windows.Forms.Button();
            this.StopButton = new System.Windows.Forms.Button();
            this.TwitchGroupBox = new System.Windows.Forms.GroupBox();
            this.IgnoreCommandsFromGroupBox = new System.Windows.Forms.GroupBox();
            this.IgnoreCommandsFromDeleteButton = new System.Windows.Forms.Button();
            this.IgnoreCommandsFromTextBox = new System.Windows.Forms.TextBox();
            this.IgnoreCommandsFromAddButton = new System.Windows.Forms.Button();
            this.IgnoreCommandsFromListBox = new System.Windows.Forms.CheckedListBox();
            this.IgnoreChatFromGroupBox = new System.Windows.Forms.GroupBox();
            this.IgnoreChatFromDeleteButton = new System.Windows.Forms.Button();
            this.IgnoreChatFromTextBox = new System.Windows.Forms.TextBox();
            this.IgnoreChatFromAddButton = new System.Windows.Forms.Button();
            this.IgnoreChatFromListBox = new System.Windows.Forms.CheckedListBox();
            this.DestinationsGroupBox = new System.Windows.Forms.GroupBox();
            this.DeleteDestinationsButton = new System.Windows.Forms.Button();
            this.DestinationTextBox = new System.Windows.Forms.TextBox();
            this.AddDestinationButton = new System.Windows.Forms.Button();
            this.DestinationsCheckedListBox = new System.Windows.Forms.CheckedListBox();
            this.SourcesGroupBox = new System.Windows.Forms.GroupBox();
            this.DeleteSourcesButton = new System.Windows.Forms.Button();
            this.SourceTextBox = new System.Windows.Forms.TextBox();
            this.AddSourceButton = new System.Windows.Forms.Button();
            this.SourcesCheckedListBox = new System.Windows.Forms.CheckedListBox();
            this.TwitchChannelTextBox = new System.Windows.Forms.TextBox();
            this.TwitchTokenTextBox = new System.Windows.Forms.TextBox();
            this.TwitchNameTextBox = new System.Windows.Forms.TextBox();
            this.TwitchChannelLabel = new System.Windows.Forms.Label();
            this.TwitchTokenLabel = new System.Windows.Forms.Label();
            this.TwitchNameLabel = new System.Windows.Forms.Label();
            this.DiscordGroupBox = new System.Windows.Forms.GroupBox();
            this.DiscordEnabledCheckBox = new System.Windows.Forms.CheckBox();
            this.DiscordChannelLabel = new System.Windows.Forms.Label();
            this.DiscordTokenLabel = new System.Windows.Forms.Label();
            this.DiscordChannelTextBox = new System.Windows.Forms.TextBox();
            this.DiscordTokenTextBox = new System.Windows.Forms.TextBox();
            this.TwitchGroupBox.SuspendLayout();
            this.IgnoreCommandsFromGroupBox.SuspendLayout();
            this.IgnoreChatFromGroupBox.SuspendLayout();
            this.DestinationsGroupBox.SuspendLayout();
            this.SourcesGroupBox.SuspendLayout();
            this.DiscordGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // StartButton
            // 
            this.StartButton.BackColor = System.Drawing.Color.Green;
            this.StartButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.StartButton.Location = new System.Drawing.Point(813, 12);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(94, 199);
            this.StartButton.TabIndex = 0;
            this.StartButton.Text = "Start";
            this.StartButton.UseVisualStyleBackColor = false;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // StopButton
            // 
            this.StopButton.BackColor = System.Drawing.Color.Red;
            this.StopButton.Enabled = false;
            this.StopButton.Location = new System.Drawing.Point(819, 398);
            this.StopButton.Name = "StopButton";
            this.StopButton.Size = new System.Drawing.Size(94, 128);
            this.StopButton.TabIndex = 1;
            this.StopButton.Text = "Stop";
            this.StopButton.UseVisualStyleBackColor = false;
            this.StopButton.Click += new System.EventHandler(this.StopButton_Click);
            // 
            // TwitchGroupBox
            // 
            this.TwitchGroupBox.Controls.Add(this.IgnoreCommandsFromGroupBox);
            this.TwitchGroupBox.Controls.Add(this.IgnoreChatFromGroupBox);
            this.TwitchGroupBox.Controls.Add(this.DestinationsGroupBox);
            this.TwitchGroupBox.Controls.Add(this.SourcesGroupBox);
            this.TwitchGroupBox.Controls.Add(this.TwitchChannelTextBox);
            this.TwitchGroupBox.Controls.Add(this.TwitchTokenTextBox);
            this.TwitchGroupBox.Controls.Add(this.TwitchNameTextBox);
            this.TwitchGroupBox.Controls.Add(this.TwitchChannelLabel);
            this.TwitchGroupBox.Controls.Add(this.TwitchTokenLabel);
            this.TwitchGroupBox.Controls.Add(this.TwitchNameLabel);
            this.TwitchGroupBox.Location = new System.Drawing.Point(12, 12);
            this.TwitchGroupBox.Name = "TwitchGroupBox";
            this.TwitchGroupBox.Size = new System.Drawing.Size(795, 362);
            this.TwitchGroupBox.TabIndex = 2;
            this.TwitchGroupBox.TabStop = false;
            this.TwitchGroupBox.Text = "Twitch";
            // 
            // IgnoreCommandsFromGroupBox
            // 
            this.IgnoreCommandsFromGroupBox.Controls.Add(this.IgnoreCommandsFromDeleteButton);
            this.IgnoreCommandsFromGroupBox.Controls.Add(this.IgnoreCommandsFromTextBox);
            this.IgnoreCommandsFromGroupBox.Controls.Add(this.IgnoreCommandsFromAddButton);
            this.IgnoreCommandsFromGroupBox.Controls.Add(this.IgnoreCommandsFromListBox);
            this.IgnoreCommandsFromGroupBox.Location = new System.Drawing.Point(478, 189);
            this.IgnoreCommandsFromGroupBox.Name = "IgnoreCommandsFromGroupBox";
            this.IgnoreCommandsFromGroupBox.Size = new System.Drawing.Size(303, 161);
            this.IgnoreCommandsFromGroupBox.TabIndex = 14;
            this.IgnoreCommandsFromGroupBox.TabStop = false;
            this.IgnoreCommandsFromGroupBox.Text = "Ignore Commands From";
            // 
            // IgnoreCommandsFromDeleteButton
            // 
            this.IgnoreCommandsFromDeleteButton.Location = new System.Drawing.Point(189, 55);
            this.IgnoreCommandsFromDeleteButton.Name = "IgnoreCommandsFromDeleteButton";
            this.IgnoreCommandsFromDeleteButton.Size = new System.Drawing.Size(105, 23);
            this.IgnoreCommandsFromDeleteButton.TabIndex = 14;
            this.IgnoreCommandsFromDeleteButton.Text = "Delete";
            this.IgnoreCommandsFromDeleteButton.UseVisualStyleBackColor = true;
            this.IgnoreCommandsFromDeleteButton.Click += new System.EventHandler(this.IgnoreCommandsFromDeleteButton_Click);
            // 
            // IgnoreCommandsFromTextBox
            // 
            this.IgnoreCommandsFromTextBox.Location = new System.Drawing.Point(6, 22);
            this.IgnoreCommandsFromTextBox.Name = "IgnoreCommandsFromTextBox";
            this.IgnoreCommandsFromTextBox.Size = new System.Drawing.Size(177, 23);
            this.IgnoreCommandsFromTextBox.TabIndex = 12;
            // 
            // IgnoreCommandsFromAddButton
            // 
            this.IgnoreCommandsFromAddButton.Location = new System.Drawing.Point(189, 21);
            this.IgnoreCommandsFromAddButton.Name = "IgnoreCommandsFromAddButton";
            this.IgnoreCommandsFromAddButton.Size = new System.Drawing.Size(105, 23);
            this.IgnoreCommandsFromAddButton.TabIndex = 13;
            this.IgnoreCommandsFromAddButton.Text = "Add";
            this.IgnoreCommandsFromAddButton.UseVisualStyleBackColor = true;
            this.IgnoreCommandsFromAddButton.Click += new System.EventHandler(this.IgnoreFromCommandsAddButton_Click);
            // 
            // IgnoreCommandsFromListBox
            // 
            this.IgnoreCommandsFromListBox.FormattingEnabled = true;
            this.IgnoreCommandsFromListBox.Location = new System.Drawing.Point(6, 55);
            this.IgnoreCommandsFromListBox.Name = "IgnoreCommandsFromListBox";
            this.IgnoreCommandsFromListBox.Size = new System.Drawing.Size(177, 94);
            this.IgnoreCommandsFromListBox.TabIndex = 10;
            // 
            // IgnoreChatFromGroupBox
            // 
            this.IgnoreChatFromGroupBox.Controls.Add(this.IgnoreChatFromDeleteButton);
            this.IgnoreChatFromGroupBox.Controls.Add(this.IgnoreChatFromTextBox);
            this.IgnoreChatFromGroupBox.Controls.Add(this.IgnoreChatFromAddButton);
            this.IgnoreChatFromGroupBox.Controls.Add(this.IgnoreChatFromListBox);
            this.IgnoreChatFromGroupBox.Location = new System.Drawing.Point(169, 189);
            this.IgnoreChatFromGroupBox.Name = "IgnoreChatFromGroupBox";
            this.IgnoreChatFromGroupBox.Size = new System.Drawing.Size(303, 161);
            this.IgnoreChatFromGroupBox.TabIndex = 14;
            this.IgnoreChatFromGroupBox.TabStop = false;
            this.IgnoreChatFromGroupBox.Text = "Ignore Chat From";
            // 
            // IgnoreChatFromDeleteButton
            // 
            this.IgnoreChatFromDeleteButton.Location = new System.Drawing.Point(189, 55);
            this.IgnoreChatFromDeleteButton.Name = "IgnoreChatFromDeleteButton";
            this.IgnoreChatFromDeleteButton.Size = new System.Drawing.Size(105, 23);
            this.IgnoreChatFromDeleteButton.TabIndex = 14;
            this.IgnoreChatFromDeleteButton.Text = "Delete";
            this.IgnoreChatFromDeleteButton.UseVisualStyleBackColor = true;
            this.IgnoreChatFromDeleteButton.Click += new System.EventHandler(this.IgnoreChatFromDeleteButton_Click);
            // 
            // IgnoreChatFromTextBox
            // 
            this.IgnoreChatFromTextBox.Location = new System.Drawing.Point(6, 22);
            this.IgnoreChatFromTextBox.Name = "IgnoreChatFromTextBox";
            this.IgnoreChatFromTextBox.Size = new System.Drawing.Size(177, 23);
            this.IgnoreChatFromTextBox.TabIndex = 12;
            // 
            // IgnoreChatFromAddButton
            // 
            this.IgnoreChatFromAddButton.Location = new System.Drawing.Point(189, 21);
            this.IgnoreChatFromAddButton.Name = "IgnoreChatFromAddButton";
            this.IgnoreChatFromAddButton.Size = new System.Drawing.Size(105, 23);
            this.IgnoreChatFromAddButton.TabIndex = 13;
            this.IgnoreChatFromAddButton.Text = "Add";
            this.IgnoreChatFromAddButton.UseVisualStyleBackColor = true;
            this.IgnoreChatFromAddButton.Click += new System.EventHandler(this.IgnoreChatFromAddButton_Click);
            // 
            // IgnoreChatFromListBox
            // 
            this.IgnoreChatFromListBox.FormattingEnabled = true;
            this.IgnoreChatFromListBox.Location = new System.Drawing.Point(6, 55);
            this.IgnoreChatFromListBox.Name = "IgnoreChatFromListBox";
            this.IgnoreChatFromListBox.Size = new System.Drawing.Size(177, 94);
            this.IgnoreChatFromListBox.TabIndex = 10;
            // 
            // DestinationsGroupBox
            // 
            this.DestinationsGroupBox.Controls.Add(this.DeleteDestinationsButton);
            this.DestinationsGroupBox.Controls.Add(this.DestinationTextBox);
            this.DestinationsGroupBox.Controls.Add(this.AddDestinationButton);
            this.DestinationsGroupBox.Controls.Add(this.DestinationsCheckedListBox);
            this.DestinationsGroupBox.Location = new System.Drawing.Point(478, 22);
            this.DestinationsGroupBox.Name = "DestinationsGroupBox";
            this.DestinationsGroupBox.Size = new System.Drawing.Size(303, 161);
            this.DestinationsGroupBox.TabIndex = 14;
            this.DestinationsGroupBox.TabStop = false;
            this.DestinationsGroupBox.Text = "Destinations";
            // 
            // DeleteDestinationsButton
            // 
            this.DeleteDestinationsButton.Location = new System.Drawing.Point(189, 55);
            this.DeleteDestinationsButton.Name = "DeleteDestinationsButton";
            this.DeleteDestinationsButton.Size = new System.Drawing.Size(105, 23);
            this.DeleteDestinationsButton.TabIndex = 14;
            this.DeleteDestinationsButton.Text = "Delete";
            this.DeleteDestinationsButton.UseVisualStyleBackColor = true;
            this.DeleteDestinationsButton.Click += new System.EventHandler(this.DeleteDestinationsButton_Click);
            // 
            // DestinationTextBox
            // 
            this.DestinationTextBox.Location = new System.Drawing.Point(6, 22);
            this.DestinationTextBox.Name = "DestinationTextBox";
            this.DestinationTextBox.Size = new System.Drawing.Size(177, 23);
            this.DestinationTextBox.TabIndex = 12;
            // 
            // AddDestinationButton
            // 
            this.AddDestinationButton.Location = new System.Drawing.Point(189, 21);
            this.AddDestinationButton.Name = "AddDestinationButton";
            this.AddDestinationButton.Size = new System.Drawing.Size(105, 23);
            this.AddDestinationButton.TabIndex = 13;
            this.AddDestinationButton.Text = "Add";
            this.AddDestinationButton.UseVisualStyleBackColor = true;
            this.AddDestinationButton.Click += new System.EventHandler(this.AddDestinationButton_Click);
            // 
            // DestinationsCheckedListBox
            // 
            this.DestinationsCheckedListBox.FormattingEnabled = true;
            this.DestinationsCheckedListBox.Location = new System.Drawing.Point(6, 55);
            this.DestinationsCheckedListBox.Name = "DestinationsCheckedListBox";
            this.DestinationsCheckedListBox.Size = new System.Drawing.Size(177, 94);
            this.DestinationsCheckedListBox.TabIndex = 10;
            // 
            // SourcesGroupBox
            // 
            this.SourcesGroupBox.Controls.Add(this.DeleteSourcesButton);
            this.SourcesGroupBox.Controls.Add(this.SourceTextBox);
            this.SourcesGroupBox.Controls.Add(this.AddSourceButton);
            this.SourcesGroupBox.Controls.Add(this.SourcesCheckedListBox);
            this.SourcesGroupBox.Location = new System.Drawing.Point(169, 22);
            this.SourcesGroupBox.Name = "SourcesGroupBox";
            this.SourcesGroupBox.Size = new System.Drawing.Size(303, 161);
            this.SourcesGroupBox.TabIndex = 14;
            this.SourcesGroupBox.TabStop = false;
            this.SourcesGroupBox.Text = "Sources";
            // 
            // DeleteSourcesButton
            // 
            this.DeleteSourcesButton.Location = new System.Drawing.Point(189, 55);
            this.DeleteSourcesButton.Name = "DeleteSourcesButton";
            this.DeleteSourcesButton.Size = new System.Drawing.Size(105, 23);
            this.DeleteSourcesButton.TabIndex = 14;
            this.DeleteSourcesButton.Text = "Delete";
            this.DeleteSourcesButton.UseVisualStyleBackColor = true;
            this.DeleteSourcesButton.Click += new System.EventHandler(this.DeleteSourcesButton_Click);
            // 
            // SourceTextBox
            // 
            this.SourceTextBox.Location = new System.Drawing.Point(6, 22);
            this.SourceTextBox.Name = "SourceTextBox";
            this.SourceTextBox.Size = new System.Drawing.Size(177, 23);
            this.SourceTextBox.TabIndex = 12;
            // 
            // AddSourceButton
            // 
            this.AddSourceButton.Location = new System.Drawing.Point(189, 21);
            this.AddSourceButton.Name = "AddSourceButton";
            this.AddSourceButton.Size = new System.Drawing.Size(105, 23);
            this.AddSourceButton.TabIndex = 13;
            this.AddSourceButton.Text = "Add";
            this.AddSourceButton.UseVisualStyleBackColor = true;
            this.AddSourceButton.Click += new System.EventHandler(this.AddSourceButton_Click);
            // 
            // SourcesCheckedListBox
            // 
            this.SourcesCheckedListBox.FormattingEnabled = true;
            this.SourcesCheckedListBox.Location = new System.Drawing.Point(6, 55);
            this.SourcesCheckedListBox.Name = "SourcesCheckedListBox";
            this.SourcesCheckedListBox.Size = new System.Drawing.Size(177, 94);
            this.SourcesCheckedListBox.TabIndex = 10;
            // 
            // TwitchChannelTextBox
            // 
            this.TwitchChannelTextBox.Location = new System.Drawing.Point(63, 74);
            this.TwitchChannelTextBox.Name = "TwitchChannelTextBox";
            this.TwitchChannelTextBox.Size = new System.Drawing.Size(100, 23);
            this.TwitchChannelTextBox.TabIndex = 9;
            // 
            // TwitchTokenTextBox
            // 
            this.TwitchTokenTextBox.Location = new System.Drawing.Point(63, 50);
            this.TwitchTokenTextBox.Name = "TwitchTokenTextBox";
            this.TwitchTokenTextBox.Size = new System.Drawing.Size(100, 23);
            this.TwitchTokenTextBox.TabIndex = 8;
            // 
            // TwitchNameTextBox
            // 
            this.TwitchNameTextBox.Location = new System.Drawing.Point(63, 26);
            this.TwitchNameTextBox.Name = "TwitchNameTextBox";
            this.TwitchNameTextBox.Size = new System.Drawing.Size(100, 23);
            this.TwitchNameTextBox.TabIndex = 7;
            // 
            // TwitchChannelLabel
            // 
            this.TwitchChannelLabel.AutoSize = true;
            this.TwitchChannelLabel.Location = new System.Drawing.Point(6, 77);
            this.TwitchChannelLabel.Name = "TwitchChannelLabel";
            this.TwitchChannelLabel.Size = new System.Drawing.Size(51, 15);
            this.TwitchChannelLabel.TabIndex = 6;
            this.TwitchChannelLabel.Text = "Channel";
            // 
            // TwitchTokenLabel
            // 
            this.TwitchTokenLabel.AutoSize = true;
            this.TwitchTokenLabel.Location = new System.Drawing.Point(17, 53);
            this.TwitchTokenLabel.Name = "TwitchTokenLabel";
            this.TwitchTokenLabel.Size = new System.Drawing.Size(40, 15);
            this.TwitchTokenLabel.TabIndex = 5;
            this.TwitchTokenLabel.Text = "Token";
            // 
            // TwitchNameLabel
            // 
            this.TwitchNameLabel.AutoSize = true;
            this.TwitchNameLabel.Location = new System.Drawing.Point(17, 29);
            this.TwitchNameLabel.Name = "TwitchNameLabel";
            this.TwitchNameLabel.Size = new System.Drawing.Size(39, 15);
            this.TwitchNameLabel.TabIndex = 4;
            this.TwitchNameLabel.Text = "Name";
            // 
            // DiscordGroupBox
            // 
            this.DiscordGroupBox.Controls.Add(this.DiscordEnabledCheckBox);
            this.DiscordGroupBox.Controls.Add(this.DiscordChannelLabel);
            this.DiscordGroupBox.Controls.Add(this.DiscordTokenLabel);
            this.DiscordGroupBox.Controls.Add(this.DiscordChannelTextBox);
            this.DiscordGroupBox.Controls.Add(this.DiscordTokenTextBox);
            this.DiscordGroupBox.Location = new System.Drawing.Point(18, 398);
            this.DiscordGroupBox.Name = "DiscordGroupBox";
            this.DiscordGroupBox.Size = new System.Drawing.Size(795, 128);
            this.DiscordGroupBox.TabIndex = 3;
            this.DiscordGroupBox.TabStop = false;
            this.DiscordGroupBox.Text = "Discord";
            // 
            // DiscordEnabledCheckBox
            // 
            this.DiscordEnabledCheckBox.AutoSize = true;
            this.DiscordEnabledCheckBox.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.DiscordEnabledCheckBox.Checked = true;
            this.DiscordEnabledCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.DiscordEnabledCheckBox.Location = new System.Drawing.Point(11, 24);
            this.DiscordEnabledCheckBox.Name = "DiscordEnabledCheckBox";
            this.DiscordEnabledCheckBox.Size = new System.Drawing.Size(68, 19);
            this.DiscordEnabledCheckBox.TabIndex = 8;
            this.DiscordEnabledCheckBox.Text = "Enabled";
            this.DiscordEnabledCheckBox.UseVisualStyleBackColor = true;
            this.DiscordEnabledCheckBox.CheckedChanged += new System.EventHandler(this.DiscordEnabledCheckBox_CheckedChanged);
            // 
            // DiscordChannelLabel
            // 
            this.DiscordChannelLabel.AutoSize = true;
            this.DiscordChannelLabel.Location = new System.Drawing.Point(6, 81);
            this.DiscordChannelLabel.Name = "DiscordChannelLabel";
            this.DiscordChannelLabel.Size = new System.Drawing.Size(51, 15);
            this.DiscordChannelLabel.TabIndex = 7;
            this.DiscordChannelLabel.Text = "Channel";
            // 
            // DiscordTokenLabel
            // 
            this.DiscordTokenLabel.AutoSize = true;
            this.DiscordTokenLabel.Location = new System.Drawing.Point(19, 52);
            this.DiscordTokenLabel.Name = "DiscordTokenLabel";
            this.DiscordTokenLabel.Size = new System.Drawing.Size(40, 15);
            this.DiscordTokenLabel.TabIndex = 6;
            this.DiscordTokenLabel.Text = "Token";
            // 
            // DiscordChannelTextBox
            // 
            this.DiscordChannelTextBox.Location = new System.Drawing.Point(63, 78);
            this.DiscordChannelTextBox.Name = "DiscordChannelTextBox";
            this.DiscordChannelTextBox.Size = new System.Drawing.Size(274, 23);
            this.DiscordChannelTextBox.TabIndex = 5;
            // 
            // DiscordTokenTextBox
            // 
            this.DiscordTokenTextBox.Location = new System.Drawing.Point(63, 49);
            this.DiscordTokenTextBox.Name = "DiscordTokenTextBox";
            this.DiscordTokenTextBox.Size = new System.Drawing.Size(274, 23);
            this.DiscordTokenTextBox.TabIndex = 4;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(915, 538);
            this.Controls.Add(this.DiscordGroupBox);
            this.Controls.Add(this.TwitchGroupBox);
            this.Controls.Add(this.StopButton);
            this.Controls.Add(this.StartButton);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.Text = "Chatr";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.TwitchGroupBox.ResumeLayout(false);
            this.TwitchGroupBox.PerformLayout();
            this.IgnoreCommandsFromGroupBox.ResumeLayout(false);
            this.IgnoreCommandsFromGroupBox.PerformLayout();
            this.IgnoreChatFromGroupBox.ResumeLayout(false);
            this.IgnoreChatFromGroupBox.PerformLayout();
            this.DestinationsGroupBox.ResumeLayout(false);
            this.DestinationsGroupBox.PerformLayout();
            this.SourcesGroupBox.ResumeLayout(false);
            this.SourcesGroupBox.PerformLayout();
            this.DiscordGroupBox.ResumeLayout(false);
            this.DiscordGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.Button StopButton;
        private System.Windows.Forms.GroupBox TwitchGroupBox;
        private System.Windows.Forms.GroupBox DiscordGroupBox;
        private System.Windows.Forms.Label DiscordChannelLabel;
        private System.Windows.Forms.Label DiscordTokenLabel;
        private System.Windows.Forms.TextBox DiscordChannelTextBox;
        private System.Windows.Forms.TextBox DiscordTokenTextBox;
        private System.Windows.Forms.Label TwitchChannelLabel;
        private System.Windows.Forms.Label TwitchTokenLabel;
        private System.Windows.Forms.Label TwitchNameLabel;
        private System.Windows.Forms.TextBox TwitchChannelTextBox;
        private System.Windows.Forms.TextBox TwitchTokenTextBox;
        private System.Windows.Forms.TextBox TwitchNameTextBox;
        private System.Windows.Forms.CheckedListBox SourcesCheckedListBox;
        private System.Windows.Forms.Button AddSourceButton;
        private System.Windows.Forms.TextBox SourceTextBox;
        private System.Windows.Forms.GroupBox DestinationsGroupBox;
        private System.Windows.Forms.TextBox DestinationTextBox;
        private System.Windows.Forms.Button AddDestinationButton;
        private System.Windows.Forms.CheckedListBox DestinationsCheckedListBox;
        private System.Windows.Forms.GroupBox SourcesGroupBox;
        private System.Windows.Forms.Button DeleteSourcesButton;
        private System.Windows.Forms.Button DeleteDestinationsButton;
        private System.Windows.Forms.GroupBox IgnoreCommandsFromGroupBox;
        private System.Windows.Forms.Button IgnoreCommandsFromDeleteButton;
        private System.Windows.Forms.TextBox IgnoreCommandsFromTextBox;
        private System.Windows.Forms.Button IgnoreCommandsFromAddButton;
        private System.Windows.Forms.CheckedListBox IgnoreCommandsFromListBox;
        private System.Windows.Forms.GroupBox IgnoreChatFromGroupBox;
        private System.Windows.Forms.Button IgnoreChatFromDeleteButton;
        private System.Windows.Forms.TextBox IgnoreChatFromTextBox;
        private System.Windows.Forms.Button IgnoreChatFromAddButton;
        private System.Windows.Forms.CheckedListBox IgnoreChatFromListBox;
        private System.Windows.Forms.CheckBox DiscordEnabledCheckBox;
    }
}


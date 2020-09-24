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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.IgnoreCommandsFromTextBox = new System.Windows.Forms.TextBox();
            this.IgnoreCommandsFromAddButton = new System.Windows.Forms.Button();
            this.IgnoreCommandsFromListBox = new System.Windows.Forms.CheckedListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.IgnoreChatFromTextBox = new System.Windows.Forms.TextBox();
            this.IgnoreChatFromAddButton = new System.Windows.Forms.Button();
            this.IgnoreChatFromListBox = new System.Windows.Forms.CheckedListBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.DeleteDestinationsButton = new System.Windows.Forms.Button();
            this.DestinationTextBox = new System.Windows.Forms.TextBox();
            this.AddDestinationButton = new System.Windows.Forms.Button();
            this.DestinationsCheckedListBox = new System.Windows.Forms.CheckedListBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.DeleteSourcesButton = new System.Windows.Forms.Button();
            this.SourceTextBox = new System.Windows.Forms.TextBox();
            this.AddSourceButton = new System.Windows.Forms.Button();
            this.SourcesCheckedListBox = new System.Windows.Forms.CheckedListBox();
            this.TwitchChannelTextBox = new System.Windows.Forms.TextBox();
            this.TwitchTokenTextBox = new System.Windows.Forms.TextBox();
            this.TwitchNameTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.DiscordGroupBox = new System.Windows.Forms.GroupBox();
            this.DiscordEnabledCheckBox = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.DiscordChannelTextBox = new System.Windows.Forms.TextBox();
            this.DiscordTokenTextBox = new System.Windows.Forms.TextBox();
            this.TwitchGroupBox.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.DiscordGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // StartButton
            // 
            this.StartButton.Location = new System.Drawing.Point(813, 12);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(94, 199);
            this.StartButton.TabIndex = 0;
            this.StartButton.Text = "Start";
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // StopButton
            // 
            this.StopButton.Enabled = false;
            this.StopButton.Location = new System.Drawing.Point(819, 398);
            this.StopButton.Name = "StopButton";
            this.StopButton.Size = new System.Drawing.Size(94, 128);
            this.StopButton.TabIndex = 1;
            this.StopButton.Text = "Stop";
            this.StopButton.UseVisualStyleBackColor = true;
            this.StopButton.Click += new System.EventHandler(this.StopButton_Click);
            // 
            // TwitchGroupBox
            // 
            this.TwitchGroupBox.Controls.Add(this.groupBox2);
            this.TwitchGroupBox.Controls.Add(this.groupBox1);
            this.TwitchGroupBox.Controls.Add(this.groupBox4);
            this.TwitchGroupBox.Controls.Add(this.groupBox3);
            this.TwitchGroupBox.Controls.Add(this.TwitchChannelTextBox);
            this.TwitchGroupBox.Controls.Add(this.TwitchTokenTextBox);
            this.TwitchGroupBox.Controls.Add(this.TwitchNameTextBox);
            this.TwitchGroupBox.Controls.Add(this.label5);
            this.TwitchGroupBox.Controls.Add(this.label4);
            this.TwitchGroupBox.Controls.Add(this.label3);
            this.TwitchGroupBox.Location = new System.Drawing.Point(12, 12);
            this.TwitchGroupBox.Name = "TwitchGroupBox";
            this.TwitchGroupBox.Size = new System.Drawing.Size(795, 362);
            this.TwitchGroupBox.TabIndex = 2;
            this.TwitchGroupBox.TabStop = false;
            this.TwitchGroupBox.Text = "Twitch";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button3);
            this.groupBox2.Controls.Add(this.IgnoreCommandsFromTextBox);
            this.groupBox2.Controls.Add(this.IgnoreCommandsFromAddButton);
            this.groupBox2.Controls.Add(this.IgnoreCommandsFromListBox);
            this.groupBox2.Location = new System.Drawing.Point(478, 189);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(303, 161);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ignore Commands From";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(189, 55);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(105, 23);
            this.button3.TabIndex = 14;
            this.button3.Text = "Delete";
            this.button3.UseVisualStyleBackColor = true;
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.IgnoreChatFromTextBox);
            this.groupBox1.Controls.Add(this.IgnoreChatFromAddButton);
            this.groupBox1.Controls.Add(this.IgnoreChatFromListBox);
            this.groupBox1.Location = new System.Drawing.Point(169, 189);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(303, 161);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ignore Chat From";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(189, 55);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(105, 23);
            this.button1.TabIndex = 14;
            this.button1.Text = "Delete";
            this.button1.UseVisualStyleBackColor = true;
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
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.DeleteDestinationsButton);
            this.groupBox4.Controls.Add(this.DestinationTextBox);
            this.groupBox4.Controls.Add(this.AddDestinationButton);
            this.groupBox4.Controls.Add(this.DestinationsCheckedListBox);
            this.groupBox4.Location = new System.Drawing.Point(478, 22);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(303, 161);
            this.groupBox4.TabIndex = 14;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Destinations";
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
            this.AddDestinationButton.Text = "Add Destination";
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
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.DeleteSourcesButton);
            this.groupBox3.Controls.Add(this.SourceTextBox);
            this.groupBox3.Controls.Add(this.AddSourceButton);
            this.groupBox3.Controls.Add(this.SourcesCheckedListBox);
            this.groupBox3.Location = new System.Drawing.Point(169, 22);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(303, 161);
            this.groupBox3.TabIndex = 14;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Sources";
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
            this.AddSourceButton.Text = "Add Source";
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
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 77);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 15);
            this.label5.TabIndex = 6;
            this.label5.Text = "Channel";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 53);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 15);
            this.label4.TabIndex = 5;
            this.label4.Text = "Token";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Name";
            // 
            // DiscordGroupBox
            // 
            this.DiscordGroupBox.Controls.Add(this.DiscordEnabledCheckBox);
            this.DiscordGroupBox.Controls.Add(this.label2);
            this.DiscordGroupBox.Controls.Add(this.label1);
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "Channel";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "Token";
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
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.DiscordGroupBox.ResumeLayout(false);
            this.DiscordGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.Button StopButton;
        private System.Windows.Forms.GroupBox TwitchGroupBox;
        private System.Windows.Forms.GroupBox DiscordGroupBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox DiscordChannelTextBox;
        private System.Windows.Forms.TextBox DiscordTokenTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TwitchChannelTextBox;
        private System.Windows.Forms.TextBox TwitchTokenTextBox;
        private System.Windows.Forms.TextBox TwitchNameTextBox;
        private System.Windows.Forms.CheckedListBox SourcesCheckedListBox;
        private System.Windows.Forms.Button AddSourceButton;
        private System.Windows.Forms.TextBox SourceTextBox;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox DestinationTextBox;
        private System.Windows.Forms.Button AddDestinationButton;
        private System.Windows.Forms.CheckedListBox DestinationsCheckedListBox;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button DeleteSourcesButton;
        private System.Windows.Forms.Button DeleteDestinationsButton;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox IgnoreCommandsFromTextBox;
        private System.Windows.Forms.Button IgnoreCommandsFromAddButton;
        private System.Windows.Forms.CheckedListBox IgnoreCommandsFromListBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox IgnoreChatFromTextBox;
        private System.Windows.Forms.Button IgnoreChatFromAddButton;
        private System.Windows.Forms.CheckedListBox IgnoreChatFromListBox;
        private System.Windows.Forms.CheckBox DiscordEnabledCheckBox;
        private System.Windows.Forms.TextBox Ignr;
    }
}


namespace TournamentTracker
{
    partial class TournamentViewerForm
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
            headerLabel = new Label();
            tournamentName = new Label();
            roundLabel = new Label();
            roundDropDown = new ComboBox();
            unplayedOnlyCheckbox = new CheckBox();
            matchupListBox = new ListBox();
            teamOneName = new Label();
            teamOneScoreLabel = new Label();
            teamOneScoreValue = new TextBox();
            teamTwoScoreValue = new TextBox();
            teamTwoScoreLabel = new Label();
            teamTwoName = new Label();
            vsLabel = new Label();
            scoreButton = new Button();
            SuspendLayout();
            // 
            // headerLabel
            // 
            headerLabel.AutoSize = true;
            headerLabel.ForeColor = SystemColors.MenuHighlight;
            headerLabel.Location = new Point(42, 31);
            headerLabel.Name = "headerLabel";
            headerLabel.Size = new Size(171, 38);
            headerLabel.TabIndex = 0;
            headerLabel.Text = "Tournament:";
            // 
            // tournamentName
            // 
            tournamentName.AutoSize = true;
            tournamentName.ForeColor = SystemColors.MenuHighlight;
            tournamentName.Location = new Point(219, 31);
            tournamentName.Name = "tournamentName";
            tournamentName.Size = new Size(123, 38);
            tournamentName.TabIndex = 3;
            tournamentName.Text = "<None>";
            // 
            // roundLabel
            // 
            roundLabel.AutoSize = true;
            roundLabel.ForeColor = SystemColors.MenuHighlight;
            roundLabel.Location = new Point(42, 116);
            roundLabel.Name = "roundLabel";
            roundLabel.Size = new Size(97, 38);
            roundLabel.TabIndex = 4;
            roundLabel.Text = "Round";
            // 
            // roundDropDown
            // 
            roundDropDown.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            roundDropDown.FormattingEnabled = true;
            roundDropDown.Location = new Point(157, 116);
            roundDropDown.Name = "roundDropDown";
            roundDropDown.Size = new Size(210, 39);
            roundDropDown.TabIndex = 5;
            roundDropDown.SelectedIndexChanged += roundDropDown_SelectedIndexChanged;
            // 
            // unplayedOnlyCheckbox
            // 
            unplayedOnlyCheckbox.AutoSize = true;
            unplayedOnlyCheckbox.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            unplayedOnlyCheckbox.ForeColor = SystemColors.MenuHighlight;
            unplayedOnlyCheckbox.Location = new Point(157, 215);
            unplayedOnlyCheckbox.Name = "unplayedOnlyCheckbox";
            unplayedOnlyCheckbox.Size = new Size(261, 50);
            unplayedOnlyCheckbox.TabIndex = 6;
            unplayedOnlyCheckbox.Text = "Unplayed Only";
            unplayedOnlyCheckbox.UseVisualStyleBackColor = true;
            unplayedOnlyCheckbox.CheckedChanged += unplayedOnlyCheckbox_CheckedChanged;
            // 
            // matchupListBox
            // 
            matchupListBox.FormattingEnabled = true;
            matchupListBox.ItemHeight = 37;
            matchupListBox.Location = new Point(42, 308);
            matchupListBox.Name = "matchupListBox";
            matchupListBox.Size = new Size(376, 226);
            matchupListBox.TabIndex = 7;
            matchupListBox.SelectedIndexChanged += matchupListBox_SelectedIndexChanged;
            // 
            // teamOneName
            // 
            teamOneName.AutoSize = true;
            teamOneName.ForeColor = SystemColors.MenuHighlight;
            teamOneName.Location = new Point(502, 308);
            teamOneName.Name = "teamOneName";
            teamOneName.Size = new Size(172, 38);
            teamOneName.TabIndex = 8;
            teamOneName.Text = "<team one>";
            // 
            // teamOneScoreLabel
            // 
            teamOneScoreLabel.AutoSize = true;
            teamOneScoreLabel.ForeColor = SystemColors.MenuHighlight;
            teamOneScoreLabel.Location = new Point(502, 375);
            teamOneScoreLabel.Name = "teamOneScoreLabel";
            teamOneScoreLabel.Size = new Size(86, 38);
            teamOneScoreLabel.TabIndex = 9;
            teamOneScoreLabel.Text = "Score";
            // 
            // teamOneScoreValue
            // 
            teamOneScoreValue.Location = new Point(603, 369);
            teamOneScoreValue.Name = "teamOneScoreValue";
            teamOneScoreValue.Size = new Size(125, 43);
            teamOneScoreValue.TabIndex = 10;
            // 
            // teamTwoScoreValue
            // 
            teamTwoScoreValue.Location = new Point(615, 539);
            teamTwoScoreValue.Name = "teamTwoScoreValue";
            teamTwoScoreValue.Size = new Size(125, 43);
            teamTwoScoreValue.TabIndex = 13;
            // 
            // teamTwoScoreLabel
            // 
            teamTwoScoreLabel.AutoSize = true;
            teamTwoScoreLabel.ForeColor = SystemColors.MenuHighlight;
            teamTwoScoreLabel.Location = new Point(502, 539);
            teamTwoScoreLabel.Name = "teamTwoScoreLabel";
            teamTwoScoreLabel.Size = new Size(86, 38);
            teamTwoScoreLabel.TabIndex = 12;
            teamTwoScoreLabel.Text = "Score";
            // 
            // teamTwoName
            // 
            teamTwoName.AutoSize = true;
            teamTwoName.ForeColor = SystemColors.MenuHighlight;
            teamTwoName.Location = new Point(502, 478);
            teamTwoName.Name = "teamTwoName";
            teamTwoName.Size = new Size(170, 38);
            teamTwoName.TabIndex = 11;
            teamTwoName.Text = "<team two>";
            // 
            // vsLabel
            // 
            vsLabel.AutoSize = true;
            vsLabel.ForeColor = SystemColors.MenuHighlight;
            vsLabel.Location = new Point(603, 431);
            vsLabel.Name = "vsLabel";
            vsLabel.Size = new Size(71, 38);
            vsLabel.TabIndex = 14;
            vsLabel.Text = "-VS-";
            // 
            // scoreButton
            // 
            scoreButton.FlatAppearance.BorderColor = Color.Silver;
            scoreButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(102, 102, 102);
            scoreButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(242, 242, 242);
            scoreButton.FlatStyle = FlatStyle.Flat;
            scoreButton.ForeColor = SystemColors.MenuHighlight;
            scoreButton.Location = new Point(788, 431);
            scoreButton.Name = "scoreButton";
            scoreButton.Size = new Size(124, 60);
            scoreButton.TabIndex = 15;
            scoreButton.Text = "Score";
            scoreButton.UseVisualStyleBackColor = true;
            scoreButton.Click += scoreButton_Click;
            // 
            // TournamentViewerForm
            // 
            AutoScaleDimensions = new SizeF(15F, 37F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            ClientSize = new Size(1017, 661);
            Controls.Add(scoreButton);
            Controls.Add(vsLabel);
            Controls.Add(teamTwoScoreValue);
            Controls.Add(teamTwoScoreLabel);
            Controls.Add(teamTwoName);
            Controls.Add(teamOneScoreValue);
            Controls.Add(teamOneScoreLabel);
            Controls.Add(teamOneName);
            Controls.Add(matchupListBox);
            Controls.Add(unplayedOnlyCheckbox);
            Controls.Add(roundDropDown);
            Controls.Add(roundLabel);
            Controls.Add(tournamentName);
            Controls.Add(headerLabel);
            Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(5, 6, 5, 6);
            Name = "TournamentViewerForm";
            Text = "Tournament Viewer";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label headerLabel;
        private Label tournamentName;
        private Label roundLabel;
        private ComboBox roundDropDown;
        private CheckBox unplayedOnlyCheckbox;
        private ListBox matchupListBox;
        private Label teamOneName;
        private Label teamOneScoreLabel;
        private TextBox teamOneScoreValue;
        private TextBox teamTwoScoreValue;
        private Label teamTwoScoreLabel;
        private Label teamTwoName;
        private Label vsLabel;
        private Button scoreButton;
    }
}
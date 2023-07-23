namespace TrackerUI
{
    partial class CreateTournamentForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateTournamentForm));
            tournamentNameValue = new TextBox();
            tournamentNameLabel = new Label();
            entryFeeLabel = new Label();
            entryFeeValue = new TextBox();
            selectTeamDropDown = new ComboBox();
            selectTeamLabel = new Label();
            createNewTeamLabel = new LinkLabel();
            addTeamButton = new Button();
            createPrizeButton = new Button();
            tournamentTeamsListBox = new ListBox();
            tournamentPlayersLabel = new Label();
            removeSelectedPlayerButton = new Button();
            removeSelectedPrizeButton = new Button();
            prizesListBox = new ListBox();
            createTournamentButton = new Button();
            prizesLabel = new Label();
            choosePrizesLabel = new Label();
            SuspendLayout();
            // 
            // tournamentNameValue
            // 
            tournamentNameValue.Location = new Point(27, 58);
            tournamentNameValue.Name = "tournamentNameValue";
            tournamentNameValue.Size = new Size(358, 43);
            tournamentNameValue.TabIndex = 12;
            // 
            // tournamentNameLabel
            // 
            tournamentNameLabel.AutoSize = true;
            tournamentNameLabel.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            tournamentNameLabel.ForeColor = Color.FromArgb(51, 153, 255);
            tournamentNameLabel.Location = new Point(20, 17);
            tournamentNameLabel.Name = "tournamentNameLabel";
            tournamentNameLabel.Size = new Size(278, 38);
            tournamentNameLabel.TabIndex = 11;
            tournamentNameLabel.Text = "1) Tournament Name";
            // 
            // entryFeeLabel
            // 
            entryFeeLabel.AutoSize = true;
            entryFeeLabel.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            entryFeeLabel.ForeColor = Color.FromArgb(51, 153, 255);
            entryFeeLabel.Location = new Point(20, 117);
            entryFeeLabel.Name = "entryFeeLabel";
            entryFeeLabel.Size = new Size(414, 38);
            entryFeeLabel.TabIndex = 13;
            entryFeeLabel.Text = "2) Entry Fee Per Team (Optional)";
            // 
            // entryFeeValue
            // 
            entryFeeValue.Location = new Point(27, 168);
            entryFeeValue.Name = "entryFeeValue";
            entryFeeValue.Size = new Size(358, 43);
            entryFeeValue.TabIndex = 14;
            entryFeeValue.Text = "0";
            // 
            // selectTeamDropDown
            // 
            selectTeamDropDown.FormattingEnabled = true;
            selectTeamDropDown.Location = new Point(27, 284);
            selectTeamDropDown.Name = "selectTeamDropDown";
            selectTeamDropDown.Size = new Size(358, 45);
            selectTeamDropDown.TabIndex = 15;
            // 
            // selectTeamLabel
            // 
            selectTeamLabel.AutoSize = true;
            selectTeamLabel.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            selectTeamLabel.ForeColor = Color.FromArgb(51, 153, 255);
            selectTeamLabel.Location = new Point(20, 236);
            selectTeamLabel.Name = "selectTeamLabel";
            selectTeamLabel.Size = new Size(207, 38);
            selectTeamLabel.TabIndex = 16;
            selectTeamLabel.Text = "3) Select Teams";
            // 
            // createNewTeamLabel
            // 
            createNewTeamLabel.AutoSize = true;
            createNewTeamLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            createNewTeamLabel.Location = new Point(228, 243);
            createNewTeamLabel.Name = "createNewTeamLabel";
            createNewTeamLabel.Size = new Size(162, 28);
            createNewTeamLabel.TabIndex = 18;
            createNewTeamLabel.TabStop = true;
            createNewTeamLabel.Text = "Create New Team";
            createNewTeamLabel.LinkClicked += createNewTeamLabel_LinkClicked;
            // 
            // addTeamButton
            // 
            addTeamButton.FlatAppearance.BorderColor = Color.Silver;
            addTeamButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(102, 102, 102);
            addTeamButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(242, 242, 242);
            addTeamButton.FlatStyle = FlatStyle.Flat;
            addTeamButton.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            addTeamButton.ForeColor = Color.FromArgb(51, 153, 255);
            addTeamButton.Location = new Point(27, 343);
            addTeamButton.Name = "addTeamButton";
            addTeamButton.Size = new Size(231, 68);
            addTeamButton.TabIndex = 19;
            addTeamButton.Text = "Add Team";
            addTeamButton.UseVisualStyleBackColor = true;
            addTeamButton.Click += addTeamButton_Click;
            // 
            // createPrizeButton
            // 
            createPrizeButton.FlatAppearance.BorderColor = Color.Silver;
            createPrizeButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(102, 102, 102);
            createPrizeButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(242, 242, 242);
            createPrizeButton.FlatStyle = FlatStyle.Flat;
            createPrizeButton.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            createPrizeButton.ForeColor = Color.FromArgb(51, 153, 255);
            createPrizeButton.Location = new Point(27, 592);
            createPrizeButton.Name = "createPrizeButton";
            createPrizeButton.Size = new Size(231, 68);
            createPrizeButton.TabIndex = 20;
            createPrizeButton.Text = "Create Prizes";
            createPrizeButton.UseVisualStyleBackColor = true;
            createPrizeButton.Click += createPrizeButton_Click;
            // 
            // tournamentTeamsListBox
            // 
            tournamentTeamsListBox.BorderStyle = BorderStyle.FixedSingle;
            tournamentTeamsListBox.FormattingEnabled = true;
            tournamentTeamsListBox.ItemHeight = 37;
            tournamentTeamsListBox.Location = new Point(482, 284);
            tournamentTeamsListBox.Name = "tournamentTeamsListBox";
            tournamentTeamsListBox.Size = new Size(337, 187);
            tournamentTeamsListBox.TabIndex = 21;
            // 
            // tournamentPlayersLabel
            // 
            tournamentPlayersLabel.AutoSize = true;
            tournamentPlayersLabel.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            tournamentPlayersLabel.ForeColor = Color.FromArgb(51, 153, 255);
            tournamentPlayersLabel.Location = new Point(476, 243);
            tournamentPlayersLabel.Name = "tournamentPlayersLabel";
            tournamentPlayersLabel.Size = new Size(143, 38);
            tournamentPlayersLabel.TabIndex = 22;
            tournamentPlayersLabel.Text = "Teams List";
            // 
            // removeSelectedPlayerButton
            // 
            removeSelectedPlayerButton.FlatAppearance.BorderColor = Color.Silver;
            removeSelectedPlayerButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(102, 102, 102);
            removeSelectedPlayerButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(242, 242, 242);
            removeSelectedPlayerButton.FlatStyle = FlatStyle.Flat;
            removeSelectedPlayerButton.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point);
            removeSelectedPlayerButton.ForeColor = Color.FromArgb(51, 153, 255);
            removeSelectedPlayerButton.Location = new Point(844, 322);
            removeSelectedPlayerButton.Name = "removeSelectedPlayerButton";
            removeSelectedPlayerButton.Size = new Size(175, 89);
            removeSelectedPlayerButton.TabIndex = 23;
            removeSelectedPlayerButton.Text = "Remove Selected";
            removeSelectedPlayerButton.UseVisualStyleBackColor = true;
            removeSelectedPlayerButton.Click += removeSelectedPlayerButton_Click_1;
            // 
            // removeSelectedPrizeButton
            // 
            removeSelectedPrizeButton.FlatAppearance.BorderColor = Color.Silver;
            removeSelectedPrizeButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(102, 102, 102);
            removeSelectedPrizeButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(242, 242, 242);
            removeSelectedPrizeButton.FlatStyle = FlatStyle.Flat;
            removeSelectedPrizeButton.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point);
            removeSelectedPrizeButton.ForeColor = Color.FromArgb(51, 153, 255);
            removeSelectedPrizeButton.Location = new Point(844, 584);
            removeSelectedPrizeButton.Name = "removeSelectedPrizeButton";
            removeSelectedPrizeButton.Size = new Size(175, 89);
            removeSelectedPrizeButton.TabIndex = 25;
            removeSelectedPrizeButton.Text = "Remove Selected";
            removeSelectedPrizeButton.UseVisualStyleBackColor = true;
            removeSelectedPrizeButton.Click += removeSelectedPrizeButton_Click;
            // 
            // prizesListBox
            // 
            prizesListBox.BorderStyle = BorderStyle.FixedSingle;
            prizesListBox.FormattingEnabled = true;
            prizesListBox.ItemHeight = 37;
            prizesListBox.Location = new Point(482, 537);
            prizesListBox.Name = "prizesListBox";
            prizesListBox.Size = new Size(337, 187);
            prizesListBox.TabIndex = 24;
            // 
            // createTournamentButton
            // 
            createTournamentButton.FlatAppearance.BorderColor = Color.Silver;
            createTournamentButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(102, 102, 102);
            createTournamentButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(242, 242, 242);
            createTournamentButton.FlatStyle = FlatStyle.Flat;
            createTournamentButton.Font = new Font("Segoe UI Semibold", 20F, FontStyle.Bold, GraphicsUnit.Point);
            createTournamentButton.ForeColor = Color.FromArgb(51, 153, 255);
            createTournamentButton.Location = new Point(482, 36);
            createTournamentButton.Name = "createTournamentButton";
            createTournamentButton.Size = new Size(522, 164);
            createTournamentButton.TabIndex = 26;
            createTournamentButton.Text = "5) Create Tournament";
            createTournamentButton.UseVisualStyleBackColor = true;
            createTournamentButton.Click += createTournamentButton_Click;
            // 
            // prizesLabel
            // 
            prizesLabel.AutoSize = true;
            prizesLabel.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            prizesLabel.ForeColor = Color.FromArgb(51, 153, 255);
            prizesLabel.Location = new Point(476, 494);
            prizesLabel.Name = "prizesLabel";
            prizesLabel.Size = new Size(139, 38);
            prizesLabel.TabIndex = 27;
            prizesLabel.Text = "Prizes List";
            // 
            // choosePrizesLabel
            // 
            choosePrizesLabel.AutoSize = true;
            choosePrizesLabel.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            choosePrizesLabel.ForeColor = Color.FromArgb(51, 153, 255);
            choosePrizesLabel.Location = new Point(20, 494);
            choosePrizesLabel.Name = "choosePrizesLabel";
            choosePrizesLabel.Size = new Size(351, 38);
            choosePrizesLabel.TabIndex = 28;
            choosePrizesLabel.Text = "4) Choose Prizes (Optional)";
            // 
            // CreateTournamentForm
            // 
            AutoScaleDimensions = new SizeF(15F, 37F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1062, 753);
            Controls.Add(choosePrizesLabel);
            Controls.Add(prizesLabel);
            Controls.Add(createTournamentButton);
            Controls.Add(removeSelectedPrizeButton);
            Controls.Add(prizesListBox);
            Controls.Add(removeSelectedPlayerButton);
            Controls.Add(tournamentPlayersLabel);
            Controls.Add(tournamentTeamsListBox);
            Controls.Add(createPrizeButton);
            Controls.Add(addTeamButton);
            Controls.Add(createNewTeamLabel);
            Controls.Add(selectTeamLabel);
            Controls.Add(selectTeamDropDown);
            Controls.Add(entryFeeValue);
            Controls.Add(entryFeeLabel);
            Controls.Add(tournamentNameValue);
            Controls.Add(tournamentNameLabel);
            Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(6, 7, 6, 7);
            Name = "CreateTournamentForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Create Your Tournament";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox tournamentNameValue;
        private Label tournamentNameLabel;
        private Label entryFeeLabel;
        private TextBox entryFeeValue;
        private ComboBox selectTeamDropDown;
        private Label selectTeamLabel;
        private LinkLabel createNewTeamLabel;
        private Button addTeamButton;
        private Button createPrizeButton;
        private ListBox tournamentTeamsListBox;
        private Label tournamentPlayersLabel;
        private Button removeSelectedPlayerButton;
        private Button removeSelectedPrizeButton;
        private ListBox prizesListBox;
        private Button createTournamentButton;
        private Label prizesLabel;
        private Label choosePrizesLabel;
    }
}
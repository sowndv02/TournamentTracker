namespace TournamentTracker
{
    partial class CreateTeamForm
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
            teamNameLabel = new Label();
            teamNamentNameValue = new TextBox();
            selectTeamMemberDropDown = new ComboBox();
            selectTeamMemberLabel = new Label();
            addMemberButton = new Button();
            addNewMemberGroupBox = new GroupBox();
            createMemberButton = new Button();
            phoneValue = new TextBox();
            phoneLabel = new Label();
            emailValue = new TextBox();
            emailLable = new Label();
            lastNameValue = new TextBox();
            label1 = new Label();
            firstNameValue = new TextBox();
            firstNameLabel = new Label();
            teamMemberListBox = new ListBox();
            removeSelectedPlayerButton = new Button();
            createTeamButton = new Button();
            addNewMemberGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // headerLabel
            // 
            headerLabel.AutoSize = true;
            headerLabel.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            headerLabel.ForeColor = SystemColors.MenuHighlight;
            headerLabel.Location = new Point(12, 9);
            headerLabel.Name = "headerLabel";
            headerLabel.Size = new Size(206, 46);
            headerLabel.TabIndex = 2;
            headerLabel.Text = "Create Team";
            // 
            // teamNameLabel
            // 
            teamNameLabel.AutoSize = true;
            teamNameLabel.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            teamNameLabel.ForeColor = SystemColors.MenuHighlight;
            teamNameLabel.Location = new Point(34, 58);
            teamNameLabel.Name = "teamNameLabel";
            teamNameLabel.Size = new Size(197, 46);
            teamNameLabel.TabIndex = 3;
            teamNameLabel.Text = "Team Name";
            // 
            // teamNamentNameValue
            // 
            teamNamentNameValue.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            teamNamentNameValue.Location = new Point(34, 106);
            teamNamentNameValue.Margin = new Padding(3, 2, 3, 2);
            teamNamentNameValue.Name = "teamNamentNameValue";
            teamNamentNameValue.Size = new Size(401, 38);
            teamNamentNameValue.TabIndex = 13;
            // 
            // selectTeamMemberDropDown
            // 
            selectTeamMemberDropDown.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            selectTeamMemberDropDown.FormattingEnabled = true;
            selectTeamMemberDropDown.Location = new Point(34, 208);
            selectTeamMemberDropDown.Margin = new Padding(3, 2, 3, 2);
            selectTeamMemberDropDown.Name = "selectTeamMemberDropDown";
            selectTeamMemberDropDown.Size = new Size(401, 39);
            selectTeamMemberDropDown.TabIndex = 19;
            // 
            // selectTeamMemberLabel
            // 
            selectTeamMemberLabel.AutoSize = true;
            selectTeamMemberLabel.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            selectTeamMemberLabel.ForeColor = SystemColors.MenuHighlight;
            selectTeamMemberLabel.Location = new Point(34, 160);
            selectTeamMemberLabel.Name = "selectTeamMemberLabel";
            selectTeamMemberLabel.Size = new Size(335, 46);
            selectTeamMemberLabel.TabIndex = 18;
            selectTeamMemberLabel.Text = "Select Team Member";
            // 
            // addMemberButton
            // 
            addMemberButton.FlatAppearance.BorderColor = Color.Silver;
            addMemberButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(102, 102, 102);
            addMemberButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(242, 242, 242);
            addMemberButton.FlatStyle = FlatStyle.Flat;
            addMemberButton.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            addMemberButton.ForeColor = SystemColors.MenuHighlight;
            addMemberButton.Location = new Point(128, 268);
            addMemberButton.Margin = new Padding(3, 2, 3, 2);
            addMemberButton.Name = "addMemberButton";
            addMemberButton.Size = new Size(169, 42);
            addMemberButton.TabIndex = 20;
            addMemberButton.Text = "Add Member";
            addMemberButton.UseVisualStyleBackColor = true;
            addMemberButton.Click += addMemberButton_Click;
            // 
            // addNewMemberGroupBox
            // 
            addNewMemberGroupBox.Controls.Add(createMemberButton);
            addNewMemberGroupBox.Controls.Add(phoneValue);
            addNewMemberGroupBox.Controls.Add(phoneLabel);
            addNewMemberGroupBox.Controls.Add(emailValue);
            addNewMemberGroupBox.Controls.Add(emailLable);
            addNewMemberGroupBox.Controls.Add(lastNameValue);
            addNewMemberGroupBox.Controls.Add(label1);
            addNewMemberGroupBox.Controls.Add(firstNameValue);
            addNewMemberGroupBox.Controls.Add(firstNameLabel);
            addNewMemberGroupBox.ForeColor = SystemColors.MenuHighlight;
            addNewMemberGroupBox.Location = new Point(34, 325);
            addNewMemberGroupBox.Name = "addNewMemberGroupBox";
            addNewMemberGroupBox.Size = new Size(401, 343);
            addNewMemberGroupBox.TabIndex = 21;
            addNewMemberGroupBox.TabStop = false;
            addNewMemberGroupBox.Text = "Add New Member";
            // 
            // createMemberButton
            // 
            createMemberButton.FlatAppearance.BorderColor = Color.Silver;
            createMemberButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(102, 102, 102);
            createMemberButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(242, 242, 242);
            createMemberButton.FlatStyle = FlatStyle.Flat;
            createMemberButton.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            createMemberButton.ForeColor = SystemColors.MenuHighlight;
            createMemberButton.Location = new Point(94, 263);
            createMemberButton.Margin = new Padding(3, 2, 3, 2);
            createMemberButton.Name = "createMemberButton";
            createMemberButton.Size = new Size(219, 64);
            createMemberButton.TabIndex = 22;
            createMemberButton.Text = "Create Member";
            createMemberButton.UseVisualStyleBackColor = true;
            createMemberButton.Click += createMemberButton_Click;
            // 
            // phoneValue
            // 
            phoneValue.Location = new Point(171, 188);
            phoneValue.Name = "phoneValue";
            phoneValue.Size = new Size(224, 42);
            phoneValue.TabIndex = 18;
            // 
            // phoneLabel
            // 
            phoneLabel.AutoSize = true;
            phoneLabel.ForeColor = SystemColors.MenuHighlight;
            phoneLabel.Location = new Point(6, 193);
            phoneLabel.Name = "phoneLabel";
            phoneLabel.Size = new Size(92, 37);
            phoneLabel.TabIndex = 17;
            phoneLabel.Text = "Phone";
            // 
            // emailValue
            // 
            emailValue.Location = new Point(171, 140);
            emailValue.Name = "emailValue";
            emailValue.Size = new Size(224, 42);
            emailValue.TabIndex = 16;
            // 
            // emailLable
            // 
            emailLable.AutoSize = true;
            emailLable.ForeColor = SystemColors.MenuHighlight;
            emailLable.Location = new Point(6, 143);
            emailLable.Name = "emailLable";
            emailLable.Size = new Size(82, 37);
            emailLable.TabIndex = 15;
            emailLable.Text = "Email";
            // 
            // lastNameValue
            // 
            lastNameValue.Location = new Point(171, 92);
            lastNameValue.Name = "lastNameValue";
            lastNameValue.Size = new Size(224, 42);
            lastNameValue.TabIndex = 14;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = SystemColors.MenuHighlight;
            label1.Location = new Point(6, 97);
            label1.Name = "label1";
            label1.Size = new Size(142, 37);
            label1.TabIndex = 13;
            label1.Text = "Last Name";
            // 
            // firstNameValue
            // 
            firstNameValue.Location = new Point(171, 44);
            firstNameValue.Name = "firstNameValue";
            firstNameValue.Size = new Size(224, 42);
            firstNameValue.TabIndex = 12;
            // 
            // firstNameLabel
            // 
            firstNameLabel.AutoSize = true;
            firstNameLabel.ForeColor = SystemColors.MenuHighlight;
            firstNameLabel.Location = new Point(6, 49);
            firstNameLabel.Name = "firstNameLabel";
            firstNameLabel.Size = new Size(144, 37);
            firstNameLabel.TabIndex = 11;
            firstNameLabel.Text = "First Name";
            // 
            // teamMemberListBox
            // 
            teamMemberListBox.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            teamMemberListBox.FormattingEnabled = true;
            teamMemberListBox.ItemHeight = 31;
            teamMemberListBox.Location = new Point(484, 106);
            teamMemberListBox.Margin = new Padding(3, 2, 3, 2);
            teamMemberListBox.Name = "teamMemberListBox";
            teamMemberListBox.Size = new Size(365, 562);
            teamMemberListBox.TabIndex = 22;
            // 
            // removeSelectedPlayerButton
            // 
            removeSelectedPlayerButton.FlatAppearance.BorderColor = Color.Silver;
            removeSelectedPlayerButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(102, 102, 102);
            removeSelectedPlayerButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(242, 242, 242);
            removeSelectedPlayerButton.FlatStyle = FlatStyle.Flat;
            removeSelectedPlayerButton.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            removeSelectedPlayerButton.ForeColor = SystemColors.MenuHighlight;
            removeSelectedPlayerButton.Location = new Point(880, 305);
            removeSelectedPlayerButton.Margin = new Padding(3, 2, 3, 2);
            removeSelectedPlayerButton.Name = "removeSelectedPlayerButton";
            removeSelectedPlayerButton.Size = new Size(118, 84);
            removeSelectedPlayerButton.TabIndex = 23;
            removeSelectedPlayerButton.Text = "Remove Selected";
            removeSelectedPlayerButton.UseVisualStyleBackColor = true;
            removeSelectedPlayerButton.Click += removeSelectedPlayerButton_Click;
            // 
            // createTeamButton
            // 
            createTeamButton.FlatAppearance.BorderColor = Color.Silver;
            createTeamButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(102, 102, 102);
            createTeamButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(242, 242, 242);
            createTeamButton.FlatStyle = FlatStyle.Flat;
            createTeamButton.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            createTeamButton.ForeColor = SystemColors.MenuHighlight;
            createTeamButton.Location = new Point(355, 695);
            createTeamButton.Margin = new Padding(3, 2, 3, 2);
            createTeamButton.Name = "createTeamButton";
            createTeamButton.Size = new Size(184, 55);
            createTeamButton.TabIndex = 27;
            createTeamButton.Text = "Create Team";
            createTeamButton.UseVisualStyleBackColor = true;
            createTeamButton.Click += createTeamButton_Click;
            // 
            // CreateTeamForm
            // 
            AutoScaleDimensions = new SizeF(14F, 36F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            ClientSize = new Size(1015, 761);
            Controls.Add(createTeamButton);
            Controls.Add(removeSelectedPlayerButton);
            Controls.Add(teamMemberListBox);
            Controls.Add(addNewMemberGroupBox);
            Controls.Add(addMemberButton);
            Controls.Add(selectTeamMemberDropDown);
            Controls.Add(selectTeamMemberLabel);
            Controls.Add(teamNamentNameValue);
            Controls.Add(teamNameLabel);
            Controls.Add(headerLabel);
            Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(5, 6, 5, 6);
            Name = "CreateTeamForm";
            Text = "Create Team";
            addNewMemberGroupBox.ResumeLayout(false);
            addNewMemberGroupBox.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label headerLabel;
        private Label teamNameLabel;
        private TextBox teamNamentNameValue;
        private ComboBox selectTeamMemberDropDown;
        private Label selectTeamMemberLabel;
        private Button addMemberButton;
        private GroupBox addNewMemberGroupBox;
        private TextBox lastNameValue;
        private Label label1;
        private TextBox firstNameValue;
        private Label firstNameLabel;
        private TextBox phoneValue;
        private Label phoneLabel;
        private TextBox emailValue;
        private Label emailLable;
        private Button createMemberButton;
        private ListBox teamMemberListBox;
        private Button removeSelectedPlayerButton;
        private Button createTeamButton;
    }
}
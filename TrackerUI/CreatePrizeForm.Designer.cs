namespace TrackerUI
{
    partial class CreatePrizeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreatePrizeForm));
            prizeAmountValue = new TextBox();
            placeNumberValue = new TextBox();
            placeNumberLabel = new Label();
            placeNameValue = new TextBox();
            placeNameLabel = new Label();
            prizeAmountLabel = new Label();
            prizePercentageValue = new TextBox();
            prizePercentageLabel = new Label();
            orLabel = new Label();
            createPrizeButton = new Button();
            SuspendLayout();
            // 
            // prizeAmountValue
            // 
            prizeAmountValue.Location = new Point(748, 380);
            prizeAmountValue.Name = "prizeAmountValue";
            prizeAmountValue.Size = new Size(238, 43);
            prizeAmountValue.TabIndex = 31;
            prizeAmountValue.Text = "0";
            // 
            // placeNumberValue
            // 
            placeNumberValue.Location = new Point(748, 132);
            placeNumberValue.Name = "placeNumberValue";
            placeNumberValue.Size = new Size(238, 43);
            placeNumberValue.TabIndex = 27;
            // 
            // placeNumberLabel
            // 
            placeNumberLabel.AutoSize = true;
            placeNumberLabel.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            placeNumberLabel.ForeColor = Color.FromArgb(51, 153, 255);
            placeNumberLabel.Location = new Point(29, 135);
            placeNumberLabel.Name = "placeNumberLabel";
            placeNumberLabel.Size = new Size(213, 37);
            placeNumberLabel.TabIndex = 26;
            placeNumberLabel.Text = "1) Place Number";
            // 
            // placeNameValue
            // 
            placeNameValue.Location = new Point(748, 241);
            placeNameValue.Name = "placeNameValue";
            placeNameValue.Size = new Size(238, 43);
            placeNameValue.TabIndex = 29;
            // 
            // placeNameLabel
            // 
            placeNameLabel.AutoSize = true;
            placeNameLabel.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            placeNameLabel.ForeColor = Color.FromArgb(51, 153, 255);
            placeNameLabel.Location = new Point(29, 247);
            placeNameLabel.Name = "placeNameLabel";
            placeNameLabel.Size = new Size(187, 37);
            placeNameLabel.TabIndex = 28;
            placeNameLabel.Text = "2) Place Name\r";
            // 
            // prizeAmountLabel
            // 
            prizeAmountLabel.AutoSize = true;
            prizeAmountLabel.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            prizeAmountLabel.ForeColor = Color.FromArgb(51, 153, 255);
            prizeAmountLabel.Location = new Point(29, 349);
            prizeAmountLabel.Name = "prizeAmountLabel";
            prizeAmountLabel.Size = new Size(670, 74);
            prizeAmountLabel.TabIndex = 30;
            prizeAmountLabel.Text = "3) Prize Amount\r\n(The amount in US$ which the prize winner will receive)\r\n";
            // 
            // prizePercentageValue
            // 
            prizePercentageValue.Location = new Point(748, 549);
            prizePercentageValue.Name = "prizePercentageValue";
            prizePercentageValue.Size = new Size(238, 43);
            prizePercentageValue.TabIndex = 33;
            prizePercentageValue.Text = "0";
            // 
            // prizePercentageLabel
            // 
            prizePercentageLabel.AutoSize = true;
            prizePercentageLabel.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            prizePercentageLabel.ForeColor = Color.FromArgb(51, 153, 255);
            prizePercentageLabel.Location = new Point(29, 518);
            prizePercentageLabel.Name = "prizePercentageLabel";
            prizePercentageLabel.Size = new Size(560, 74);
            prizePercentageLabel.TabIndex = 32;
            prizePercentageLabel.Text = "4) Prize Percentage\r\n(Percentage of total income from tournament)";
            // 
            // orLabel
            // 
            orLabel.AutoSize = true;
            orLabel.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            orLabel.ForeColor = Color.FromArgb(51, 153, 255);
            orLabel.Location = new Point(202, 456);
            orLabel.Name = "orLabel";
            orLabel.Size = new Size(54, 31);
            orLabel.TabIndex = 34;
            orLabel.Text = "-or-";
            // 
            // createPrizeButton
            // 
            createPrizeButton.FlatAppearance.BorderColor = Color.Silver;
            createPrizeButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(102, 102, 102);
            createPrizeButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(242, 242, 242);
            createPrizeButton.FlatStyle = FlatStyle.Flat;
            createPrizeButton.Font = new Font("Segoe UI Semibold", 20F, FontStyle.Bold, GraphicsUnit.Point);
            createPrizeButton.ForeColor = Color.FromArgb(51, 153, 255);
            createPrizeButton.Location = new Point(381, 637);
            createPrizeButton.Name = "createPrizeButton";
            createPrizeButton.Size = new Size(309, 86);
            createPrizeButton.TabIndex = 35;
            createPrizeButton.Text = "5) Create Prize";
            createPrizeButton.UseVisualStyleBackColor = true;
            createPrizeButton.Click += createPrizeButton_Click;
            // 
            // CreatePrizeForm
            // 
            AutoScaleDimensions = new SizeF(15F, 37F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1062, 753);
            Controls.Add(createPrizeButton);
            Controls.Add(orLabel);
            Controls.Add(prizePercentageValue);
            Controls.Add(prizePercentageLabel);
            Controls.Add(prizeAmountValue);
            Controls.Add(prizeAmountLabel);
            Controls.Add(placeNameValue);
            Controls.Add(placeNameLabel);
            Controls.Add(placeNumberValue);
            Controls.Add(placeNumberLabel);
            Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(6, 7, 6, 7);
            Name = "CreatePrizeForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Create Prize";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox placeNumberValue;
        private Label placeNumberLabel;
        private TextBox placeNameValue;
        private Label placeNameLabel;
        private Label prizeAmountLabel;
        private TextBox prizePercentageValue;
        private Label prizePercentageLabel;
        private Label orLabel;
        private Button createPrizeButton;
        private TextBox prizeAmountValue;
    }
}
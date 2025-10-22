namespace BankingSystem
{
    partial class RegistrationForm
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
            Header = new Label();
            NameInput = new TextBox();
            PasswordInput = new TextBox();
            SubmitButton = new Button();
            PhoneInput = new TextBox();
            AddressInput = new TextBox();
            NameLabel = new Label();
            label3 = new Label();
            PhoneLabel = new Label();
            AddressLabel = new Label();
            LoginLabel = new LinkLabel();
            MessageLabel = new Label();
            SuspendLayout();
            // 
            // Header
            // 
            Header.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            Header.Location = new Point(447, 47);
            Header.Margin = new Padding(4, 0, 4, 0);
            Header.Name = "Header";
            Header.Size = new Size(240, 68);
            Header.TabIndex = 0;
            Header.Text = "Регистрация";
            Header.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // NameInput
            // 
            NameInput.Location = new Point(399, 203);
            NameInput.Margin = new Padding(4, 5, 4, 5);
            NameInput.Name = "NameInput";
            NameInput.Size = new Size(334, 31);
            NameInput.TabIndex = 1;
            // 
            // PasswordInput
            // 
            PasswordInput.Location = new Point(399, 403);
            PasswordInput.Margin = new Padding(4, 5, 4, 5);
            PasswordInput.Name = "PasswordInput";
            PasswordInput.Size = new Size(334, 31);
            PasswordInput.TabIndex = 2;
            // 
            // SubmitButton
            // 
            SubmitButton.Font = new Font("Segoe UI", 14F);
            SubmitButton.Location = new Point(447, 597);
            SubmitButton.Margin = new Padding(4, 5, 4, 5);
            SubmitButton.Name = "SubmitButton";
            SubmitButton.Size = new Size(234, 73);
            SubmitButton.TabIndex = 3;
            SubmitButton.Text = "Регистрирай се";
            SubmitButton.UseVisualStyleBackColor = true;
            SubmitButton.Click += SubmitButton_Click;
            // 
            // PhoneInput
            // 
            PhoneInput.Location = new Point(399, 301);
            PhoneInput.Margin = new Padding(4, 5, 4, 5);
            PhoneInput.Name = "PhoneInput";
            PhoneInput.Size = new Size(334, 31);
            PhoneInput.TabIndex = 4;
            // 
            // AddressInput
            // 
            AddressInput.Location = new Point(399, 508);
            AddressInput.Margin = new Padding(4, 5, 4, 5);
            AddressInput.Name = "AddressInput";
            AddressInput.Size = new Size(334, 31);
            AddressInput.TabIndex = 5;
            // 
            // NameLabel
            // 
            NameLabel.Font = new Font("Segoe UI", 14F);
            NameLabel.Location = new Point(469, 160);
            NameLabel.Margin = new Padding(4, 0, 4, 0);
            NameLabel.Name = "NameLabel";
            NameLabel.Size = new Size(197, 38);
            NameLabel.TabIndex = 6;
            NameLabel.Text = "Две имена";
            NameLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI", 14F);
            label3.Location = new Point(469, 360);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(197, 38);
            label3.TabIndex = 7;
            label3.Text = "Парола";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // PhoneLabel
            // 
            PhoneLabel.Font = new Font("Segoe UI", 14F);
            PhoneLabel.Location = new Point(469, 258);
            PhoneLabel.Margin = new Padding(4, 0, 4, 0);
            PhoneLabel.Name = "PhoneLabel";
            PhoneLabel.Size = new Size(197, 38);
            PhoneLabel.TabIndex = 8;
            PhoneLabel.Text = "Телефон";
            PhoneLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // AddressLabel
            // 
            AddressLabel.Font = new Font("Segoe UI", 14F);
            AddressLabel.Location = new Point(469, 465);
            AddressLabel.Margin = new Padding(4, 0, 4, 0);
            AddressLabel.Name = "AddressLabel";
            AddressLabel.Size = new Size(197, 38);
            AddressLabel.TabIndex = 9;
            AddressLabel.Text = "Адрес";
            AddressLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // LoginLabel
            // 
            LoginLabel.AutoSize = true;
            LoginLabel.Font = new Font("Segoe UI", 14F);
            LoginLabel.LinkColor = Color.Black;
            LoginLabel.Location = new Point(491, 675);
            LoginLabel.Margin = new Padding(4, 0, 4, 0);
            LoginLabel.Name = "LoginLabel";
            LoginLabel.Size = new Size(138, 38);
            LoginLabel.TabIndex = 10;
            LoginLabel.TabStop = true;
            LoginLabel.Text = "Вписване";
            LoginLabel.LinkClicked += LoginLabel_LinkClicked;
            // 
            // MessageLabel
            // 
            MessageLabel.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            MessageLabel.ForeColor = Color.Red;
            MessageLabel.Location = new Point(13, 554);
            MessageLabel.Margin = new Padding(4, 0, 4, 0);
            MessageLabel.Name = "MessageLabel";
            MessageLabel.Size = new Size(1117, 38);
            MessageLabel.TabIndex = 27;
            MessageLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // RegistrationForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1143, 750);
            Controls.Add(MessageLabel);
            Controls.Add(LoginLabel);
            Controls.Add(AddressLabel);
            Controls.Add(PhoneLabel);
            Controls.Add(label3);
            Controls.Add(NameLabel);
            Controls.Add(AddressInput);
            Controls.Add(PhoneInput);
            Controls.Add(PasswordInput);
            Controls.Add(NameInput);
            Controls.Add(Header);
            Controls.Add(SubmitButton);
            Margin = new Padding(4, 5, 4, 5);
            Name = "RegistrationForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Регистрация";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Header;
        private TextBox NameInput;
        private TextBox PasswordInput;
        private Button SubmitButton;
        private TextBox PhoneInput;
        private TextBox AddressInput;
        private Label NameLabel;
        private Label label3;
        private Label PhoneLabel;
        private Label AddressLabel;
        private LinkLabel LoginLabel;
        private Label MessageLabel;
    }
}

namespace BankingSystem.Forms
{
    partial class LoginForm
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
            PhoneLabel = new Label();
            label3 = new Label();
            PhoneInput = new TextBox();
            PasswordInput = new TextBox();
            Header = new Label();
            SubmitButton = new Button();
            RegisterLabel = new LinkLabel();
            MessageLabel = new Label();
            SuspendLayout();
            // 
            // PhoneLabel
            // 
            PhoneLabel.Font = new Font("Segoe UI", 14F);
            PhoneLabel.Location = new Point(474, 253);
            PhoneLabel.Margin = new Padding(4, 0, 4, 0);
            PhoneLabel.Name = "PhoneLabel";
            PhoneLabel.Size = new Size(197, 38);
            PhoneLabel.TabIndex = 21;
            PhoneLabel.Text = "Телефон";
            PhoneLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI", 14F);
            label3.Location = new Point(474, 355);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(197, 38);
            label3.TabIndex = 20;
            label3.Text = "Парола";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // PhoneInput
            // 
            PhoneInput.Location = new Point(404, 296);
            PhoneInput.Margin = new Padding(4, 5, 4, 5);
            PhoneInput.Name = "PhoneInput";
            PhoneInput.Size = new Size(334, 31);
            PhoneInput.TabIndex = 17;
            // 
            // PasswordInput
            // 
            PasswordInput.Location = new Point(404, 398);
            PasswordInput.Margin = new Padding(4, 5, 4, 5);
            PasswordInput.Name = "PasswordInput";
            PasswordInput.Size = new Size(334, 31);
            PasswordInput.TabIndex = 15;
            // 
            // Header
            // 
            Header.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            Header.Location = new Point(452, 42);
            Header.Margin = new Padding(4, 0, 4, 0);
            Header.Name = "Header";
            Header.Size = new Size(234, 68);
            Header.TabIndex = 13;
            Header.Text = "Вписване";
            Header.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // SubmitButton
            // 
            SubmitButton.Font = new Font("Segoe UI", 14F);
            SubmitButton.Location = new Point(452, 592);
            SubmitButton.Margin = new Padding(4, 5, 4, 5);
            SubmitButton.Name = "SubmitButton";
            SubmitButton.Size = new Size(234, 73);
            SubmitButton.TabIndex = 24;
            SubmitButton.Text = "Впиши се";
            SubmitButton.UseVisualStyleBackColor = true;
            SubmitButton.Click += SubmitButton_Click;
            // 
            // RegisterLabel
            // 
            RegisterLabel.AutoSize = true;
            RegisterLabel.Font = new Font("Segoe UI", 14F);
            RegisterLabel.LinkColor = Color.Black;
            RegisterLabel.Location = new Point(483, 670);
            RegisterLabel.Margin = new Padding(4, 0, 4, 0);
            RegisterLabel.Name = "RegisterLabel";
            RegisterLabel.Size = new Size(176, 38);
            RegisterLabel.TabIndex = 25;
            RegisterLabel.TabStop = true;
            RegisterLabel.Text = "Регистрация";
            RegisterLabel.LinkClicked += RegisterLabel_LinkClicked;
            // 
            // MessageLabel
            // 
            MessageLabel.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            MessageLabel.ForeColor = Color.Red;
            MessageLabel.Location = new Point(13, 549);
            MessageLabel.Margin = new Padding(4, 0, 4, 0);
            MessageLabel.Name = "MessageLabel";
            MessageLabel.Size = new Size(1117, 38);
            MessageLabel.TabIndex = 26;
            MessageLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1143, 750);
            Controls.Add(MessageLabel);
            Controls.Add(PhoneLabel);
            Controls.Add(label3);
            Controls.Add(PhoneInput);
            Controls.Add(PasswordInput);
            Controls.Add(Header);
            Controls.Add(SubmitButton);
            Controls.Add(RegisterLabel);
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Вписване";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label PhoneLabel;
        private Label label3;
        private TextBox PhoneInput;
        private TextBox PasswordInput;
        private Label Header;
        private Button SubmitButton;
        private LinkLabel RegisterLabel;
        private Label MessageLabel;
    }
}
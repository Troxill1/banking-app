namespace BankingSystem
{
    partial class MainMenuForm
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
            label1 = new Label();
            DepositButton = new Button();
            WithdrawButton = new Button();
            HistoryButton = new Button();
            HelloLabel = new Label();
            BalanceLabel = new Label();
            EmiLabel = new Label();
            AmountInput = new TextBox();
            AmountLabel = new Label();
            SubmitDepositButton = new Button();
            SubmitWithdrawButton = new Button();
            ReturnButton = new Button();
            MessageLabel = new Label();
            AccountsDropdown = new ComboBox();
            AccountLabel = new Label();
            label2 = new Label();
            ExitButton = new Button();
            LogButton = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            label1.Location = new Point(17, 38);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.RightToLeft = RightToLeft.Yes;
            label1.Size = new Size(1505, 47);
            label1.TabIndex = 0;
            label1.Text = "Банкова система";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // DepositButton
            // 
            DepositButton.Font = new Font("Segoe UI", 14F);
            DepositButton.Location = new Point(275, 706);
            DepositButton.Margin = new Padding(4, 5, 4, 5);
            DepositButton.Name = "DepositButton";
            DepositButton.Size = new Size(309, 62);
            DepositButton.TabIndex = 1;
            DepositButton.Text = "Депозит";
            DepositButton.UseVisualStyleBackColor = true;
            DepositButton.Click += DepositButton_Click;
            // 
            // WithdrawButton
            // 
            WithdrawButton.Font = new Font("Segoe UI", 14F);
            WithdrawButton.Location = new Point(618, 706);
            WithdrawButton.Margin = new Padding(4, 5, 4, 5);
            WithdrawButton.Name = "WithdrawButton";
            WithdrawButton.Size = new Size(309, 62);
            WithdrawButton.TabIndex = 2;
            WithdrawButton.Text = "Изтегляне";
            WithdrawButton.UseVisualStyleBackColor = true;
            WithdrawButton.Click += WithdrawButton_Click;
            // 
            // HistoryButton
            // 
            HistoryButton.Font = new Font("Segoe UI", 14F);
            HistoryButton.Location = new Point(955, 706);
            HistoryButton.Margin = new Padding(4, 5, 4, 5);
            HistoryButton.Name = "HistoryButton";
            HistoryButton.Size = new Size(309, 62);
            HistoryButton.TabIndex = 3;
            HistoryButton.Text = "Преглед на историята";
            HistoryButton.UseVisualStyleBackColor = true;
            HistoryButton.Click += HistoryButton_Click;
            // 
            // HelloLabel
            // 
            HelloLabel.Font = new Font("Segoe UI", 18F);
            HelloLabel.Location = new Point(17, 142);
            HelloLabel.Margin = new Padding(4, 0, 4, 0);
            HelloLabel.Name = "HelloLabel";
            HelloLabel.RightToLeft = RightToLeft.Yes;
            HelloLabel.Size = new Size(1507, 47);
            HelloLabel.TabIndex = 6;
            HelloLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // BalanceLabel
            // 
            BalanceLabel.Font = new Font("Segoe UI", 14F);
            BalanceLabel.Location = new Point(17, 212);
            BalanceLabel.Margin = new Padding(4, 0, 4, 0);
            BalanceLabel.Name = "BalanceLabel";
            BalanceLabel.RightToLeft = RightToLeft.Yes;
            BalanceLabel.Size = new Size(1508, 73);
            BalanceLabel.TabIndex = 7;
            BalanceLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // EmiLabel
            // 
            EmiLabel.Font = new Font("Segoe UI", 14F);
            EmiLabel.Location = new Point(17, 302);
            EmiLabel.Margin = new Padding(4, 0, 4, 0);
            EmiLabel.Name = "EmiLabel";
            EmiLabel.RightToLeft = RightToLeft.Yes;
            EmiLabel.Size = new Size(1509, 47);
            EmiLabel.TabIndex = 9;
            EmiLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // AmountInput
            // 
            AmountInput.Font = new Font("Segoe UI", 14F);
            AmountInput.Location = new Point(659, 520);
            AmountInput.Margin = new Padding(4, 5, 4, 5);
            AmountInput.Name = "AmountInput";
            AmountInput.Size = new Size(221, 45);
            AmountInput.TabIndex = 10;
            // 
            // AmountLabel
            // 
            AmountLabel.Font = new Font("Segoe UI", 14F);
            AmountLabel.Location = new Point(692, 470);
            AmountLabel.Margin = new Padding(4, 0, 4, 0);
            AmountLabel.Name = "AmountLabel";
            AmountLabel.RightToLeft = RightToLeft.Yes;
            AmountLabel.Size = new Size(156, 45);
            AmountLabel.TabIndex = 11;
            AmountLabel.Text = "Сума";
            AmountLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // SubmitDepositButton
            // 
            SubmitDepositButton.Font = new Font("Segoe UI", 14F);
            SubmitDepositButton.Location = new Point(659, 583);
            SubmitDepositButton.Margin = new Padding(4, 5, 4, 5);
            SubmitDepositButton.Name = "SubmitDepositButton";
            SubmitDepositButton.Size = new Size(223, 62);
            SubmitDepositButton.TabIndex = 12;
            SubmitDepositButton.Text = "Депозирай";
            SubmitDepositButton.UseVisualStyleBackColor = true;
            SubmitDepositButton.Click += SubmitDepositButton_Click;
            // 
            // SubmitWithdrawButton
            // 
            SubmitWithdrawButton.Font = new Font("Segoe UI", 14F);
            SubmitWithdrawButton.Location = new Point(659, 583);
            SubmitWithdrawButton.Margin = new Padding(4, 5, 4, 5);
            SubmitWithdrawButton.Name = "SubmitWithdrawButton";
            SubmitWithdrawButton.Size = new Size(223, 62);
            SubmitWithdrawButton.TabIndex = 13;
            SubmitWithdrawButton.Text = "Изтегли";
            SubmitWithdrawButton.UseVisualStyleBackColor = true;
            SubmitWithdrawButton.Click += SubmitWithdrawButton_Click;
            // 
            // ReturnButton
            // 
            ReturnButton.Font = new Font("Segoe UI", 14F);
            ReturnButton.Location = new Point(1399, 135);
            ReturnButton.Margin = new Padding(4, 5, 4, 5);
            ReturnButton.Name = "ReturnButton";
            ReturnButton.Size = new Size(126, 62);
            ReturnButton.TabIndex = 15;
            ReturnButton.Text = "Назад";
            ReturnButton.UseVisualStyleBackColor = true;
            ReturnButton.Click += ReturnButton_Click;
            // 
            // MessageLabel
            // 
            MessageLabel.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            MessageLabel.Location = new Point(17, 807);
            MessageLabel.Margin = new Padding(4, 0, 4, 0);
            MessageLabel.Name = "MessageLabel";
            MessageLabel.RightToLeft = RightToLeft.Yes;
            MessageLabel.Size = new Size(1505, 45);
            MessageLabel.TabIndex = 16;
            MessageLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // AccountsDropdown
            // 
            AccountsDropdown.DropDownStyle = ComboBoxStyle.DropDownList;
            AccountsDropdown.Font = new Font("Segoe UI", 12F);
            AccountsDropdown.FormattingEnabled = true;
            AccountsDropdown.Location = new Point(17, 180);
            AccountsDropdown.Margin = new Padding(4, 5, 4, 5);
            AccountsDropdown.Name = "AccountsDropdown";
            AccountsDropdown.Size = new Size(387, 40);
            AccountsDropdown.TabIndex = 17;
            AccountsDropdown.SelectedIndexChanged += AccountsDropdown_SelectedIndexChanged;
            // 
            // AccountLabel
            // 
            AccountLabel.Font = new Font("Segoe UI", 12F);
            AccountLabel.Location = new Point(17, 80);
            AccountLabel.Margin = new Padding(4, 0, 4, 0);
            AccountLabel.Name = "AccountLabel";
            AccountLabel.RightToLeft = RightToLeft.Yes;
            AccountLabel.Size = new Size(387, 37);
            AccountLabel.TabIndex = 18;
            AccountLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.BackColor = Color.White;
            label2.Font = new Font("Segoe UI", 12F);
            label2.ImageAlign = ContentAlignment.MiddleLeft;
            label2.Location = new Point(17, 122);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.RightToLeft = RightToLeft.Yes;
            label2.Size = new Size(387, 48);
            label2.TabIndex = 19;
            label2.Text = "Избери сметка";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // ExitButton
            // 
            ExitButton.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            ExitButton.ForeColor = Color.Red;
            ExitButton.Location = new Point(1399, 63);
            ExitButton.Margin = new Padding(4, 5, 4, 5);
            ExitButton.Name = "ExitButton";
            ExitButton.Size = new Size(126, 62);
            ExitButton.TabIndex = 21;
            ExitButton.Text = "Изход";
            ExitButton.UseVisualStyleBackColor = true;
            ExitButton.Click += ExitButton_Click;
            // 
            // LogButton
            // 
            LogButton.Font = new Font("Segoe UI", 14F);
            LogButton.Location = new Point(1396, 706);
            LogButton.Margin = new Padding(4, 5, 4, 5);
            LogButton.Name = "LogButton";
            LogButton.Size = new Size(126, 62);
            LogButton.TabIndex = 22;
            LogButton.Text = "Лог";
            LogButton.UseVisualStyleBackColor = true;
            LogButton.Click += LogButton_Click;
            // 
            // MainMenuForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1541, 880);
            Controls.Add(LogButton);
            Controls.Add(ExitButton);
            Controls.Add(label2);
            Controls.Add(AccountLabel);
            Controls.Add(AccountsDropdown);
            Controls.Add(MessageLabel);
            Controls.Add(ReturnButton);
            Controls.Add(SubmitWithdrawButton);
            Controls.Add(SubmitDepositButton);
            Controls.Add(AmountLabel);
            Controls.Add(AmountInput);
            Controls.Add(EmiLabel);
            Controls.Add(BalanceLabel);
            Controls.Add(HelloLabel);
            Controls.Add(HistoryButton);
            Controls.Add(WithdrawButton);
            Controls.Add(DepositButton);
            Controls.Add(label1);
            Margin = new Padding(4, 5, 4, 5);
            Name = "MainMenuForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Банкова система";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button DepositButton;
        private Button WithdrawButton;
        private Button HistoryButton;
        private Label HelloLabel;
        private Label BalanceLabel;
        private Label EmiLabel;
        private TextBox AmountInput;
        private Label AmountLabel;
        private Button SubmitDepositButton;
        private Button SubmitWithdrawButton;
        private Button ReturnButton;
        private Label MessageLabel;
        private ComboBox AccountsDropdown;
        private Label AccountLabel;
        private Label label2;
        private Button ExitButton;
        private Button LogButton;
    }
}
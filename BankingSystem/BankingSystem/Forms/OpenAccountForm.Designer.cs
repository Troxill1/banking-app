namespace BankingSystem
{
    partial class OpenAccountForm
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
            LoanButton = new Button();
            SavingsButton = new Button();
            CheckingButton = new Button();
            AmountTextBox = new TextBox();
            AmountLabel = new Label();
            PeriodLabel = new Label();
            PeriodTextBox = new TextBox();
            SubmitButton = new Button();
            MessageLabel = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            label1.Location = new Point(365, 33);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(394, 68);
            label1.TabIndex = 1;
            label1.Text = "Откриване на сметка";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // LoanButton
            // 
            LoanButton.Font = new Font("Segoe UI", 14F);
            LoanButton.Location = new Point(373, 282);
            LoanButton.Margin = new Padding(4, 5, 4, 5);
            LoanButton.Name = "LoanButton";
            LoanButton.Size = new Size(386, 60);
            LoanButton.TabIndex = 2;
            LoanButton.Text = "Кредитна сметка";
            LoanButton.UseVisualStyleBackColor = true;
            LoanButton.Click += LoanButton_Click;
            // 
            // SavingsButton
            // 
            SavingsButton.Font = new Font("Segoe UI", 14F);
            SavingsButton.Location = new Point(373, 388);
            SavingsButton.Margin = new Padding(4, 5, 4, 5);
            SavingsButton.Name = "SavingsButton";
            SavingsButton.Size = new Size(386, 60);
            SavingsButton.TabIndex = 3;
            SavingsButton.Text = "Спестовна сметка";
            SavingsButton.UseVisualStyleBackColor = true;
            SavingsButton.Click += SavingsButton_Click;
            // 
            // CheckingButton
            // 
            CheckingButton.Font = new Font("Segoe UI", 14F);
            CheckingButton.Location = new Point(373, 497);
            CheckingButton.Margin = new Padding(4, 5, 4, 5);
            CheckingButton.Name = "CheckingButton";
            CheckingButton.Size = new Size(386, 60);
            CheckingButton.TabIndex = 4;
            CheckingButton.Text = "Разплащателна сметка";
            CheckingButton.UseVisualStyleBackColor = true;
            CheckingButton.Click += CheckingButton_Click;
            // 
            // AmountTextBox
            // 
            AmountTextBox.Font = new Font("Segoe UI", 14F);
            AmountTextBox.Location = new Point(373, 282);
            AmountTextBox.Margin = new Padding(4, 5, 4, 5);
            AmountTextBox.Name = "AmountTextBox";
            AmountTextBox.Size = new Size(384, 45);
            AmountTextBox.TabIndex = 5;
            // 
            // AmountLabel
            // 
            AmountLabel.Font = new Font("Segoe UI", 14F);
            AmountLabel.Location = new Point(434, 223);
            AmountLabel.Margin = new Padding(4, 0, 4, 0);
            AmountLabel.Name = "AmountLabel";
            AmountLabel.Size = new Size(257, 53);
            AmountLabel.TabIndex = 6;
            AmountLabel.Text = "Размер на кредита";
            AmountLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // PeriodLabel
            // 
            PeriodLabel.Font = new Font("Segoe UI", 14F);
            PeriodLabel.Location = new Point(373, 363);
            PeriodLabel.Margin = new Padding(4, 0, 4, 0);
            PeriodLabel.Name = "PeriodLabel";
            PeriodLabel.Size = new Size(386, 53);
            PeriodLabel.TabIndex = 7;
            PeriodLabel.Text = "Кредитен период (в години)";
            PeriodLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // PeriodTextBox
            // 
            PeriodTextBox.Font = new Font("Segoe UI", 14F);
            PeriodTextBox.Location = new Point(373, 422);
            PeriodTextBox.Margin = new Padding(4, 5, 4, 5);
            PeriodTextBox.Name = "PeriodTextBox";
            PeriodTextBox.Size = new Size(384, 45);
            PeriodTextBox.TabIndex = 8;
            // 
            // SubmitButton
            // 
            SubmitButton.Font = new Font("Segoe UI", 14F);
            SubmitButton.Location = new Point(373, 567);
            SubmitButton.Margin = new Padding(4, 5, 4, 5);
            SubmitButton.Name = "SubmitButton";
            SubmitButton.Size = new Size(386, 60);
            SubmitButton.TabIndex = 9;
            SubmitButton.Text = "Открий сметка";
            SubmitButton.UseVisualStyleBackColor = true;
            SubmitButton.Click += SubmitButton_Click;
            // 
            // MessageLabel
            // 
            MessageLabel.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            MessageLabel.ForeColor = Color.Red;
            MessageLabel.Location = new Point(17, 682);
            MessageLabel.Margin = new Padding(4, 0, 4, 0);
            MessageLabel.Name = "MessageLabel";
            MessageLabel.Size = new Size(1109, 53);
            MessageLabel.TabIndex = 10;
            MessageLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // OpenAccountForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1143, 750);
            Controls.Add(MessageLabel);
            Controls.Add(SubmitButton);
            Controls.Add(PeriodTextBox);
            Controls.Add(PeriodLabel);
            Controls.Add(AmountLabel);
            Controls.Add(AmountTextBox);
            Controls.Add(CheckingButton);
            Controls.Add(SavingsButton);
            Controls.Add(LoanButton);
            Controls.Add(label1);
            Margin = new Padding(4, 5, 4, 5);
            Name = "OpenAccountForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Откриване на сметка";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button LoanButton;
        private Button SavingsButton;
        private Button CheckingButton;
        private TextBox AmountTextBox;
        private Label AmountLabel;
        private Label PeriodLabel;
        private TextBox PeriodTextBox;
        private Button SubmitButton;
        private Label MessageLabel;
    }
}
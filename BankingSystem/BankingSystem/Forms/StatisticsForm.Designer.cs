namespace BankingSystem.Forms
{
    partial class StatisticsForm
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
            StatisticsLabel = new Label();
            ReturnButton = new Button();
            AccountLabel = new Label();
            ExportButton = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 35);
            label1.Name = "label1";
            label1.Size = new Size(936, 55);
            label1.TabIndex = 0;
            label1.Text = "Агрегирани статистики";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // StatisticsLabel
            // 
            StatisticsLabel.Font = new Font("Segoe UI", 12F);
            StatisticsLabel.Location = new Point(12, 168);
            StatisticsLabel.Name = "StatisticsLabel";
            StatisticsLabel.Size = new Size(936, 464);
            StatisticsLabel.TabIndex = 1;
            StatisticsLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // ReturnButton
            // 
            ReturnButton.Font = new Font("Segoe UI", 14F);
            ReturnButton.ForeColor = Color.Orange;
            ReturnButton.Location = new Point(844, 35);
            ReturnButton.Margin = new Padding(4, 5, 4, 5);
            ReturnButton.Name = "ReturnButton";
            ReturnButton.Size = new Size(103, 50);
            ReturnButton.TabIndex = 24;
            ReturnButton.Text = "Назад";
            ReturnButton.UseVisualStyleBackColor = true;
            ReturnButton.Click += ReturnButton_Click;
            // 
            // AccountLabel
            // 
            AccountLabel.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            AccountLabel.Location = new Point(12, 104);
            AccountLabel.Name = "AccountLabel";
            AccountLabel.Size = new Size(936, 38);
            AccountLabel.TabIndex = 25;
            AccountLabel.Text = "За";
            AccountLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // ExportButton
            // 
            ExportButton.Font = new Font("Segoe UI", 14F);
            ExportButton.Location = new Point(815, 582);
            ExportButton.Margin = new Padding(4, 5, 4, 5);
            ExportButton.Name = "ExportButton";
            ExportButton.Size = new Size(132, 50);
            ExportButton.TabIndex = 32;
            ExportButton.Text = "Експорт";
            ExportButton.UseVisualStyleBackColor = true;
            ExportButton.Click += ExportButton_Click;
            // 
            // StatisticsForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(960, 652);
            Controls.Add(ExportButton);
            Controls.Add(AccountLabel);
            Controls.Add(ReturnButton);
            Controls.Add(StatisticsLabel);
            Controls.Add(label1);
            Name = "StatisticsForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Агрегирани статистики";
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Label StatisticsLabel;
        private Button ReturnButton;
        private Label AccountLabel;
        private Button ExportButton;
    }
}
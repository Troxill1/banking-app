namespace BankingSystem.Forms
{
    partial class AuditLogForm
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
            ReturnButton = new Button();
            label1 = new Label();
            LogLabel = new RichTextBox();
            ClearButton = new Button();
            NameLabel = new Label();
            SuspendLayout();
            // 
            // ReturnButton
            // 
            ReturnButton.Font = new Font("Segoe UI", 14F);
            ReturnButton.ForeColor = Color.Orange;
            ReturnButton.Location = new Point(1273, 37);
            ReturnButton.Margin = new Padding(4, 5, 4, 5);
            ReturnButton.Name = "ReturnButton";
            ReturnButton.Size = new Size(126, 62);
            ReturnButton.TabIndex = 26;
            ReturnButton.Text = "Назад";
            ReturnButton.UseVisualStyleBackColor = true;
            ReturnButton.Click += ReturnButton_Click;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            label1.Location = new Point(12, 28);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.RightToLeft = RightToLeft.Yes;
            label1.Size = new Size(1387, 45);
            label1.TabIndex = 25;
            label1.Text = "Записи на потребителските операции";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // LogLabel
            // 
            LogLabel.BackColor = SystemColors.ButtonFace;
            LogLabel.BorderStyle = BorderStyle.None;
            LogLabel.Font = new Font("Segoe UI", 14F);
            LogLabel.Location = new Point(13, 201);
            LogLabel.Margin = new Padding(4, 5, 4, 5);
            LogLabel.Name = "LogLabel";
            LogLabel.ReadOnly = true;
            LogLabel.ScrollBars = RichTextBoxScrollBars.Vertical;
            LogLabel.Size = new Size(1387, 630);
            LogLabel.TabIndex = 24;
            LogLabel.TabStop = false;
            LogLabel.Text = "";
            // 
            // ClearButton
            // 
            ClearButton.Font = new Font("Segoe UI", 14F);
            ClearButton.ForeColor = SystemColors.ActiveCaptionText;
            ClearButton.Location = new Point(13, 37);
            ClearButton.Margin = new Padding(4, 5, 4, 5);
            ClearButton.Name = "ClearButton";
            ClearButton.Size = new Size(164, 86);
            ClearButton.TabIndex = 27;
            ClearButton.Text = "Премахни записите";
            ClearButton.UseVisualStyleBackColor = true;
            ClearButton.Click += ClearButton_Click;
            // 
            // NameLabel
            // 
            NameLabel.Font = new Font("Segoe UI", 14F);
            NameLabel.Location = new Point(368, 89);
            NameLabel.Margin = new Padding(4, 0, 4, 0);
            NameLabel.Name = "NameLabel";
            NameLabel.RightToLeft = RightToLeft.Yes;
            NameLabel.Size = new Size(675, 45);
            NameLabel.TabIndex = 28;
            NameLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // AuditLogForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1415, 865);
            Controls.Add(NameLabel);
            Controls.Add(ClearButton);
            Controls.Add(ReturnButton);
            Controls.Add(label1);
            Controls.Add(LogLabel);
            Name = "AuditLogForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Записи на потребителските операции";
            ResumeLayout(false);
        }

        #endregion

        private Button ReturnButton;
        private Label label1;
        private RichTextBox LogLabel;
        private Button ClearButton;
        private Label NameLabel;
    }
}
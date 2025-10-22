namespace BankingSystem.Forms
{
    partial class TransactionHistoryForm
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
            HistoryLabel = new RichTextBox();
            ReturnButton = new Button();
            label1 = new Label();
            EmiLabel = new Label();
            BalanceLabel = new Label();
            FilterDropdown = new ComboBox();
            label2 = new Label();
            label3 = new Label();
            SortDropdown = new ComboBox();
            ExportButton = new Button();
            FromDatePicker = new DateTimePicker();
            ToDatePicker = new DateTimePicker();
            FromLabel = new Label();
            ToLabel = new Label();
            TypeLabel = new Label();
            TypeDropdown = new ComboBox();
            SubmitButton = new Button();
            FromAmountInput = new TextBox();
            ToAmountInput = new TextBox();
            ResetFiltersButton = new Button();
            StatisticsButton = new Button();
            MessageLabel = new Label();
            SuspendLayout();
            // 
            // HistoryLabel
            // 
            HistoryLabel.BackColor = SystemColors.ButtonFace;
            HistoryLabel.BorderStyle = BorderStyle.None;
            HistoryLabel.Font = new Font("Segoe UI", 14F);
            HistoryLabel.Location = new Point(13, 278);
            HistoryLabel.Margin = new Padding(4, 5, 4, 5);
            HistoryLabel.Name = "HistoryLabel";
            HistoryLabel.ReadOnly = true;
            HistoryLabel.ScrollBars = RichTextBoxScrollBars.Vertical;
            HistoryLabel.Size = new Size(1387, 574);
            HistoryLabel.TabIndex = 21;
            HistoryLabel.TabStop = false;
            HistoryLabel.Text = "";
            // 
            // ReturnButton
            // 
            ReturnButton.Font = new Font("Segoe UI", 14F);
            ReturnButton.ForeColor = Color.Orange;
            ReturnButton.Location = new Point(1274, 45);
            ReturnButton.Margin = new Padding(4, 5, 4, 5);
            ReturnButton.Name = "ReturnButton";
            ReturnButton.Size = new Size(126, 62);
            ReturnButton.TabIndex = 23;
            ReturnButton.Text = "Назад";
            ReturnButton.UseVisualStyleBackColor = true;
            ReturnButton.Click += ReturnButton_Click;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            label1.Location = new Point(13, 36);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.RightToLeft = RightToLeft.Yes;
            label1.Size = new Size(1387, 45);
            label1.TabIndex = 22;
            label1.Text = "История на транзакциите";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // EmiLabel
            // 
            EmiLabel.Font = new Font("Segoe UI", 14F);
            EmiLabel.Location = new Point(13, 187);
            EmiLabel.Margin = new Padding(4, 0, 4, 0);
            EmiLabel.Name = "EmiLabel";
            EmiLabel.RightToLeft = RightToLeft.Yes;
            EmiLabel.Size = new Size(1387, 50);
            EmiLabel.TabIndex = 26;
            EmiLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // BalanceLabel
            // 
            BalanceLabel.Font = new Font("Segoe UI", 14F);
            BalanceLabel.Location = new Point(13, 96);
            BalanceLabel.Margin = new Padding(4, 0, 4, 0);
            BalanceLabel.Name = "BalanceLabel";
            BalanceLabel.RightToLeft = RightToLeft.Yes;
            BalanceLabel.Size = new Size(1387, 82);
            BalanceLabel.TabIndex = 25;
            BalanceLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // FilterDropdown
            // 
            FilterDropdown.DropDownStyle = ComboBoxStyle.DropDownList;
            FilterDropdown.Font = new Font("Segoe UI", 12F);
            FilterDropdown.FormattingEnabled = true;
            FilterDropdown.Items.AddRange(new object[] { "Дата", "Сума", "Тип" });
            FilterDropdown.Location = new Point(503, 987);
            FilterDropdown.Name = "FilterDropdown";
            FilterDropdown.Size = new Size(182, 40);
            FilterDropdown.TabIndex = 27;
            FilterDropdown.SelectedIndexChanged += FilterDropdown_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(503, 946);
            label2.Name = "label2";
            label2.Size = new Size(182, 38);
            label2.TabIndex = 28;
            label2.Text = "Филтрирай по";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(200, 946);
            label3.Name = "label3";
            label3.Size = new Size(276, 38);
            label3.TabIndex = 30;
            label3.Text = "Сортирай по";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // SortDropdown
            // 
            SortDropdown.DropDownStyle = ComboBoxStyle.DropDownList;
            SortDropdown.Font = new Font("Segoe UI", 12F);
            SortDropdown.FormattingEnabled = true;
            SortDropdown.Items.AddRange(new object[] { "Дата - възходяща", "Дата - низходяща", "Сума - възходяща", "Сума - низходяща", "Тип" });
            SortDropdown.Location = new Point(200, 987);
            SortDropdown.Name = "SortDropdown";
            SortDropdown.Size = new Size(276, 40);
            SortDropdown.TabIndex = 29;
            SortDropdown.SelectedIndexChanged += SortDropdown_SelectedIndexChanged;
            // 
            // ExportButton
            // 
            ExportButton.Font = new Font("Segoe UI", 14F);
            ExportButton.Location = new Point(1255, 963);
            ExportButton.Margin = new Padding(4, 5, 4, 5);
            ExportButton.Name = "ExportButton";
            ExportButton.Size = new Size(145, 62);
            ExportButton.TabIndex = 31;
            ExportButton.Text = "Експорт";
            ExportButton.UseVisualStyleBackColor = true;
            ExportButton.Click += ExportButton_Click;
            // 
            // FromDatePicker
            // 
            FromDatePicker.CalendarFont = new Font("Segoe UI", 12F);
            FromDatePicker.Font = new Font("Segoe UI", 12F);
            FromDatePicker.Location = new Point(764, 942);
            FromDatePicker.MaxDate = new DateTime(2100, 12, 31, 0, 0, 0, 0);
            FromDatePicker.MinDate = new DateTime(2000, 1, 1, 0, 0, 0, 0);
            FromDatePicker.Name = "FromDatePicker";
            FromDatePicker.Size = new Size(306, 39);
            FromDatePicker.TabIndex = 32;
            // 
            // ToDatePicker
            // 
            ToDatePicker.CalendarFont = new Font("Segoe UI", 12F);
            ToDatePicker.Font = new Font("Segoe UI", 12F);
            ToDatePicker.Location = new Point(764, 994);
            ToDatePicker.MaxDate = new DateTime(2100, 12, 31, 0, 0, 0, 0);
            ToDatePicker.MinDate = new DateTime(2000, 1, 1, 0, 0, 0, 0);
            ToDatePicker.Name = "ToDatePicker";
            ToDatePicker.Size = new Size(306, 39);
            ToDatePicker.TabIndex = 33;
            // 
            // FromLabel
            // 
            FromLabel.Font = new Font("Segoe UI", 12F);
            FromLabel.Location = new Point(712, 946);
            FromLabel.Name = "FromLabel";
            FromLabel.Size = new Size(46, 31);
            FromLabel.TabIndex = 34;
            FromLabel.Text = "От";
            FromLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // ToLabel
            // 
            ToLabel.Font = new Font("Segoe UI", 12F);
            ToLabel.Location = new Point(712, 995);
            ToLabel.Name = "ToLabel";
            ToLabel.Size = new Size(46, 34);
            ToLabel.TabIndex = 35;
            ToLabel.Text = "До";
            ToLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // TypeLabel
            // 
            TypeLabel.Font = new Font("Segoe UI", 12F);
            TypeLabel.Location = new Point(712, 946);
            TypeLabel.Name = "TypeLabel";
            TypeLabel.Size = new Size(266, 38);
            TypeLabel.TabIndex = 36;
            TypeLabel.Text = "Избери тип";
            TypeLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // TypeDropdown
            // 
            TypeDropdown.DropDownStyle = ComboBoxStyle.DropDownList;
            TypeDropdown.Font = new Font("Segoe UI", 12F);
            TypeDropdown.FormattingEnabled = true;
            TypeDropdown.Items.AddRange(new object[] { "Изтегляне", "Внасяне", "Плащане на кредит", "Прилагане на лихва" });
            TypeDropdown.Location = new Point(712, 987);
            TypeDropdown.Name = "TypeDropdown";
            TypeDropdown.Size = new Size(266, 40);
            TypeDropdown.TabIndex = 37;
            // 
            // SubmitButton
            // 
            SubmitButton.Font = new Font("Segoe UI", 14F);
            SubmitButton.ForeColor = Color.FromArgb(0, 192, 0);
            SubmitButton.Location = new Point(1255, 963);
            SubmitButton.Margin = new Padding(4, 5, 4, 5);
            SubmitButton.Name = "SubmitButton";
            SubmitButton.Size = new Size(145, 62);
            SubmitButton.TabIndex = 38;
            SubmitButton.Text = "Изпълни";
            SubmitButton.UseVisualStyleBackColor = true;
            SubmitButton.Click += SubmitButton_Click;
            // 
            // FromAmountInput
            // 
            FromAmountInput.Font = new Font("Segoe UI", 12F);
            FromAmountInput.Location = new Point(764, 942);
            FromAmountInput.Name = "FromAmountInput";
            FromAmountInput.Size = new Size(125, 39);
            FromAmountInput.TabIndex = 39;
            // 
            // ToAmountInput
            // 
            ToAmountInput.Font = new Font("Segoe UI", 12F);
            ToAmountInput.Location = new Point(764, 994);
            ToAmountInput.Name = "ToAmountInput";
            ToAmountInput.Size = new Size(125, 39);
            ToAmountInput.TabIndex = 40;
            // 
            // ResetFiltersButton
            // 
            ResetFiltersButton.Font = new Font("Segoe UI", 12F);
            ResetFiltersButton.ForeColor = Color.Black;
            ResetFiltersButton.Location = new Point(1102, 956);
            ResetFiltersButton.Margin = new Padding(4, 5, 4, 5);
            ResetFiltersButton.Name = "ResetFiltersButton";
            ResetFiltersButton.Size = new Size(145, 73);
            ResetFiltersButton.TabIndex = 41;
            ResetFiltersButton.Text = "Премахни филтри";
            ResetFiltersButton.UseVisualStyleBackColor = true;
            ResetFiltersButton.Click += ResetFiltersButton_Click;
            // 
            // StatisticsButton
            // 
            StatisticsButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            StatisticsButton.ForeColor = Color.Black;
            StatisticsButton.Location = new Point(24, 963);
            StatisticsButton.Margin = new Padding(4, 5, 4, 5);
            StatisticsButton.Name = "StatisticsButton";
            StatisticsButton.Size = new Size(145, 62);
            StatisticsButton.TabIndex = 42;
            StatisticsButton.Text = "Статистики";
            StatisticsButton.UseVisualStyleBackColor = true;
            StatisticsButton.Click += StatisticsButton_Click;
            // 
            // MessageLabel
            // 
            MessageLabel.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            MessageLabel.ForeColor = Color.Red;
            MessageLabel.Location = new Point(13, 880);
            MessageLabel.Margin = new Padding(4, 0, 4, 0);
            MessageLabel.Name = "MessageLabel";
            MessageLabel.RightToLeft = RightToLeft.Yes;
            MessageLabel.Size = new Size(1387, 50);
            MessageLabel.TabIndex = 43;
            MessageLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // TransactionHistoryForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1413, 1048);
            Controls.Add(MessageLabel);
            Controls.Add(StatisticsButton);
            Controls.Add(ResetFiltersButton);
            Controls.Add(ReturnButton);
            Controls.Add(ToAmountInput);
            Controls.Add(FromAmountInput);
            Controls.Add(SubmitButton);
            Controls.Add(ToLabel);
            Controls.Add(FromLabel);
            Controls.Add(ToDatePicker);
            Controls.Add(ExportButton);
            Controls.Add(label3);
            Controls.Add(SortDropdown);
            Controls.Add(label2);
            Controls.Add(FilterDropdown);
            Controls.Add(EmiLabel);
            Controls.Add(BalanceLabel);
            Controls.Add(label1);
            Controls.Add(HistoryLabel);
            Controls.Add(TypeDropdown);
            Controls.Add(FromDatePicker);
            Controls.Add(TypeLabel);
            Name = "TransactionHistoryForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "История на транзакциите";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox HistoryLabel;
        private Button ReturnButton;
        private Label label1;
        private Label EmiLabel;
        private Label BalanceLabel;
        private ComboBox FilterDropdown;
        private Label label2;
        private Label label3;
        private ComboBox SortDropdown;
        private Button ExportButton;
        private DateTimePicker FromDatePicker;
        private DateTimePicker ToDatePicker;
        private Label FromLabel;
        private Label ToLabel;
        private Label TypeLabel;
        private ComboBox TypeDropdown;
        private Button SubmitButton;
        private TextBox FromAmountInput;
        private TextBox ToAmountInput;
        private Button ResetFiltersButton;
        private Button StatisticsButton;
        private Label MessageLabel;
    }
}
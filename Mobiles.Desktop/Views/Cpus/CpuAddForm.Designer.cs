namespace Mobiles.Desktop.Views.Cpus
{
    partial class CpuAddForm
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
            CancelButton = new Button();
            SaveButton = new Button();
            TableLayoutPanel = new TableLayoutPanel();
            TitleLabel = new Label();
            NameLabel = new Label();
            NameTextBox = new TextBox();
            CoreCountLabel = new Label();
            CoreCountNumericUpDown = new NumericUpDown();
            ClockSpeedLabel = new Label();
            ClockSpeedNumericUpDown = new NumericUpDown();
            GpuNameLabel = new Label();
            GpuNameTextBox = new TextBox();
            ButtonsTableLayoutPanel = new TableLayoutPanel();
            TableLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)CoreCountNumericUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ClockSpeedNumericUpDown).BeginInit();
            ButtonsTableLayoutPanel.SuspendLayout();
            SuspendLayout();
            // 
            // CancelButton
            // 
            CancelButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            CancelButton.DialogResult = DialogResult.Cancel;
            CancelButton.Location = new Point(3, 59);
            CancelButton.Name = "CancelButton";
            CancelButton.Size = new Size(75, 23);
            CancelButton.TabIndex = 1;
            CancelButton.Text = "Cancel";
            CancelButton.UseVisualStyleBackColor = true;
            // 
            // SaveButton
            // 
            SaveButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            SaveButton.DialogResult = DialogResult.OK;
            SaveButton.Location = new Point(266, 59);
            SaveButton.Name = "SaveButton";
            SaveButton.Size = new Size(78, 23);
            SaveButton.TabIndex = 0;
            SaveButton.Text = "Save";
            SaveButton.UseVisualStyleBackColor = true;
            SaveButton.Click += SaveButton_Click;
            // 
            // TableLayoutPanel
            // 
            TableLayoutPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            TableLayoutPanel.ColumnCount = 1;
            TableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            TableLayoutPanel.Controls.Add(TitleLabel, 0, 0);
            TableLayoutPanel.Controls.Add(NameLabel, 0, 1);
            TableLayoutPanel.Controls.Add(NameTextBox, 0, 2);
            TableLayoutPanel.Controls.Add(CoreCountLabel, 0, 3);
            TableLayoutPanel.Controls.Add(CoreCountNumericUpDown, 0, 4);
            TableLayoutPanel.Controls.Add(ClockSpeedLabel, 0, 5);
            TableLayoutPanel.Controls.Add(ClockSpeedNumericUpDown, 0, 6);
            TableLayoutPanel.Controls.Add(GpuNameLabel, 0, 7);
            TableLayoutPanel.Controls.Add(GpuNameTextBox, 0, 8);
            TableLayoutPanel.Controls.Add(ButtonsTableLayoutPanel, 0, 9);
            TableLayoutPanel.Location = new Point(12, 12);
            TableLayoutPanel.Name = "TableLayoutPanel";
            TableLayoutPanel.RowCount = 10;
            TableLayoutPanel.RowStyles.Add(new RowStyle());
            TableLayoutPanel.RowStyles.Add(new RowStyle());
            TableLayoutPanel.RowStyles.Add(new RowStyle());
            TableLayoutPanel.RowStyles.Add(new RowStyle());
            TableLayoutPanel.RowStyles.Add(new RowStyle());
            TableLayoutPanel.RowStyles.Add(new RowStyle());
            TableLayoutPanel.RowStyles.Add(new RowStyle());
            TableLayoutPanel.RowStyles.Add(new RowStyle());
            TableLayoutPanel.RowStyles.Add(new RowStyle());
            TableLayoutPanel.RowStyles.Add(new RowStyle());
            TableLayoutPanel.Size = new Size(353, 312);
            TableLayoutPanel.TabIndex = 2;
            // 
            // TitleLabel
            // 
            TitleLabel.AutoSize = true;
            TitleLabel.Dock = DockStyle.Fill;
            TitleLabel.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            TitleLabel.Location = new Point(3, 0);
            TitleLabel.Name = "TitleLabel";
            TitleLabel.Size = new Size(347, 45);
            TitleLabel.TabIndex = 3;
            TitleLabel.Text = "Add Cpu";
            TitleLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // NameLabel
            // 
            NameLabel.AutoSize = true;
            NameLabel.Location = new Point(3, 45);
            NameLabel.Name = "NameLabel";
            NameLabel.Size = new Size(39, 15);
            NameLabel.TabIndex = 0;
            NameLabel.Text = "Name";
            // 
            // NameTextBox
            // 
            NameTextBox.Dock = DockStyle.Fill;
            NameTextBox.Location = new Point(3, 63);
            NameTextBox.Name = "NameTextBox";
            NameTextBox.Size = new Size(347, 23);
            NameTextBox.TabIndex = 1;
            // 
            // CoreCountLabel
            // 
            CoreCountLabel.AutoSize = true;
            CoreCountLabel.Location = new Point(3, 89);
            CoreCountLabel.Name = "CoreCountLabel";
            CoreCountLabel.Size = new Size(68, 15);
            CoreCountLabel.TabIndex = 3;
            CoreCountLabel.Text = "Core Count";
            // 
            // CoreCountNumericUpDown
            // 
            CoreCountNumericUpDown.Dock = DockStyle.Fill;
            CoreCountNumericUpDown.Location = new Point(3, 107);
            CoreCountNumericUpDown.Maximum = new decimal(new int[] { 64, 0, 0, 0 });
            CoreCountNumericUpDown.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            CoreCountNumericUpDown.Name = "CoreCountNumericUpDown";
            CoreCountNumericUpDown.Size = new Size(347, 23);
            CoreCountNumericUpDown.TabIndex = 9;
            CoreCountNumericUpDown.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // ClockSpeedLabel
            // 
            ClockSpeedLabel.AutoSize = true;
            ClockSpeedLabel.Location = new Point(3, 133);
            ClockSpeedLabel.Name = "ClockSpeedLabel";
            ClockSpeedLabel.Size = new Size(72, 15);
            ClockSpeedLabel.TabIndex = 5;
            ClockSpeedLabel.Text = "Clock Speed";
            // 
            // ClockSpeedNumericUpDown
            // 
            ClockSpeedNumericUpDown.Dock = DockStyle.Fill;
            ClockSpeedNumericUpDown.Location = new Point(3, 151);
            ClockSpeedNumericUpDown.Maximum = new decimal(new int[] { 8192, 0, 0, 0 });
            ClockSpeedNumericUpDown.Minimum = new decimal(new int[] { 512, 0, 0, 0 });
            ClockSpeedNumericUpDown.Name = "ClockSpeedNumericUpDown";
            ClockSpeedNumericUpDown.Size = new Size(347, 23);
            ClockSpeedNumericUpDown.TabIndex = 10;
            ClockSpeedNumericUpDown.Value = new decimal(new int[] { 512, 0, 0, 0 });
            // 
            // GpuNameLabel
            // 
            GpuNameLabel.AutoSize = true;
            GpuNameLabel.Location = new Point(3, 177);
            GpuNameLabel.Name = "GpuNameLabel";
            GpuNameLabel.Size = new Size(64, 15);
            GpuNameLabel.TabIndex = 7;
            GpuNameLabel.Text = "Gpu Name";
            // 
            // GpuNameTextBox
            // 
            GpuNameTextBox.Dock = DockStyle.Fill;
            GpuNameTextBox.Location = new Point(3, 195);
            GpuNameTextBox.Name = "GpuNameTextBox";
            GpuNameTextBox.Size = new Size(347, 23);
            GpuNameTextBox.TabIndex = 8;
            // 
            // ButtonsTableLayoutPanel
            // 
            ButtonsTableLayoutPanel.ColumnCount = 2;
            ButtonsTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            ButtonsTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 174F));
            ButtonsTableLayoutPanel.Controls.Add(SaveButton, 1, 0);
            ButtonsTableLayoutPanel.Controls.Add(CancelButton, 0, 0);
            ButtonsTableLayoutPanel.Dock = DockStyle.Fill;
            ButtonsTableLayoutPanel.Location = new Point(3, 224);
            ButtonsTableLayoutPanel.Name = "ButtonsTableLayoutPanel";
            ButtonsTableLayoutPanel.RowCount = 1;
            ButtonsTableLayoutPanel.RowStyles.Add(new RowStyle());
            ButtonsTableLayoutPanel.Size = new Size(347, 85);
            ButtonsTableLayoutPanel.TabIndex = 2;
            // 
            // CpuAddForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(377, 336);
            Controls.Add(TableLayoutPanel);
            Name = "CpuAddForm";
            Text = "CpuAddForm";
            TableLayoutPanel.ResumeLayout(false);
            TableLayoutPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)CoreCountNumericUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)ClockSpeedNumericUpDown).EndInit();
            ButtonsTableLayoutPanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Button CancelButton;
        private Button SaveButton;
        private TableLayoutPanel TableLayoutPanel;
        private Label NameLabel;
        private TextBox NameTextBox;
        private TableLayoutPanel ButtonsTableLayoutPanel;
        private Label CoreCountLabel;
        private Label ClockSpeedLabel;
        private Label GpuNameLabel;
        private TextBox GpuNameTextBox;
        private NumericUpDown ClockSpeedNumericUpDown;
        private NumericUpDown CoreCountNumericUpDown;
        private Label TitleLabel;
    }
}
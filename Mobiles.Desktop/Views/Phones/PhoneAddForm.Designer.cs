namespace Mobiles.Desktop.Views.Phones
{
    partial class PhoneAddForm
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
            BatteryPowerLabel = new Label();
            BatteryPowerNumericUpDown = new NumericUpDown();
            IsDualSimCheckBox = new CheckBox();
            InternalMemoryLabel = new Label();
            InternalMemoryNumericUpDown = new NumericUpDown();
            RamLabel = new Label();
            RamNumericUpDown = new NumericUpDown();
            PriceRangeLabel = new Label();
            PriceRangeComboBox = new ComboBox();
            CpuLabel = new Label();
            CpuComboBox = new ComboBox();
            ButtonsTLayoutPanel = new TableLayoutPanel();
            TableLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)BatteryPowerNumericUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)InternalMemoryNumericUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)RamNumericUpDown).BeginInit();
            ButtonsTLayoutPanel.SuspendLayout();
            SuspendLayout();
            // 
            // CancelButton
            // 
            CancelButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            CancelButton.Location = new Point(3, 75);
            CancelButton.Name = "CancelButton";
            CancelButton.Size = new Size(75, 23);
            CancelButton.TabIndex = 3;
            CancelButton.Text = "Cancel";
            CancelButton.UseVisualStyleBackColor = true;
            CancelButton.DialogResult = DialogResult.Cancel;
            // 
            // SaveButton
            // 
            SaveButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            SaveButton.Location = new Point(271, 75);
            SaveButton.Name = "SaveButton";
            SaveButton.Size = new Size(75, 23);
            SaveButton.TabIndex = 2;
            SaveButton.Text = "Save";
            SaveButton.UseVisualStyleBackColor = true;
            SaveButton.Click += SaveButton_Click;
            SaveButton.DialogResult = DialogResult.OK;
            // 
            // TableLayoutPanel
            // 
            TableLayoutPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            TableLayoutPanel.AutoSize = true;
            TableLayoutPanel.ColumnCount = 1;
            TableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            TableLayoutPanel.Controls.Add(TitleLabel, 0, 0);
            TableLayoutPanel.Controls.Add(BatteryPowerLabel, 0, 1);
            TableLayoutPanel.Controls.Add(BatteryPowerNumericUpDown, 0, 2);
            TableLayoutPanel.Controls.Add(IsDualSimCheckBox, 0, 3);
            TableLayoutPanel.Controls.Add(InternalMemoryLabel, 0, 4);
            TableLayoutPanel.Controls.Add(InternalMemoryNumericUpDown, 0, 5);
            TableLayoutPanel.Controls.Add(RamLabel, 0, 6);
            TableLayoutPanel.Controls.Add(RamNumericUpDown, 0, 7);
            TableLayoutPanel.Controls.Add(PriceRangeLabel, 0, 8);
            TableLayoutPanel.Controls.Add(PriceRangeComboBox, 0, 9);
            TableLayoutPanel.Controls.Add(CpuLabel, 0, 10);
            TableLayoutPanel.Controls.Add(CpuComboBox, 0, 11);
            TableLayoutPanel.Controls.Add(ButtonsTLayoutPanel, 0, 12);
            TableLayoutPanel.Location = new Point(12, 12);
            TableLayoutPanel.Name = "TableLayoutPanel";
            TableLayoutPanel.RowCount = 13;
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
            TableLayoutPanel.RowStyles.Add(new RowStyle());
            TableLayoutPanel.RowStyles.Add(new RowStyle());
            TableLayoutPanel.RowStyles.Add(new RowStyle());
            TableLayoutPanel.Size = new Size(355, 397);
            TableLayoutPanel.TabIndex = 4;
            // 
            // TitleLabel
            // 
            TitleLabel.AutoSize = true;
            TitleLabel.Dock = DockStyle.Fill;
            TitleLabel.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            TitleLabel.Location = new Point(3, 0);
            TitleLabel.Name = "TitleLabel";
            TitleLabel.Size = new Size(349, 45);
            TitleLabel.TabIndex = 3;
            TitleLabel.Text = "Add Phone";
            TitleLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // BatteryPowerLabel
            // 
            BatteryPowerLabel.AutoSize = true;
            BatteryPowerLabel.Location = new Point(3, 45);
            BatteryPowerLabel.Name = "BatteryPowerLabel";
            BatteryPowerLabel.Size = new Size(117, 15);
            BatteryPowerLabel.TabIndex = 3;
            BatteryPowerLabel.Text = "Battery Power (mAh)";
            // 
            // BatteryPowerNumericUpDown
            // 
            BatteryPowerNumericUpDown.Dock = DockStyle.Fill;
            BatteryPowerNumericUpDown.Increment = new decimal(new int[] { 100, 0, 0, 0 });
            BatteryPowerNumericUpDown.Location = new Point(3, 63);
            BatteryPowerNumericUpDown.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            BatteryPowerNumericUpDown.Name = "BatteryPowerNumericUpDown";
            BatteryPowerNumericUpDown.Size = new Size(349, 23);
            BatteryPowerNumericUpDown.TabIndex = 9;
            BatteryPowerNumericUpDown.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // IsDualSimCheckBox
            // 
            IsDualSimCheckBox.AutoSize = true;
            IsDualSimCheckBox.Location = new Point(3, 92);
            IsDualSimCheckBox.Name = "IsDualSimCheckBox";
            IsDualSimCheckBox.Size = new Size(78, 19);
            IsDualSimCheckBox.TabIndex = 10;
            IsDualSimCheckBox.Text = "Dual Sim?";
            IsDualSimCheckBox.UseVisualStyleBackColor = true;
            // 
            // InternalMemoryLabel
            // 
            InternalMemoryLabel.AutoSize = true;
            InternalMemoryLabel.Location = new Point(3, 114);
            InternalMemoryLabel.Name = "InternalMemoryLabel";
            InternalMemoryLabel.Size = new Size(121, 15);
            InternalMemoryLabel.TabIndex = 11;
            InternalMemoryLabel.Text = "Internal Memory (GB)";
            // 
            // InternalMemoryNumericUpDown
            // 
            InternalMemoryNumericUpDown.Dock = DockStyle.Fill;
            InternalMemoryNumericUpDown.Increment = new decimal(new int[] { 32, 0, 0, 0 });
            InternalMemoryNumericUpDown.Location = new Point(3, 132);
            InternalMemoryNumericUpDown.Maximum = new decimal(new int[] { 4096, 0, 0, 0 });
            InternalMemoryNumericUpDown.Name = "InternalMemoryNumericUpDown";
            InternalMemoryNumericUpDown.Size = new Size(349, 23);
            InternalMemoryNumericUpDown.TabIndex = 12;
            // 
            // RamLabel
            // 
            RamLabel.AutoSize = true;
            RamLabel.Location = new Point(3, 158);
            RamLabel.Name = "RamLabel";
            RamLabel.Size = new Size(60, 15);
            RamLabel.TabIndex = 13;
            RamLabel.Text = "Ram (MB)";
            // 
            // RamNumericUpDown
            // 
            RamNumericUpDown.Increment = new decimal(new int[] { 512, 0, 0, 0 });
            RamNumericUpDown.Location = new Point(3, 176);
            RamNumericUpDown.Maximum = new decimal(new int[] { 16384, 0, 0, 0 });
            RamNumericUpDown.Name = "RamNumericUpDown";
            RamNumericUpDown.Size = new Size(349, 23);
            RamNumericUpDown.TabIndex = 14;
            // 
            // PriceRangeLabel
            // 
            PriceRangeLabel.AutoSize = true;
            PriceRangeLabel.Location = new Point(3, 202);
            PriceRangeLabel.Name = "PriceRangeLabel";
            PriceRangeLabel.Size = new Size(69, 15);
            PriceRangeLabel.TabIndex = 15;
            PriceRangeLabel.Text = "Price Range";
            // 
            // PriceRangeComboBox
            // 
            PriceRangeComboBox.Dock = DockStyle.Fill;
            PriceRangeComboBox.FormattingEnabled = true;
            PriceRangeComboBox.Location = new Point(3, 220);
            PriceRangeComboBox.Name = "PriceRangeComboBox";
            PriceRangeComboBox.Size = new Size(349, 23);
            PriceRangeComboBox.TabIndex = 16;
            // 
            // CpuLabel
            // 
            CpuLabel.AutoSize = true;
            CpuLabel.Location = new Point(3, 246);
            CpuLabel.Name = "CpuLabel";
            CpuLabel.Size = new Size(29, 15);
            CpuLabel.TabIndex = 17;
            CpuLabel.Text = "Cpu";
            // 
            // CpuComboBox
            // 
            CpuComboBox.Dock = DockStyle.Fill;
            CpuComboBox.FormattingEnabled = true;
            CpuComboBox.Location = new Point(3, 264);
            CpuComboBox.Name = "CpuComboBox";
            CpuComboBox.Size = new Size(349, 23);
            CpuComboBox.TabIndex = 18;
            // 
            // ButtonsTLayoutPanel
            // 
            ButtonsTLayoutPanel.ColumnCount = 2;
            ButtonsTLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            ButtonsTLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            ButtonsTLayoutPanel.Controls.Add(CancelButton, 0, 0);
            ButtonsTLayoutPanel.Controls.Add(SaveButton, 1, 0);
            ButtonsTLayoutPanel.Dock = DockStyle.Fill;
            ButtonsTLayoutPanel.Location = new Point(3, 293);
            ButtonsTLayoutPanel.Name = "ButtonsTLayoutPanel";
            ButtonsTLayoutPanel.RowCount = 1;
            ButtonsTLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            ButtonsTLayoutPanel.Size = new Size(349, 101);
            ButtonsTLayoutPanel.TabIndex = 19;
            // 
            // PhoneAddForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(379, 421);
            Controls.Add(TableLayoutPanel);
            Name = "PhoneAddForm";
            Text = "PhoneAddForm";
            TableLayoutPanel.ResumeLayout(false);
            TableLayoutPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)BatteryPowerNumericUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)InternalMemoryNumericUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)RamNumericUpDown).EndInit();
            ButtonsTLayoutPanel.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button CancelButton;
        private Button SaveButton;
        private TableLayoutPanel TableLayoutPanel;
        private Label TitleLabel;
        private Label BatteryPowerLabel;
        private NumericUpDown BatteryPowerNumericUpDown;
        private CheckBox IsDualSimCheckBox;
        private Label InternalMemoryLabel;
        private NumericUpDown InternalMemoryNumericUpDown;
        private Label RamLabel;
        private NumericUpDown RamNumericUpDown;
        private Label PriceRangeLabel;
        private ComboBox PriceRangeComboBox;
        private Label CpuLabel;
        private ComboBox CpuComboBox;
        private TableLayoutPanel ButtonsTLayoutPanel;
    }
}
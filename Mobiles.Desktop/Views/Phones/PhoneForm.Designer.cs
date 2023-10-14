namespace Mobiles.Desktop.Views.Phones
{
    partial class PhoneForm
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
            PhonesDataGridView = new DataGridView();
            AddButton = new Button();
            TableLayoutPanel = new TableLayoutPanel();
            EditButton = new Button();
            ControlPanel = new Panel();
            ((System.ComponentModel.ISupportInitialize)PhonesDataGridView).BeginInit();
            TableLayoutPanel.SuspendLayout();
            ControlPanel.SuspendLayout();
            SuspendLayout();
            // 
            // PhonesDataGridView
            // 
            PhonesDataGridView.AllowUserToAddRows = false;
            PhonesDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            PhonesDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            PhonesDataGridView.Dock = DockStyle.Fill;
            PhonesDataGridView.Location = new Point(3, 3);
            PhonesDataGridView.Name = "PhonesDataGridView";
            PhonesDataGridView.ReadOnly = true;
            PhonesDataGridView.RowTemplate.Height = 25;
            PhonesDataGridView.Size = new Size(794, 413);
            PhonesDataGridView.TabIndex = 0;
            // 
            // AddButton
            // 
            AddButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            AddButton.Location = new Point(716, 4);
            AddButton.Name = "AddButton";
            AddButton.Size = new Size(75, 23);
            AddButton.TabIndex = 3;
            AddButton.Text = "New";
            AddButton.UseVisualStyleBackColor = true;
            AddButton.Click += AddButton_Click;
            // 
            // TableLayoutPanel
            // 
            TableLayoutPanel.ColumnCount = 1;
            TableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            TableLayoutPanel.Controls.Add(PhonesDataGridView, 0, 0);
            TableLayoutPanel.Controls.Add(ControlPanel, 0, 1);
            TableLayoutPanel.Dock = DockStyle.Fill;
            TableLayoutPanel.Location = new Point(0, 0);
            TableLayoutPanel.Name = "TableLayoutPanel";
            TableLayoutPanel.RowCount = 2;
            TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 92.08791F));
            TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 7.912088F));
            TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            TableLayoutPanel.Size = new Size(800, 455);
            TableLayoutPanel.TabIndex = 6;
            // 
            // EditButton
            // 
            EditButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            EditButton.Location = new Point(620, 4);
            EditButton.Name = "EditButton";
            EditButton.Size = new Size(75, 23);
            EditButton.TabIndex = 4;
            EditButton.Text = "Edit";
            EditButton.UseVisualStyleBackColor = true;
            EditButton.Click += EditButton_Click;
            // 
            // ControlPanel
            // 
            ControlPanel.Controls.Add(EditButton);
            ControlPanel.Controls.Add(AddButton);
            ControlPanel.Dock = DockStyle.Fill;
            ControlPanel.Location = new Point(3, 422);
            ControlPanel.Name = "ControlPanel";
            ControlPanel.Size = new Size(794, 30);
            ControlPanel.TabIndex = 5;
            // 
            // PhoneForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 455);
            Controls.Add(TableLayoutPanel);
            Name = "PhoneForm";
            Text = "PhoneReadForm";
            ((System.ComponentModel.ISupportInitialize)PhonesDataGridView).EndInit();
            TableLayoutPanel.ResumeLayout(false);
            ControlPanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private DataGridView PhonesDataGridView;
        private Button AddButton;
        private TableLayoutPanel TableLayoutPanel;
        private Panel ControlPanel;
        private Button EditButton;
    }
}
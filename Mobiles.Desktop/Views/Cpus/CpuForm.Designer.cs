namespace Mobiles.Desktop.Views.Cpus
{
    partial class CpuForm
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
            components = new System.ComponentModel.Container();
            CpuDataGridView = new DataGridView();
            phonesDbContextBindingSource = new BindingSource(components);
            AddButton = new Button();
            EditButton = new Button();
            ControlPanel = new Panel();
            TableLayoutPanel = new TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)CpuDataGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)phonesDbContextBindingSource).BeginInit();
            ControlPanel.SuspendLayout();
            TableLayoutPanel.SuspendLayout();
            SuspendLayout();
            // 
            // CpuDataGridView
            // 
            CpuDataGridView.AllowUserToAddRows = false;
            CpuDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            CpuDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            CpuDataGridView.Dock = DockStyle.Fill;
            CpuDataGridView.Location = new Point(3, 3);
            CpuDataGridView.Name = "CpuDataGridView";
            CpuDataGridView.ReadOnly = true;
            CpuDataGridView.RowTemplate.Height = 25;
            CpuDataGridView.Size = new Size(794, 411);
            CpuDataGridView.TabIndex = 0;
            // 
            // phonesDbContextBindingSource
            // 
            phonesDbContextBindingSource.DataSource = typeof(Core.Data.PhonesDbContext);
            // 
            // AddButton
            // 
            AddButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            AddButton.Location = new Point(716, 4);
            AddButton.Name = "AddButton";
            AddButton.Size = new Size(75, 23);
            AddButton.TabIndex = 1;
            AddButton.Text = "New";
            AddButton.UseVisualStyleBackColor = true;
            AddButton.Click += AddButton_Click;
            // 
            // EditButton
            // 
            EditButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            EditButton.Location = new Point(624, 4);
            EditButton.Name = "EditButton";
            EditButton.Size = new Size(75, 23);
            EditButton.TabIndex = 2;
            EditButton.Text = "Edit";
            EditButton.UseVisualStyleBackColor = true;
            EditButton.Click += EditButton_Click;
            // 
            // ControlPanel
            // 
            ControlPanel.Controls.Add(EditButton);
            ControlPanel.Controls.Add(AddButton);
            ControlPanel.Dock = DockStyle.Fill;
            ControlPanel.Location = new Point(3, 420);
            ControlPanel.Name = "ControlPanel";
            ControlPanel.Size = new Size(794, 30);
            ControlPanel.TabIndex = 3;
            // 
            // TableLayoutPanel
            // 
            TableLayoutPanel.ColumnCount = 1;
            TableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            TableLayoutPanel.Controls.Add(CpuDataGridView, 0, 0);
            TableLayoutPanel.Controls.Add(ControlPanel, 0, 1);
            TableLayoutPanel.Dock = DockStyle.Fill;
            TableLayoutPanel.Location = new Point(0, 0);
            TableLayoutPanel.Name = "TableLayoutPanel";
            TableLayoutPanel.RowCount = 2;
            TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 92.22222F));
            TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 7.77777767F));
            TableLayoutPanel.Size = new Size(800, 453);
            TableLayoutPanel.TabIndex = 4;
            // 
            // CpuForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 453);
            Controls.Add(TableLayoutPanel);
            Name = "CpuForm";
            Text = "CpuReadForm";
            ((System.ComponentModel.ISupportInitialize)CpuDataGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)phonesDbContextBindingSource).EndInit();
            ControlPanel.ResumeLayout(false);
            TableLayoutPanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private DataGridView CpuDataGridView;
        private BindingSource phonesDbContextBindingSource;
        private Button AddButton;
        private Button EditButton;
        private Panel ControlPanel;
        private TableLayoutPanel TableLayoutPanel;
    }
}
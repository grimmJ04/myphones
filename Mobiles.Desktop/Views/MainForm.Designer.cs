namespace Mobiles.Desktop.Views
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            MenuStrip = new MenuStrip();
            FileToolStripMenuItem = new ToolStripMenuItem();
            importToolStripMenuItem = new ToolStripMenuItem();
            CpuToolStripMenuItem = new ToolStripMenuItem();
            PhoneToolStripMenuItem = new ToolStripMenuItem();
            ExitToolStripMenuItem = new ToolStripMenuItem();
            ViewToolStripMenuItem = new ToolStripMenuItem();
            CpusToolStripMenuItem = new ToolStripMenuItem();
            PhonesToolStripMenuItem = new ToolStripMenuItem();
            RootPanel = new Panel();
            MenuStrip.SuspendLayout();
            SuspendLayout();
            // 
            // MenuStrip
            // 
            MenuStrip.Items.AddRange(new ToolStripItem[] { FileToolStripMenuItem, ViewToolStripMenuItem });
            MenuStrip.Location = new Point(0, 0);
            MenuStrip.Name = "MenuStrip";
            MenuStrip.Size = new Size(800, 24);
            MenuStrip.TabIndex = 0;
            MenuStrip.Text = "menuStrip1";
            // 
            // FileToolStripMenuItem
            // 
            FileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { importToolStripMenuItem, ExitToolStripMenuItem });
            FileToolStripMenuItem.Name = "FileToolStripMenuItem";
            FileToolStripMenuItem.Size = new Size(37, 20);
            FileToolStripMenuItem.Text = "File";
            // 
            // importToolStripMenuItem
            // 
            importToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { CpuToolStripMenuItem, PhoneToolStripMenuItem });
            importToolStripMenuItem.Name = "importToolStripMenuItem";
            importToolStripMenuItem.Size = new Size(110, 22);
            importToolStripMenuItem.Text = "Import";
            // 
            // CpuToolStripMenuItem
            // 
            CpuToolStripMenuItem.Name = "CpuToolStripMenuItem";
            CpuToolStripMenuItem.Size = new Size(108, 22);
            CpuToolStripMenuItem.Text = "Cpu";
            CpuToolStripMenuItem.Click += ImportCpuCsvToolStripMenuItem_Click;
            // 
            // PhoneToolStripMenuItem
            // 
            PhoneToolStripMenuItem.Name = "PhoneToolStripMenuItem";
            PhoneToolStripMenuItem.Size = new Size(108, 22);
            PhoneToolStripMenuItem.Text = "Phone";
            PhoneToolStripMenuItem.Click += ImportPhoneCsvToolStripMenuItem_Click;
            // 
            // ExitToolStripMenuItem
            // 
            ExitToolStripMenuItem.Name = "ExitToolStripMenuItem";
            ExitToolStripMenuItem.Size = new Size(110, 22);
            ExitToolStripMenuItem.Text = "Exit";
            ExitToolStripMenuItem.Click += ExitToolStripMenuItem_Click;
            // 
            // ViewToolStripMenuItem
            // 
            ViewToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { CpusToolStripMenuItem, PhonesToolStripMenuItem });
            ViewToolStripMenuItem.Name = "ViewToolStripMenuItem";
            ViewToolStripMenuItem.Size = new Size(44, 20);
            ViewToolStripMenuItem.Text = "View";
            // 
            // CpusToolStripMenuItem
            // 
            CpusToolStripMenuItem.Name = "CpusToolStripMenuItem";
            CpusToolStripMenuItem.Size = new Size(113, 22);
            CpusToolStripMenuItem.Text = "Cpus";
            CpusToolStripMenuItem.Click += CpusToolStripMenuItem_Click;
            // 
            // PhonesToolStripMenuItem
            // 
            PhonesToolStripMenuItem.Name = "PhonesToolStripMenuItem";
            PhonesToolStripMenuItem.Size = new Size(113, 22);
            PhonesToolStripMenuItem.Text = "Phones";
            PhonesToolStripMenuItem.Click += PhonesToolStripMenuItem_Click;
            // 
            // RootPanel
            // 
            RootPanel.AutoSize = true;
            RootPanel.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            RootPanel.Dock = DockStyle.Fill;
            RootPanel.Location = new Point(0, 24);
            RootPanel.Name = "RootPanel";
            RootPanel.Size = new Size(800, 492);
            RootPanel.TabIndex = 1;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 516);
            Controls.Add(RootPanel);
            Controls.Add(MenuStrip);
            MainMenuStrip = MenuStrip;
            Name = "MainForm";
            Text = "PassMan";
            MenuStrip.ResumeLayout(false);
            MenuStrip.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip MenuStrip;
        private ToolStripMenuItem FileToolStripMenuItem;
        private ToolStripMenuItem ExitToolStripMenuItem;
        private ToolStripMenuItem ViewToolStripMenuItem;
        private ToolStripMenuItem PhonesToolStripMenuItem;
        private ToolStripMenuItem CpusToolStripMenuItem;
        private Panel RootPanel;
        private ToolStripMenuItem importToolStripMenuItem;
        private ToolStripMenuItem CpuToolStripMenuItem;
        private ToolStripMenuItem PhoneToolStripMenuItem;
    }
}
using Mobiles.Core.Data;
using Mobiles.Core.Models;
using Mobiles.Core.Utils;
using Mobiles.Desktop.Views.Cpus;
using Mobiles.Desktop.Views.Phones;

namespace Mobiles.Desktop.Views
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            PhoneForm form = new()
            {
                AutoSize = true,
                Dock = DockStyle.Fill,
                TopLevel = false,
                AutoScroll = true,
                FormBorderStyle = FormBorderStyle.None
            };
            RootPanel.Controls.Add(form);
            form.Show();
        }

        private void ClearRootControls()
        {
            foreach (var control in RootPanel.Controls)
            {
                (control as Form)?.Close();
            }
            RootPanel.Controls.Clear();
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void PhonesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClearRootControls();
            PhoneForm form = new()
            {
                AutoSize = true,
                Dock = DockStyle.Fill,
                TopLevel = false,
                AutoScroll = true,
                FormBorderStyle = FormBorderStyle.None
            };
            RootPanel.Controls.Add(form);
            form.Show();
        }

        private void CpusToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClearRootControls();
            CpuForm form = new()
            {
                AutoSize = true,
                Dock = DockStyle.Fill,
                TopLevel = false,
                AutoScroll = true,
                FormBorderStyle = FormBorderStyle.None
            };
            RootPanel.Controls.Add(form);
            form.Show();
        }

        private async void ImportCpuCsvToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using var dialog = new OpenFileDialog();
            var dialogResult = dialog.ShowDialog();
            if (dialogResult == DialogResult.OK)
            {
                var items = CsvUtils.ParseCsv<SmartphoneCpu>(dialog.FileName);
                using PhonesDbContext context = Program.GetDbContext();

                foreach (var item in items)
                {
                    await Task.Run(() =>
                    {
                        try
                        {
                            context.SmartphoneCpus.Add(item);
                            context.SaveChanges();
                        }
                        catch (Exception) { }
                    });
                }
            }
        }

        private async void ImportPhoneCsvToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using var dialog = new OpenFileDialog();
            var dialogResult = dialog.ShowDialog();
            if (dialogResult == DialogResult.OK)
            {
                var items = CsvUtils.ParseCsv<Smartphone>(dialog.FileName);
                using PhonesDbContext context = Program.GetDbContext();
                foreach (var item in items)
                {
                    await Task.Run(() =>
                    {
                        try
                        {
                            context.Add(item);
                            context.SaveChanges();
                        }
                        catch (Exception) { }
                    });
                }
            }
        }
    }
}

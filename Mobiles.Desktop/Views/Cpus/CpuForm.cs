using Microsoft.EntityFrameworkCore;
using Mobiles.Core.Data;
using Mobiles.Core.Utils;
using Mobiles.Models;

namespace Mobiles.Desktop.Views.Cpus
{
    public partial class CpuForm : Form
    {
        private readonly PhonesDbContext _context;
        private readonly BindingSource _bindingSource = new();

        public CpuForm()
        {
            _context = Program.GetDbContext();
            InitializeComponent();

            _context.SmartphoneCpus.LoadAsync();
            _bindingSource.DataSource = _context.SmartphoneCpus.Local.ToBindingList();
            CpuDataGridView.DataSource = _bindingSource;
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            _context.Dispose();
            base.OnFormClosing(e);
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            using CpuAddForm form = new();
            var dialogResult = form.ShowDialog();
            if (dialogResult == DialogResult.OK && form.Cpu != null)
            {
                _context.Add(form.Cpu);
            }
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            if (CpuDataGridView.CurrentRow.DataBoundItem is not SmartphoneCpu item)
            {
                MessageBox.Show("Select a row to edit first!", "Empty selection", MessageBoxButtons.OK);
                return;
            }
            using CpuAddForm form = new(item);
            var dialogResult = form.ShowDialog();
            if (dialogResult == DialogResult.OK && form.Cpu != null)
            {
                _context.Upsert(form.Cpu);
                _context.SaveChanges();
            }
        }
    }
}

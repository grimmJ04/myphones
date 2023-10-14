using Microsoft.EntityFrameworkCore;
using Mobiles.Core.Data;

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
            using CpuAddForm form = new(_context);
            form.ShowDialog();
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
        }
    }
}

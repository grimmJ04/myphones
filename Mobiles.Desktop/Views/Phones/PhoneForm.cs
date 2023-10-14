using Microsoft.EntityFrameworkCore;
using Mobiles.Core.Data;

namespace Mobiles.Desktop.Views.Phones
{
    public partial class PhoneForm : Form
    {
        private readonly PhonesDbContext _context;
        private readonly BindingSource _bindingSource = new();

        public PhoneForm()
        {
            _context = Program.GetDbContext();
            InitializeComponent();

            _context.Smartphones.LoadAsync();
            _bindingSource.DataSource = _context.Smartphones.Local.ToBindingList();
            PhonesDataGridView.DataSource = _bindingSource;
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            _context.Dispose();
            base.OnFormClosing(e);
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            using PhoneAddForm form = new(_context);
            form.ShowDialog();
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
        }
    }
}

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
            PhoneDataGridView.DataSource = _bindingSource;
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            _context.Dispose();
            base.OnFormClosing(e);
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            using PhoneAddForm form = new();
            var dialogResult = form.ShowDialog();
            if (dialogResult == DialogResult.OK && form.Phone != null)
            {
                _context.Add(form.Phone);
                _context.SaveChangesAsync();
            }
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            if (PhoneDataGridView.CurrentRow.DataBoundItem is not Smartphone item)
            {
                MessageBox.Show("Select a row to edit first!", "Empty selection", MessageBoxButtons.OK);
                return;
            }
            using PhoneAddForm form = new(item);
            var dialogResult = form.ShowDialog();
            if (dialogResult == DialogResult.OK && form.Phone != null && _context.Smartphones.Find(item.Id) is Smartphone dbItem)
            {
                _context.Smartphones.Entry(dbItem).CurrentValues.SetValues(form.Phone);
                _context.SaveChangesAsync();
                _bindingSource.ResetBindings(false);
            }
        }
    }
}

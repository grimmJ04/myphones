using Mobiles.Core.Data;
using Mobiles.Models;

namespace Mobiles.Desktop.Views.Phones
{
    public partial class PhoneAddForm : Form
    {
        private readonly PhonesDbContext _context;

        public PhoneAddForm(PhonesDbContext context)
        {
            _context = context;
            InitializeComponent();
        }

        private async void SaveButton_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
            var phone = new Smartphone { };
            await _context.AddAsync(phone);
            await _context.SaveChangesAsync();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {

        }
    }
}

using Mobiles.Core.Data;
using Mobiles.Models;

namespace Mobiles.Desktop.Views.Cpus
{
    public partial class CpuAddForm : Form
    {
        private readonly PhonesDbContext _context;

        public CpuAddForm(PhonesDbContext context)
        {
            _context = context;
            InitializeComponent();
        }

        private async void SaveButton_Click(object sender, EventArgs e)
        {
            var phone = new SmartphoneCpu { Name = "best cpu in the whole world", ClockSpeed_MHz = 1500, CoreCount = 6, GpuName = "pepper" };
            await _context.AddAsync(phone);
            await _context.SaveChangesAsync();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {

        }
    }
}

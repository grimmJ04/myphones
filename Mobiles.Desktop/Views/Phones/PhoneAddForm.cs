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
            var phone = new Smartphone { CpuId = 10, BatteryPower_mAh = 3000, InternalMemory_GB = 4096, IsDualSim = true, Ram_MB = 4096, PriceRange = Price.HighCost };
            await _context.AddAsync(phone);
            await _context.SaveChangesAsync();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {

        }
    }
}

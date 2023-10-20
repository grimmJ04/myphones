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
            throw new NotImplementedException();
            var cpu = new SmartphoneCpu { };
            await _context.AddAsync(cpu);
            await _context.SaveChangesAsync();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {

        }
    }
}

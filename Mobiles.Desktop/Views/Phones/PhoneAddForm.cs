namespace Mobiles.Desktop.Views.Phones
{
    public partial class PhoneAddForm : Form
    {
        private readonly int? EditId;
        public Smartphone? Phone { get; private set; }

        public PhoneAddForm(Smartphone? phone = null)
        {
            EditId = phone?.Id;
            InitializeComponent();

            var priceRangeItems = Enum.GetValues<Price>();
            using var context = Program.GetDbContext();
            var cpuItems = context.SmartphoneCpus.ToArray();

            PriceRangeComboBox.DataSource = priceRangeItems;
            CpuComboBox.Items.AddRange(cpuItems);

            if (phone != null)
            {
                InitEditMode(phone);
            }
        }

        private void InitEditMode(Smartphone phone)
        {
            Text = $"Editing phone with id: {phone.Id}";
            TitleLabel.Text = TitleLabel.Text.Replace("Add", "Edit");
            BatteryPowerNumericUpDown.Value = phone.BatteryPower_mAh;
            IsDualSimCheckBox.Checked = phone.IsDualSim;
            InternalMemoryNumericUpDown.Value = phone.InternalMemory_GB;
            RamNumericUpDown.Value = phone.Ram_MB;
            PriceRangeComboBox.SelectedItem = phone.PriceRange;
            using var context = Program.GetDbContext();
            int? selection = null;
            int? cpuId = context.Smartphones.Find(EditId)?.CpuId;
            if (cpuId == null)
            {
                return;
            }
            for (int i = 0; i < CpuComboBox.Items.Count; ++i)
            {
                if (CpuComboBox.Items[i] is SmartphoneCpu item && item.Id == cpuId)
                {
                    selection = i;
                    break;
                }
            }
            if (selection.HasValue)
            {
                CpuComboBox.SelectedIndex = selection.Value;
            }
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            var phone = new Smartphone()
            {
                Id = EditId ?? 0,
                BatteryPower_mAh = Convert.ToInt32(BatteryPowerNumericUpDown.Value),
                IsDualSim = IsDualSimCheckBox.Checked,
                InternalMemory_GB = Convert.ToInt32(InternalMemoryNumericUpDown.Value),
                Ram_MB = Convert.ToInt32(RamNumericUpDown.Value),
                PriceRange = (Price)PriceRangeComboBox.SelectedItem,
                CpuId = (CpuComboBox.SelectedItem as SmartphoneCpu)?.Id ?? 0
            };
            Phone = phone;
        }
    }
}

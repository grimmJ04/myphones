using Mobiles.Models;

namespace Mobiles.Desktop.Views.Cpus
{
    public partial class CpuAddForm : Form
    {
        private readonly int? EditId;
        public SmartphoneCpu? Cpu { get; private set; }

        public CpuAddForm(SmartphoneCpu? cpu = null)
        {
            EditId = cpu?.Id;
            InitializeComponent();
            if (cpu != null)
            {
                InitEditMode(cpu);
            }
        }

        private void InitEditMode(SmartphoneCpu cpu)
        {
            Text = $"Editing cpu with id: {cpu.Id}";
            TitleLabel.Text = "Edit Cpu";
            NameTextBox.Text = cpu.Name;
            CoreCountNumericUpDown.Value = cpu.CoreCount;
            ClockSpeedNumericUpDown.Value = cpu.ClockSpeed_MHz;
            GpuNameTextBox.Text = cpu.GpuName;
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            var cpu = new SmartphoneCpu
            {
                Id = EditId ?? 0,
                Name = NameTextBox.Text,
                CoreCount = Convert.ToInt32(CoreCountNumericUpDown.Value),
                ClockSpeed_MHz = Convert.ToInt32(ClockSpeedNumericUpDown.Value),
                GpuName = GpuNameTextBox.Text
            };
            Cpu = cpu;
        }
    }
}

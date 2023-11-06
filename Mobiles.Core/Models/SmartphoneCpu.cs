using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Mobiles.Core.Models
{
    [Table("smartphone_cpu")]
    public class SmartphoneCpu
    {
        [Key]
        public int Id { get; set; }

        [Required, StringLength(255)]
        public string Name { get; set; } = string.Empty;

        [Required, Range(1, 32), DisplayName("Core Count")]
        public int CoreCount { get; set; }

        [Required, Range(512, 8192), DisplayName("Clock Speed (MHz)")]
        public int ClockSpeed_MHz { get; set; }

        [Required, StringLength(255), DisplayName("Gpu Name")]
        public string GpuName { get; set; } = string.Empty;

        public override string ToString()
        {
            return $"Name: {Name} | " +
                $"Cores: {CoreCount} | " +
                $"Clock: {ClockSpeed_MHz} | " +
                $"Gpu: {GpuName}";
        }
    }
}

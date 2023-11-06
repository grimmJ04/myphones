using CsvHelper.Configuration.Attributes;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Mobiles.Core.Models
{
    [Table("smartphone")]
    public class Smartphone
    {
        [Key]
        public int Id { get; set; }

        [ForeignKey("Cpu"), ScaffoldColumn(false)]
        public int CpuId { get; set; }

        [Required, Range(0, 10_000), DisplayName("Battery Power")]
        public int BatteryPower_mAh { get; set; }

        [Required, DisplayName("Dual Sim?")]
        public bool IsDualSim { get; set; }

        [Required, Range(0, 4096), DisplayName("Internal Memory (GB)")]
        public int InternalMemory_GB { get; set; }

        [Required, Range(0, 16_384), DisplayName("Ram (MB)")]
        public int Ram_MB { get; set; }

        [Required, DisplayName("Price Range")]
        public Price PriceRange { get; set; }

        [Ignore, Browsable(false)]
        virtual public SmartphoneCpu? Cpu { get; set; }
    }
}

using System.ComponentModel.DataAnnotations;

namespace DnDManager.Models
{
    public class LogEntry
    {
        public int Id { get; set; }

        public int RoundNumber { get; set; }

        [Required]
        public string Description { get; set; } = string.Empty;

        public int? DamageOrHealing { get; set; }

        public int EncounterId { get; set; }
        public Encounter? Encounter { get; set; }
    }
}

using System.ComponentModel.DataAnnotations;

namespace DnDManager.Models
{
    public class Encounter.cs
    {
        public int Id { get; set; }

        [Required]
        public string Action { get; set; }

        public int RoundNumber { get; set; }

        public int? DamageOrHealing { get; set; }

        public int EncounterId { get; set; }
        public Encounter? Encounter { get; set; }
    }
}

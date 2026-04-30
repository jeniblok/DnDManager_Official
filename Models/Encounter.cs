using System.ComponentModel.DataAnnotations;

namespace DnDManager.Models
{
    public class Encounter
  {
    public int Id { get; set; }
    public string Name { get; set; }
    public string Outcome { get; set; }

    public int? SessionLogId { get; set; }
    public SessionLog? SessionLog { get; set; }

    public List<LogEntry> LogEntries { get; set; } = new List<LogEntry>();
    }
}

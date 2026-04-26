public class Encounter
{
    public int Id { get; set; }

    public string Name { get; set; } // "Goblin Fight"

    public string Outcome { get; set; } // Win/Loss/Retreated

    public int SessionLogId { get; set; }
    public SessionLog SessionLog { get; set; }

    public List<LogEntry> LogEntries { get; set; }
}

using System;

namespace StatisticsAnalysisTool.Models;

public class CombatEventLogEntry
{
    public string Type { get; set; }
    public string AttackerName { get; set; }
    public string AttackerGuild { get; set; }
    public string VictimName { get; set; }
    public string VictimGuild { get; set; }
    public DateTime Timestamp { get; set; }
    public string CsvOutput { get; set; }
}

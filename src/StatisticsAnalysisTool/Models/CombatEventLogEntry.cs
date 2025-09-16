using StatisticsAnalysisTool.Enumerations;
using System;

namespace StatisticsAnalysisTool.Models;

public class CombatEventLogEntry
{
    public CombatEventLogEntry()
    {
        TimestampUtc = DateTime.UtcNow;
    }

    public DateTime TimestampUtc { get; }
    public string CauserName { get; init; } = string.Empty;
    public string CauserGuild { get; init; } = string.Empty;
    public string AffectedName { get; init; } = string.Empty;
    public string AffectedGuild { get; init; } = string.Empty;
    public HealthChangeType HealthChangeType { get; init; }
    public double HealthChange { get; init; }
    public double NewHealthValue { get; init; }
    public int SpellIndex { get; init; }

    public string CsvOutput => GetCsvOutputString();

    private string GetCsvOutputString()
    {
        return FormattableString.Invariant(
            $"{TimestampUtc:O};{CauserGuild};{CauserName};{AffectedGuild};{AffectedName};{HealthChangeType};{HealthChange};{NewHealthValue};{SpellIndex}");
    }
}

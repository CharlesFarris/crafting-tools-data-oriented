using System.Collections.Immutable;
using SleepingBearSystems.Tools.DataOriented;

namespace SleepingBearSystems.CraftingTools.Domain;

/// <summary>
/// Methods used to support profession data.
/// </summary>
public static class Profession
{
    /// <summary>
    /// Creates a profession record.
    /// </summary>
    /// <param name="id">The ID of the profession.</param>
    /// <param name="name">The name of the profession.</param>
    /// <returns>A record containing the profession.</returns>
    public static ImmutableDictionary<string, object> CreateProfession(string id, string name) =>
        Generic.BeginRecord()
            .AddProperty("id", id)
            .AddProperty("name", name)
            .End();
}

using System.Collections.Immutable;
using SleepingBearSystems.Tools.DataOriented;

namespace SleepingBearSystems.CraftingTools.Domain;

/// <summary>
/// Methods for handling game records.
/// </summary>
public static class Game
{
    /// <summary>
    /// Creates a game record.
    /// </summary>
    /// <param name="id">The game ID.</param>
    /// <param name="name">The name of the game.</param>
    /// <returns>A record containing a game.</returns>
    public static ImmutableDictionary<string, object> CreateRecord(string id, string name) =>
        Record
            .Begin()
            .AddProperty("id", id)
            .AddProperty("name", name)
            .End();
}

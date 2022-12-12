using System.Collections.Immutable;
using SleepingBearSystems.Tools.DataOriented;

namespace SleepingBearSystems.CraftingTools.Domain;

/// <summary>
/// Methods for handling Item records.
/// </summary>
public static class Item
{
    /// <summary>
    /// Creates an item record.
    /// </summary>
    /// <param name="id">The item ID.</param>
    /// <param name="name">The item name.</param>
    /// <param name="gameId">The game ID.</param>
    /// <returns>A record containing an item.</returns>
    public static ImmutableDictionary<string, object> CreateRecord(
        string id,
        string name,
        string gameId) =>
        Record
            .Begin()
            .AddProperty("id", id)
            .AddProperty("name", name)
            .AddProperty("gameId", gameId)
            .End();
}

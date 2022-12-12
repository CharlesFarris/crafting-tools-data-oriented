using SleepingBearSystems.Tools.DataOriented;

namespace SleepingBearSystems.CraftingTools.Domain;

/// <summary>
/// Methods for handling crafting data.
/// </summary>
public static class Crafting
{
    /// <summary>
    /// Gets a profession record from the crafting data.
    /// </summary>
    /// <param name="craftingData">The crafting data.</param>
    /// <param name="professionId">The profession's ID.</param>
    /// <returns>A recording containing the profession.</returns>
    public static object? GetProfession(object craftingData, string professionId) =>
        craftingData
            .AsRecord()
            .Get("professionsById", professionId);
}

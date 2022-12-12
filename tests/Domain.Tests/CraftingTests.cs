using SleepingBearSystems.Tools.DataOriented;

namespace SleepingBearSystems.CraftingTools.Domain.Tests;

/// <summary>
/// Tests for <see cref="Crafting"/>.
/// </summary>
internal static class CraftingTests
{
    [Test]
    public static void GetProfessionById_ValidatesBehavior()
    {
        var record = Crafting.GetProfession(CraftingData, professionId: "2");
        Assert.That(record, Is.Not.Null);
        Assert.Multiple(() =>
        {
            Assert.That(record.Get("id"), Is.EqualTo("2"));
            Assert.That(record.Get("name"), Is.EqualTo("Alchemy"));
            Assert.That(record.Get("gameId"), Is.EqualTo("1"));
        });
    }

    private static readonly object CraftingData = Record
        .Begin()
        .AddProperty("gamesById", Record
            .Begin()
            .AddProperty("1", Game.CreateRecord(id: "1", name: "Generic MMORPG"))
            .End())
        .AddProperty("professionsById", Record
            .Begin()
            .AddProperty("1", Profession.CreateRecord(id: "1", name: "Cooking", gameId: "1"))
            .AddProperty("2", Profession.CreateRecord(id: "2", name: "Alchemy", gameId: "1"))
            // ReSharper disable once StringLiteralTypo
            .AddProperty("3", Profession.CreateRecord(id: "3", name: "Blacksmithing", gameId: "1"))
            .End())
        .End();
}

using SleepingBearSystems.Tools.DataOriented;

namespace SleepingBearSystems.CraftingTools.Domain.Tests;

/// <summary>
/// Tests for <see cref="Game"/>.
/// </summary>
internal static class GameTests
{
    [Test]
    public static void CreateRecord_ValidatesBehavior()
    {
        var record = Game.CreateRecord(id: "1234", name: "Generic MMORPG");
        Assert.That(record, Is.Not.Null);
        Assert.Multiple(() =>
        {
            Assert.That(record.Get("id"), Is.EqualTo("1234"));
            Assert.That(record.Get("name"), Is.EqualTo("Generic MMORPG"));
        });
    }
}

using SleepingBearSystems.Tools.DataOriented;

namespace SleepingBearSystems.CraftingTools.Domain.Tests;

/// <summary>
/// Tests for <see cref="Item"/>.
/// </summary>
internal static class ItemTests
{
    [Test]
    public static void CreateRecord_ValidatesBehavior()
    {
        var record = Item.CreateRecord(id: "1234", name: "Oak Log", gameId: "246");
        Assert.That(record, Is.Not.Null);
        Assert.Multiple(() =>
        {
            Assert.That(record.Get("id"), Is.EqualTo("1234"));
            Assert.That(record.Get("name"), Is.EqualTo("Oak Log"));
            Assert.That(record.Get("gameId"), Is.EqualTo("246"));
        });
    }
}

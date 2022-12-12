using System.Collections.Immutable;
using SleepingBearSystems.Tools.DataOriented;

namespace SleepingBearSystems.CraftingTools.Domain.Tests;

/// <summary>
/// Tests for <see cref="Profession"/>.
/// </summary>
internal static class ProfessionTests
{
    [Test]
    public static void CreateRecord_ValidatesBehavior()
    {
        var record = Profession.CreateRecord(id: "1234", name: "Cooking", gameId: "234");
        Assert.That(record, Is.Not.Null);
        Assert.That(record, Is.TypeOf<ImmutableDictionary<string, object>>());
        Assert.Multiple(() =>
        {
            Assert.That(record.Get("id"), Is.EqualTo("1234"));
            Assert.That(record.Get("name"), Is.EqualTo("Cooking"));
            Assert.That(record.Get("gameId"), Is.EqualTo("234"));
        });
    }
}

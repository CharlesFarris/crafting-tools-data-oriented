using System.Collections.Immutable;
using SleepingBearSystems.Tools.DataOriented;

namespace SleepingBearSystems.CraftingTools.Domain.Tests;

/// <summary>
/// Tests for <see cref="Profession"/>.
/// </summary>
internal static class ProfessionTests
{
    [Test]
    public static void CreateProfession_ValidatesBehavior()
    {
        var record = Profession.CreateProfession("1234", "Cooking");
        Assert.That(record, Is.Not.Null);
        Assert.That(record, Is.TypeOf<ImmutableDictionary<string, object>>());
        Assert.Multiple(() =>
        {
            Assert.That(record.Get("id"), Is.EqualTo("1234"));
            Assert.That(record.Get("name"), Is.EqualTo("Cooking"));
        });
    }
}

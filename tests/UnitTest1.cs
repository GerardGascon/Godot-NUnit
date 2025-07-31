using Project.Domain;

namespace tests;

public class Tests
{
    [Test]
    public void Test1() {
        Experiment sut = new();

        Assert.That(sut.ShouldBeTrue(), Is.True);
    }
}
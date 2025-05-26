using LZK1.Core.Services;

namespace LZK1.Core.Tests;

public class CounterStateTests
{
    [Test]
    public void TestIncrement()
    {
        var state = new CounterState();

        state.Increment();

        Assert.That(state.Count, Is.EqualTo(1));
    }

    [Test]
    public void TestDecrement()
    {
        var state = new CounterState();

        state.Increment();  // Zähler = 1
        state.Decrement();  // Zähler = 0

        Assert.That(state.Count, Is.EqualTo(0));
    }

    [Test]
    public void TestDecrement_DoesNotGoNegative()
    {
        var state = new CounterState();

        state.Decrement();  // Zähler ist 0, darf nicht negativ werden

        Assert.That(state.Count, Is.EqualTo(0));
    }
}
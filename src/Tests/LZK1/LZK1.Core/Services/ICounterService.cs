namespace LZK1.Core.Services;

public interface ICounterService
{
    /// <summary>
    /// Gibt den aktuellen Text-Label-Status zurück.
    /// </summary>
    string GetLabel();

    /// <summary>
    /// Erhöht den Zähler um 1.
    /// </summary>
    void Increment();

    /// <summary>
    /// Fragt per Dialog, ob erhöht werden soll, und erhöht ggf.
    /// </summary>
    Task<bool> TryIncrement();

    /// <summary>
    /// Verringert den Zähler um 1.
    /// </summary>
    void Decrement();

    /// <summary>
    /// Fragt per Dialog, ob verringert werden soll, und verringert ggf.
    /// </summary>
    Task<bool> TryDecrement();
}
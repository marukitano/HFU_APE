namespace LZK1.Core.Services;

public interface ICounterService
{
    /// <summary>
    /// Gibt den aktuellen Text-Label-Status zur�ck.
    /// </summary>
    string GetLabel();

    /// <summary>
    /// Erh�ht den Z�hler um 1.
    /// </summary>
    void Increment();

    /// <summary>
    /// Fragt per Dialog, ob erh�ht werden soll, und erh�ht ggf.
    /// </summary>
    Task<bool> TryIncrement();

    /// <summary>
    /// Verringert den Z�hler um 1.
    /// </summary>
    void Decrement();

    /// <summary>
    /// Fragt per Dialog, ob verringert werden soll, und verringert ggf.
    /// </summary>
    Task<bool> TryDecrement();
}
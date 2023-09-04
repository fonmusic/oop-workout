namespace SuperMarket.Models;

/// <summary>
/// Interface for returning order and money
/// </summary>
public interface IReturnOrder
{
    /// <summary>
    /// Method for returning order
    /// </summary>
    void ReturnOrder();
    /// <summary>
    /// Method for returning money
    /// </summary>
    void MoneyReturn();
}
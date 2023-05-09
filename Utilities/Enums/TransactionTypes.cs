using System.ComponentModel;

namespace Utilities.Enums
{
    /// <summary>
    /// درآمد(1) - هزینه(2)ه
    /// </summary>

    public enum TransactionTypes
    {
        [Description("درآمد")]
        Income = 1,
        [Description("هزینه")]
        Expense = 2,
    }
}

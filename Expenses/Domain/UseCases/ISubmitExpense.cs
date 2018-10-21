using System;

namespace Expenses.Domain.UseCases
{
  public interface ISubmitExpense
  {
    void Execute(Guid userId, string description, long priceWithoutTax, long priceIncludingTax);
  }
}

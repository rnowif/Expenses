using System;

namespace Expenses.Domain.UseCases
{
  public class SubmitExpense : ISubmitExpense
  {
    public void Execute(Guid userId, string description, long priceWithoutTax, long priceIncludingTax)
    {
      throw new NotImplementedException();
    }
  }
}

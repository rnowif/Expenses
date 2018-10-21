using System;

namespace Expenses.Domain.Entities
{
  public class Expense
  {
    public Guid Id { get; }
    public Guid UserId { get; }
    public string Description { get; }
    public long PriceWithoutTax { get; }
    public long PriceIncludingTax { get; }

    public Expense(Guid id, Guid userId, string description, long priceWithoutTax, long priceIncludingTax)
    {
      Id = id;
      UserId = userId;
      Description = description;
      PriceWithoutTax = priceWithoutTax;
      PriceIncludingTax = priceIncludingTax;
    }
  }
}

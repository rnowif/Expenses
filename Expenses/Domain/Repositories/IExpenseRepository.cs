using Expenses.Domain.Entities;

namespace Expenses.Domain.Repositories
{
  public interface IExpenseRepository
  {
    void Create(Expense expense);
  }
}

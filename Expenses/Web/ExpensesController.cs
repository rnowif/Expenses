using System;
using Expenses.Domain.UseCases;
using Microsoft.AspNetCore.Mvc;

namespace Expenses.Web
{
  [Route("api/expenses")]
  [ApiController]
  public class ExpensesController : ControllerBase
  {
    private readonly ISubmitExpense _submitExpense;

    public ExpensesController(ISubmitExpense submitExpense)
    {
      _submitExpense = submitExpense;
    }

    [HttpPost]
    public void SubmitExpense([FromBody] SubmitExpenseCommand expense)
    {
      _submitExpense.Execute(expense.UserId, expense.Description, expense.PriceWithoutTax, expense.PriceIncludingTax);
    }
  }

  public class SubmitExpenseCommand
  {
    public Guid UserId { get; set; }
    public string Description { get; set; }
    public long PriceWithoutTax { get; set; }
    public long PriceIncludingTax { get; set; }
  }
}

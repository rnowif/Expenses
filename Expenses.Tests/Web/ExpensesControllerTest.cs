using System;
using Expenses.Domain.UseCases;
using Expenses.Web;
using Moq;
using NUnit.Framework;

namespace Expenses.Tests.Web
{
  [TestFixture]
  public class ExpensesControllerTest
  {
    private readonly ExpensesController _controller;
    private readonly Mock<ISubmitExpense> _useCase;
    
    public ExpensesControllerTest()
    {
      _useCase = new Mock<ISubmitExpense>();
      _controller = new ExpensesController(_useCase.Object);
    }
    
    [Test]
    public void should_trigger_use_case_when_submit_expenses()
    {
      var expenses = new SubmitExpenseCommand()
      {
        UserId = Guid.NewGuid(),
        Description = "Mobile phone",
        PriceIncludingTax = 1488,
        PriceWithoutTax = 1699
      };

      _controller.SubmitExpense(expenses);
      
      _useCase.Verify(uc => uc.Execute(expenses.UserId, expenses.Description, expenses.PriceWithoutTax, expenses.PriceIncludingTax));
    }
    
  }
}

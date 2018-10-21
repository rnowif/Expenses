using System;
using Expenses.Domain.Entities;
using Expenses.Domain.Repositories;
using Expenses.Domain.UseCases;
using Expenses.Web;
using Moq;
using NUnit.Framework;

namespace Expenses.Tests.Domain.UseCases
{
  [TestFixture]
  public class SubmitExpenseText
  {
    private readonly SubmitExpense _useCase;
    private readonly Mock<IExpenseRepository> _repository;
    
    public SubmitExpenseText()
    {
      _repository = new Mock<IExpenseRepository>();
      _useCase = new SubmitExpense(_repository.Object);
    }
    
    [Test]
    public void should_create_expense_when_execute()
    {
      var userId = Guid.NewGuid();
      _useCase.Execute(userId, "Mobile Phone", 1488, 1699);
      
      _repository.Verify(repo => repo.Create(It.Is<Expense>(
        e => e.UserId == userId 
             && e.Description == "Mobile Phone" 
             && e.PriceWithoutTax == 1488 
             && e.PriceIncludingTax == 1699
      )));
    }
    
  }
}

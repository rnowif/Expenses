using Expenses.Controllers;
using Microsoft.AspNetCore.Mvc;
using NUnit.Framework;

namespace Expenses.Tests.Controllers
{
  [TestFixture]
  public class ValuesControllerTest
  {
    private readonly ValuesController _controller;
    
    public ValuesControllerTest()
    {
      _controller = new ValuesController();
    }
    
    [Test]
    public void Get_WhenCalled_ReturnsOkResult()
    {
      // Act
      var okResult = _controller.Get().Result;
 
      // Assert
      Assert.IsInstanceOf<OkObjectResult>(okResult);
      
      var result = (OkObjectResult) okResult;
      Assert.AreEqual(new string[] {"value1", "value2"}, result.Value);
    }
  }
}

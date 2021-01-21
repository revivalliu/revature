using PizzaBox.Domain.Models;
using Xunit;

namespace PizzaBox.Testing
{
  public class SizeTests
  {
    [Fact]
    private void Test_SizeExists()
    {
      // arrange
      var sut = new Size("Small", 5); // inference

      // act
      var actual = sut;

      // assert
      Assert.IsType<Size>(actual);
      Assert.NotNull(actual);
    }
  }
}

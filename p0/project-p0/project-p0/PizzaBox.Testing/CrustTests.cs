using PizzaBox.Domain.Models;
using Xunit;

namespace PizzaBox.Testing
{
  public class CrustTests
  {
    [Fact]
    private void Test_CrustExists()
    {
      // arrange
      var sut = new Crust("NewYork Style", 6); // inference

      // act
      var actual = sut;

      // assert
      Assert.IsType<Crust>(actual);
      Assert.NotNull(actual);
    }
  }
}

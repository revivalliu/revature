using PizzaBox.Domain.Models;
using Xunit;

namespace PizzaBox.Testing
{
  public class PizzaTests
  {
    [Fact]
    private void Test_PizzaExists()
    {
      // arrange
      var sut = new MeatPizza(); // inference

      // act
      var actual = sut;

      // assert
      Assert.IsType<MeatPizza>(actual);
      Assert.NotNull(actual);
    }
    [Fact]
    private void Test_VeggiePizzaExists()
    {
      // arrange
      var sut = new VeggiePizza(); // inference

      // act
      var actual = sut;

      // assert
      Assert.IsType<VeggiePizza>(actual);
      Assert.NotNull(actual);
    }
  }
}

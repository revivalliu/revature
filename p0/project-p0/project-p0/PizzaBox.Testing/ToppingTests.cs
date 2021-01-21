using PizzaBox.Domain.Models;
using Xunit;

namespace PizzaBox.Testing
{
  public class ToppingTests
  {
    [Fact]
    private void Test_ToppingExists()
    {
      // arrange
      var sut = new Topping("Pineapple", 4); // inference

      // act
      var actual = sut;

      // assert
      Assert.IsType<Topping>(actual);
      Assert.NotNull(actual);
    }
    [Fact]
    private void Test_Topping()
    {
      Topping topping1 = new Topping();
      topping1.Name = "Pineapple";
      Assert.Equal("Pineapple", topping1.Name);

    }
  }
}

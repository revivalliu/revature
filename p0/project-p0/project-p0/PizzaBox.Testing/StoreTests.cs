using PizzaBox.Domain.Models;
using Xunit;

namespace PizzaBox.Testing
{
  public class StoreTests
  {
    [Fact]
    private void Test_StoreExists()
    {
      // arrange
      var sut = new Store(); // inference

      // act
      var actual = sut;

      // assert
      Assert.IsType<Store>(actual);
      Assert.NotNull(actual);
    }
   [Fact]
    private void Test_StoreName()
    {
      Store store1 = new Store();
      store1.Name = "Domino";
      Assert.Equal("Domino", store1.Name);

    }
  }
}

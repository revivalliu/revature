using PizzaBox.Domain.Models;
using Xunit;

namespace PizzaBox.Testing
{
  public class UserTests
  {
    [Fact]
    private void Test_UserExists()
    {
      // arrange
      var sut = new User(); // inference

      // act
      var actual = sut;

      // assert
      Assert.IsType<User>(actual);
      Assert.NotNull(actual);
    }
    [Fact]
    private void Test_UserName()
    {
      User user1 = new User();
      user1.Name = "Seraphina";
      Assert.Equal("Seraphina", user1.Name);

    }
  }
}

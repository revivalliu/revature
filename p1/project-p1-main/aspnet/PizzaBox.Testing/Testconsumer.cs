using UnitTest.Controllers;    
using Xunit;    
    
namespace PizzaBox.Testing    
{    
    public class TestCustomerController  
    {    
        [Fact]    
        public void Test1()    
        {    
            CustomerController user = new CustomerController();    
            string result = home.GetEmployeeName(1);    
            Assert.Equal("Jignesh", result);    
        }    
    }    
}    

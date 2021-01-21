using System;
using PizzaBox.Domain.Models;


namespace PizzaBox.Client
{
  public class StoreView
  {
    private static SqlClient _sql = new SqlClient();
    public void StoreViewMenu(Store store)
    {
      var exit = false;
      do
      {
        System.Console.WriteLine("\n=======Welcome to store view=======");
        System.Console.WriteLine("1: View placed orders");
        //RevenueByWeek
        System.Console.WriteLine("2: View Revenue By Week");
        System.Console.WriteLine("3: Exit");

        int selection;
        int.TryParse(Console.ReadLine(), out selection);

        switch (selection)
        {
          case 1:
   
            break;

          case 2:
            //exit = true;
            System.Console.WriteLine("\nView Revenue By Week!");
            break;
          case 3:
            exit = true;
            System.Console.WriteLine("\nBye-bye!");
            break;
        }
      } while (!exit);
    }
  }
}

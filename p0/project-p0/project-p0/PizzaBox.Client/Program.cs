using System;
using System.Collections.Generic;
using System.Linq;
using PizzaBox.Domain.Models;
using PizzaBox.Domain.Singletons;

namespace PizzaBox.Client
{
  class Program
  {
    private static readonly ClientSingleton _client = ClientSingleton.Instance;
    private readonly ClientSingleton _client2;
    private static readonly SqlClient _sql = new SqlClient();

    public Program()
    {
      _client2 = ClientSingleton.Instance;
    }

    static void Main(string[] args)
    {
            System.Console.WriteLine("====Welcome to Pizza Box!======");
            System.Console.WriteLine("Please choose from below");
            System.Console.WriteLine("1: User");
            System.Console.WriteLine("2: Store");
            System.Console.WriteLine("3: Exit");

            int s;
            int.TryParse(Console.ReadLine(), out s);
            string username;

            switch (s)
            {
                //user
                case 1:
                    System.Console.Write("Please enter your name: ");
                    username = Console.ReadLine();
                    System.Console.WriteLine($"\nYou entered {username}!");

                    UserView(username);

                    break;

                // store
                case 2:
                    System.Console.Write("Please choose your store: \n");
                    
                    var storeList = _sql.ReadStores(); // get store from database
                   
                    for (int i = 0; i<storeList.Count(); i++)
                    {
                        System.Console.WriteLine($"{i + 1}: {storeList.ElementAt(i)}");
                          
                    }
                    int pizzastore;
                    System.Console.Write("Let's go to store# : ");
                    int.TryParse(Console.ReadLine(), out pizzastore);

                    var store = storeList.ElementAt(pizzastore - 1); // select a store to order from
                    System.Console.WriteLine($"\nStarting the store view for {store}");    
                    StoreViewMenu(store);                   
                    break;
            }
    }

    static void PrintAllStores()
    {
      foreach (var store in _client.Stores)
      {
        System.Console.WriteLine(store);
      }
    }

    static void PrintAllStoresWithEF()
    {
      foreach (var store in _sql.ReadStores())
      {
        System.Console.WriteLine(store);
      }
    }
   
    public static void StoreViewMenu(Store store)
    {
      var exit = false;
      do
      {
        System.Console.WriteLine("\n=======Welcome to store view=======");
        System.Console.WriteLine("1: View placed orders");
        System.Console.WriteLine("2: View Revenue By Week");
        System.Console.WriteLine("3: Go back/Exit");

        int selection;
        int.TryParse(Console.ReadLine(), out selection);
        var orderlist = _sql._db.Orders.ToList(); //(user);
       //decimal total = 0;
        switch (selection)
        {
          case 1:

            int j = 1;
            for (int i = 0; i < orderlist.Count(); i++)
            {
              decimal p = orderlist.ElementAt(i).Price;

              if (p != 0 && orderlist.ElementAt(i).Store.Name == store.Name)
              {
                System.Console.WriteLine("-------------------------------------------------------------");
                                         
                System.Console.WriteLine($"| {j} | Date: {orderlist.ElementAt(i).DateOrdered} | {orderlist.ElementAt(i).Store.Name} | Price: $ {orderlist.ElementAt(i).Price} |");
                //t = t + p;
                j = j+1;
              }

            }
            System.Console.WriteLine("-------------------------------------------------------------");
            break;

          case 2:
            //exit = true;
            System.Console.WriteLine("\nView Revenue By Week!");
            //var orderlist = _sql._db.Orders.ToList(); //(user);
            decimal t = 0;
            for (int i = 0; i < orderlist.Count(); i++)
            {
              decimal p = orderlist.ElementAt(i).Price;

              //System.Console.WriteLine($"010101xxxxxxxxxx {p}");
              if (p != 0 && orderlist.ElementAt(i).Store.Name == store.Name)
              {
                //System.Console.WriteLine($"{i + 1}: {orderlist.ElementAt(i).DateOrdered}, {orderlist.ElementAt(i).Store.Name}, {orderlist.ElementAt(i).Price} ");
                t = t + p;
              }
            }
            System.Console.WriteLine($"During last week, Store {store.Name}'s total revenue is $ {t}.");
            break;
          case 3:
            exit = true;
            System.Console.WriteLine("\nBye-bye!");
            break;
        }
      } while (!exit);
    }

        public static void UserView(string username)
        {
            var exit = false;
            do
            {
                System.Console.WriteLine("====Welcome to the user interface======");
                System.Console.WriteLine("\nWhat would you like to do? ");
                System.Console.WriteLine("1: Place an order");
                System.Console.WriteLine("2: View order history");
                System.Console.WriteLine("3: Exit.");

                int selection;
                int pizzastore;
                int.TryParse(Console.ReadLine(), out selection);
                User user = new User(username);

                switch (selection)
                {
                    // order pizzas option
                    case 1:
                        System.Console.WriteLine("====Place your order======");
                        System.Console.WriteLine("Please choose your favorite store:");
             
                    var storeList = _sql.ReadStores(); // get store from database           
                    
                    for (int i = 0; i<storeList.Count(); i++)
                    {
                        System.Console.WriteLine($"{i + 1}: {storeList.ElementAt(i)}");
                            
                    }
                    int.TryParse(Console.ReadLine(), out pizzastore);

                    var store = storeList.ElementAt(pizzastore - 1); // select a store to order from

                        // sync data: order save, store save, and so on.
                        System.Console.WriteLine($"\n=======Starting placing an ordering from {store}=======");
                        System.Console.WriteLine($"\n=======Menu of {store}======");
                        System.Console.WriteLine("Would you like to try today's sepcials?");
                        System.Console.WriteLine("Large meat pizza ................ ONLY ... $10");
                        System.Console.WriteLine("Large veggie pizza ............... ONLY ... $8");
                        System.Console.WriteLine("Customized pizza ....................Starting from ... $12");
                        System.Console.WriteLine("How many meat pizzas do you want? Enter 0 for none.");
                        int numMeatPizza;
                        int.TryParse(Console.ReadLine(), out numMeatPizza);
                        System.Console.WriteLine("How many veggie pizzas do you want? Enter 0 for none.");
                        int numVegiePizza;
                        int.TryParse(Console.ReadLine(), out numVegiePizza);
                        System.Console.WriteLine("How many Customized pizzas do you want? Enter 0 for none.");
                        int numCusPizza;
                        int.TryParse(Console.ReadLine(), out numCusPizza);
                        int numPizza = numMeatPizza + numVegiePizza + numCusPizza;
                        decimal p = numMeatPizza * 10 + numVegiePizza * 8 + numCusPizza * 12;
                        System.Console.WriteLine($"You ordered {numPizza} pizzas and your total is ${p}. Enjoy.");
                        
                        var dat1 = DateTime.UtcNow;;
                        
                        Order o = new Order(user, p, store);
                        //////o.MakeMeatPizza();
                        ///// o.MakeVeggiePizza();
                        //update oder table
                     
                        _sql._db.Orders.Add(o);
                        _sql._db.SaveChanges();

                        store.Orders.Add(o);
                        store.CreateOrder(); // create an order

                        _sql._db.SaveChanges();

                        user.SelectedStore = store;
                        user.Order = o;
                        _sql._db.Users.Add(user); 
                        _sql._db.SaveChanges(); 

                        System.Console.WriteLine();
                        
                        break;
                    // view order history for user
                    case 2:
                        ViewOrderHistory(user);
                        break;
                    // exit application
                    case 3:
                        exit = true;
                        System.Console.WriteLine("\nExit!");
                        break;
                }
            } while (!exit);
        }

        public static void ViewOrderHistory(User user)
         {
         
            System.Console.WriteLine($"The orders history for {user.Name}");
            var orderlist = _sql._db.Orders.ToList(); //(user);
            decimal t = 0;
            for (int i = 0; i<orderlist.Count(); i++)
             {
                decimal p = orderlist.ElementAt(i).Price;
          
                        //System.Console.WriteLine($"010101xxxxxxxxxx {p}");
                        if(p!=0 ) {
                            System.Console.WriteLine($"{i + 1}: {orderlist.ElementAt(i).DateOrdered}, {orderlist.ElementAt(i).Store.Name}, {orderlist.ElementAt(i).Price} ");
                            t = t+p;
                        }
             }
            System.Console.WriteLine($"Last 7 days User {user.Name} ordered ${t} in total.");
          }

        // add a single pizza to an order
        private static void SelectPizza(User user, Store store)
        {
            ///store.ViewMenu();

            do
            {
                int selection;
                System.Console.Write("\n Choose from our sepcial pizza of the day or create your own: ");
                int.TryParse(Console.ReadLine(), out selection);
                System.Console.WriteLine("1: MeatPizza");
                System.Console.WriteLine("2: Customized");
                switch (selection)
                {
                    // order pizzas option
                    case 1:
                            //user.Orders.Last().MakeMeatPizza();
                            System.Console.WriteLine("Meat Pizza!");
                        break;
                // create base pizza from user selection
                    case 2:

                            store.CreateOrder();
                            _sql.Update();

                            break;
                }
                
                return;

            } while (true);
        }
    }
  }

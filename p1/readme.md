#Project Description

Pizza Parlor is a online pizza ordering application for both customers and stores. Customers can choose from their favorite store and make their own custom pizza. In addition, check out their order history and review all your previous orders. The stores can also use it for manage their orders and sales.

##Technologies Used

.NET Core - ASP.NET Core MVC
.NET Core - C#
.NET Core - EF + SQL
.NET Core - xUnit

##List of features

Customers can access this application through a web browser.
Select from a list of stores to order from.
Create a custom pizza in term of selecting its size, crust type, and toppings.
Shows your pizzas into a list to ensure it's correct.
Add and remove pizzas to your current order.
Review your past order history for all stores.

##To-Do list:

Add validation to prevent more than 5 toppings to be added to a pizza.
Better routing to prevent data objects from being passed through the URL
Allow filtering of orders by store and date for users.
Implement a user authentication system to prevent people with the same name to access the same account.

##Getting Started
git clone git@github.com:revivalliu/revature/new/master/p1
dotnet build aspnet
dotnet run aspnet/PizzaBox.Client/PizzaBox.Client.csproj

#Usage
After the application is running, in a web browser go into http://localhost:5000. At the login screen you can enter your name and click login. Select Place Order and select from a list of stores.

At the ordering screen, you must select a Crust and Size for your pizza. Optionally, you can select any number of toppings. When your pizza is done, you can click the Add Pizza button and your order will appear on the right side.

These are your pizzas and you can select either to finish your order or remove any pizzas. When you're done with your order you can click the Finish Order. This will bring you a page telling you that your order has been placed. You cannot make another order until 2 hours has passed.

The View History button lets you see all your orders placed starting with your first order. These orders will list their cost, the store it was ordered from, and the list of pizzas from the order.

Finally you can click logout to exit back to the login screen.

###License
This project uses the following license: MIT

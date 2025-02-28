-----------------------------------SQL--------------------------------------------
Database normalization is about organizing tables to:

Avoid duplicate data : Store each data only once.
Ensure data consistency: Changes for data in one place update everywhere automatically.

In the schema:

Categories table separates category names from Products, reducing repetition.
OrderDetails calculates SubTotal in queries instead of storing it, keeping data consistent.

To make queries faster:

Indexes : Added on columns that are searched often, like UserName and OrderDate.
JOINs : Used to connect tables efficiently.
GROUP BY : Used to calculate totals.
LIMIT : Shows only the top results to speed up queries.
EXPLAIN : Checks how query runs and finds slow parts.
Stored Procedures : Handle complex tasks efficiently.
Triggers : Automatically update stock when an order is placed.
-----------------------------------.NET CORE --------------------------------------------

1. Model
Purpose: Manages data and business logic.
Example: Classes like User, Product, and Order.
2. View
Purpose: Displays the data to the user.
Example: .cshtml files (like Index.cshtml, Purchases.cshtml).
3. Controller
Purpose: Handles user requests and controls the flow of the application.
Example: ProductController, OrderController.

How It Works Together:
User Action → Controller → Model → View → User
----------------------------------- Java --------------------------------------------



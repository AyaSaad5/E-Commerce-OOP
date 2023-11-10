# E-Commerce-OOP with OOP in C#
E-commerce management system is a platform that helps businesses to manage their online store. it demonstrates the use of Object-Oriented Programming (OOP) principles.
It provides a central place to track products, customers, orders, and shipping.

## Features

- Product Management: Create, update, and display products with information such as name, price, and quantity.
- Shopping Cart: Add and remove products from the shopping cart, calculate the total price, and display the cart contents.
- Customer Management: Create and update customer information, mark customers as deleted (inactive), and retrieve customer details.
- Order Creation: Create orders from the items in a shopping cart, calculate order totals, and display order details.

## Project Structure

- we divide our solution into 3 project (3 layers).
  - Data Access layer: in this layer we declared our entities(Pesrson, Customer, Product, Category, Brand, CartProduct, ShoppingCart, OrderDetails, OrderStatus, Carrier).
  - 
  - Business Logic layer: in this layer we created 2 folders, one for Generic Interface and another for Repository which include :
     ShoppingCartRepository.cs: Class managing the shopping cart and its functionality.
     CustomerRepository.cs: Class managing customer data.
     OrderRepository.cs: Class representing an order.
     ProductRepository.cs: Class to manage CartProduct fuctionality.
    
  - Presentation layer: This layer is responsible for the user interface . It receives user input, validates it, and sends it to the next layer.
    in our project PL layer is a console.

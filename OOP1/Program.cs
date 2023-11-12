using System;
using OOP1;

NewMethod();

static void NewMethod()
{
    Product product1 = new Product();
    product1.Id = 1;
    product1.CategoryId = 2;
    product1.ProductName = "Masa";
    product1.UnitPrice = 500;
    product1.UnitsInStock = 3;

    Product product2 = new Product { Id = 2, CategoryId = 5,
    = 5, ProductName = "kalem", UnitPrice = 35 };

    ProductManager productManager = new ProductManager();
    productManager.Add(product1);
    Console.WriteLine(product1.ProductName);




}


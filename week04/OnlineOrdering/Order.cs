using System;
using System.Collections.Generic;

public class Order
{
    private List<Product> _orderList = new List<Product>();
    private Customer _customer;

    public Order(Customer customer)
    {
        _customer = customer;
    }

    public void AddProduct(Product product)
    {
        _orderList.Add(product);
    }

    public decimal CalculateTotalPrice()
    {
        decimal total = 0;
        foreach (var product in _orderList)
        {
            total += product.GetTotalCost();
        }

        decimal shippingCost;
        if (_customer.LivesInUSA())
        {
            shippingCost = 5;
        }
        else
        {
            shippingCost = 35;
        }

        return total + shippingCost;
    }

    public string GetPackingLabel()
    {
        string packingLabel = "";
        foreach (var product in _orderList)
        {
            packingLabel += product.DisplayProduct();

        }
        return packingLabel.Trim();
    }

    public string GetShippingLabel()
    {
       
        return _customer.DisplayCustomer();
    }
}
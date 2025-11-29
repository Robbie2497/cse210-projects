using System;
using System.Reflection.Emit;

public class Order
{
    private List<Product> _products;
    private Customer _customer;

    public Order(List<Product> products, Customer customer)
    {
        _products = products;
        _customer = customer;
    }

    public double GetOrderCost()
    {
        double cost = 0;
        foreach (Product product in _products)
        {
            cost += product.GetTotalCost();
        }

        if (_customer.LivesInUSA())
        {
            cost += 5;
            Console.WriteLine("Shipping: $5");
        } 
        else
        {
            cost += 35;
            Console.WriteLine("Shipping: $35");
        }

        return cost;
    }

    public string GetPackingLabel()
    {
        string label = "Packing Label: \n";

        foreach (Product product in _products)
        {
            label += $"Id: {product.GetProductId()} Name: {product.GetName()} \n";
        }

        return label;
    }

    public string GetShippingLabel()
    {
        string label = "Shipping Label: \n";
        label += $"{_customer.GetCustomerName()} \n";
        label += _customer.GetAddressString();

        return label;
    }

}
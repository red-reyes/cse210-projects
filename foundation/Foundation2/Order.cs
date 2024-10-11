using System;
using System.Collections.Generic;

public class Order
{
    private List<Product> _products;
    private Customer customer;
    private int _usaFee = 5;
    private int _internationalFee = 35;

    //constructor
    public Order(List<Product> Products, Customer Customer, int UsaFee, int InternationalFee)
    {
        _products = Products;
        customer = Customer;
        _usaFee = UsaFee;
        _internationalFee = InternationalFee;
    }

    public List<Product> GetProducts()
    {
        return _products;
    }
    public string GetPackingLabel()
    {
        string packingLabel = "PACKING LABEL\n";
        foreach (Product product in _products)
        {
            packingLabel += product.GetProductDetails()+"\n";
        }
        return packingLabel;
    }

    public string GetShippingLabel()
    {
        string shippingLabel = "SHIPPING LABEL\n";
        shippingLabel += $"Customer Name: {customer.GetCustomerName()}\nAddress: {customer.GetShippingAddress()}";
        return shippingLabel;
    }

    public int GetShippingFee()
    {
        int shippingFee = 0;
        if (customer.isInUsa)
        {
            shippingFee = 5;
        }
        else
        {
            shippingFee = 35;
        }
        return shippingFee;
    }
    
       public double GetTotalCost()
    {
        //initialize totalcost
        double totalCost = 0;
        //product1 price*quantity = OrderCost
       foreach (Product product in _products)
       {
        totalCost += product.GetOrderCost();
       }
       return totalCost;
    }

    //totalCost + shipping fee
    public double GetFinalCost()
    {
       return GetTotalCost() + GetShippingFee();
    }


}
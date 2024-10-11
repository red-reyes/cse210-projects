using System;

public class Product
{
    //private fields
    private string _name;
    private string _productId;
    private double _price;
    private int _quantity;
    

    //constructors
    public Product(string Name, string ProductId, double Price, int Quantity)
    {
        _name = Name;
        _productId = ProductId;
        _price = Price;
        _quantity = Quantity;
    }
    //methods
    public string GetName()
    {
        return _name;
    }
    public string GetProductId()
    {
        return _productId;
    }
    public double GetPrice()
    {
        return _price;
    }
    public int GetQuantity()
    {
        return _quantity;
    }
    /*
    The total cost of this product is computed by : 
    ***price per unit * quantity*** 
    */
    public double GetOrderCost()
    {
        return _price * _quantity;
    }
    public string GetProductDetails()
    {
        return $"{GetName()} {GetProductId()} {GetPrice()} {GetQuantity()} {GetOrderCost()}";
    }
}
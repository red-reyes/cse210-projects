using System;

public class Customer
{
    private string _customerName;
    private Address _shippingAddress;

    public Customer( string CustomerName, Address ShippingAddress)
    {
        _customerName = CustomerName;
        _shippingAddress = ShippingAddress;

    }
    public string GetCustomerName()
    {
        return _customerName;
    }

    public string GetShippingAddress()
    {
        return _shippingAddress.GetFullAddress();
    }
    public bool isInUsa
    {
        get
        {
        return _shippingAddress.GetCountry().ToLower() == "usa";
        }
    }
}
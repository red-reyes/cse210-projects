using System;

public class Address
{
    private string _street;
    private string _city;
    private string _state; //or province
    private string _country;

    public Address(string Street, string City, string State, string Country)
    {
        _street = Street;
        _city = City;
        _state = State;
        _country = Country;
    }
    public string GetStreet()
    {
        return _street;
    }
    public string GetCity()
    {
        return _city;
    }
    public string GetState()
    {
        return _state;
    }
    public string GetCountry()
    {
        return _country;
    }
    //check address if within the US or not
    public bool isInUsa()
    {
        return _country.ToLower() == "usa";
    }
    /*
    ***The address should have a method to return a string all of its fields together in one string (with newline characters where appropriate)***
    */
    public string GetFullAddress()
    {
        return $"{_street}, {_city}, {_state}\nCountry: {_country}";
    }
}
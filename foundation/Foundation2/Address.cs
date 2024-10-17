using System;

public class Address 
{
    private string _streetAddress;
    private string _city;
    private string _state;
    private string _country;

    public Address()
    {
    }

    public bool GetUSA() 
    {
        if (_country == "USA")
        {
            return true;
        }
        else if (_country == "US")
        {
            return true;
        } 
        else if (_country == "United States")
        {
            return true;
        }
        else
        {
            return false;
        }
    } 

    public string GetAddress()
    {
        return($"Address: {_streetAddress}, {_city}, {_state}, {_country}");
    }

    public void SetAddress(string address, string city, string state, string country)
    {
        _streetAddress = address;
        _city = city;
        _state = state;
        _country = country;
    }
}
using System;

public class Customer
{
    private string _name;
    private Address  _address = new Address();

public Customer()
{
}

public bool InUSA()
{
    return _address.GetUSA();
}

public string GetName()
{
    return _name;
}

public string GetAddress()
{
    return _address.GetAddress();
}

public void SetName(string name)
{
    _name = name;
}

public void SetAddress(string address, string city, string state, string country)
{
    _address.SetAddress(address, city, state, country);
}
}
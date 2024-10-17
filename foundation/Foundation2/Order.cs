using System;

public class Order
{
    private Customer _customer = new Customer();

    private List<Product> _products = new List<Product>();

public string GetPackingLabel()
{
    string packLabel="";
    int order = 1;

    foreach (Product product in _products)
    {
        packLabel += $"{order}.{product.GetPack()}\n";
        order++; 
    }
    return packLabel;
}

public string GetShippingLabel()
{
    return($"Name:{_customer.GetName()}\n{_customer.GetAddress()}");
}

public double GetShippingCost()
{
    if (_customer.InUSA())
    {
        return 5;
    } 
    else
    {
        return 35;
    }
}

public double GetTotal()
{
    double sum = 0;

    foreach (Product product in _products)
    {
        sum += product.GetProductCost();
    }
    sum += GetShippingCost();
    return sum;
}

public void SetName(string name)
{
    _customer.SetName(name);
}

public void SetAddress(string address, string city, string state, string country)
{
    _customer.SetAddress(address, city, state, country);
}

public void AddList(Product product)
{
    _products.Add(product);
}
}
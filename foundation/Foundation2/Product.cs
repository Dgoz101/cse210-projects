using System;

public class Product
{
    private string _name;
    private string _productId;
    private double _price;
    private double _quantity;

public Product()
{
}

public Product(string name, string id, double price, double quantity)
{
    _name = name;
    _productId = id;
    _price = price;
    _quantity = quantity;
}

public double GetProductCost()
{
    return _price * _quantity;
}

public void SetProduct(string name, string id, double price, double quantity)
{
    _name = name;
    _productId = id;
    _price = price;
    _quantity = quantity;
}

public string GetPack()
{
    return($"ID:Name-> {_productId}:{_name}");
}
}
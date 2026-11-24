using System;

class Product
{
    private string _name;
    private int _id;
    private float _price;
    private int _quantity;


    public Product(string name, int id, float price, int quantity)
    {
        _name = name;
        _id = id;
        _price = price;
        _quantity = quantity;
    }

    public string GetValues()
    {
        string allText;

        allText = $"Product: {_name} | ID: {_id.ToString()} | Quantity: {_quantity.ToString()} \n";

        return allText;
    }

    public float GetTotalCost()
    {
        float total;
        total = _price * _quantity;
        return total;
    }
}

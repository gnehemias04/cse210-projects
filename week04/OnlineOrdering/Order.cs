using System;

class Order
{
    private Customer _customer;
    private List<Product> _products = new List<Product>();


    public Order(Customer customer)
    {
        _customer = customer;
    }


    public void AddProduct(Product product)
    {
        _products.Add(product);
    }
    private string PackingLabel()
    {
        string packing = "";

        foreach (Product product in _products)
        {
            packing = packing + product.GetValues();
        }
        return packing;
    }
    private string ShippingLabel()
    {
        string shipping = _customer.GetName() + "\n" + _customer.GetAddress().GetValues();

        return shipping;
    }
    private float TotalPrice()
    {
        float totalPrice = 0;
        bool usa;

        foreach (Product product in _products)
        {
            totalPrice = totalPrice + product.GetTotalCost();
        }

        usa = _customer.LivesUsa();
        if (usa)
        {
            totalPrice = totalPrice + 5;
        }
        else
        {
            totalPrice = totalPrice + 35;
        }


        return totalPrice;
    }

    public string GetOrder()
    {
        string allText;
        string productValues = "";
        foreach (Product product in _products)
        {
            productValues = productValues + product.GetValues();
        }

        allText = $"Order \nPacking Label:\n{PackingLabel()}\n\nShipping Label:\n{ShippingLabel()}\n\nTotal Price : {TotalPrice()}";


        return allText;
    }


}

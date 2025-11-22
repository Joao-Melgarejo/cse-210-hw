using System;

class Order
{
    private List<Product> _products;
    private Customer _customer;
    private double USA_SHIPPING_COST = 5.0;
    private double INTERNATIONAL_SHIPPING_COST = 35.0;
   
   public Order(Customer customer)
    {
        _products = new List<Product>();
        _customer = customer;
    }
    public void AddProduct(Product product)
    {
        _products.Add(product);
    }
    public double GetTotalPrice()
    {
        double ProductTotalCost = 0;
        foreach(Product product in _products)
        {
            ProductTotalCost += product.GetTotalCost();
        }
        double ShippingCost;
        if (_customer.GetLiveInUsa())
        {
            ShippingCost = USA_SHIPPING_COST;
        }
        else
        {
            ShippingCost = INTERNATIONAL_SHIPPING_COST;
        }
        return ProductTotalCost + ShippingCost;
    }
    public string GetPackingLabel()
    {
        string packingLabel = "Packing Label:\n";
        foreach (var product in _products)
        {
            packingLabel += $"{product.GetName()} (ID: {product.GetProductID()})\n";
        }
        return packingLabel;
    }
    public string GetShippingLabel()
    {
        return $"Shipping Label:\n{_customer.GetCustomerName()}\n{_customer.GetAddress().GetFullAddress()}";
    }
}
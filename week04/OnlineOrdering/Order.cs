public class Order
{
    public List<Product> _oderList = new List<Product>();
    public Customer customer;

    public Order(Customer customer)
    {
        this.customer = customer;
    }

    public void AddProduct(Product product)
    {
        _oderList.Add(product);
    }
    public decimal CalculateTotalPrice()
    {
        decimal total = 0;
        foreach (var product in _oderList)
        {
            total += product.GetTotalCost();
        }
        decimal shippingCost;
        if (customer.Address.USACitizen())
        {
            shippingCost = 5;
        }
        else
        {
            shippingCost = 35;
        }
 
        return total + shippingCost;
    }

    public string GetPackingLabel()
    {
        string packingLabel = "";
        foreach (var product in _oderList)
        {
            packingLabel += $"{product._name} (ID: {product._productID})\n";
        }
        return packingLabel.Trim();
    }

    public string GetShippingLable()
    {
        return $"{customer._name}\n{customer.Address.GetAddress()}";
    }
}
public class Product
{
    private string _name;
    private int _productID;
    private decimal _price;
    private int _quantity;

    public Product(string name, int productID, int price, int quantity)
    {
        _name = name;
        _productID = productID;
        _price = price;
        _quantity = quantity;
    }
    public decimal GetTotalCost()
    {
        return _price * _quantity;
    }

    public string DisplayProduct()
    {
        return $"{_name}, ID: ({_productID})";
    }
    
}
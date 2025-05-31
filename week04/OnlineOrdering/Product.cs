public class Product
{
    public string _name;
    public int _productID;
    public decimal _price;
    public int _quantity;

    public Product(string name, int productID, decimal price, int quantity)
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

    public void Display()
    {
        
    }
}
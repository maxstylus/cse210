public class Product
{
    private string _name = "";
    private int _productId = 0;
    private int _price = 0;
    private int _productQuanity = 0;
    public Product(string name, int productId, int price, int productQuantity)
    {
        _name = name;
        _productId = productId;
        _price = price;
        _productQuanity = productQuantity;
    }

    public int getProductPrice()
    {
        return _price * _productQuanity;
    }

    public string getCustomerName()
    {
        return _name;
    }

    public int  getProductId()
    {
        return _productId;
    }
}
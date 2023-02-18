public class Order
{

    private List<Product> _productsOrdered = new List<Product>();

    private Customer _customer;

    private int _totalPrice = 0;

    private const int USA_COST = 5;
    private const int INT_COST = 35;
    
    public Order(Customer customer, List<Product> productsOrdered)
    {
        _customer = customer;
        _productsOrdered = productsOrdered;
    }

    public int getTotalOrderCost()
    {
        // total price is calculated as the sum of the prices of each product plus a one-time shipping cost.
        // If the customer lives in the USA then shipping cost is $5 otherwise shipping cost is $35.
        int subtotal = 0;
        foreach (Product product in _productsOrdered)
        {
            subtotal += product.getProductPrice();
        }

        if (_customer.isUSA() == true)
        {
            _totalPrice = subtotal + USA_COST;
        }
        else
        {
            _totalPrice = subtotal + INT_COST;
        }

        return _totalPrice;
    }

    public void displayOrderTotal()
    {
        int price = getTotalOrderCost();
        Console.WriteLine($"\nTotal Price: {price}");

    }

    public List<string> getPackingLabels()
    {
        // Packing Label is the: name and productId for each product in the order. 
         List<string> packingLabels = new List<string>();

        foreach (Product product in _productsOrdered)
        {
            string name = product.getCustomerName();
            int productId = product.getProductId();

            packingLabels.Add($"\n{name}: {productId.ToString()}");
        }

        return packingLabels;
    }

    public void displayPackingLabels(List<string> packingLabels)
    {
        Console.WriteLine("\nPacking Label: ");
        Console.WriteLine("------------");

        foreach (string label in packingLabels)
        {
            Console.WriteLine(label);
        }
    }

    public void displayShippingLabel()
    {
        Console.WriteLine("\nShipping Label: ");
        Console.WriteLine("------------");
        Console.WriteLine($"{_customer.getName()}\n {_customer.getFullAddress()}\n");

    }

}
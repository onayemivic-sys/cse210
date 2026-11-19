using System.Collections.Generic;
using System.Text;

public class Order
{
    // Private fields.
    private List<Product> _orderProducts;
    private Customer _orderCustomer;

    // Constructor.
    public Order(Customer customer)
    {
        _orderCustomer = customer;
        _orderProducts = new List<Product>();
    }

    // Add a product to the order.
    public void AddProduct(Product product)
    {
        _orderProducts.Add(product);
    }

    // Calculate the total cost of the order.
    public decimal GetTotalCost()
    {
        decimal total = 0;

        // Add the cost of every product.
        foreach (Product product in _orderProducts)
        {
            total += product.GetTotalCost();
        }

        // Add shipping cost once.
        if (_orderCustomer.LivesInUSA())
        {
            total += 5;
        }
        else
        {
            total += 35;
        }

        return total;
    }

    // Generate the packing label.
    public string GetPackingLabel()
    {
        StringBuilder label = new StringBuilder();

        label.AppendLine("PACKING LABEL");

        foreach (Product product in _orderProducts)
        {
            label.AppendLine(
                $"Product: {product.GetName()} | ID: {product.GetProductId()}"
            );
        }

        return label.ToString();
    }

    // Generate the shipping label.
    public string GetShippingLabel()
    {
        StringBuilder label = new StringBuilder();

        label.AppendLine("SHIPPING LABEL");
        label.AppendLine($"Customer: {_orderCustomer.GetName()}");
        label.AppendLine(_orderCustomer.GetAddress().GetAddress());

        return label.ToString();
    }
}
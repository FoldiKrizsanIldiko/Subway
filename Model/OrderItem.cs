namespace Subway1;

public class OrderItem
{
    // OrderItem
    // ● price of the item
    public double Price;

    public OrderItem(double? price)
    {
        if (price != null) Price = (double)price;
    }
}
namespace Subway1;

public class Restaurant:IRestaurant
{
    // Restaurant
    // ● has a name
    // ● list of all ordered items
    // ● adding new orders to the restaurant
    // ● calculating price of all orders in restaurant

    private string Name;
    private List<OrderItem> OrderItems { get; set; }

    public Restaurant(string name)
    {
        Name = name;
        OrderItems = new System.Collections.Generic.List<OrderItem>();
    }

    public void AddOrder(List<OrderItem> order)
    {
        foreach (var item in order)
        {
            OrderItems.Add(item);
        }

        Console.WriteLine($"Your bill is : {order.Sum(item => item.Price())} $cent");
    }

    public double SumPriceOfOrders()
    {
        return OrderItems.Sum(item => item.Price());
    }

    public void ShowAllOrderOfDay()
    {
        Console.WriteLine($"The orders of {Name}: \n");
        OrderItems.ForEach(e=>Console.WriteLine(e));
    }
}
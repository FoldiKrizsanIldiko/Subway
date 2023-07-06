namespace Subway1;

public interface IRestoran
{
    void AddOrder(List<OrderItem> order);
    int SumPriceOfOrders();
}
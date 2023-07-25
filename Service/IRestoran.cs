namespace Subway1;

public interface IRestaurant
{
    void AddOrder(List<OrderItem> order);
   double SumPriceOfOrders();

   void ShowAllOrderOfDay();
}
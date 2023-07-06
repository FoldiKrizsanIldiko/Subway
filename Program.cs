// See https://aka.ms/new-console-template for more information

using Subway1;

class Program
{
    public static void Main(string[] args)
    {
        IRestoran restaurant = new Restaurant("Subway");
        List<Ingredient_item> listForBurger = new List<Ingredient_item>()
        {
            new Ingredient_item("buci", 20),
            new Ingredient_item("meat", 50),
            new Ingredient_item("salat", 5)
        };
        OrderItem item = new Drink(DrinkFlavour.Fanta);
        OrderItem item1 = new Sandwich(listForBurger);

        List<OrderItem> firstOrder = new List<OrderItem>() { item, item1 };
        List<OrderItem> SecondOrder = new List<OrderItem>() { new Drink(DrinkFlavour.CocaCola), new Drink(DrinkFlavour.IceTea), item1, item1 };
        restaurant.AddOrder(firstOrder);
        restaurant.AddOrder(SecondOrder);
        Console.WriteLine(restaurant.SumPriceOfOrders());
    }
}

namespace Subway1;

public class Sandwich:OrderItem
{
    // Sandwich
    // ● list of ingredients
    private List<Ingredient_item> _ingredientItems;

    public Sandwich( List<Ingredient_item> ingredientItems) : base(null)
    {
        _ingredientItems = ingredientItems;
        Price = ingredientItems.Sum(item => item.Price);
    }

    public override string ToString()
    {
        return $"Sandwich: {Price}";
    }
}
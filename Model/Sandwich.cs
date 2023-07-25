namespace Subway1;

public class Sandwich:OrderItem
{
    // Sandwich
    // ● list of ingredients
    private List<Ingredient_item> _ingredientItems;

    public Sandwich( List<Ingredient_item> ingredientItems) 
    {
       _ingredientItems = ingredientItems;
     
    }

    public override double Price()
    {
        return _ingredientItems.Sum(item => item.Price);
        
    }

    public override string ToString()
    {
        return $"Sandwich: from {String.Join(", ",_ingredientItems.Select(e=>e.Name))} {Price()}";
    }
}
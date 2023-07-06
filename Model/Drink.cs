namespace Subway1;

public class Drink:OrderItem
{
    // Drink
    // ● flavour (CocaCola, Fanta, IceTea)
    private DrinkFlavour _flavour;
    
    public Drink( DrinkFlavour flavour) : base(null)
    {
        _flavour = flavour;
        Price = (double)_flavour;
    }

    public override string ToString()
    {
        return $"Drink: {_flavour}, price {Price}";
    }
}
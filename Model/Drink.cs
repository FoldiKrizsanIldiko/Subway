namespace Subway1;

public class Drink:OrderItem
{
    // Drink
    // ● flavour (CocaCola, Fanta, IceTea)
    private DrinkFlavour _flavour;
    
    public Drink( DrinkFlavour flavour) 
    {
        _flavour = flavour;
        
    }

    public override double Price()
    {
      return  (double)_flavour;
    }

    public override string ToString()
    {
        return $"Drink: {_flavour}, price {Price()}";
    }
}
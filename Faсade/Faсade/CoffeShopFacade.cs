public class CoffeeShopFacade
{
    private Coffee coffee;
    private Milk milk;
    private Decorations decorations;

    public CoffeeShopFacade()
    {
        coffee = new Coffee();
        milk = new Milk();
        decorations = new Decorations();
    }

    public void MakeCappuccino()
    {
        Console.WriteLine("Приготовление капучино...");
        coffee.GrindCoffee();
        coffee.BrewCoffee();
        coffee.PourCoffee();
        milk.HeatMilk();
        milk.FrothMilk();
        milk.PourMilk();
        decorations.AddWhippedCream();
        Console.WriteLine("Капучино готов!\n");
    }

    public void MakeLatte()
    {
        Console.WriteLine("Приготовление латте...");
        coffee.GrindCoffee();
        coffee.BrewCoffee();
        coffee.PourCoffee();
        milk.HeatMilk();
        milk.PourMilk();
        Console.WriteLine("Латте готов!\n");
    }

    public void MakeRaf()
    {
        Console.WriteLine("Приготовление рафа...");
        coffee.GrindCoffee();
        coffee.BrewCoffee();
        coffee.PourCoffee();
        milk.HeatMilk();
        milk.FrothMilk();
        milk.PourMilk();
        decorations.AddSyrup();
        Console.WriteLine("Раф готов!");
    }
}

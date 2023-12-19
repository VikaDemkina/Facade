class Program
{
    static void Main(string[] args)
    {
        CoffeeShopFacade coffeeShop = new CoffeeShopFacade();

        coffeeShop.MakeCappuccino();

        coffeeShop.MakeLatte();

        coffeeShop.MakeRaf();
    }
}
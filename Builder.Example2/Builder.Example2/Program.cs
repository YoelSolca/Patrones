using Builder.Example2;

//No sabe que esta realizando, solo sabe que es una hamburguesa
BurguerDirector chef = new BurguerDirector();

//Sabe que tipo de hamburguesa realizar
ClassicBurgerBuilder classicBurgerBuilder = new ClassicBurgerBuilder();
chef.MakeBurger(classicBurgerBuilder);
Burger ClassicBurger = classicBurgerBuilder.GetBurguer();

Console.WriteLine($"Classic Burger:");
ClassicBurger.DisplayInformation();


VeggieBurgerBuilder veggieBurgerBuilder = new VeggieBurgerBuilder();
chef.MakeBurger(veggieBurgerBuilder);
Burger VeggieBurger = veggieBurgerBuilder.GetBurguer();

Console.WriteLine();
Console.WriteLine();
Console.WriteLine($"Veggie Burger:");
VeggieBurger.DisplayInformation();

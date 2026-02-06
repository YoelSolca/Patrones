namespace Builder.Example2
{
    public class ClassicBurgerBuilder : IBurgerBuilder
    {
        private Burger burguer = new Burger();
        public void AddBread()
        {
            burguer.Bread = "Sesame bread";
        }

        public void AddCheese()
        {
            burguer.Cheese = "Cheddar";
        }

        public void AddDressing()
        {
            burguer.Dressing = "Ketchup";
        }

        public void AddLettuce()
        {
            burguer.Lettuce = true;
        }

        public void AddMeat()
        {
            burguer.Meat = "Chicken";
        }

        public void AddTomato()
        {
            burguer.Tomato = true;
        }

        public Burger GetBurguer()
        {
            return burguer;
        }
    }
}

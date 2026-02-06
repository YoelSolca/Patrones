namespace Builder.Example2
{
    public class VeggieBurgerBuilder : IBurgerBuilder
    {
        private Burger burguer = new Burger();
        public void AddBread()
        {
            burguer.Bread = "Whole Wheat";
        }

        public void AddCheese()
        {
            burguer.Cheese = "Vegan cheese";
        }

        public void AddDressing()
        {
            burguer.Dressing = "Vegan mayo";
        }

        public void AddLettuce()
        {
            burguer.Lettuce = true;
        }

        public void AddMeat()
        {
            burguer.Meat = "Lentil patty";
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

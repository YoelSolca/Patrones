namespace Builder.Example2
{
    public class BurguerDirector
    {
        public void MakeBurger(IBurgerBuilder builder)
        {
            builder.AddBread();
            builder.AddMeat();
            builder.AddCheese();
            builder.AddDressing();
            builder.AddLettuce();
            builder.AddTomato();
            var burger = builder.GetBurguer();
        }

        //private readonly IBurgerBuilder _builder;
        //public BurguerDirector(IBurgerBuilder builder)
        //{
        //    _builder = builder;
        //}

      

    }
}

namespace Builder.Example2
{
    public class Burger
    {
        public string Bread { get; set; }
        public string Meat { get; set; }

        public string Cheese { get; set; }

        public string Dressing { get; set; }

        public bool Lettuce { get; set; }

        public bool Tomato { get; set; }

        public void DisplayInformation()
        {
            Console.WriteLine($"Bread: {Bread}");
            Console.WriteLine($"Meat: {Meat}");
            Console.WriteLine($"Cheese: {Cheese}");
            Console.WriteLine($"Dressing: {Dressing}");
            Console.WriteLine($"Lettuce: {Lettuce}");
            Console.WriteLine($"Tomato: {Tomato}");
        }

    }
}

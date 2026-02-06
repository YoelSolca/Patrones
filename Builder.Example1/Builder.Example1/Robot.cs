namespace Builder.Example1
{
    //Robot = Producto (Lo que se va a construir)
    public class Robot
    {
        public string Head { get; set; }
        public string Body { get; set; }
        public string Arms { get; set; }
        public string Legs { get; set; }

        public void DisplayRobotInfo()
        {
            Console.WriteLine("Robot Info:");
            Console.WriteLine($"Head: {Head}");
            Console.WriteLine($"Body: {Body}");
            Console.WriteLine($"Arms: {Arms}");
            Console.WriteLine($"Legs: {Legs}");
        }

    }
}

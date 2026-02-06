namespace Builder.Example1
{
    //ConcreteBuilder = Implementa la interfaz del Builder y construye el producto
    public class RobotBuilder : IRobotBuilder
    {
        private Robot _robot = new Robot();
        public void BuildArms(string arms)
        {
            _robot.Arms = arms;
        }

        public void BuildBody(string body)
        {
            _robot.Body = body;
        }

        public void BuildHead(string head)
        {
            _robot.Head = head;
        }

        public void BuildLegs(string legs)
        {
            _robot.Legs = legs;
        }

        public Robot GetRobot()
        {
            return _robot;
        }
    }
}

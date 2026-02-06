namespace Builder.Example1
{
    //Director = Clase que dirige el proceso de construcción utilizando el Builder
    public class RobotDirector
    {
        private IRobotBuilder _robotBuilder;

        public RobotDirector(IRobotBuilder robotBuilder)
        {
            _robotBuilder = robotBuilder;
        }

        public void ConstructRobot()
        {
            _robotBuilder.BuildHead("Metal Head");
            _robotBuilder.BuildBody("Steel Body");
            _robotBuilder.BuildArms("Hydraulic Arms");
            _robotBuilder.BuildLegs("All-Terrain Legs");
        }
    }
}

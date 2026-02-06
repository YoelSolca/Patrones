namespace Builder.Example1
{
    //Builder = Interfaz que define los pasos para construir el producto
    public interface IRobotBuilder
    {
        void BuildHead(string head);
        void BuildBody(string body);
        void BuildArms(string arms);
        void BuildLegs(string legs);
        Robot GetRobot();
    }
}

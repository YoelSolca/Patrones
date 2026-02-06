using Builder.Example1;

IRobotBuilder robotBuilder = new RobotBuilder();
RobotDirector robotDirector = new RobotDirector(robotBuilder);
robotDirector.ConstructRobot();
Robot robot = robotBuilder.GetRobot();

robot.DisplayRobotInfo();

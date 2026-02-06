using Singleton.RealWorldExample;


//Permite centralizar el acceso a los eventos y a los metodos de la clase

EventLogger logger = EventLogger.GetInstance();

logger.LogEvent("Starting app.");
logger.LogEvent("Executing Task 1.");

EventLogger logger2 = EventLogger.GetInstance();

logger2.LogEvent("Finishing execution of task 1.");
logger2.LogEvent("Ending app.");

EventLogger logger3 = EventLogger.GetInstance();

logger3.DisplayLog();
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton.RealWorldExample
{
    public class EventLogger
    {
        private static EventLogger _instance;
        private List<string> _eventsLogs;
    
        private EventLogger()
        {
            _eventsLogs = new List<string>();
        }

        public static EventLogger GetInstance()
        {
            if (_instance == null)
            {
                _instance = new EventLogger();
            }

            return _instance;
        }

        public void LogEvent(string eventMessage)
        {
            string timestamp = DateTime.UtcNow.ToString("yyyy-MM-dd HH:mm:ss.ff");
            _eventsLogs.Add($"{timestamp}: {eventMessage}");
        }

        public void DisplayLog()
        {
            foreach (string log in _eventsLogs)
            {
                Console.WriteLine(log); 
            }
        }
    }
}

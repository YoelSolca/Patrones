using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton.ThreadSafe
{
    public class ThreadSafeSingleton
    {
        private static ThreadSafeSingleton _instance;

        private static readonly object _lock = new object();


        private ThreadSafeSingleton()
        {
            
        }


        public static ThreadSafeSingleton GetInstance()
        {
            if(_instance == null)
            {
                //lock -> Se asegura que haya una seguridad de hilos -> 1 hilo a la vez puede crear la instancia de ThreadSafeSingleton
                lock (_lock) 
                {
                    if (_instance == null)
                    {
                        _instance = new ThreadSafeSingleton();
                    }
                }
            }

            return _instance;
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Consiste en una clase cuyo constructor es privado y que contiene una referencia a la única instancia de esta ckase.

namespace Singleton.Example1
{
    public class MySingleton
    {
        //instancia de MySingleton
        private static MySingleton _instance;

        //constructor privado para evitar instanciación externa
        private MySingleton()
        {
            _instance = new MySingleton();
        }


        //método público y estático para obtener la instancia única
        public static MySingleton GetInstance()
        {
            if (_instance == null)
            {
                _instance = new MySingleton();
            }

            return _instance;
        }
    }
}

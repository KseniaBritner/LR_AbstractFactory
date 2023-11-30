using AbstractFactory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    public class SingletonFactory : MazeFactory
    {
        private static SingletonFactory _instance;
        private SingletonFactory() { }
        public static SingletonFactory Instance
        {
            get
            {
                _instance = new SingletonFactory();
                return _instance;
            }
        }
    }
}

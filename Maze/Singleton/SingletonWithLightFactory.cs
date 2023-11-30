using AbstractFactory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    public class SingletonWithLightFactory : MazeFactory
    {
        private static SingletonWithLightFactory _instance;
        private SingletonWithLightFactory() { }
        public static SingletonWithLightFactory Instance
        {
            get
            {
                _instance = new SingletonWithLightFactory();
                return _instance;
            }
        }
    }
}

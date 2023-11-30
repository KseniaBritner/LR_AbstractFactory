using AbstractFactory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    public class SingletonWithBombFactory : MazeFactory
    {
        private static SingletonWithBombFactory _instance;

        private SingletonWithBombFactory() { }

        public static SingletonWithBombFactory Instance
        {
            get
            {
                _instance = new SingletonWithBombFactory();
                return _instance;
            }
        }
    }
}

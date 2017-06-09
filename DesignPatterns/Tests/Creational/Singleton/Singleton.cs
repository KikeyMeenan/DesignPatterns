using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Creational.Singleton
{
    public class SingleObject
    {
        //create an object
        private static SingleObject instance = new SingleObject();

        public int CallCount { get; private set; }

        //make constructor private so it can't be instantiated
        private SingleObject() { }

        //access the only object
        public static SingleObject getInstance()
        {
            return instance;
        }

        public void CallSingleton()
        {
            CallCount++;
        }
    }
}

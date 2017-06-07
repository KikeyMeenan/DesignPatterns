using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Creational.Singleton
{
    public class SingleObject
    {
        //create an object
        private static SingleObject instance = new SingleObject();

        //make constructor private so it can't be instantiated
        private SingleObject() { }

        //access the only object
        public static SingleObject getInstance()
        {
            return instance;
        }

        public string ShowMessage()
        {
            return "The Message";
        }
    }
}

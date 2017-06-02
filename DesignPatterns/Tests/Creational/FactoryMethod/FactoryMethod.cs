using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Creational.FactoryMethod
{
    public class FactoryMethod
    {
        public static void Go()
        {
            Document[] documents = new Document[2];

            documents[0] = new Resume();
            documents[1] = new Report();
        }

        //http://www.dofactory.com/net/factory-method-design-pattern
        abstract class Document
        {
            private List<string> _names = new List<string>();

            //this is the factory method part!
            public Document()
            {

            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Creational.AbstractFactory
{
    class AbstractFactory
    {
        public static void Main(string continent)
        {
            if(continent == "africa")
            {
                ContinentFactory africa = new AfricaFactory();
                AnimalWorld world = new AnimalWorld(africa);
                world.RunFoodChain();
            }
            if(continent == "america")
            {
                ContinentFactory america = new AmericaFactory();
                AnimalWorld world = new AnimalWorld(america);
                world.RunFoodChain();
            }
        }

        class AnimalWorld
        {
            private Herbivore _herbivore;
            private Carnivore _carnivore;
            
            public AnimalWorld(ContinentFactory factory)
            {
                _carnivore = factory.CreateCarnivore();
                _herbivore = factory.CreateHerbivore();
            }

            public void RunFoodChain()
            {
                _carnivore.Eat(_herbivore);
            }
        }

        //Abstarct/Super Factory - returns a factory
        interface ContinentFactory
        {
            Herbivore CreateHerbivore();
            Carnivore CreateCarnivore();
        }

        //Factory
        class AfricaFactory : ContinentFactory
        {
            public Herbivore CreateHerbivore()
            {
                return new Wildebeest();
            }
            public Carnivore CreateCarnivore()
            {
                return new Lion();
            }
        }

        class AmericaFactory: ContinentFactory
        {
            public Herbivore CreateHerbivore()
            {
                return new Bison();
            }

            public Carnivore CreateCarnivore()
            {
                return new Wolf();
            }
        }

        abstract class Herbivore
        {
        }

        class Wildebeest : Herbivore
        {
        }

        class Bison : Herbivore
        {

        }

        abstract class Carnivore
        {
            public abstract void Eat(Herbivore h);
        }

        class Lion : Carnivore
        {
            public override void Eat(Herbivore h)
            {
                Console.WriteLine(this.GetType().Name +
                  " eats " + h.GetType().Name);
            }
        }

        class Wolf : Carnivore
        {
            public override void Eat(Herbivore h)
            {
                Console.WriteLine(this.GetType().Name +
                  " eats " + h.GetType().Name);
            }
        }
    }
}

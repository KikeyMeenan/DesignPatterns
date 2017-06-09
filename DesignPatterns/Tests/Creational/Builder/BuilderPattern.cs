using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Creational.Builder
{
    public interface Item
    {
        string name();
        Packing packing();
        float price();
    }

    public abstract class Burger : Item
    {
        public abstract string name();

        public Packing packing()
        {
            return new Wrapper();
        }

        public abstract float price();
    }

    public abstract class ColdDrink : Item
    {
        public abstract string name();

        public Packing packing()
        {
            return new Bottle();
        }

        public abstract float price();
    }

    public class VegBurger : Burger
    {
        public override string name()
        {
            return "Veg Burger";
        }

        public override float price()
        {
            return 25.0f;
        }
    }

    public class ChickenBurger : Burger
    {
        public override string name()
        {
            return "Chicken Burger";
        }

        public override float price()
        {
            return 50.5f;
        }
    }

    public class Coke : ColdDrink
    {
        public override string name()
        {
            return "Coke";
        }

        public override float price()
        {
            return 30.0f;
        }
    }

    public class Pepsi : ColdDrink
    {
        public override string name()
        {
            return "Pepsi";
        }

        public override float price()
        {
            return 35.5f;
        }
    }

    #region packing
    public interface Packing
    {
        string pack();
    }

    public class Wrapper : Packing
    {
        public string pack()
        {
            return "Wrapper";
        }
    }

    public class Bottle : Packing
    {
        public string pack()
        {
            return "Bottle";
        }
    }
    #endregion

}

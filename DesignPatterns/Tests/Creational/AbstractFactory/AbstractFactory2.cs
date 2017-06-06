using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Creational.AbstractFactory
{
    //https://www.tutorialspoint.com/design_pattern/abstract_factory_pattern.htm


    #region shapes
    public interface Shape
    {
        void draw();
    }

    public class Rectangle : Shape
    {
        public void draw()
        {
            Console.WriteLine("Inside Rectangle::draw() method.");
        }
    }

    public class Square : Shape
    {
        public void draw()
        {
            Console.WriteLine("Inside Square::draw() method.");
        }
    }

    public class Circle : Shape
    {
        public void draw()
        {
            Console.WriteLine("Inside Circle::draw() method.");
        }
    }
    #endregion

    #region colours
    public interface Colour
    {
        void fill();
    }

    public class Red : Colour
    {
        public void fill()
        {
            Console.WriteLine("Inside Red::fill() method.");
        }
    }

    public class Green : Colour
    {
        public void fill()
        {
            Console.WriteLine("Inside Green::fill() method.");
        }
    }

    public class Blue : Colour
    {
        public void fill()
        {
            Console.WriteLine("Inside Blue::fill() method.");
        }
    }
    #endregion
    
    //Abstract Factory
    public abstract class AbstractFactory2
    {
        public abstract Colour getColour(string colour);
        public abstract Shape getShape(string shapeType);
    }

    //Shape Factory - Gets a Shape
    public class ShapeFactory : AbstractFactory2
    {
        public override Colour getColour(string colour)
        {
            return null;
        }

        public override Shape getShape(string shapeType)
        {
            if(shapeType == null)
            {
                return null;
            }

            if(shapeType.ToLower() == "circle")
            {
                return new Circle();
            }

            else if(shapeType.ToLower() == "rectangle")
            {
                return new Rectangle();
            }

            else if(shapeType.ToLower() == "square")
            {
                return new Square();
            }

            return null;
        }
    }

    //Colour Factory - Gets a Colour
    public class ColourFactory : AbstractFactory2
    {
        public override Colour getColour(string colour)
        {
            if(colour == null)
            {
                return null;
            }

            if(colour.ToLower() == "red")
            {
                return new Red();
            }
            else if(colour.ToLower() == "green")
            {
                return new Green();
            }
            else if(colour.ToLower() == "blue")
            {
                return new Blue();
            }

            return null;
        }

        public override Shape getShape(string shapeType)
        {
            return null;
        }
    }

    //Factory Producer
    public class FactoryProducer
    {
        public static AbstractFactory2 getFactory(string choice)
        {
            if(choice.ToLower() == "shape")
            {
                return new ShapeFactory();
            }
            else if(choice.ToLower() == "colour")
            {
                return new ColourFactory();
            }

            return null;
        }
    }

    public class AbstractFactoryPatternDemo
    {
        private static AbstractFactory2 _factory;

        public static void DrawSomeShapes()
        {
            //get a shape factory using the super factory
            //we don't need to know what the type is for the factory
            _factory = FactoryProducer.getFactory("shape");

            //use shape factory to get a shape
            //we don't need to know what the type is for the shape
            Shape shape1 = _factory.getShape("circle");

            shape1.draw();

            //use shape factory to get a shape
            //we don't need to know what the type is for the shape
            Shape shape2 = _factory.getShape("rectangle");

            shape2.draw();
        }

        public static void GetSomeColours()
        {
            //get a colour factory using the super factory
            //we don't need to know what the type is for the factory
            _factory = FactoryProducer.getFactory("cololur");

            //use colour factory to get a colour
            //we don't need to know what the type is for the colour
            Colour colour1 = _factory.getColour("Red");

            colour1.fill();

            Colour colour2 = _factory.getColour("Blue");

            colour2.fill();
        }
    }
}

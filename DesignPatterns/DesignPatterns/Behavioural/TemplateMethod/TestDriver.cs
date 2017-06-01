using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Behavioural.TemplateMethod
{
    class TestDriver
    {
        static void TestDriveCar()
        {
            Car manual = new ManualCar();
            manual.TestDrive();

            Car auto = new AutomaticCar();
            auto.TestDrive();
        }
    }

    abstract class Car
    {
        public virtual void Start()
        {
            Console.WriteLine("Turn Key Forward");
        }

        public abstract void ChangeGear();

        public virtual void Stop()
        {
            Console.WriteLine("Turn Key Backward");
        }

        public void TestDrive()
        {
            Start();
            ChangeGear();
            Stop();
        }
    }

    class ManualCar : Car
    {
        public override void ChangeGear()
        {
            Console.WriteLine("Put down clutch and move stick");
        }
    }

    class AutomaticCar : Car
    {
        public override void ChangeGear()
        {
            Console.WriteLine("Do Nothing");
        }
    }
}

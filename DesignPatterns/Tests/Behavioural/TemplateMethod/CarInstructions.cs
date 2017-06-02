namespace DesignPatterns.Behavioural.TemplateMethod
{
    public class CarInstructions
    {
        public static string TestDriveCar(bool isAuto)
        {
            Instructions _car;

            if (isAuto)
            {
                _car = new AutomaticCarInstructions();
            }
            else
            {
                _car = new ManualCarInstructions();
            }

            return _car.TestDrive();
        }
    }

    abstract class Instructions
    {
        public virtual string Start()
        {
            return "Turn Key Forward";
        }

        public abstract string ChangeGear();

        public virtual string Stop()
        {
            return "Turn Key Backward";
        }

        public string TestDrive()
        {
            var result = string.Empty;
            result += Start();
            result += (", " + ChangeGear());
            result += (", " + Stop());
            return result;
        }
    }

    class ManualCarInstructions : Instructions
    {
        public override string ChangeGear()
        {
            return "Put down clutch and move stick";
        }
    }

    class AutomaticCarInstructions : Instructions
    {
        public override string ChangeGear()
        {
            return "Do Nothing";
        }
    }
}

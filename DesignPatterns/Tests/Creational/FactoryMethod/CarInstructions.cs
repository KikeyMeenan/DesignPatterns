using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Creational.FactoryMethod
{
    public class CarInstructions
    {
        public static List<string> GetInstructions(bool isAuto)
        {
            InstructionsDocument instructions;

            if (isAuto)
            {
                instructions = new AutoInstructions();
            }
            else
            {
                instructions = new ManualInstructions();
            }

            return instructions.instructions;
        }

        //http://www.dofactory.com/net/factory-method-design-pattern
        abstract class InstructionsDocument
        {
            private List<string> _instruction = new List<string>();

            public InstructionsDocument()
            {
                //this pattern is creational, it CREATES when instantiated
                this.CreateInstructions();
            }

            public List<string> instructions
            {
                get { return _instruction; }
            }

            //this is the factory METHOD!!! This pattern is all about the METHOD! - It is a factory method because it HIDES the method?
            public abstract void CreateInstructions();
        }

        class AutoInstructions : InstructionsDocument
        {
            public override void CreateInstructions()
            {
                instructions.Add("Turn Key Forward");
                instructions.Add("Do Nothing");
                instructions.Add("Turn Key Backward");
            }
        }

        class ManualInstructions : InstructionsDocument
        {
            public override void CreateInstructions()
            {
                instructions.Add("Turn Key Forward");
                instructions.Add("Put down clutch and move stick");
                instructions.Add("Turn Key Backward");
            }
        }
    }
}

using System;

namespace Duck {
    public class ModelDuck : Duck {

        public ModelDuck(IFlyBehavior flyBehavior, IQuackBehavior quackBehavior) : base(flyBehavior, quackBehavior) {
            
        }
        
        public override void Display() {
            Console.WriteLine("I'm a model duck");
        }
    }
}
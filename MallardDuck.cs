using System;

namespace Duck {
    public class MallardDuck : Duck {
        public MallardDuck(IFlyBehavior flyBehavior, IQuackBehavior quackBehavior) : base(flyBehavior, quackBehavior) {
            
        }
        
        public override void Display() {
            Console.WriteLine("I'm a mallard DUck!!!");
        }
    }
}
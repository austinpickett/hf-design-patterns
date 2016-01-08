using System;
namespace Duck {
    public abstract class Duck {
        public IFlyBehavior flyBehavior { get; set; }
        public IQuackBehavior quackBehavior { get; set; }
        public Duck(IFlyBehavior flyBehavior, IQuackBehavior quackBehavior) {
            this.flyBehavior = flyBehavior;
            this.quackBehavior = quackBehavior;
        }
        public abstract void Display();
        
        public void PerformFly() {
            flyBehavior.Fly();
        }
        
        public void PerformQuack() {
            quackBehavior.QuackSound();
        }
        
        public void Swim() {
            Console.WriteLine("All ducks float!");
        }
    }
}
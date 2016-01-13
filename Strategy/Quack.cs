using System;

namespace Duck {
    public class Quack : IQuackBehavior {
        public void QuackSound() {
            Console.WriteLine("quack!");
        }
    }
}
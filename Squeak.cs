using System;

namespace Duck {
    public class Squeak : IQuackBehavior {
        public void QuackSound() {
            Console.WriteLine("Squeak");
        }
    }
}
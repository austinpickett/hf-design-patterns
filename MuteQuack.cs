using System;

namespace Duck {
    public class MuteQuack : IQuackBehavior {
        public void QuackSound() {
            Console.WriteLine("<< silence >>");
        }
    }
}
using System;
namespace Duck {
    public class FlyWithWings : IFlyBehavior {
        public void Fly() {
            Console.WriteLine("I'm flying");
        }
    }
}
using System;

namespace Duck {
    public class FlyRocketPowered : IFlyBehavior {
        public void Fly() {
            Console.WriteLine("I'm flying with rockets");
        }
    }
}
using System;

namespace Duck {
    public class MiniDuckSimulator {
        public static void Main(string[] args) {
            Duck mallard = new MallardDuck(new FlyWithWings(), new Quack());
            
            mallard.PerformQuack();
            mallard.PerformFly();
            mallard.flyBehavior = new FlyNoWay();
            mallard.PerformFly();
            
            Duck model = new ModelDuck(new FlyWithWings(), new Quack());
            model.PerformFly();
        }
    }
}
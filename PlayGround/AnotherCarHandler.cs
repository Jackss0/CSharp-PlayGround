using System;

namespace PlayGround
{
    public class AnotherCarHandler : InitialCarClass
    {
        public override void BuyCar(string carName)
        {
            Console.WriteLine($"I do nothing!! but: {carName}");
        }
    }
}

using System;

namespace PlayGround
{
    public class CarHandler : InitialCarClass
    {   
        public delegate void CarPurchasedDelegate(object sender, EventArgs args);

        public static event CarPurchasedDelegate CarPurchased;

        public override void BuyCar(string carName)
        {
            Console.WriteLine("Updating inventory...");

            CarPurchased?.Invoke(carName, new EventArgs());
        }

        public static void OnCarPurchased(object sender, EventArgs args)
        {
            Console.WriteLine($"A car was purchased: {sender}");
        }
    }
}
